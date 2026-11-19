using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace contructs // Твой namespace
{
    public partial class Form3 : Form
    {
        string connection = @"Server=KRN-20-204-C05\MSSQLSERVER2;Database=contract_db;Integrated Security=True;TrustServerCertificate=True;";

        private string userRole;

        public Form3(string role)
        {
            InitializeComponent();
            userRole = role;

            // Привязка событий
            this.Load += Form3_Load;
            btnRefresh.Click += new EventHandler(btnRefresh_Click);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            LoadContractCards();
            ChekDeadlines(); // Проверка сроков при загрузке

            if (userRole == "director")
            {
                btnAddContract.Enabled = false;
            }
            else
            {
                btnAddContract.Enabled = true;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadContractCards();
        }

        // === ЕДИНЫЙ МЕТОД ЗАГРУЗКИ КАРТОЧЕК ===
        private void LoadContractCards()
        {
            flowLayoutPanel1.Controls.Clear();

            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();

                    // Используем CONVERT(..., 120) для гарантии формата YYYY-MM-DD
                    string query = @"SELECT c.number, c.title, cont.name as contractor_name, 
                                    c.amount, c.status, 
                                    CONVERT(varchar, c.start_date, 120) as start_date, 
                                    CONVERT(varchar, c.end_date, 120) as end_date 
                             FROM contracts c
                             LEFT JOIN contractors cont ON c.contractor_id = cont.contractor_id
                             ORDER BY c.end_date ASC";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        // Безопасное чтение строк
                        string number = reader["number"] != DBNull.Value ? reader["number"].ToString() : "";
                        string title = reader["title"] != DBNull.Value ? reader["title"].ToString() : "";
                        string contractor = reader["contractor_name"] != DBNull.Value ? reader["contractor_name"].ToString() : "Не указан";
                        string status = reader["status"] != DBNull.Value ? reader["status"].ToString() : "Активный";

                        // БЕЗОПАСНОЕ ЧТЕНИЕ СУММЫ (Защита от FormatException)
                        decimal amountVal = 0;
                        if (reader["amount"] != DBNull.Value)
                        {
                            decimal.TryParse(reader["amount"].ToString(), out amountVal);
                        }

                        // БЕЗОПАСНОЕ ЧТЕНИЕ ДАТ (Защита от FormatException и русских месяцев)
                        DateTime startDate = DateTime.Now;
                        DateTime endDate = DateTime.Now;

                        if (reader["start_date"] != DBNull.Value)
                        {
                            // TryParse сам поймет формат "2026-12-10" или "10.12.2026"
                            DateTime.TryParse(reader["start_date"].ToString(), out startDate);
                        }

                        if (reader["end_date"] != DBNull.Value)
                        {
                            DateTime.TryParse(reader["end_date"].ToString(), out endDate);
                        }

                        string datesDisplay = $"{startDate.ToShortDateString()} — {endDate.ToShortDateString()}";

                        // Создаем карточку
                        UserControl1 card = new UserControl1();

                        // Передаем данные. amountVal.ToString("N2") гарантирует строку "1 500,00"
                        card.SetupCard(number, title, contractor, amountVal.ToString("N2"), datesDisplay, status, endDate);

                        flowLayoutPanel1.Controls.Add(card);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки: " + ex.Message, "Критическая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // === ПРОВЕРКА СРОКОВ (УВЕДОМЛЕНИЯ) ===
        private void ChekDeadlines()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();
                    // ДОБАВЬ CONVERT И ЗДЕСЬ ТОЖЕ!
                    string query = @"SELECT number, CONVERT(varchar, end_date, 120) as end_date 
                             FROM contracts 
                             WHERE status = 'Активный' 
                               AND end_date BETWEEN GETDATE() AND DATEADD(day, 3, GETDATE())";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    string warnings = "";

                    while (reader.Read())
                    {
                        // Теперь дата придет в формате "2026-12-10", Convert сработает
                        if (reader["end_date"] != DBNull.Value)
                        {
                            DateTime endDate = Convert.ToDateTime(reader["end_date"]);
                            warnings += $"Договор № {reader["number"]} истекает {endDate.ToShortDateString()}!\n";
                        }
                    }

                    if (!string.IsNullOrEmpty(warnings))
                    {
                        MessageBox.Show("ВНИМАНИЕ! Скоро истекают сроки:\n\n" + warnings,
                            "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                // Логируем ошибку, но не ломаем программу
                System.Diagnostics.Debug.WriteLine("Ошибка уведомлений: " + ex.Message);
            }
        }

        // === ПОИСК ПО НОМЕРУ ===
        private void txtSerch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSerch.Text.Trim().ToLower();

            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is UserControl1 card)
                {
                    bool matches = card.lblNumber.Text.ToLower().Contains(searchText);

                    // Учитываем текущий фильтр по статусу
                    if (cmbStatus.Text != "Все" && cmbStatus.SelectedIndex >= 0)
                    {
                        string cleanCardStatus = card.lblStatus.Text.ToLower().Replace('ё', 'е');
                        string cleanFilterStatus = cmbStatus.Text.ToLower().Replace('ё', 'е');
                        matches = matches && (cleanCardStatus == cleanFilterStatus);
                    }

                    card.Visible = matches;
                }
            }
        }

        // === ФИЛЬТР ПО СТАТУСУ ===
        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedStatus = cmbStatus.Text;

            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is UserControl1 card)
                {
                    string cardStatus = card.lblStatus.Text;

                    // МАГИЯ: Заменяем 'ё' на 'е' для корректного сравнения
                    string cleanCardStatus = cardStatus.ToLower().Replace('ё', 'е');
                    string cleanFilterStatus = selectedStatus.ToLower().Replace('ё', 'е');

                    bool isVisible = false;

                    if (selectedStatus == "Все" || string.IsNullOrEmpty(selectedStatus))
                    {
                        isVisible = true;
                    }
                    else
                    {
                        isVisible = (cleanCardStatus == cleanFilterStatus);
                    }

                    // Учитываем текущий текст поиска
                    if (!string.IsNullOrWhiteSpace(txtSerch.Text))
                    {
                        isVisible = isVisible && card.lblNumber.Text.ToLower().Contains(txtSerch.Text.Trim().ToLower());
                    }

                    card.Visible = isVisible;
                }
            }
        }

        // === ДОБАВЛЕНИЕ ДОГОВОРА ===
        private void btnAddContract_Click(object sender, EventArgs e)
        {
            using (Form6 addForm = new Form6())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    LoadContractCards(); // Обновляем реестр после успешного добавления
                }
            }
        }

        // Кнопка Назад (если нужна)
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 guestForm = new Form2(1, "Админ", "admin");
            guestForm.Show();
            this.Hide();
        }
        // Добавь это в конец класса Form3 в файле Form3.cs
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            // Этот метод нужен, чтобы дизайнер не ругался. 
            // Обычно здесь ничего не пишут, если не нужно рисовать что-то вручную.
        }
    }
}