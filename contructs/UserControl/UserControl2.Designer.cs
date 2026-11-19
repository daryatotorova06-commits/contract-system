namespace contructs
{
    partial class UserControl2
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
            lblName = new Label();
            lblInn = new Label();
            lblKpp = new Label();
            lblAddress = new Label();
            lblPhone = new Label();
            lblEmail = new Label();
            lblType = new Label();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblName.Location = new Point(73, 34);
            lblName.Name = "lblName";
            lblName.Size = new Size(65, 25);
            lblName.TabIndex = 0;
            lblName.Text = "label1";
            // 
            // lblInn
            // 
            lblInn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblInn.AutoSize = true;
            lblInn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblInn.Location = new Point(73, 79);
            lblInn.Name = "lblInn";
            lblInn.Size = new Size(63, 25);
            lblInn.TabIndex = 1;
            lblInn.Text = "label2";
            // 
            // lblKpp
            // 
            lblKpp.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblKpp.AutoSize = true;
            lblKpp.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblKpp.Location = new Point(75, 122);
            lblKpp.Name = "lblKpp";
            lblKpp.Size = new Size(63, 25);
            lblKpp.TabIndex = 2;
            lblKpp.Text = "label3";
            // 
            // lblAddress
            // 
            lblAddress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblAddress.Location = new Point(75, 168);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(63, 25);
            lblAddress.TabIndex = 3;
            lblAddress.Text = "label4";
            // 
            // lblPhone
            // 
            lblPhone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblPhone.Location = new Point(75, 209);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(63, 25);
            lblPhone.TabIndex = 4;
            lblPhone.Text = "label5";
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblEmail.Location = new Point(75, 252);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(63, 25);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "label6";
            // 
            // lblType
            // 
            lblType.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblType.AutoSize = true;
            lblType.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblType.Location = new Point(75, 294);
            lblType.Name = "lblType";
            lblType.Size = new Size(63, 25);
            lblType.TabIndex = 6;
            lblType.Text = "label7";
            // 
            // UserControl2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblType);
            Controls.Add(lblEmail);
            Controls.Add(lblPhone);
            Controls.Add(lblAddress);
            Controls.Add(lblKpp);
            Controls.Add(lblInn);
            Controls.Add(lblName);
            Name = "UserControl2";
            Size = new Size(946, 365);
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
    }
}
