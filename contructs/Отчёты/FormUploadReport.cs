using Microsoft.Data.SqlClient;
using OfficeOpenXml.Style;
using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace contructs // Обрати внимание: у тебя в проекте namespace называется contructs (с двумя c), я исправил это здесь
{
    public partial class FormUploadReport : Form
    {
        // ТВОЯ СТРОКА ПОДКЛЮЧЕНИЯ (скопируй из Form4, если эта не подойдет)
        string connection = @"Server=KRN-20-204-C05\MSSQLSERVER2;Database=contract_db;Integrated Security=True;TrustServerCertificate=True";

        // ID сотрудника (ПОКА ЗАДАЙ ВРУЧНУЮ, ПОТОМ СДЕЛАЕШЬ АВТОМАТИЧЕСКИ ПРИ ВХОДЕ)
        int currentEmployeeId = 1;

        string selectedFilePath = "";

        public FormUploadReport()
        {
            InitializeComponent();
            // Загружаем список при открытии формы
            this.Load += FormUploadReport_Load;
        }

        // 1. СОБЫТИЕ ЗАГРУЗКИ ФОРМЫ (показывает таблицу сразу)
        private void FormUploadReport_Load(object sender, EventArgs e)
        {
            LoadReportsList();
        }

        // 2. КНОПКА "ВЫБРАТЬ ФАЙЛ"
        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Все файлы (*.*)|*.*|Word (*.docx)|*.docx|Excel (*.xlsx)|*.xlsx|PDF (*.pdf)|*.pdf";
                ofd.Title = "Выберите файл отчета";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedFilePath = ofd.FileName;
                    lblFileName.Text = Path.GetFileName(selectedFilePath);
                    lblFileName.ForeColor = System.Drawing.Color.Green;
                }
            }
        }

        // 3. КНОПКА "ЗАГРУЗИТЬ ОТЧЕТ"
        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedFilePath))
            {
                MessageBox.Show("Сначала выберите файл!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // А. Создаем папку Reports рядом с программой, если её нет
                string appPath = AppDomain.CurrentDomain.BaseDirectory;
                string targetFolder = Path.Combine(appPath, "Reports");
                if (!Directory.Exists(targetFolder))
                    Directory.CreateDirectory(targetFolder);

                // Б. Генерируем уникальное имя файла (чтобы не перезаписать чужой отчет)
                string newFileName = Guid.NewGuid().ToString() + Path.GetExtension(selectedFilePath);
                string targetPath = Path.Combine(targetFolder, newFileName);

                // В. Копируем файл в нашу папку
                File.Copy(selectedFilePath, targetPath);

                // Г. Сохраняем информацию в базу данных
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();
                    string query = "INSERT INTO employee_reports (employee_id, file_name, file_path, description) VALUES (@eid, @fn, @fp, @desc)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@eid", currentEmployeeId);
                        cmd.Parameters.AddWithValue("@fn", Path.GetFileName(selectedFilePath)); // Оригинальное имя
                        cmd.Parameters.AddWithValue("@fp", newFileName); // Уникальное имя на диске
                        cmd.Parameters.AddWithValue("@desc", txtDescription.Text);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Отчет успешно загружен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Очищаем поля и обновляем таблицу
                selectedFilePath = "";
                lblFileName.Text = "(Файл не выбран)";
                lblFileName.ForeColor = System.Drawing.Color.Gray;
                txtDescription.Clear();
                LoadReportsList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 4. МЕТОД ДЛЯ ЗАПОЛНЕНИЯ ТАБЛИЦЫ
        private void LoadReportsList()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();
                    // ВАЖНО: file_path нужен для открытия, но мы скроем его в таблице
                    string query = "SELECT report_id, file_name as 'Имя файла', description as 'Описание', upload_date as 'Дата', file_path FROM employee_reports WHERE employee_id = @eid ORDER BY upload_date DESC";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    da.SelectCommand.Parameters.AddWithValue("@eid", currentEmployeeId);

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvReports.DataSource = dt;

                    // Скрываем колонку с техническим именем файла (file_path)
                    if (dgvReports.Columns.Contains("file_path"))
                        dgvReports.Columns["file_path"].Visible = false;

                    // Растягиваем колонки по ширине
                    dgvReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки списка: " + ex.Message);
            }
        }

        // 5. ОТКРЫТИЕ ФАЙЛА ПО ДВОЙНОМУ КЛИКУ (или клику по кнопке в таблице)
        // Если ты добавила кнопку в таблицу, используй dgvReports_CellContentClick
        // Если просто двойной клик по строке - используй dgvReports_CellDoubleClick
        private void dgvReports_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Проверяем, что кликнули не по заголовку
            if (e.RowIndex >= 0)
            {
                OpenSelectedFile(e.RowIndex);
            }
        }

        // Вспомогательный метод для открытия
        private void OpenSelectedFile(int rowIndex)
        {
            try
            {
                // Берем скрытое имя файла из базы (из колонки file_path)
                // Если ты скрыла колонку, она все равно доступна по имени
                object cellValue = dgvReports.Rows[rowIndex].Cells["file_path"].Value;

                if (cellValue != null && !string.IsNullOrEmpty(cellValue.ToString()))
                {
                    string savedName = cellValue.ToString();

                    string appPath = AppDomain.CurrentDomain.BaseDirectory;
                    string fullPath = Path.Combine(appPath, "Reports", savedName);

                    if (File.Exists(fullPath))
                    {
                        // Открываем файл в программе по умолчанию (Word, Excel...)
                        Process.Start(new ProcessStartInfo(fullPath) { UseShellExecute = true });
                    }
                    else
                    {
                        MessageBox.Show("Файл не найден на диске! Возможно, он был удален вручную.", "Ошибка");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось открыть файл: " + ex.Message);
            }
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDeleteReport_Click(object sender, EventArgs e)
        {
            if (dgvReports.CurrentRow == null || dgvReports.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Выберите отчет для удаления!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Спрашиваем подтверждение
            DialogResult result = MessageBox.Show(
                "Вы действительно хотите удалить этот отчет?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // 1. Получаем данные из выбранной строки
                    int reportId = Convert.ToInt32(dgvReports.CurrentRow.Cells["report_id"].Value); // Нужно добавить report_id в SELECT запрос!
                    string fileName = dgvReports.CurrentRow.Cells["file_path"].Value.ToString();

                    // 2. Удаляем физический файл с диска
                    string appPath = AppDomain.CurrentDomain.BaseDirectory;
                    string fullPath = Path.Combine(appPath, "Reports", fileName);

                    if (File.Exists(fullPath))
                    {
                        File.Delete(fullPath);
                    }

                    // 3. Удаляем запись из базы данных
                    using (SqlConnection conn = new SqlConnection(connection))
                    {
                        conn.Open();
                        string query = "DELETE FROM employee_reports WHERE report_id = @rid";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@rid", reportId);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Отчет успешно удален.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 4. Обновляем таблицу
                    LoadReportsList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при удалении: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}