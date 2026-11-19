using contructs;
using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace contructs // Замени на имя своего проекта, если оно другое
{
    public partial class Form1 : Form
    {
        // Твоя строка подключения к базе contract_db
        string connection = @"Server=KRN-20-204-C05\MSSQLSERVER2;Database=contract_db;Integrated Security=True;TrustServerCertificate=True";

        public Form1()
        {     
            InitializeComponent();
            textBox2.PasswordChar = '*'; // Скрываем пароль звездочками
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();

            // 1. Сначала проверяем, не пустые ли поля
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Заполните логин и пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();

                    // Запрос под твою таблицу users (пароль в password_hash)
                    string query = "SELECT userId, full_name, roleId, is_active FROM users WHERE login = @login AND password_hash = @pass";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@pass", password);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // Проверяем, активен ли пользователь (поле is_active)
                        bool isActive = reader["is_active"] != DBNull.Value && Convert.ToBoolean(reader["is_active"]);

                        if (!isActive)
                        {
                            MessageBox.Show("Этот пользователь заблокирован.", "Ошибка доступа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Получаем данные из базы
                        int userId = Convert.ToInt32(reader["userId"]);
                        string fullName = reader["full_name"].ToString();
                        int roleId = Convert.ToInt32(reader["roleId"]);

                        // Определяем роль текстом для передачи в Form2
                        string role = "";
                        if (roleId == 1) role = "admin";
                        else if (roleId == 2) role = "manager";
                        else role = "director";

                        // Открываем главную форму (Form2) и передаем туда данные
                        Form2 mainForm = new Form2(userId, fullName, role);
                        mainForm.Show();

                        this.Hide(); // Скрываем окно входа
                    }
                    else
                    {
                        MessageBox.Show("Неверный логин или пароль.", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox2.Clear();
                        textBox2.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения к БД:\n" + ex.Message, "Системная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}