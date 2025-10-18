namespace Corvus.Forms
{
    partial class AccessPage
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
            cmbMember = new ComboBox();
            btnSubmit = new Button();
            checkedListBoxAccess = new CheckedListBox();
            label2 = new Label();
            dataGridViewAccess = new DataGridView();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            labelAddress = new Label();
            labelPhone = new Label();
            labelEmail = new Label();
            labelJoinDate = new Label();
            labelFullName = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAccess).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 22);
            label1.Name = "label1";
            label1.Size = new Size(69, 21);
            label1.TabIndex = 0;
            label1.Text = "Member";
            // 
            // cmbMember
            // 
            cmbMember.FormattingEnabled = true;
            cmbMember.Location = new Point(14, 46);
            cmbMember.Name = "cmbMember";
            cmbMember.Size = new Size(259, 23);
            cmbMember.TabIndex = 1;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(294, 46);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(60, 23);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxAccess
            // 
            checkedListBoxAccess.FormattingEnabled = true;
            checkedListBoxAccess.Items.AddRange(new object[] { "Grant All", "Loan", "Saving", "Transfer - Inhouse", "Transfer - Accross", "Exchange" });
            checkedListBoxAccess.Location = new Point(14, 75);
            checkedListBoxAccess.Name = "checkedListBoxAccess";
            checkedListBoxAccess.Size = new Size(340, 112);
            checkedListBoxAccess.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(385, 22);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 4;
            label2.Text = "Access";
            // 
            // dataGridViewAccess
            // 
            dataGridViewAccess.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAccess.Location = new Point(385, 46);
            dataGridViewAccess.Name = "dataGridViewAccess";
            dataGridViewAccess.Size = new Size(607, 351);
            dataGridViewAccess.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelFullName);
            groupBox1.Controls.Add(labelJoinDate);
            groupBox1.Controls.Add(labelEmail);
            groupBox1.Controls.Add(labelPhone);
            groupBox1.Controls.Add(labelAddress);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(14, 209);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(340, 188);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Details";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 32);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 7;
            label3.Text = "Full Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 56);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 8;
            label4.Text = "Join Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 81);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 9;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 105);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 10;
            label6.Text = "Phone";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 129);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 11;
            label7.Text = "Address";
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Location = new Point(132, 129);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(16, 15);
            labelAddress.TabIndex = 12;
            labelAddress.Text = "...";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(132, 105);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(16, 15);
            labelPhone.TabIndex = 13;
            labelPhone.Text = "...";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(132, 81);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(16, 15);
            labelEmail.TabIndex = 14;
            labelEmail.Text = "...";
            labelEmail.Click += label9_Click;
            // 
            // labelJoinDate
            // 
            labelJoinDate.AutoSize = true;
            labelJoinDate.Location = new Point(132, 56);
            labelJoinDate.Name = "labelJoinDate";
            labelJoinDate.Size = new Size(16, 15);
            labelJoinDate.TabIndex = 15;
            labelJoinDate.Text = "...";
            // 
            // labelFullName
            // 
            labelFullName.AutoSize = true;
            labelFullName.Location = new Point(132, 32);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new Size(16, 15);
            labelFullName.TabIndex = 16;
            labelFullName.Text = "...";
            // 
            // AccessPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Controls.Add(dataGridViewAccess);
            Controls.Add(label2);
            Controls.Add(checkedListBoxAccess);
            Controls.Add(btnSubmit);
            Controls.Add(cmbMember);
            Controls.Add(label1);
            Name = "AccessPage";
            Size = new Size(1015, 425);
            ((System.ComponentModel.ISupportInitialize)dataGridViewAccess).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbMember;
        private Button btnSubmit;
        private CheckedListBox checkedListBoxAccess;
        private Label label2;
        private DataGridView dataGridViewAccess;
        private GroupBox groupBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label labelFullName;
        private Label labelJoinDate;
        private Label labelEmail;
        private Label labelPhone;
        private Label labelAddress;
    }
}
