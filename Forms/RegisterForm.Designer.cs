
namespace Corvus.Forms
{
    partial class RegisterForm
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            btnSubmit = new Button();
            lblRegValidate = new Label();
            txtFullName = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtCardID = new TextBox();
            txtPhone = new TextBox();
            txtPhoneAlt = new TextBox();
            txtEmail = new TextBox();
            txtReferenceID = new TextBox();
            txtHint = new TextBox();
            txtHint2 = new TextBox();
            btnCancel = new Button();
            txtAdress = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(80, 51);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(123, 32);
            label1.TabIndex = 0;
            label1.Text = "Full Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(682, 51);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(121, 32);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(1295, 51);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(111, 32);
            label3.TabIndex = 2;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(80, 184);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(93, 32);
            label4.TabIndex = 3;
            label4.Text = "Card ID";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(682, 184);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(82, 32);
            label5.TabIndex = 4;
            label5.Text = "Phone";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(1295, 184);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(118, 32);
            label6.TabIndex = 5;
            label6.Text = "Phone Alt";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(80, 363);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(71, 32);
            label7.TabIndex = 6;
            label7.Text = "Email";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(682, 363);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(150, 32);
            label8.TabIndex = 7;
            label8.Text = "Reference ID";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(1295, 363);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(98, 32);
            label9.TabIndex = 8;
            label9.Text = "Address";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(80, 528);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new Size(272, 32);
            label10.TabIndex = 9;
            label10.Text = "What is your fav colour?";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = SystemColors.ButtonHighlight;
            label11.Location = new Point(682, 528);
            label11.Margin = new Padding(5, 0, 5, 0);
            label11.Name = "label11";
            label11.Size = new Size(314, 32);
            label11.TabIndex = 10;
            label11.Text = "Who is your fav singer/artist";
            label11.Click += label11_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.DimGray;
            btnSubmit.Location = new Point(52, 662);
            btnSubmit.Margin = new Padding(5, 5, 5, 5);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(193, 75);
            btnSubmit.TabIndex = 11;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblRegValidate
            // 
            lblRegValidate.AutoSize = true;
            lblRegValidate.Location = new Point(682, 683);
            lblRegValidate.Margin = new Padding(5, 0, 5, 0);
            lblRegValidate.Name = "lblRegValidate";
            lblRegValidate.Size = new Size(29, 32);
            lblRegValidate.TabIndex = 13;
            lblRegValidate.Text = "...";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(80, 106);
            txtFullName.Margin = new Padding(5, 5, 5, 5);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(378, 39);
            txtFullName.TabIndex = 14;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(682, 106);
            txtUsername.Margin = new Padding(5, 5, 5, 5);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(378, 39);
            txtUsername.TabIndex = 15;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(1295, 106);
            txtPassword.Margin = new Padding(5, 5, 5, 5);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(378, 39);
            txtPassword.TabIndex = 16;
            // 
            // txtCardID
            // 
            txtCardID.Location = new Point(80, 254);
            txtCardID.Margin = new Padding(5, 5, 5, 5);
            txtCardID.Name = "txtCardID";
            txtCardID.Size = new Size(378, 39);
            txtCardID.TabIndex = 17;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(682, 254);
            txtPhone.Margin = new Padding(5, 5, 5, 5);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(378, 39);
            txtPhone.TabIndex = 18;
            // 
            // txtPhoneAlt
            // 
            txtPhoneAlt.Location = new Point(1295, 254);
            txtPhoneAlt.Margin = new Padding(5, 5, 5, 5);
            txtPhoneAlt.Name = "txtPhoneAlt";
            txtPhoneAlt.Size = new Size(378, 39);
            txtPhoneAlt.TabIndex = 19;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(80, 438);
            txtEmail.Margin = new Padding(5, 5, 5, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(378, 39);
            txtEmail.TabIndex = 20;
            // 
            // txtReferenceID
            // 
            txtReferenceID.Location = new Point(682, 438);
            txtReferenceID.Margin = new Padding(5, 5, 5, 5);
            txtReferenceID.Name = "txtReferenceID";
            txtReferenceID.ReadOnly = true;
            txtReferenceID.Size = new Size(378, 39);
            txtReferenceID.TabIndex = 21;
            // 
            // txtHint
            // 
            txtHint.Location = new Point(80, 590);
            txtHint.Margin = new Padding(5, 5, 5, 5);
            txtHint.Name = "txtHint";
            txtHint.Size = new Size(378, 39);
            txtHint.TabIndex = 22;
            // 
            // txtHint2
            // 
            txtHint2.Location = new Point(682, 590);
            txtHint2.Margin = new Padding(5, 5, 5, 5);
            txtHint2.Name = "txtHint2";
            txtHint2.Size = new Size(378, 39);
            txtHint2.TabIndex = 23;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.DimGray;
            btnCancel.Location = new Point(289, 662);
            btnCancel.Margin = new Padding(5, 5, 5, 5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(193, 75);
            btnCancel.TabIndex = 24;
            btnCancel.Text = "Back";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtAdress
            // 
            txtAdress.Location = new Point(1295, 422);
            txtAdress.Margin = new Padding(5, 5, 5, 5);
            txtAdress.Multiline = true;
            txtAdress.Name = "txtAdress";
            txtAdress.Size = new Size(378, 258);
            txtAdress.TabIndex = 25;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1867, 789);
            Controls.Add(txtAdress);
            Controls.Add(btnCancel);
            Controls.Add(txtHint2);
            Controls.Add(txtHint);
            Controls.Add(txtReferenceID);
            Controls.Add(txtEmail);
            Controls.Add(txtPhoneAlt);
            Controls.Add(txtPhone);
            Controls.Add(txtCardID);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtFullName);
            Controls.Add(lblRegValidate);
            Controls.Add(btnSubmit);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ButtonHighlight;
            Margin = new Padding(5, 5, 5, 5);
            Name = "RegisterForm";
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button btnSubmit;
        private Label lblRegValidate;
        private TextBox txtFullName;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtCardID;
        private TextBox txtPhone;
        private TextBox txtPhoneAlt;
        private TextBox txtEmail;
        private TextBox txtReferenceID;
        private TextBox txtHint;
        private TextBox txtHint2;
        private Button btnCancel;
        private TextBox txtAdress;
    }
}