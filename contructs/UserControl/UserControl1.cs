using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Windows.Forms;

namespace contructs
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        public void SetData(string number, string title, string contractor, decimal amount, DateTime startDate,  DateTime endDate, string status)
        {
            lblNumber.Text = "Номер: " + number;
            lblTitle.Text = title;
            lblContractor.Text = "Контрагент: " + contractor;
            lblAmount.Text = "Сумма " + amount.ToString("N2") + "руб.";
            lblDates.Text = $"Срок  {startDate.ToShortDateString()} - {endDate.ToShortDateString()}";
            lblStatus.Text = status; 

            this.BackColor = Color.White;
            if (status == "Расторгнут")
            {
                this.BackColor = Color.LightCoral;
            }
            else if (status == "Активный")
            {
                TimeSpan timeLeft = endDate - DateTime.Now;
                if (timeLeft.TotalDays <= 3 && timeLeft.TotalDays > 0)
                {
                    this.BackColor = Color.LightYellow;
                }
                else
                {
                    this.BackColor = Color.Honeydew;
                }
            }
        }
        // Это обычный метод, который вызывается из Form3 при создании карточки
        public void SetupCard(string number, string title, string contractor, string amount, string dates, string status, DateTime endDate)
        {
            lblNumber.Text = number;
            lblTitle.Text = title;
            lblContractor.Text = contractor;
            lblAmount.Text = amount;
            lblDates.Text = dates;
            lblStatus.Text = status;

            this.BackColor = Color.White;
            if (status == "Расторгнут")
            {
                this.BackColor = Color.LightCoral;
            }
            else if (status == "Активный")
            {
                TimeSpan timeLeft = endDate - DateTime.Now;
                if (timeLeft.TotalDays <= 3 && timeLeft.TotalDays > 0)
                {
                    this.BackColor = Color.LightYellow;
                }
                else
                {
                    this.BackColor = Color.Honeydew;
                }
            }
        }
    }
}
