using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corvus.Forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            using var db = new AppDbContext();
            var auth = new AuthService(db);
            var member = auth.RegisterAsync(txtAdress.Text, txtCardID.Text, txtEmail.Text, txtFullName.Text, txtPassword.Text, txtPhone.Text, txtPhoneAlt.Text, txtReferenceID.Text, txtUsername.Text, txtHint.Text, txtHint2.Text);
            if (member != null)
            {
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.setSuccessAlert("Registration Success! Please Login....");
                loginForm.ShowDialog();
            }
            else
            {
                lblRegValidate.Text = "Registration Failed!";
                lblRegValidate.Visible = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }

}