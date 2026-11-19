namespace contructs // ИСПРАВЛЕНО: было contructs
{
    partial class Form6
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
            lblNumber = new Label();
            txtNumber = new TextBox();
            lblContractor = new Label();
            cmbContractor = new ComboBox();
            lblTitle = new Label();
            txtTitle = new TextBox();
            lblAmount = new Label();
            numAmount = new NumericUpDown();
            lblStart = new Label();
            dtpStart = new DateTimePicker();
            lblEnd = new Label();
            dtpEnd = new DateTimePicker();
            btnSave = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numAmount).BeginInit();

            SuspendLayout(); // РАСКОММЕНТИРОВАНО

            // lblNumber
            lblNumber.AutoSize = true;
            lblNumber.Location = new Point(52, 68);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(99, 15);
            lblNumber.TabIndex = 0;
            lblNumber.Text = "Номер договора:";

            // txtNumber
            txtNumber.Location = new Point(182, 68);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(150, 23);
            txtNumber.TabIndex = 1;

            // lblContractor
            lblContractor.AutoSize = true;
            lblContractor.Location = new Point(52, 103);
            lblContractor.Name = "lblContractor";
            lblContractor.Size = new Size(69, 15);
            lblContractor.TabIndex = 2;
            lblContractor.Text = "Контрагент:";

            // cmbContractor
            cmbContractor.DropDownStyle = ComboBoxStyle.DropDownList; // ВАЖНО: Запрет ручного ввода
            cmbContractor.FormattingEnabled = true;
            cmbContractor.Location = new Point(182, 100);
            cmbContractor.Name = "cmbContractor";
            cmbContractor.Size = new Size(200, 23);
            cmbContractor.TabIndex = 3;

            // lblTitle
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(52, 143);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(109, 15);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Предмет договора:";

            // txtTitle
            txtTitle.Location = new Point(182, 140);
            txtTitle.Multiline = true; // ВАЖНО: Многострочное поле
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(200, 60);
            txtTitle.TabIndex = 5;

            // lblAmount
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(52, 215);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(62, 15);
            lblAmount.TabIndex = 6;
            lblAmount.Text = "Сумма (₽):";

            // numAmount
            numAmount.DecimalPlaces = 2; // ВАЖНО: Копейки
            numAmount.Location = new Point(182, 213);
            numAmount.Name = "numAmount";
            numAmount.Size = new Size(120, 23);
            numAmount.TabIndex = 7;
            numAmount.ThousandsSeparator = true;

            // lblStart
            lblStart.AutoSize = true;
            lblStart.Location = new Point(52, 250);
            lblStart.Name = "lblStart";
            lblStart.Size = new Size(74, 15);
            lblStart.TabIndex = 8;
            lblStart.Text = "Дата начала:";

            // dtpStart
            dtpStart.Format = DateTimePickerFormat.Short;
            dtpStart.Location = new Point(182, 246);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(120, 23);
            dtpStart.TabIndex = 9;

            // lblEnd
            lblEnd.AutoSize = true;
            lblEnd.Location = new Point(52, 280);
            lblEnd.Name = "lblEnd";
            lblEnd.Size = new Size(95, 15);
            lblEnd.TabIndex = 10;
            lblEnd.Text = "Дата окончания:";

            // dtpEnd
            dtpEnd.Format = DateTimePickerFormat.Short;
            dtpEnd.Location = new Point(182, 276);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(120, 23);
            dtpEnd.TabIndex = 11;

            // btnSave
            btnSave.Location = new Point(58, 320);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 30);
            btnSave.TabIndex = 12;
            btnSave.Text = "Сохранить"; // ИСПРАВЛЕНО: было button1
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;

            // btnCancel
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(182, 320);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 30);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Отмена"; // ИСПРАВЛЕНО: было button1
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;

            // Form6
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 380);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(dtpEnd);
            Controls.Add(lblEnd);
            Controls.Add(dtpStart);
            Controls.Add(lblStart);
            Controls.Add(numAmount);
            Controls.Add(lblAmount);
            Controls.Add(txtTitle);
            Controls.Add(lblTitle);
            Controls.Add(cmbContractor);
            Controls.Add(lblContractor);
            Controls.Add(txtNumber);
            Controls.Add(lblNumber);

            Name = "Form6"; // РАСКОММЕНТИРОВАНО
            Text = "Новый договор";

            Load += Form6_Load; // РАСКОММЕНТИРОВАНО (Критически важно!)

            ((System.ComponentModel.ISupportInitialize)numAmount).EndInit();

            ResumeLayout(false); // РАСКОММЕНТИРОВАНО
            PerformLayout();     // РАСКОММЕНТИРОВАНО
        }

        #endregion

        private Label lblNumber;
        private TextBox txtNumber;
        private Label lblContractor;
        private ComboBox cmbContractor;
        private Label lblTitle;
        private TextBox txtTitle;
        private Label lblAmount;
        private NumericUpDown numAmount;
        private Label lblStart;
        private DateTimePicker dtpStart;
        private Label lblEnd;
        private DateTimePicker dtpEnd;
        private Button btnSave;
        private Button btnCancel;
    }
}