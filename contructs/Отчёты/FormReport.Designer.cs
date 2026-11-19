namespace contructs
{
    partial class FormReport
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
            label1 = new Label();
            lblTotalCount = new Label();
            lblTotalSum = new Label();
            dgvTopContracts = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvTopContracts).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(232, 9);
            label1.Name = "label1";
            label1.Size = new Size(217, 21);
            label1.TabIndex = 0;
            label1.Text = "Статиcтика по договорам";
            label1.Click += label1_Click;
            // 
            // lblTotalCount
            // 
            lblTotalCount.AutoSize = true;
            lblTotalCount.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblTotalCount.Location = new Point(49, 55);
            lblTotalCount.Name = "lblTotalCount";
            lblTotalCount.Size = new Size(45, 17);
            lblTotalCount.TabIndex = 1;
            lblTotalCount.Text = "label2";
            lblTotalCount.Click += lblTotalCount_Click;
            // 
            // lblTotalSum
            // 
            lblTotalSum.AutoSize = true;
            lblTotalSum.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblTotalSum.Location = new Point(489, 55);
            lblTotalSum.Name = "lblTotalSum";
            lblTotalSum.Size = new Size(45, 17);
            lblTotalSum.TabIndex = 2;
            lblTotalSum.Text = "label3";
            lblTotalSum.Click += lblTotalSum_Click;
            // 
            // dgvTopContracts
            // 
            dgvTopContracts.AllowUserToAddRows = false;
            dgvTopContracts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTopContracts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTopContracts.Location = new Point(12, 92);
            dgvTopContracts.Name = "dgvTopContracts";
            dgvTopContracts.ReadOnly = true;
            dgvTopContracts.Size = new Size(679, 207);
            dgvTopContracts.TabIndex = 3;
            dgvTopContracts.CellContentClick += dgvTopContracts_CellContentClick;
            // 
            // FormReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(703, 313);
            Controls.Add(dgvTopContracts);
            Controls.Add(lblTotalSum);
            Controls.Add(lblTotalCount);
            Controls.Add(label1);
            Name = "FormReport";
            Text = "Отчеты";
            Load += FormReport_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTopContracts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblTotalCount;
        private Label lblTotalSum;
        private DataGridView dgvTopContracts;
    }
}