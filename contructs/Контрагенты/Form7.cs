using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace contructs
{
    public partial class Form7 : Form
    {
        string connection = @"Server=KRN-20-204-C05\MSSQLSERVER2;Database=contract_db;Integrated Security=True;TrustServerCertificate=True";

        public Form7()
        {
            InitializeComponent();
            btnSave.DialogResult = DialogResult.None;
            btnCancel.DialogResult = DialogResult.Cancel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            { MessageBox.Show("Введите название организации!"); return; }

            if (string.IsNullOrWhiteSpace(txtInn.Text))
            { MessageBox.Show("Введите ИНН!"); return; }

            // 2. СОХРАНЕНИЕ
            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();

                    // Используем параметры для защиты от SQL-инъекций
                    string query = @"INSERT INTO contractors 
                                    (name, inn, kpp, address, phone, email, type) 
                                    VALUES 
                                    (@name, @inn, @kpp, @address, @phone, @email, @type)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
                    cmd.Parameters.AddWithValue("@inn", txtInn.Text.Trim());
                    cmd.Parameters.AddWithValue("@kpp", txtKpp.Text.Trim()); // Может быть пустым для ИП
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text.Trim());
                    cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@type", cmbType.SelectedItem.ToString());

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Контрагент успешно добавлен!", "Успех");
                this.DialogResult = DialogResult.OK; // Сообщаем Form4 об успехе
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
