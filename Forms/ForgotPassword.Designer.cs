namespace Corvus.Forms
{
    partial class ForgotPassword
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
            btnSubmit = new Button();
            btnBack = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtUsername = new TextBox();
            txtColor = new TextBox();
            txtSinger = new TextBox();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(36, 149);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(76, 23);
            btnSubmit.TabIndex = 9;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(138, 149);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(76, 23);
            btnBack.TabIndex = 10;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 78);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 11;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(338, 198);
            label2.Name = "label2";
            label2.Size = new Size(202, 15);
            label2.TabIndex = 12;
            label2.Text = "What is Your Favourite Artist/Singer ?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 198);
            label3.Name = "label3";
            label3.Size = new Size(165, 15);
            label3.TabIndex = 13;
            label3.Text = "What is Your Favourite Color ?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 277);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 14;
            label4.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(36, 106);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(263, 23);
            txtUsername.TabIndex = 15;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(36, 230);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(263, 23);
            txtColor.TabIndex = 16;
            // 
            // txtSinger
            // 
            txtSinger.Location = new Point(338, 230);
            txtSinger.Name = "txtSinger";
            txtSinger.Size = new Size(263, 23);
            txtSinger.TabIndex = 17;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(36, 306);
            txtPassword.Name = "txtPassword";
            txtPassword.ReadOnly = true;
            txtPassword.Size = new Size(434, 23);
            txtPassword.TabIndex = 18;
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 397);
            Controls.Add(txtPassword);
            Controls.Add(txtSinger);
            Controls.Add(txtColor);
            Controls.Add(txtUsername);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(btnSubmit);
            Name = "ForgotPassword";
            Text = "Forgot Password";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSubmit;
        private Button btnBack;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtUsername;
        private TextBox txtColor;
        private TextBox txtSinger;
        private TextBox txtPassword;
    }
}