namespace Corvus.Forms
{
    partial class AccrossPage
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dgvCoop = new DataGridView();
            dgvMember = new DataGridView();
            dgvTransfer = new DataGridView();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCoop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMember).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTransfer).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 20);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 0;
            label1.Text = "Coop";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(705, 20);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 1;
            label2.Text = "Member";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 359);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 2;
            label3.Text = "Transfer";
            // 
            // dgvCoop
            // 
            dgvCoop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCoop.Location = new Point(23, 57);
            dgvCoop.Name = "dgvCoop";
            dgvCoop.RowHeadersWidth = 51;
            dgvCoop.Size = new Size(637, 258);
            dgvCoop.TabIndex = 3;
            // 
            // dgvMember
            // 
            dgvMember.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMember.Location = new Point(705, 57);
            dgvMember.Name = "dgvMember";
            dgvMember.RowHeadersWidth = 51;
            dgvMember.Size = new Size(637, 258);
            dgvMember.TabIndex = 4;
            // 
            // dgvTransfer
            // 
            dgvTransfer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransfer.Location = new Point(23, 392);
            dgvTransfer.Name = "dgvTransfer";
            dgvTransfer.RowHeadersWidth = 51;
            dgvTransfer.Size = new Size(1319, 303);
            dgvTransfer.TabIndex = 5;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(632, 719);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(109, 39);
            btnRefresh.TabIndex = 6;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // AccrossPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnRefresh);
            Controls.Add(dgvTransfer);
            Controls.Add(dgvMember);
            Controls.Add(dgvCoop);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AccrossPage";
            Size = new Size(1372, 781);
            ((System.ComponentModel.ISupportInitialize)dgvCoop).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMember).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTransfer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dgvCoop;
        private DataGridView dgvMember;
        private DataGridView dgvTransfer;
        private Button btnRefresh;
    }
}
