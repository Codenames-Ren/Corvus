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
            memberCode = new DataGridViewTextBoxColumn();
            memberName = new DataGridViewTextBoxColumn();
            belanceAmount = new DataGridViewTextBoxColumn();
            dgvTransfer = new DataGridView();
            transferCode = new DataGridViewTextBoxColumn();
            transferCoopCode = new DataGridViewTextBoxColumn();
            transferCodeOrigin = new DataGridViewTextBoxColumn();
            transferCodeBenef = new DataGridViewTextBoxColumn();
            btnRefresh = new Button();
            transferAmount = new DataGridViewTextBoxColumn();
            transferRemarks = new DataGridViewTextBoxColumn();
            coopCode = new DataGridViewTextBoxColumn();
            coopName = new DataGridViewTextBoxColumn();
            coopAddress = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvCoop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMember).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTransfer).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 32);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 32);
            label1.TabIndex = 0;
            label1.Text = "Coop";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1146, 32);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(105, 32);
            label2.TabIndex = 1;
            label2.Text = "Member";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 574);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(98, 32);
            label3.TabIndex = 2;
            label3.Text = "Transfer";
            // 
            // dgvCoop
            // 
            dgvCoop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCoop.Columns.AddRange(new DataGridViewColumn[] { coopCode, coopName, coopAddress });
            dgvCoop.Location = new Point(37, 91);
            dgvCoop.Margin = new Padding(5);
            dgvCoop.Name = "dgvCoop";
            dgvCoop.RowHeadersWidth = 51;
            dgvCoop.Size = new Size(1035, 413);
            dgvCoop.TabIndex = 3;
            // 
            // dgvMember
            // 
            dgvMember.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMember.Columns.AddRange(new DataGridViewColumn[] { memberCode, memberName, belanceAmount });
            dgvMember.Location = new Point(1146, 91);
            dgvMember.Margin = new Padding(5);
            dgvMember.Name = "dgvMember";
            dgvMember.RowHeadersWidth = 51;
            dgvMember.Size = new Size(1035, 413);
            dgvMember.TabIndex = 4;
            // 
            // memberCode
            // 
            memberCode.HeaderText = "MEMBER CODE";
            memberCode.MinimumWidth = 10;
            memberCode.Name = "memberCode";
            memberCode.Width = 200;
            // 
            // memberName
            // 
            memberName.HeaderText = "MEMBER NAME";
            memberName.MinimumWidth = 10;
            memberName.Name = "memberName";
            memberName.Width = 200;
            // 
            // belanceAmount
            // 
            belanceAmount.HeaderText = "BELANCE AMOUNT";
            belanceAmount.MinimumWidth = 10;
            belanceAmount.Name = "belanceAmount";
            belanceAmount.Width = 200;
            // 
            // dgvTransfer
            // 
            dgvTransfer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransfer.Columns.AddRange(new DataGridViewColumn[] { transferCode, transferCoopCode, transferCodeOrigin, transferCodeBenef, transferAmount, transferRemarks });
            dgvTransfer.Location = new Point(37, 627);
            dgvTransfer.Margin = new Padding(5);
            dgvTransfer.Name = "dgvTransfer";
            dgvTransfer.RowHeadersWidth = 51;
            dgvTransfer.Size = new Size(2143, 485);
            dgvTransfer.TabIndex = 5;
            // 
            // transferCode
            // 
            transferCode.HeaderText = "TRANSFER CODE";
            transferCode.MinimumWidth = 10;
            transferCode.Name = "transferCode";
            transferCode.Width = 200;
            // 
            // transferCoopCode
            // 
            transferCoopCode.HeaderText = "TRANSFER COOP CODE";
            transferCoopCode.MinimumWidth = 10;
            transferCoopCode.Name = "transferCoopCode";
            transferCoopCode.Width = 200;
            // 
            // transferCodeOrigin
            // 
            transferCodeOrigin.HeaderText = "TRANSFER CODE ORIGIN";
            transferCodeOrigin.MinimumWidth = 10;
            transferCodeOrigin.Name = "transferCodeOrigin";
            transferCodeOrigin.Width = 200;
            // 
            // transferCodeBenef
            // 
            transferCodeBenef.HeaderText = "TRANSFER CODE BENEF";
            transferCodeBenef.MinimumWidth = 10;
            transferCodeBenef.Name = "transferCodeBenef";
            transferCodeBenef.Width = 200;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(1027, 1150);
            btnRefresh.Margin = new Padding(5);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(177, 62);
            btnRefresh.TabIndex = 6;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // transferAmount
            // 
            transferAmount.HeaderText = "TRANSFER AMOUNT";
            transferAmount.MinimumWidth = 10;
            transferAmount.Name = "transferAmount";
            transferAmount.Width = 200;
            // 
            // transferRemarks
            // 
            transferRemarks.HeaderText = "TRANSFER REMARKS";
            transferRemarks.MinimumWidth = 10;
            transferRemarks.Name = "transferRemarks";
            transferRemarks.Width = 200;
            // 
            // coopCode
            // 
            coopCode.HeaderText = "COOP CODE";
            coopCode.MinimumWidth = 10;
            coopCode.Name = "coopCode";
            coopCode.Width = 200;
            // 
            // coopName
            // 
            coopName.HeaderText = "COOP NAME";
            coopName.MinimumWidth = 10;
            coopName.Name = "coopName";
            coopName.Width = 200;
            // 
            // coopAddress
            // 
            coopAddress.HeaderText = "COOP ADDRESS";
            coopAddress.MinimumWidth = 10;
            coopAddress.Name = "coopAddress";
            coopAddress.Width = 200;
            // 
            // AccrossPage
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnRefresh);
            Controls.Add(dgvTransfer);
            Controls.Add(dgvMember);
            Controls.Add(dgvCoop);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(5);
            Name = "AccrossPage";
            Size = new Size(2230, 1250);
            Load += AccrossPage_Load_1;
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
        private DataGridViewTextBoxColumn memberCode;
        private DataGridViewTextBoxColumn memberName;
        private DataGridViewTextBoxColumn belanceAmount;
        private DataGridViewTextBoxColumn transferCode;
        private DataGridViewTextBoxColumn transferCoopCode;
        private DataGridViewTextBoxColumn transferCodeOrigin;
        private DataGridViewTextBoxColumn transferCodeBenef;
        private DataGridViewTextBoxColumn coopCode;
        private DataGridViewTextBoxColumn coopName;
        private DataGridViewTextBoxColumn coopAddress;
        private DataGridViewTextBoxColumn transferAmount;
        private DataGridViewTextBoxColumn transferRemarks;
    }
}
