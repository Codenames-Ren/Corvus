namespace Corvus.Forms.AdminMenus
{
    partial class ApprovalPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboProduct = new ComboBox();
            label1 = new Label();
            dataGridViewApproval = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewApproval).BeginInit();
            SuspendLayout();
            // 
            // comboProduct
            // 
            comboProduct.FormattingEnabled = true;
            comboProduct.Items.AddRange(new object[] { "--Choose--", "Loan", "Saving", "Across Registration" });
            comboProduct.Location = new Point(26, 87);
            comboProduct.Margin = new Padding(6, 6, 6, 6);
            comboProduct.Name = "comboProduct";
            comboProduct.Size = new Size(374, 40);
            comboProduct.TabIndex = 0;
            comboProduct.SelectedIndexChanged += comboProduct_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(32, 49);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(96, 32);
            label1.TabIndex = 1;
            label1.Text = "Product";
            // 
            // dataGridViewApproval
            // 
            dataGridViewApproval.AllowUserToAddRows = false;
            dataGridViewApproval.AllowUserToDeleteRows = false;
            dataGridViewApproval.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewApproval.Location = new Point(26, 173);
            dataGridViewApproval.Margin = new Padding(6, 6, 6, 6);
            dataGridViewApproval.Name = "dataGridViewApproval";
            dataGridViewApproval.ReadOnly = true;
            dataGridViewApproval.RowHeadersWidth = 82;
            dataGridViewApproval.Size = new Size(1209, 320);
            dataGridViewApproval.TabIndex = 2;
            dataGridViewApproval.CellClick += dataGridViewApproval_CellClick;
            // 
            // ApprovalPage
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 64);
            Controls.Add(dataGridViewApproval);
            Controls.Add(label1);
            Controls.Add(comboProduct);
            Margin = new Padding(6, 6, 6, 6);
            Name = "ApprovalPage";
            Size = new Size(1267, 553);
            Load += ApprovalPage_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewApproval).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboProduct;
        private Label label1;
        private DataGridView dataGridViewApproval;
    }
}
