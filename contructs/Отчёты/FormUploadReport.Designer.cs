namespace contructs
{
    partial class FormUploadReport
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
            txtDescription = new TextBox();
            btnSelectFile = new Button();
            lblFileName = new Label();
            btnUpload = new Button();
            dgvReports = new DataGridView();
            label1 = new Label();
            btnDeleteReport = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReports).BeginInit();
            SuspendLayout();
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(40, 49);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(187, 23);
            txtDescription.TabIndex = 0;
            txtDescription.TextChanged += txtDescription_TextChanged;
            // 
            // btnSelectFile
            // 
            btnSelectFile.Location = new Point(39, 78);
            btnSelectFile.Name = "btnSelectFile";
            btnSelectFile.Size = new Size(120, 23);
            btnSelectFile.TabIndex = 1;
            btnSelectFile.Text = "Выбрать файл";
            btnSelectFile.UseVisualStyleBackColor = true;
            btnSelectFile.Click += btnSelectFile_Click;
            // 
            // lblFileName
            // 
            lblFileName.AutoSize = true;
            lblFileName.Location = new Point(166, 86);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new Size(105, 15);
            lblFileName.TabIndex = 2;
            lblFileName.Text = "(Файл не выбран)";
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(40, 107);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(140, 23);
            btnUpload.TabIndex = 3;
            btnUpload.Text = "⬆️ Загрузить отчет";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // dgvReports
            // 
            dgvReports.AllowUserToAddRows = false;
            dgvReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReports.Location = new Point(40, 151);
            dgvReports.Name = "dgvReports";
            dgvReports.ReadOnly = true;
            dgvReports.Size = new Size(446, 199);
            dgvReports.TabIndex = 4;
            dgvReports.CellContentClick += dgvReports_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 29);
            label1.Name = "label1";
            label1.Size = new Size(135, 15);
            label1.TabIndex = 5;
            label1.Text = "Комментарий к отчету:";
            // 
            // btnDeleteReport
            // 
            btnDeleteReport.Location = new Point(332, 360);
            btnDeleteReport.Name = "btnDeleteReport";
            btnDeleteReport.Size = new Size(194, 23);
            btnDeleteReport.TabIndex = 6;
            btnDeleteReport.Text = "🗑️ Удалить выбранный отчет";
            btnDeleteReport.UseVisualStyleBackColor = true;
            btnDeleteReport.Click += btnDeleteReport_Click;
            // 
            // FormUploadReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 391);
            Controls.Add(btnDeleteReport);
            Controls.Add(label1);
            Controls.Add(dgvReports);
            Controls.Add(btnUpload);
            Controls.Add(lblFileName);
            Controls.Add(btnSelectFile);
            Controls.Add(txtDescription);
            Name = "FormUploadReport";
            Text = "Загрузка отчёта";
            Load += FormUploadReport_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReports).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDescription;
        private Button btnSelectFile;
        private Label lblFileName;
        private Button btnUpload;
        private DataGridView dgvReports;
        private Label label1;
        private Button btnDeleteReport;
    }
}