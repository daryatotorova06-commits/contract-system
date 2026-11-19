namespace contructs
{
    partial class Form8
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
            lblFull_name = new Label();
            txtFull_name = new TextBox();
            lblPosition = new Label();
            txtPosition = new TextBox();
            lblDepartment = new Label();
            cmbDepartment = new ComboBox();
            lblPhone = new Label();
            lblEmail = new Label();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblFull_name
            // 
            lblFull_name.AutoSize = true;
            lblFull_name.Location = new Point(29, 40);
            lblFull_name.Name = "lblFull_name";
            lblFull_name.Size = new Size(37, 15);
            lblFull_name.TabIndex = 0;
            lblFull_name.Text = "ФИО:";
            // 
            // txtFull_name
            // 
            txtFull_name.Location = new Point(72, 37);
            txtFull_name.Name = "txtFull_name";
            txtFull_name.Size = new Size(100, 23);
            txtFull_name.TabIndex = 1;
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Location = new Point(29, 89);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(72, 15);
            lblPosition.TabIndex = 2;
            lblPosition.Text = "Должность:";
            // 
            // txtPosition
            // 
            txtPosition.Location = new Point(107, 86);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(100, 23);
            txtPosition.TabIndex = 3;
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Location = new Point(29, 134);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(43, 15);
            lblDepartment.TabIndex = 4;
            lblDepartment.Text = "Отдел:";
            // 
            // cmbDepartment
            // 
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Items.AddRange(new object[] { "Юридический отдел", "Отдел делопроизводства", "Отдел закупок", "Бухгалтерия", "Руководитель" });
            cmbDepartment.Location = new Point(78, 126);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(121, 23);
            cmbDepartment.TabIndex = 5;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(29, 176);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(29, 15);
            lblPhone.TabIndex = 6;
            lblPhone.Text = "Тел:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(29, 220);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(72, 217);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 8;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(64, 173);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(100, 23);
            txtPhone.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(40, 283);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 10;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(180, 283);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 331);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(lblPhone);
            Controls.Add(cmbDepartment);
            Controls.Add(lblDepartment);
            Controls.Add(txtPosition);
            Controls.Add(lblPosition);
            Controls.Add(txtFull_name);
            Controls.Add(lblFull_name);
            Name = "Form8";
            Text = "Добавление сотрудников";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFull_name;
        private TextBox txtFull_name;
        private Label lblPosition;
        private TextBox txtPosition;
        private Label lblDepartment;
        private ComboBox cmbDepartment;
        private Label lblPhone;
        private Label lblEmail;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private Button btnSave;
        private Button btnCancel;
    }
}