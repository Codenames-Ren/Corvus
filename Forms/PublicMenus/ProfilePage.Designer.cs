namespace Corvus.Forms.PublicMenus
{
    partial class ProfilePage
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
            labelMemberId = new Label();
            label11 = new Label();
            label9 = new Label();
            labelJoinDate = new Label();
            label7 = new Label();
            label8 = new Label();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            listBoxAccess = new CheckedListBox();
            label10 = new Label();
            textCardId = new TextBox();
            textFullname = new TextBox();
            textEmail = new TextBox();
            textPhone = new TextBox();
            textPhoneAlt = new TextBox();
            textAddress = new TextBox();
            buttonSubmit = new Button();
            SuspendLayout();
            // 
            // labelMemberId
            // 
            labelMemberId.AutoSize = true;
            labelMemberId.Location = new Point(228, 51);
            labelMemberId.Margin = new Padding(6, 0, 6, 0);
            labelMemberId.Name = "labelMemberId";
            labelMemberId.Size = new Size(29, 32);
            labelMemberId.TabIndex = 43;
            labelMemberId.Text = "...";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.White;
            label11.Location = new Point(45, 51);
            label11.Margin = new Padding(6, 0, 6, 0);
            label11.Name = "label11";
            label11.Size = new Size(132, 32);
            label11.TabIndex = 42;
            label11.Text = "Member Id";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.White;
            label9.Location = new Point(45, 107);
            label9.Margin = new Padding(6, 0, 6, 0);
            label9.Name = "label9";
            label9.Size = new Size(151, 32);
            label9.TabIndex = 40;
            label9.Text = "Card Id (KTP)";
            label9.Click += label9_Click;
            // 
            // labelJoinDate
            // 
            labelJoinDate.AutoSize = true;
            labelJoinDate.Location = new Point(228, 230);
            labelJoinDate.Margin = new Padding(6, 0, 6, 0);
            labelJoinDate.Name = "labelJoinDate";
            labelJoinDate.Size = new Size(29, 32);
            labelJoinDate.TabIndex = 35;
            labelJoinDate.Text = "...";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(45, 476);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(98, 32);
            label7.TabIndex = 33;
            label7.Text = "Address";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(45, 414);
            label8.Margin = new Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new Size(118, 32);
            label8.TabIndex = 32;
            label8.Text = "Phone Alt";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(45, 352);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(82, 32);
            label5.TabIndex = 31;
            label5.Text = "Phone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(45, 290);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(71, 32);
            label6.TabIndex = 30;
            label6.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(45, 235);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(114, 32);
            label4.TabIndex = 29;
            label4.Text = "Join Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(45, 169);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(123, 32);
            label3.TabIndex = 28;
            label3.Text = "Full Name";
            // 
            // listBoxAccess
            // 
            listBoxAccess.BackColor = Color.FromArgb(64, 0, 64);
            listBoxAccess.Enabled = false;
            listBoxAccess.ForeColor = Color.White;
            listBoxAccess.FormattingEnabled = true;
            listBoxAccess.Items.AddRange(new object[] { "Grant All", "Loan", "Saving", "Transfer - Inhouse", "Transfer - Accross", "Exchange" });
            listBoxAccess.Location = new Point(576, 85);
            listBoxAccess.Margin = new Padding(6, 6, 6, 6);
            listBoxAccess.Name = "listBoxAccess";
            listBoxAccess.Size = new Size(281, 256);
            listBoxAccess.TabIndex = 46;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(581, 47);
            label10.Margin = new Padding(6, 0, 6, 0);
            label10.Name = "label10";
            label10.Size = new Size(125, 32);
            label10.TabIndex = 47;
            label10.Text = "My Access";
            // 
            // textCardId
            // 
            textCardId.Location = new Point(228, 100);
            textCardId.Margin = new Padding(6, 6, 6, 6);
            textCardId.Name = "textCardId";
            textCardId.Size = new Size(312, 39);
            textCardId.TabIndex = 48;
            // 
            // textFullname
            // 
            textFullname.Location = new Point(228, 162);
            textFullname.Margin = new Padding(6, 6, 6, 6);
            textFullname.Name = "textFullname";
            textFullname.Size = new Size(312, 39);
            textFullname.TabIndex = 49;
            // 
            // textEmail
            // 
            textEmail.Location = new Point(228, 284);
            textEmail.Margin = new Padding(6, 6, 6, 6);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(312, 39);
            textEmail.TabIndex = 50;
            // 
            // textPhone
            // 
            textPhone.Location = new Point(228, 346);
            textPhone.Margin = new Padding(6, 6, 6, 6);
            textPhone.Name = "textPhone";
            textPhone.Size = new Size(312, 39);
            textPhone.TabIndex = 51;
            // 
            // textPhoneAlt
            // 
            textPhoneAlt.Location = new Point(228, 407);
            textPhoneAlt.Margin = new Padding(6, 6, 6, 6);
            textPhoneAlt.Name = "textPhoneAlt";
            textPhoneAlt.Size = new Size(312, 39);
            textPhoneAlt.TabIndex = 52;
            // 
            // textAddress
            // 
            textAddress.Location = new Point(228, 469);
            textAddress.Margin = new Padding(6, 6, 6, 6);
            textAddress.Multiline = true;
            textAddress.Name = "textAddress";
            textAddress.Size = new Size(312, 155);
            textAddress.TabIndex = 53;
            // 
            // buttonSubmit
            // 
            buttonSubmit.BackColor = Color.Purple;
            buttonSubmit.Location = new Point(576, 397);
            buttonSubmit.Margin = new Padding(6, 6, 6, 6);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(284, 49);
            buttonSubmit.TabIndex = 54;
            buttonSubmit.Text = "Update";
            buttonSubmit.UseVisualStyleBackColor = false;
            // 
            // ProfilePage
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 64);
            Controls.Add(buttonSubmit);
            Controls.Add(textAddress);
            Controls.Add(textPhoneAlt);
            Controls.Add(textPhone);
            Controls.Add(textEmail);
            Controls.Add(textFullname);
            Controls.Add(textCardId);
            Controls.Add(label10);
            Controls.Add(listBoxAccess);
            Controls.Add(labelMemberId);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(labelJoinDate);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            ForeColor = Color.White;
            Margin = new Padding(6, 6, 6, 6);
            Name = "ProfilePage";
            Size = new Size(882, 670);
            Load += ProfilePage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMemberId;
        private Label label11;
        private Label label9;
        private Label labelJoinDate;
        private Label label7;
        private Label label8;
        private Label label5;
        private Label label6;
        private Label label4;
        private Label label3;
        private CheckedListBox listBoxAccess;
        private Label label10;
        private TextBox textCardId;
        private TextBox textFullname;
        private TextBox textEmail;
        private TextBox textPhone;
        private TextBox textPhoneAlt;
        private TextBox textAddress;
        private Button buttonSubmit;
    }
}
