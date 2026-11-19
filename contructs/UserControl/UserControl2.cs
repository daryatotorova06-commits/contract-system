using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace contructs
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
            this.Size = new Size(500, 330);
            this.BackColor = Color.White;
            this.Margin = new Padding(5); // Отступ между карточками
        }

        public void SetData (string name, string inn, string kpp, string address, string phone, string email, string type)
        {
            lblName.Text = name;
            lblInn.Text = "ИНН: " + inn;
            lblKpp.Text = "КПП: " + kpp;
            lblAddress.Text = "Адрес: " + address;
            lblPhone.Text = "Тел: " + phone;
            lblEmail.Text = "Email: " + email;
            lblType.Text = "Тип: " + type;
        }
    }
}
