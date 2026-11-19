namespace contructs
{
    partial class Form7
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
            lblName = new Label();
            lblInn = new Label();
            lblKpp = new Label();
            lblAddress = new Label();
            lblPhone = new Label();
            lblEmail = new Label();
            lblType = new Label();
            txtName = new TextBox();
            txtInn = new TextBox();
            txtKpp = new TextBox();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            cmbType = new ComboBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(28, 20);
            lblName.Name = "lblName";
            lblName.Size = new Size(136, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Название организации:";
            // 
            // lblInn
            // 
            lblInn.AutoSize = true;
            lblInn.Location = new Point(28, 57);
            lblInn.Name = "lblInn";
            lblInn.Size = new Size(37, 15);
            lblInn.TabIndex = 1;
            lblInn.Text = "ИНН:";
            // 
            // lblKpp
            // 
            lblKpp.AutoSize = true;
            lblKpp.Location = new Point(28, 92);
            lblKpp.Name = "lblKpp";
            lblKpp.Size = new Size(35, 15);
            lblKpp.TabIndex = 2;
            lblKpp.Text = "КПП:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(28, 131);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(43, 15);
            lblAddress.TabIndex = 3;
            lblAddress.Text = "Адрес:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(28, 169);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(58, 15);
            lblPhone.TabIndex = 4;
            lblPhone.Text = "Телефон:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(28, 207);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email:";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(28, 249);
            lblType.Name = "lblType";
            lblType.Size = new Size(100, 15);
            lblType.TabIndex = 6;
            lblType.Text = "Тип контрагента:";
            // 
            // txtName
            // 
            txtName.Location = new Point(170, 17);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 7;
            // 
            // txtInn
            // 
            txtInn.Location = new Point(71, 54);
            txtInn.Name = "txtInn";
            txtInn.Size = new Size(100, 23);
            txtInn.TabIndex = 8;
            // 
            // txtKpp
            // 
            txtKpp.Location = new Point(69, 89);
            txtKpp.Name = "txtKpp";
            txtKpp.Size = new Size(100, 23);
            txtKpp.TabIndex = 9;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(71, 128);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(100, 23);
            txtAddress.TabIndex = 10;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(92, 166);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(100, 23);
            txtPhone.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(73, 204);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 12;
            // 
            // cmbType
            // 
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbType.FormattingEnabled = true;
            cmbType.Items.AddRange(new object[] { "Поставщик", "Подрядчик", "Покупатель", "Заказчик" });
            cmbType.Location = new Point(134, 246);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(121, 23);
            cmbType.TabIndex = 13;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(42, 331);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 14;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(212, 331);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cmbType);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtAddress);
            Controls.Add(txtKpp);
            Controls.Add(txtInn);
            Controls.Add(txtName);
            Controls.Add(lblType);
            Controls.Add(lblEmail);
            Controls.Add(lblPhone);
            Controls.Add(lblAddress);
            Controls.Add(lblKpp);
            Controls.Add(lblInn);
            Controls.Add(lblName);
            Name = "Form7";
            Text = "Добавление контрагента";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblInn;
        private Label lblKpp;
        private Label lblAddress;
        private Label lblPhone;
        private Label lblEmail;
        private Label lblType;
        private TextBox txtName;
        private TextBox txtInn;
        private TextBox txtKpp;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private ComboBox cmbType;
        private Button btnSave;
        private Button btnCancel;
    }
}