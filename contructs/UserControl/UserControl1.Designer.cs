namespace contructs
{
    partial class UserControl1
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            lblNumber = new Label();
            lblTitle = new Label();
            lblContractor = new Label();
            lblAmount = new Label();
            lblDates = new Label();
            lblStatus = new Label();
            SuspendLayout();
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblNumber.Location = new Point(57, 29);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(65, 25);
            lblNumber.TabIndex = 0;
            lblNumber.Text = "label1";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblTitle.Location = new Point(57, 76);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(63, 25);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "label2";
            // 
            // lblContractor
            // 
            lblContractor.AutoSize = true;
            lblContractor.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblContractor.Location = new Point(57, 119);
            lblContractor.Name = "lblContractor";
            lblContractor.Size = new Size(63, 25);
            lblContractor.TabIndex = 2;
            lblContractor.Text = "label3";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblAmount.Location = new Point(57, 165);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(63, 25);
            lblAmount.TabIndex = 3;
            lblAmount.Text = "label4";
            // 
            // lblDates
            // 
            lblDates.AutoSize = true;
            lblDates.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblDates.Location = new Point(57, 216);
            lblDates.Name = "lblDates";
            lblDates.Size = new Size(63, 25);
            lblDates.TabIndex = 4;
            lblDates.Text = "label5";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblStatus.Location = new Point(59, 265);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(63, 25);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "label6";
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblStatus);
            Controls.Add(lblDates);
            Controls.Add(lblAmount);
            Controls.Add(lblContractor);
            Controls.Add(lblTitle);
            Controls.Add(lblNumber);
            Name = "UserControl1";
            Size = new Size(749, 365);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitle;
        private Label lblContractor;
        private Label lblAmount;
        private Label lblDates;
        public Label lblNumber;
        public Label lblStatus;
    }
}
