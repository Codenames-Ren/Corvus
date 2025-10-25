using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using BraveHeroCooperation.Utils;
using Corvus.Data;
using Corvus.Models;
using Corvus.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Corvus.Forms
{
    public partial class LoanPage : UserControl
    {
        Member loggedMember;
        Installment installmentForm;

        public LoanPage(Member member)
        {
            loggedMember = member;
            InitializeComponent();
        }

        private void buttonFileKTP_Click(object sender, EventArgs e)
        {
            textBoxKtp.Text = FileHelper.UploadDocument("KTP");
        }

        private void buttonFileKK_Click(object sender, EventArgs e)
        {
            textBoxKk.Text = FileHelper.UploadDocument("KK");
        }

        private void buttonFileSlip_Click(object sender, EventArgs e)
        {
            textBoxSlip.Text = FileHelper.UploadDocument("Slip Gaji");
        }

        private void LoanPage_Load(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();
            SetLoanDropdown(db);
            SetDefaultField();
            ResetField();
            LoadLoanGrid(db);
            HideInstallment();
        }

        private void SetLoanDropdown(AppDbContext db)
        {
            ProductService productService = new ProductService(db);
            comboLoanMaster.DataSource = productService.SetDropDownLoan();
            comboLoanMaster.DisplayMember = "DisplayName";
            comboLoanMaster.ValueMember = "Id";
        }

        private void buttonNewLoan_Click(object sender, EventArgs e)
        {
            SetDefaultField();
            ResetField();
            comboLoanMaster.Enabled = true;
            HideInstallment();
        }

        private void SetDefaultField()
        {
            comboLoanMaster.SelectedIndex = 0;
            buttonShowKtp.Visible = false;
            buttonShowKk.Visible = false;
            buttonShowSlip.Visible = false;
            buttonFileKtp.Visible = true;
            buttonFileKk.Visible = true;
            buttonFileSlip.Visible = true;
        }

        private void SetChosenField()
        {
            buttonShowKtp.Visible = true;
            buttonShowKk.Visible = true;
            buttonShowSlip.Visible = true;
            buttonFileKtp.Visible = false;
            buttonFileKk.Visible = false;
            buttonFileSlip.Visible = false;
        }

        private void ResetField()
        {
            textBoxKtp.Text = "";
            textBoxKk.Text = "";
            textBoxSlip.Text = "";
            textBoxDate.Text = "";
            textBoxTenor.Text = "";
            textBoxInterest.Text = "";
            textBoxAmount.Text = "";
            textBoxMinAmount.Text = "";
            textBoxMaxAmount.Text = "";
            textBoxLoanId.Text = RandomNumberGenerator.GetString("1234567890", 6);
            LabelId.Text = "";
        }

        private async void LoadLoanGrid(AppDbContext db)
        {
            LoanServices loanService = new LoanServices(db);
            dataGridViewLoan.DataSource = await loanService.LoadLoanGrid(loggedMember.Id);

            dataGridViewLoan.Columns[0].DataPropertyName = "Id";
            dataGridViewLoan.Columns[1].DataPropertyName = "LoanId";
            dataGridViewLoan.Columns[2].DataPropertyName = "Amount";
            dataGridViewLoan.Columns[3].DataPropertyName = "Outstanding";
            dataGridViewLoan.Columns[4].DataPropertyName = "TenorLeft";

            dataGridViewLoan.Columns[0].Visible = false;
            dataGridViewLoan.Columns[1].HeaderText = "Loan ID";
            dataGridViewLoan.Columns[2].HeaderText = "Amount";
            dataGridViewLoan.Columns[3].HeaderText = "Outstanding";
            dataGridViewLoan.Columns[4].HeaderText = "Tenor Left";
        }

        private async void dataGridViewLoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int idLoan = int.Parse(dataGridViewLoan.Rows[e.RowIndex].Cells[0].Value.ToString());
                AppDbContext db = new AppDbContext();
                LoanServices loanService = new LoanServices(db);
                var loan = await loanService.findById(idLoan);

                if (loan != null)
                {
                    if (loan.IsApproved)
                    {
                        SetChosenField();
                        textBoxKtp.Text = loan.KtpPath;
                        textBoxKk.Text = loan.KkPath;
                        textBoxSlip.Text = loan.SlipGajiPath;
                        textBoxDate.Text = loan.DueDate.ToString();
                        textBoxInterest.Text = loan.Interest.ToString();
                        textBoxTenor.Text = loan.Tenor.ToString();
                        textBoxAmount.Text = loan.Amount.ToString();
                        textBoxMinAmount.Text = loan.Amount.ToString();
                        textBoxMaxAmount.Text = loan.TotalAmount.ToString();
                        LabelId.Text = loan.Id.ToString();
                        comboLoanMaster.SelectedIndex = 0;
                        comboLoanMaster.Enabled = false;

                        //if (installmentForm == null)
                            //installmentForm = new Installment(loggedMember, 0);

                        //installmentForm.SetLoan(loan.Id);
                        //installmentForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Your loan is not approved yet.", "Approval", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        HideInstallment();
                    }
                }
                else
                {
                    HideInstallment();
                }
            }
        }

        private async void buttonApply_Click(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();
            LoanServices loanService = new LoanServices(db);

            // Validation
            if (string.IsNullOrEmpty(textBoxAmount.Text) ||
                string.IsNullOrEmpty(textBoxMinAmount.Text) ||
                string.IsNullOrEmpty(textBoxMaxAmount.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal amount = decimal.Parse(textBoxAmount.Text);
            decimal minAmount = decimal.Parse(textBoxMinAmount.Text);
            decimal maxAmount = decimal.Parse(textBoxMaxAmount.Text);

            if (amount < minAmount || amount > maxAmount)
            {
                MessageBox.Show($"Amount must be between {minAmount} and {maxAmount}.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Match parameter dengan service: saveOrUpdate(Member member, string amount, string ktp,
            //                                              string kk, string slip, string dueDate, string interest,
            //                                              string interestFine, string loanId, string tenor, string adminFee)
            await loanService.saveOrUpdate(
                loggedMember,
                textBoxAmount.Text,           // amount
                textBoxKtp.Text,              // ktp
                textBoxKk.Text,               // kk
                textBoxSlip.Text,             // slip
                textBoxDate.Text,             // dueDate
                textBoxInterest.Text,         // interest
                "0",                          // interestFine (default 0, bisa diganti sesuai kebutuhan)
                textBoxLoanId.Text,           // loanId
                textBoxTenor.Text,            // tenor
                "0"                           // adminFee (default 0, bisa diganti sesuai kebutuhan)
            );

            MessageBox.Show("Loan application submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Reload grid dan reset form
            LoadLoanGrid(db);
            ResetField();
        }

        private void HideInstallment()
        {
            //if (installmentForm == null)
                //installmentForm = new Installment(loggedMember, 0);

            //installmentForm.SetLoan(0);
            //installmentForm.Hide();
        }

        private void ResetDropdown()
        {
            textBoxInterest.Text = "";
            textBoxTenor.Text = "";
            textBoxMinAmount.Text = "";
            textBoxMaxAmount.Text = "";
            textBoxAmount.Text = "";
        }

        private async void comboLoanMaster_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetDropdown();

            if (comboLoanMaster.SelectedIndex > 0)
            {
                int idLoanMaster = int.Parse(comboLoanMaster.SelectedValue.ToString());
                AppDbContext db = new AppDbContext();
                ProductService productService = new ProductService(db);
                LoanMaster? loanMaster = await productService.findLoanById(idLoanMaster);

                if (loanMaster != null)
                {
                    textBoxInterest.Text = loanMaster.Interest.ToString();
                    textBoxTenor.Text = loanMaster.Tenor.ToString();
                    textBoxMinAmount.Text = loanMaster.MinAmount.ToString();
                    textBoxMaxAmount.Text = loanMaster.MaxAmount.ToString();
                }
                else
                {
                    ResetDropdown();
                }
            }
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();
            SetLoanDropdown(db);
            SetDefaultField();
            ResetField();
            LoadLoanGrid(db);
            HideInstallment();
        }
    }
}