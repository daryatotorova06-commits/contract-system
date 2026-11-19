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
    public partial class Form5 : Form
    {
        string connection = @"Server=KRN-20-204-C05\MSSQLSERVER2;Database=contract_db;Integrated Security=True;TrustServerCertificate=True";
        public Form5()
        {
            InitializeComponent();
            this.Load += Form5_Load;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        private void LoadEmployees(string searchQuery = "", string deptFilter = "Все отделы")
        {
            // Очищаем панель с карточками (предполагаю, она называется flowLayoutPanel1 или panelEmployees)
            flowLayoutPanel1.Controls.Clear();

            try
            {
                using (SqlConnection conn = new SqlConnection(connection)) // Ваша строка подключения
                {
                    conn.Open();

                    // Запрос к таблице employees
                    string query = @"SELECT full_name, position, department, phone, email 
                             FROM employees WHERE 1=1";

                    var parameters = new List<SqlParameter>();

                    // 1. Поиск по ФИО или Должности
                    if (!string.IsNullOrEmpty(searchQuery))
                    {
                        query += " AND (full_name LIKE @search OR position LIKE @search)";
                        parameters.Add(new SqlParameter("@search", "%" + searchQuery + "%"));
                    }

                    // 2. Фильтр по отделу
                    if (deptFilter != "Все отделы")
                    {
                        query += " AND department = @dept";
                        parameters.Add(new SqlParameter("@dept", deptFilter));
                    }

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (parameters.Count > 0)
                            cmd.Parameters.AddRange(parameters.ToArray());

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Создаем карточку сотрудника (UserControl3, судя по вашим прошлым скринам)
                                UserControl3 card = new UserControl3();

                                // Заполняем данными. 
                                // ВАЖНО: Убедитесь, что метод SetData в UserControl3 принимает именно такие параметры!
                                // Если там другие имена параметров, просто передавайте значения по порядку.
                                card.SetData(
                                    reader["full_name"].ToString(),
                                    reader["position"].ToString(),
                                    reader["department"].ToString(),
                                    reader["phone"].ToString(),
                                    reader["email"].ToString()
                                );

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
            LoadEmployees(txtSearch.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (Form8 addForm = new Form8())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    LoadEmployees(); // Обновляем реестр после успешного добавления
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

        private void button2_Click(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        private void cmbDeptFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Если есть поле поиска txtSearch, используем его. Если нет - передаем "".
            string searchText = txtSearch != null ? txtSearch.Text : "";

            LoadEmployees(searchText, cmbDeptFilter.Text);
        }
    }
}
