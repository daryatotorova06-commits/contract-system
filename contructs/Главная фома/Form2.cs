using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.IO;

namespace contructs
{
    public partial class Form2 : Form

    {
        private string userRole;
        public Form2(int userId, string userName, string role)
        {
            InitializeComponent();
            userRole = role;

            if (role == "admin")
            {
                btnConterparties.Visible = true;
                btnContracts.Visible = true;
                btnEmployees.Visible = true;
            }
            else if (role == "manager")
            {
                btnConterparties.Visible = false;
                btnContracts.Visible = true;
                btnEmployees.Visible = false;
            }
            else if (role == "director")
            {
                btnConterparties.Visible = true;
                btnContracts.Visible = true;
                btnEmployees.Visible = true;
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Close();
        }

        private void btnContracts_Click(object sender, EventArgs e)
        {
            Form3 cont = new Form3(userRole);
            cont.Show();
            this.Close();
        }

        private void btnConterparties_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Close();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Close();
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

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            FormUploadReport frm = new FormUploadReport();
            frm.Show();
            this.Close();
        }
    }
}
