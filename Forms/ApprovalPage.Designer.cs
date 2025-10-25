namespace Corvus.Forms
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
            dataGridViewApproval = new DataGridView();
            comboProduct = new ComboBox();
            lblProduct = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewApproval).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewApproval
            // 
            dataGridViewApproval.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewApproval.Location = new Point(37, 111);
            dataGridViewApproval.Name = "dataGridViewApproval";
            dataGridViewApproval.Size = new Size(697, 204);
            dataGridViewApproval.TabIndex = 5;
            // 
            // comboProduct
            // 
            comboProduct.FormattingEnabled = true;
            comboProduct.Location = new Point(37, 64);
            comboProduct.Name = "comboProduct";
            comboProduct.Size = new Size(267, 23);
            comboProduct.TabIndex = 4;
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProduct.Location = new Point(37, 40);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(64, 21);
            lblProduct.TabIndex = 3;
            lblProduct.Text = "Product";
            lblProduct.Visible = false;
            // 
            // ApprovalPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridViewApproval);
            Controls.Add(comboProduct);
            Controls.Add(lblProduct);
            Name = "ApprovalPage";
            Size = new Size(831, 370);
            ((System.ComponentModel.ISupportInitialize)dataGridViewApproval).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewApproval;
        private ComboBox comboProduct;
        private Label lblProduct;
    }
}
