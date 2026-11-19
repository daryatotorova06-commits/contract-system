namespace contructs
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            panel1 = new Panel();
            label1 = new Label();
            btnConterparties = new Button();
            btnContracts = new Button();
            btnEmployees = new Button();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            btnReport = new Button();
            btnOpenReports = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LavenderBlush;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(12, 406);
            button1.Name = "button1";
            button1.Size = new Size(81, 32);
            button1.TabIndex = 0;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(843, 69);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(294, 23);
            label1.Name = "label1";
            label1.Size = new Size(276, 30);
            label1.TabIndex = 0;
            label1.Text = "Система учета договоров";
            // 
            // btnConterparties
            // 
            btnConterparties.BackColor = Color.LavenderBlush;
            btnConterparties.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnConterparties.Location = new Point(335, 144);
            btnConterparties.Name = "btnConterparties";
            btnConterparties.Size = new Size(220, 58);
            btnConterparties.TabIndex = 3;
            btnConterparties.Text = "Контрагенты";
            btnConterparties.UseVisualStyleBackColor = false;
            btnConterparties.Click += btnConterparties_Click;
            // 
            // btnContracts
            // 
            btnContracts.BackColor = Color.LavenderBlush;
            btnContracts.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnContracts.Location = new Point(68, 144);
            btnContracts.Name = "btnContracts";
            btnContracts.Size = new Size(234, 57);
            btnContracts.TabIndex = 4;
            btnContracts.Text = "Договоры";
            btnContracts.UseVisualStyleBackColor = false;
            btnContracts.Click += btnContracts_Click;
            // 
            // btnEmployees
            // 
            btnEmployees.BackColor = Color.LavenderBlush;
            btnEmployees.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnEmployees.Location = new Point(586, 144);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new Size(199, 56);
            btnEmployees.TabIndex = 5;
            btnEmployees.Text = "Сотрудники";
            btnEmployees.UseVisualStyleBackColor = false;
            btnEmployees.Click += btnEmployees_Click;
            // 
            // btnReport
            // 
            btnReport.Location = new Point(741, 417);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(90, 21);
            btnReport.TabIndex = 6;
            btnReport.Text = "Статистика";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // btnOpenReports
            // 
            btnOpenReports.Location = new Point(649, 417);
            btnOpenReports.Name = "btnOpenReports";
            btnOpenReports.Size = new Size(75, 23);
            btnOpenReports.TabIndex = 7;
            btnOpenReports.Text = "📂 Отчеты";
            btnOpenReports.UseVisualStyleBackColor = true;
            btnOpenReports.Click += btnExportExcel_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(843, 450);
            Controls.Add(btnOpenReports);
            Controls.Add(btnReport);
            Controls.Add(btnEmployees);
            Controls.Add(btnContracts);
            Controls.Add(btnConterparties);
            Controls.Add(panel1);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Система учета договоров";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Panel panel1;
        private Label label1;
        private Button btnConterparties;
        private Button btnContracts;
        private Button btnEmployees;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Button btnReport;
        private Button btnOpenReports;
    }
}