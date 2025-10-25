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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            cmbMember = new ComboBox();
            btnSubmit = new Button();
            listBoxAccess = new CheckedListBox();
            label2 = new Label();
            dataGridViewAccess = new DataGridView();
            groupBox1 = new GroupBox();
            labePhoneAlt = new Label();
            label8 = new Label();
            labelFullName = new Label();
            labelJoinDate = new Label();
            labelEmail = new Label();
            labelPhone = new Label();
            labelAddress = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            memberBindingSource = new BindingSource(components);
            accessBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridViewAccess).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)memberBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accessBindingSource).BeginInit();
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
            // listBoxAccess
            // 
            listBoxAccess.FormattingEnabled = true;
            listBoxAccess.Items.AddRange(new object[] { "Grant All", "Loan", "Saving", "Transfer - Inhouse", "Transfer - Accross", "Exchange" });
            listBoxAccess.Location = new Point(14, 75);
            listBoxAccess.Name = "listBoxAccess";
            listBoxAccess.Size = new Size(340, 112);
            listBoxAccess.TabIndex = 3;
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
            groupBox1.Controls.Add(labePhoneAlt);
            groupBox1.Controls.Add(label8);
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
            // labePhoneAlt
            // 
            labePhoneAlt.AutoSize = true;
            labePhoneAlt.Location = new Point(132, 129);
            labePhoneAlt.Name = "labePhoneAlt";
            labePhoneAlt.Size = new Size(16, 15);
            labePhoneAlt.TabIndex = 18;
            labePhoneAlt.Text = "...";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 129);
            label8.Name = "label8";
            label8.Size = new Size(59, 15);
            label8.TabIndex = 17;
            label8.Text = "Phone Alt";
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
            // labelJoinDate
            // 
            labelJoinDate.AutoSize = true;
            labelJoinDate.Location = new Point(132, 56);
            labelJoinDate.Name = "labelJoinDate";
            labelJoinDate.Size = new Size(16, 15);
            labelJoinDate.TabIndex = 15;
            labelJoinDate.Text = "...";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(132, 81);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(16, 15);
            labelEmail.TabIndex = 14;
            labelEmail.Text = "...";
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
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Location = new Point(132, 157);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(16, 15);
            labelAddress.TabIndex = 12;
            labelAddress.Text = "...";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 157);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 11;
            label7.Text = "Address";
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 81);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 9;
            label5.Text = "Email";
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 32);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 7;
            label3.Text = "Full Name";
            // 
            // AccessPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Controls.Add(dataGridViewAccess);
            Controls.Add(label2);
            Controls.Add(listBoxAccess);
            Controls.Add(btnSubmit);
            Controls.Add(cmbMember);
            Controls.Add(label1);
            Name = "AccessPage";
            Size = new Size(1015, 425);
            ((System.ComponentModel.ISupportInitialize)dataGridViewAccess).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)memberBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)accessBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbMember;
        private Button btnSubmit;
        private CheckedListBox listBoxAccess;
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
        private Label labePhoneAlt;
        private Label label8;
        private BindingSource memberBindingSource;
        private BindingSource accessBindingSource;
    }
}
