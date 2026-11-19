namespace contructs
{
    partial class Form5
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
            txtSearch = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnAdd = new Button();
            label1 = new Label();
            button2 = new Button();
            cmbDeptFilter = new ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(24, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(330, 30);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(100, 23);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(3, 101);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(793, 337);
            flowLayoutPanel1.TabIndex = 2;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(639, 59);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(149, 23);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Добавить сотрудника";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(336, 12);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 4;
            label1.Text = "Поиск по ФИО";
            // 
            // button2
            // 
            button2.Location = new Point(341, 59);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Обновить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // cmbDeptFilter
            // 
            cmbDeptFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDeptFilter.FormattingEnabled = true;
            cmbDeptFilter.Items.AddRange(new object[] { "Все отделы", "Юридический отдел", "Отдел делопоизводства", "Бухгалтерия", "Руководитель", "Отдел закупок" });
            cmbDeptFilter.Location = new Point(667, 30);
            cmbDeptFilter.Name = "cmbDeptFilter";
            cmbDeptFilter.Size = new Size(121, 23);
            cmbDeptFilter.TabIndex = 6;
            cmbDeptFilter.SelectedIndexChanged += cmbDeptFilter_SelectedIndexChanged;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbDeptFilter);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(txtSearch);
            Controls.Add(button1);
            Name = "Form5";
            Text = "Сотрудники";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtSearch;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnAdd;
        private Label label1;
        private Button button2;
        private ComboBox cmbDeptFilter;
    }
}