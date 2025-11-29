using Corvus.Data;
using Corvus.Models;
using Corvus.Services;
using Corvus.Utils;
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
    public partial class ApprovalPage : UserControl
    {
        Member loggedMember;
        public ApprovalPage(Member member)
        {
            loggedMember = member;
            InitializeComponent();
        }

        private void ApprovalPage_Load(object sender, EventArgs e)
        {
            comboProduct.SelectedIndex = 0;
        }

        private async void comboProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();
            if (comboProduct.SelectedIndex == 1)
            {
                LoanServices loanService = new LoanServices(db);
                dataGridViewApproval.AutoGenerateColumns = true;
                dataGridViewApproval.DataSource = await loanService.LoadsApproval();

                dataGridViewApproval.Columns[0].DataPropertyName = "Id";
                dataGridViewApproval.Columns[1].DataPropertyName = "LoanId";
                dataGridViewApproval.Columns[2].DataPropertyName = "CreatedOn";
                dataGridViewApproval.Columns[3].DataPropertyName = "Amount";
                dataGridViewApproval.Columns[4].DataPropertyName = "Outstanding";
                dataGridViewApproval.Columns[5].DataPropertyName = "Interest";
                dataGridViewApproval.Columns[6].DataPropertyName = "Tenor";
                dataGridViewApproval.Columns[7].DataPropertyName = "Member";
                dataGridViewApproval.Columns[8].DataPropertyName = "KtpPath";
                dataGridViewApproval.Columns[9].DataPropertyName = "KkPath";
                dataGridViewApproval.Columns[10].DataPropertyName = "SlipGajiPath";
                dataGridViewApproval.Columns[11].DataPropertyName = "Amount";

                dataGridViewApproval.Columns[0].Visible = false;
                dataGridViewApproval.Columns[1].HeaderText = "Loan Id";
                dataGridViewApproval.Columns[2].HeaderText = "Created On";
                dataGridViewApproval.Columns[3].HeaderText = "Amount";
                dataGridViewApproval.Columns[4].HeaderText = "Outstanding";
                dataGridViewApproval.Columns[5].HeaderText = "Interest";
                dataGridViewApproval.Columns[6].HeaderText = "Tenor";
                dataGridViewApproval.Columns[7].HeaderText = "Member";
                dataGridViewApproval.Columns[8].HeaderText = "KTP";
                dataGridViewApproval.Columns[9].HeaderText = "KK";
                dataGridViewApproval.Columns[10].HeaderText = "Slip Gaji";
                dataGridViewApproval.Columns[11].HeaderText = "Join Date";

                for (int i = 11; i < dataGridViewApproval.Columns.Count; i++)
                {
                    dataGridViewApproval.Columns[i].Visible = false;
                }
            }
        }

        private void dataGridViewApproval_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AppDbContext db = new AppDbContext();
            if (comboProduct.SelectedIndex == 1)
            {
                if (e.RowIndex >= 0)
                {
                    string path;
                    if (e.ColumnIndex == 8)
                    {
                        path = dataGridViewApproval.Rows[e.RowIndex].Cells[8].Value.ToString();
                        FileHelper.ShowFile(path);
                    }
                    else if (e.ColumnIndex == 9)
                    {
                        path = dataGridViewApproval.Rows[e.RowIndex].Cells[9].Value.ToString();
                        FileHelper.ShowFile(path);
                    }
                    else if (e.ColumnIndex == 10)
                    {
                        path = dataGridViewApproval.Rows[e.RowIndex].Cells[10].Value.ToString();
                        FileHelper.ShowFile(path);
                    }
                    else
                    {
                        LoanServices loanService = new LoanServices(db);
                        DialogResult result = MessageBox.Show("Approve?", "Decision", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                        int idLoan = int.Parse(dataGridViewApproval.Rows[e.RowIndex].Cells[0].Value.ToString());
                        if (result == DialogResult.Yes)
                            loanService.SetApproval(idLoan, true);
                        else if (result == DialogResult.No)
                            loanService.SetApproval(idLoan, false);

                        comboProduct.SelectedIndex = 0;
                        comboProduct.SelectedIndex = 1;
                    }
                }
            }
        }
    }
}