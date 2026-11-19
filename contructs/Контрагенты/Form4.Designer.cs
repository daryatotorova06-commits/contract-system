namespace contructs
{
    partial class Form4
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
            txtSearch = new TextBox();
            button1 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnAdd = new Button();
            label1 = new Label();
            button2 = new Button();
            cmbTypeFilter = new ComboBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(337, 40);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(100, 23);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(28, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.ImeMode = ImeMode.NoControl;
            flowLayoutPanel1.Location = new Point(12, 113);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(776, 333);
            flowLayoutPanel1.TabIndex = 2;
            flowLayoutPanel1.WrapContents = false;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(632, 69);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(156, 23);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Добавить контрагента";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(342, 20);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 4;
            label1.Text = "Поиск по ИНН";
            // 
            // button2
            // 
            button2.Location = new Point(350, 69);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Обновить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // cmbTypeFilter
            // 
            cmbTypeFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTypeFilter.FormattingEnabled = true;
            cmbTypeFilter.Items.AddRange(new object[] { "Все", "Поставщик", "Подрядчик", "Заказчик", "Покупатель" });
            cmbTypeFilter.Location = new Point(667, 40);
            cmbTypeFilter.Name = "cmbTypeFilter";
            cmbTypeFilter.Size = new Size(121, 23);
            cmbTypeFilter.TabIndex = 6;
            cmbTypeFilter.SelectedIndexChanged += cmbTypeFilter_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(667, 16);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 7;
            label2.Text = "Фильтр по типу";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(cmbTypeFilter);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Controls.Add(button1);
            Controls.Add(txtSearch);
            Controls.Add(flowLayoutPanel1);
            Name = "Form4";
            Text = "Контрагенты";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private Button button1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnAdd;
        private Label label1;
        private Button button2;
        private ComboBox cmbTypeFilter;
        private Label label2;
    }
}