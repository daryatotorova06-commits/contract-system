using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace contructs
{
    public partial class Form6 : Form
    {
        // Строка подключения
        string connString = @"Server=KRN-20-204-C05\MSSQLSERVER2;Database=contract_db;Integrated Security=True;TrustServerCertificate=True";

        public Form6()
        {
            InitializeComponent(); // Эта строка вызывает тот самый код из Designer.cs
            btnSave.DialogResult = DialogResult.None;
            btnCancel.DialogResult = DialogResult.Cancel;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            LoadContractors();
            dtpStart.Value = DateTime.Now;
            dtpEnd.Value = DateTime.Now.AddMonths(1);
        }

        private void LoadContractors()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    string query = "SELECT contractor_id, name FROM contractors ORDER BY name";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    cmbContractor.DataSource = dt;
                    cmbContractor.DisplayMember = "name";
                    cmbContractor.ValueMember = "contractor_id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки контрагентов: " + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // ВАЛИДАЦИЯ
            if (string.IsNullOrWhiteSpace(txtNumber.Text)) { MessageBox.Show("Введите номер!"); return; }
            if (cmbContractor.SelectedIndex == -1) { MessageBox.Show("Выберите контрагента!"); return; }
            if (string.IsNullOrWhiteSpace(txtTitle.Text)) { MessageBox.Show("Введите предмет!"); return; }
            if (dtpEnd.Value <= dtpStart.Value) { MessageBox.Show("Дата окончания должна быть позже начала!"); return; }

            // В методе btnSave_Click внутри Form6.cs

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    // ДОБАВЛЕНО: type_id в список столбцов и значений
                    string query = @"INSERT INTO contracts 
                        (number, title, contractor_id, employee_id, type_id, start_date, end_date, amount, status) 
                        VALUES 
                        (@number, @title, @contractor_id, @employee_id, @type_id, @start, @end, @amount, 'Активный')";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@number", txtNumber.Text.Trim());
                    cmd.Parameters.AddWithValue("@title", txtTitle.Text.Trim());
                    cmd.Parameters.AddWithValue("@contractor_id", cmbContractor.SelectedValue);
                    cmd.Parameters.AddWithValue("@employee_id", 1); // ID сотрудника (временный или текущий пользователь)

                    // ДОБАВЛЕНО: Передаем ID типа договора (поставь 1, если такой тип есть в базе)
                    cmd.Parameters.AddWithValue("@type_id", 1);

                    cmd.Parameters.AddWithValue("@start", dtpStart.Value.Date);
                    cmd.Parameters.AddWithValue("@end", dtpEnd.Value.Date);
                    cmd.Parameters.AddWithValue("@amount", numAmount.Value);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Договор успешно создан!", "Успех");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
            private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); // Просто закрываем форму при нажатии "Отмена"
        }
    }
    
}