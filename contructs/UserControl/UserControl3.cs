using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace contructs
{
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
            this.Size = new Size(500, 330);
            this.BackColor = Color.White;
            this.Margin = new Padding(5); // Отступ между карточками
        }
        public void SetData(string full_name, string position, string departament, string phone, string email)
        {
            lblFullName.Text = full_name;
            lblPosition.Text = "Должность:" + position;
            lblDepartment.Text = "Отдел:" + departament;
            lblPhone.Text = "Тел:" + phone;
            lblEmail.Text = "Email" + email;
        }

        private void UserControl3_Load(object sender, EventArgs e)
        {

        }
    }
}
