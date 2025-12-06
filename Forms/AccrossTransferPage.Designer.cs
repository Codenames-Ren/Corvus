namespace Corvus.Forms
{
    partial class AccrossTransferPage
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtBalance = new TextBox();
            txtBeneficiary = new TextBox();
            txtAmount = new TextBox();
            txtTransfer = new TextBox();
            txtRemarks = new TextBox();
            btnSubmit = new Button();
            btnClear = new Button();
            label6 = new Label();
            label7 = new Label();
            dgvIncoming = new DataGridView();
            dgvOutgoing = new DataGridView();
            timerInbox = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dgvIncoming).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOutgoing).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 51);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(96, 32);
            label1.TabIndex = 0;
            label1.Text = "Balance";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 179);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(131, 32);
            label2.TabIndex = 1;
            label2.Text = "Beneficiary";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 299);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 32);
            label3.TabIndex = 2;
            label3.Text = "Amount";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 421);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(139, 32);
            label4.TabIndex = 3;
            label4.Text = "Transfer Ref";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 547);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(103, 32);
            label5.TabIndex = 4;
            label5.Text = "Remarks";
            // 
            // txtBalance
            // 
            txtBalance.Location = new Point(44, 106);
            txtBalance.Margin = new Padding(5, 5, 5, 5);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(513, 39);
            txtBalance.TabIndex = 5;
            // 
            // txtBeneficiary
            // 
            txtBeneficiary.Location = new Point(44, 230);
            txtBeneficiary.Margin = new Padding(5, 5, 5, 5);
            txtBeneficiary.Name = "txtBeneficiary";
            txtBeneficiary.Size = new Size(513, 39);
            txtBeneficiary.TabIndex = 6;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(44, 357);
            txtAmount.Margin = new Padding(5, 5, 5, 5);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(513, 39);
            txtAmount.TabIndex = 7;
            // 
            // txtTransfer
            // 
            txtTransfer.Location = new Point(44, 474);
            txtTransfer.Margin = new Padding(5, 5, 5, 5);
            txtTransfer.Name = "txtTransfer";
            txtTransfer.Size = new Size(513, 39);
            txtTransfer.TabIndex = 8;
            // 
            // txtRemarks
            // 
            txtRemarks.Location = new Point(44, 600);
            txtRemarks.Margin = new Padding(5, 5, 5, 5);
            txtRemarks.Multiline = true;
            txtRemarks.Name = "txtRemarks";
            txtRemarks.Size = new Size(513, 198);
            txtRemarks.TabIndex = 9;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(44, 832);
            btnSubmit.Margin = new Padding(5, 5, 5, 5);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(214, 59);
            btnSubmit.TabIndex = 10;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(344, 832);
            btnClear.Margin = new Padding(5, 5, 5, 5);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(214, 59);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(783, 14);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(114, 32);
            label6.TabIndex = 12;
            label6.Text = "Incoming";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(783, 474);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(116, 32);
            label7.TabIndex = 13;
            label7.Text = "Outgoing";
            // 
            // dgvIncoming
            // 
            dgvIncoming.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIncoming.Location = new Point(783, 51);
            dgvIncoming.Margin = new Padding(5, 5, 5, 5);
            dgvIncoming.Name = "dgvIncoming";
            dgvIncoming.RowHeadersWidth = 51;
            dgvIncoming.Size = new Size(951, 402);
            dgvIncoming.TabIndex = 14;
            // 
            // dgvOutgoing
            // 
            dgvOutgoing.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOutgoing.Location = new Point(783, 510);
            dgvOutgoing.Margin = new Padding(5, 5, 5, 5);
            dgvOutgoing.Name = "dgvOutgoing";
            dgvOutgoing.RowHeadersWidth = 51;
            dgvOutgoing.Size = new Size(951, 402);
            dgvOutgoing.TabIndex = 15;
            // 
            // timerInbox
            // 
            timerInbox.Tick += timerInbox_Tick;
            // 
            // AccrossTransferPage
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1838, 970);
            Controls.Add(dgvOutgoing);
            Controls.Add(dgvIncoming);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(btnClear);
            Controls.Add(btnSubmit);
            Controls.Add(txtRemarks);
            Controls.Add(txtTransfer);
            Controls.Add(txtAmount);
            Controls.Add(txtBeneficiary);
            Controls.Add(txtBalance);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(5, 5, 5, 5);
            Name = "AccrossTransferPage";
            Text = "AccrossTransferPage";
            Load += AccrossTransferPage_Load;
            ((System.ComponentModel.ISupportInitialize)dgvIncoming).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOutgoing).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtBalance;
        private TextBox txtBeneficiary;
        private TextBox txtAmount;
        private TextBox txtTransfer;
        private TextBox txtRemarks;
        private Button btnSubmit;
        private Button btnClear;
        private Label label6;
        private Label label7;
        private DataGridView dgvIncoming;
        private DataGridView dgvOutgoing;
        private System.Windows.Forms.Timer timerInbox;
    }
}