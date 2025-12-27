using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Corvus.Forms;
using Corvus.Forms.AdminMenus;
using Corvus.Models;

namespace Corvus.Forms
{
    public partial class AdminForm : Form
    {
        Member? loggedMember = null;
        public AdminForm(Member member)
        {
            loggedMember = member; // admin
            InitializeComponent();
            this.Text = "Corvus Cooperation (Administrator: " +
                loggedMember.MemberId + " - " + loggedMember.FullName + ")";
        }
        public void route(System.Windows.Forms.Control control)
        {
            this.panelDisplay.Controls.Clear();
            this.panelDisplay.Dock = DockStyle.Fill;
            this.panelDisplay.Controls.Add(control);
        }
        private void accessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            route(new AccessPage(loggedMember));
        }
        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            route(new ConfigPage());
        }
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loggedMember = null;
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void acrossToolStripMenuItem_Click(object sender, EventArgs e)
        {
            route(new AccrossPage());
        }

        private void AdminForm_Load_1(object sender, EventArgs e)
        {
            route(new DashboardAdminPage(loggedMember));
        }

        private void memberToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            route(new MemberPage());
        }

        private void accessToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            route(new AccessPage(loggedMember));
        }

        private void productToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            route(new ProductPage());
        }

        private void approvalToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            route(new ApprovalPage(loggedMember));
        }
    }
}