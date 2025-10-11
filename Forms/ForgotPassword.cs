using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Corvus.Data;
using Corvus.Services;

namespace Corvus.Forms
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void ForgotPasswordForm_Load(object sender, EventArgs e)
        {
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            using var db = new AppDbContext();
            var auth = new AuthService(db); //EAC1B
            var password = await auth.ResetPasswordAsync(txtUsername.Text, txtColor.Text, txtSinger.Text);
            if (password == "")
            {
                MessageBox.Show("Invalid username or the answer", "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                txtPassword.Text = password;
            }
        }
    }
}
