using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace contructs
{
    public partial class Form8 : Form
    {
        string connection = @"Server=KRN-20-204-C05\MSSQLSERVER2;Database=contract_db;Integrated Security=True;TrustServerCertificate=True";
        public Form8()
        {
            InitializeComponent();
            btnSave.DialogResult = DialogResult.None;
            btnCancel.DialogResult = DialogResult.Cancel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFull_name.Text))
            { MessageBox.Show("Введите ФИО!"); return; }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            { MessageBox.Show("Введите номер телефона!"); return; }

            // 2. СОХРАНЕНИЕ
            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();

                    // Используем параметры для защиты от SQL-инъекций
                    string query = @"INSERT INTO employees 
                                    (full_name, position, department, phone, email) 
                                    VALUES 
                                    (@full_name, @position, @department, @phone, @email)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@full_name", txtFull_name.Text.Trim());
                    cmd.Parameters.AddWithValue("@position", txtPosition.Text.Trim());
                    cmd.Parameters.AddWithValue("@department", cmbDepartment.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Сотрудник успешно добавлен!", "Успех");
                this.DialogResult = DialogResult.OK; 
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
