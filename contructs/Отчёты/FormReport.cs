using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace contructs
{
    public partial class FormReport : Form
    {
        string connection = @"Server=KRN-20-204-C05\MSSQLSERVER2;Database=contract_db;Integrated Security=True;TrustServerCertificate=True";


        public FormReport()
        {
            InitializeComponent();

            this.Load += FormReport_Load;
        }

        private void lblTotalCount_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalSum_Click(object sender, EventArgs e)
        {

        }

        private void dgvTopContracts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            LoadReportData();
        }
        private void LoadReportData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();

                    // 1. Загружаем общую статистику
                    string statsQuery = @"
                        SELECT 
                            COUNT(*) as TotalCount, 
                            ISNULL(SUM(amount), 0) as TotalSum 
                        FROM contracts";

                    using (SqlCommand cmdStats = new SqlCommand(statsQuery, conn))
                    using (SqlDataReader rStats = cmdStats.ExecuteReader())
                    {
                        if (rStats.Read())
                        {
                            lblTotalCount.Text = $"Всего договоров: {rStats["TotalCount"]}";

                            decimal sum = Convert.ToDecimal(rStats["TotalSum"]);
                            // Формат N0 добавляет пробелы между тысячами (1 000 000)
                            lblTotalSum.Text = $"Общая сумма: {sum:N0} ₽";
                        }
                    }

                    // 2. Загружаем Топ-5 самых дорогих договоров
                    // Исправленный запрос для Топ-5
                    string topQuery = @"
    SELECT TOP 5 
        number as 'Номер',          -- Было правильно
        amount as 'Сумма',          -- Было правильно
        start_date as 'Дата начала' -- БЫЛО date_start, СТАЛО start_date
    FROM contracts
    ORDER BY amount DESC";

                    SqlDataAdapter da = new SqlDataAdapter(topQuery, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvTopContracts.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке отчета: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
    
