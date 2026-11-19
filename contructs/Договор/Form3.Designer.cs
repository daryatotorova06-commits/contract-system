namespace contructs
{
    partial class Form3
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            txtSerch = new TextBox();
            label1 = new Label();
            cmbStatus = new ComboBox();
            btnRefresh = new Button();
            btnAddContract = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(12, 93);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(776, 345);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // txtSerch
            // 
            txtSerch.Location = new Point(333, 32);
            txtSerch.Name = "txtSerch";
            txtSerch.Size = new Size(100, 23);
            txtSerch.TabIndex = 1;
            txtSerch.TextChanged += txtSerch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(329, 14);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 2;
            label1.Text = "Поиск по номеру";
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Все", "Активный", "Завершен", "На согласовании", "Расторгнут" });
            cmbStatus.Location = new Point(667, 32);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(121, 23);
            cmbStatus.TabIndex = 3;
            cmbStatus.SelectedIndexChanged += cmbStatus_SelectedIndexChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(346, 61);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(73, 26);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Обновить";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnAddContract
            // 
            btnAddContract.Location = new Point(659, 66);
            btnAddContract.Name = "btnAddContract";
            btnAddContract.Size = new Size(129, 21);
            btnAddContract.TabIndex = 5;
            btnAddContract.Text = "Добавить договор";
            btnAddContract.UseVisualStyleBackColor = true;
            btnAddContract.Click += btnAddContract_Click;
            // 
            // button1
            // 
            button1.Location = new Point(22, 32);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(button1);
            Controls.Add(btnAddContract);
            Controls.Add(btnRefresh);
            Controls.Add(cmbStatus);
            Controls.Add(label1);
            Controls.Add(txtSerch);
            Name = "Form3";
            Text = "Договоры";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox txtSerch;
        private Label label1;
        private ComboBox cmbStatus;
        private Button btnRefresh;
        private Button btnAddContract;
        private Button button1;
    }
}