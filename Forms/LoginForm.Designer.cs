namespace Corvus.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            pictureBox1 = new PictureBox();
            LoginLabel = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnSubmit = new Button();
            linkLblForgot = new LinkLabel();
            btnRegister = new Button();
            lblValidate = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(-8, -5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(427, 477);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginLabel.ForeColor = SystemColors.ButtonHighlight;
            LoginLabel.Location = new Point(547, 62);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(188, 38);
            LoginLabel.TabIndex = 1;
            LoginLabel.Text = "Corvus Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(458, 131);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 2;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(458, 215);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 3;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(458, 168);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(344, 27);
            txtUsername.TabIndex = 4;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(458, 258);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(344, 27);
            txtPassword.TabIndex = 5;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.DimGray;
            btnSubmit.ForeColor = SystemColors.ButtonHighlight;
            btnSubmit.Location = new Point(483, 307);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(107, 43);
            btnSubmit.TabIndex = 6;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // linkLblForgot
            // 
            linkLblForgot.ActiveLinkColor = Color.WhiteSmoke;
            linkLblForgot.AutoSize = true;
            linkLblForgot.LinkColor = Color.White;
            linkLblForgot.Location = new Point(591, 381);
            linkLblForgot.Name = "linkLblForgot";
            linkLblForgot.Size = new Size(118, 20);
            linkLblForgot.TabIndex = 8;
            linkLblForgot.TabStop = true;
            linkLblForgot.Text = "Forgot Password";
            linkLblForgot.LinkClicked += linkLblForgot_LinkClicked;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.DimGray;
            btnRegister.ForeColor = SystemColors.ButtonHighlight;
            btnRegister.Location = new Point(678, 307);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(107, 43);
            btnRegister.TabIndex = 9;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // lblValidate
            // 
            lblValidate.AutoSize = true;
            lblValidate.Location = new Point(453, 27);
            lblValidate.Name = "lblValidate";
            lblValidate.Size = new Size(18, 20);
            lblValidate.TabIndex = 10;
            lblValidate.Text = "...";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(837, 474);
            Controls.Add(lblValidate);
            Controls.Add(btnRegister);
            Controls.Add(linkLblForgot);
            Controls.Add(btnSubmit);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(LoginLabel);
            Controls.Add(pictureBox1);
            Name = "LoginForm";
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label LoginLabel;
        private Label label2;
        private Label label3;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnSubmit;
        private LinkLabel linkLblForgot;
        private Button btnRegister;
        private Label lblValidate;
    }
}