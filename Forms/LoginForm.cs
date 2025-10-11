using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Corvus.Models;

namespace Corvus.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public void setSuccessAlert(String message)
        {
            lblValidate.Text = message;
            lblValidate.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            lblValidate.Visible = false;
            using var db = new AppDbContext();
            var auth = new AuthService(db);
            var user = await auth.LoginAsync(txtUsername.Text, txtPassword.Text);
            if (user != null)
            {
                LoggedInUser = user;
                if (LoggedInUser.level == "admin")
                {
                    this.Hide();
                    AdminForm form = new AdminForm(LoggedInUser);
                    form.ShowDialog();
                }
                else
                {
                    AccessService accessService = new AccessService(db);
                    Access access = await accessService.GetAccess(user.id);
                    if (access == null)
                    {
                        lblValidate.Text = "Access Is Not Granted By Admin!";
                        lblValidate.ForeColor = Color.Red;
                        lblValidate.Visible = true;
                    }
                    else
                    {
                        this.Hide();
                        HomeForm form = new HomeForm(LoggedInUser);
                        form.ShowDialog();
                    }
                }
            }
            else
            {
                lblValidate.Text = "Invalid Credentials";
                lblValidate.ForeColor = Color.Red;
                lblValidate.Visible = true;
            }

        }

        private void linkLblForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ForgotPassword form = new ForgotPassword();
            form.ShowDialog();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm form = new RegisterForm();
            form.ShowDialog();
        }
    }
}