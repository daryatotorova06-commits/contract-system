using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using contructs; // Если формы лежат в разных папках или неймспейсах

namespace contructs
{
    public partial class Form4 : Form
    {
        string connection = @"Server=KRN-20-204-C05\MSSQLSERVER2;Database=contract_db;Integrated Security=True;TrustServerCertificate=True";

        public Form4()
        {
            InitializeComponent();
            this.Load += Form4_Load;

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            LoadContractors();
        }
        // Добавляем второй параметр typeFilter со значением по умолчанию "Все"
        private void LoadContractors(string searchQuery = "", string typeFilter = "Все")
        {
            flowLayoutPanel1.Controls.Clear();

            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();

                    // Базовый запрос. WHERE 1=1 - это хитрость, чтобы удобно добавлять условия через AND
                    string query = @"SELECT c.name, c.inn, c.kpp, c.address, c.phone, c.email, c.type 
                             FROM contractors AS c WHERE 1=1";

                    // Список параметров для защиты от SQL-инъекций
                    var parameters = new List<SqlParameter>();

                    // 1. Если есть текст в поиске -> ищем по Имени или ИНН
                    if (!string.IsNullOrEmpty(searchQuery))
                    {
                        query += " AND (c.name LIKE @search OR c.inn LIKE @search)";
                        parameters.Add(new SqlParameter("@search", "%" + searchQuery + "%"));
                    }

                    // 2. Если в ComboBox выбрано НЕ "Все" -> фильтруем по типу
                    if (typeFilter != "Все")
                    {
                        query += " AND c.type = @type";
                        parameters.Add(new SqlParameter("@type", typeFilter));
                    }

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Добавляем все накопленные параметры в команду
                        if (parameters.Count > 0)
                            cmd.Parameters.AddRange(parameters.ToArray());

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                UserControl2 card = new UserControl2();
                                card.SetData(
                                    reader["name"].ToString(),
                                    reader["inn"].ToString(),
                                    reader["kpp"].ToString(),
                                    reader["address"].ToString(),
                                    reader["phone"].ToString(),
                                    reader["email"].ToString(),
                                    reader["type"].ToString()
                                );

                                // Если у вас был код для ширины карточки, оставьте его здесь
                                // card.Width = flowLayoutPanel1.ClientSize.Width - 20; 

                                flowLayoutPanel1.Controls.Add(card);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 guestForm = new Form2(1, "Админ", "admin");
            guestForm.Show();
            this.Hide();
        }
        // Этот метод связывает поле ввода с загрузкой данных
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // Вызываем метод загрузки и передаем туда то, что написано в поле
            LoadContractors(txtSearch.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (Form7 addForm = new Form7())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    LoadContractors(); // Обновляем реестр после успешного добавления
                }
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

            // Проходим по всем элементам (карточкам) внутри панели
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                // Устанавливаем ширину каждой карточки равной ширине самой панели
                // Вычитаем 20 пикселей, чтобы учесть полосу прокрутки и отступы, 
                // иначе появится горизонтальный скролл.
                control.Width = flowLayoutPanel1.ClientSize.Width - 20;
            }

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр формы отчета
            FormReport reportForm = new FormReport();

            // Показываем её
            reportForm.Show();

            // Опционально: можно скрыть текущую форму, если хочешь режим "только отчет"
            // this.Hide(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadContractors();
        }

        private void cmbTypeFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadContractors(txtSearch.Text, cmbTypeFilter.Text);
        }
    }
}
