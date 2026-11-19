namespace contructs
{
    partial class UserControl3
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
            lblFullName = new Label();
            lblPosition = new Label();
            lblDepartment = new Label();
            lblPhone = new Label();
            lblEmail = new Label();
            SuspendLayout();
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblFullName.Location = new Point(58, 62);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(65, 25);
            lblFullName.TabIndex = 0;
            lblFullName.Text = "label1";
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblPosition.Location = new Point(58, 100);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(63, 25);
            lblPosition.TabIndex = 1;
            lblPosition.Text = "label2";
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblDepartment.Location = new Point(58, 148);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(63, 25);
            lblDepartment.TabIndex = 2;
            lblDepartment.Text = "label3";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblPhone.Location = new Point(58, 192);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(63, 25);
            lblPhone.TabIndex = 3;
            lblPhone.Text = "label4";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblEmail.Location = new Point(58, 234);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(63, 25);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "label5";
            // 
            // UserControl3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblEmail);
            Controls.Add(lblPhone);
            Controls.Add(lblDepartment);
            Controls.Add(lblPosition);
            Controls.Add(lblFullName);
            Name = "UserControl3";
            Size = new Size(749, 365);
            Load += UserControl3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFullName;
        private Label lblPosition;
        private Label lblDepartment;
        private Label lblPhone;
        private Label lblEmail;
    }
}
