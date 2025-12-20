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
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corvus.Forms
{
    public partial class SavingPage : UserControl
    {

        Member loggedMember;

        public SavingPage(Member member)
        {
            loggedMember = member;
            InitializeComponent();
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {

        }

        private void buttonFileKK_Click(object sender, EventArgs e)
        {
            txtDocumentKK.Text = FileHelper.UploadDocument("KK");
        }

        private void SavingPage_Load(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();

            SetSavingDropDown(db);
            SetDefaultField();
            ResetField();

            LoadSavingGrid(db);
        }

        private void SetSavingDropDown(AppDbContext db)
        {
            ProductService productService = new ProductService(db);
            //loanMasterBindingSource.DataSource = productService.SetDropDownSaving();
            Object obj = productService.SetDropDownSaving();
            cmbSavingMaster.Items.Add(obj);
            cmbSavingMaster.DisplayMember = "DisplayName";
            cmbSavingMaster.ValueMember = "Id";
        }

        private void SetDefaultField()
        {
            cmbSavingMaster.SelectedIndex = 0;
            btnShowKTP.Visible = false;
            btnShowKK.Visible = false;
            btnShowSlip.Visible = false;
            btnBrowseKTP.Visible = true;
            btnBrowseKK.Visible = true;
            btnBrowseSlip.Visible = true;

        }

        private void SetChosenField()
        {
            btnShowKTP.Visible = true;
            btnShowKK.Visible = true;
            btnShowSlip.Visible = true;
            btnBrowseKTP.Visible = false;
            btnBrowseKK.Visible = false;
            btnBrowseSlip.Visible = false;
        }

        private void ResetField()
        {
            txtDocumentKK.Text = "";
            txtDocumentKTP.Text = "";
            txtDocumentSlipGaji.Text = "";
            txtDueDate.Text = "";
            txtAmount.Text = "";
            ResetDropDown();
            txtSavingID.Text = RandomNumberGenerator.GetString("1234567890", 6);
            lblSavingID.Text = "";
        }

        private void ResetDropDown()
        {
            txtInterest.Text = "";
            txtInterestFine.Text = "";
            txtTenor.Text = "";
            txtAdminFee.Text = "";
            txtMinAmount.Text = "";
            txtMaxAmount.Text = "";
        }

        private async void LoadSavingGrid(AppDbContext db)
        {
            SavingService savingService = new SavingService(db);
            //loanBindingSource.DataSource = await savingService.LoadSavingGrid(loggedMember);

            //dgvSaving.Columns[0].DataPropertyName = "Id";
            //dgvSaving.Columns[1].DataPropertyName = "SavingId";
            //dgvSaving.Columns[2].DataPropertyName = "Amount";
            //dgvSaving.Columns[3].DataPropertyName = "Tenor";

            List<Saving> listSaving = await savingService.LoadSavingGrid(loggedMember.Id);
            foreach (Saving s in listSaving)
            {
                dgvSaving.Rows.Add(s.Id, s.SavingId, s.Amount, s.Tenor);
            }


            dgvSaving.Columns[0].Visible = false;
            dgvSaving.Columns[1].HeaderText = "Saving ID";
            dgvSaving.Columns[2].HeaderText = "Amount";
            dgvSaving.Columns[3].HeaderText = "Tenor";

        }

        private async void comboLoanMaster_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSavingMaster.SelectedIndex == 0)
                ResetDropDown();

            if (cmbSavingMaster.SelectedIndex > 0)
            {
                int idLoanMaster = int.Parse(cmbSavingMaster.SelectedValue.ToString());
                AppDbContext db = new AppDbContext();
                ProductService productService = new ProductService(db);
                LoanMaster? loanMaster = await productService.findLoanById(idLoanMaster);

                if (loanMaster != null)
                {
                    txtInterest.Text = loanMaster.Interest.ToString();
                    txtInterestFine.Text = loanMaster.Fine.ToString();
                    txtTenor.Text = loanMaster.Tenor.ToString();
                    txtAdminFee.Text = loanMaster.AdminFee.ToString();
                    txtMinAmount.Text = loanMaster.MinAmount.ToString();
                    txtMaxAmount.Text = loanMaster.MaxAmount.ToString();
                }
                else
                {
                    ResetDropDown();
                }
            }
        }

        private void buttonNewSaving_Click(object sender, EventArgs e)
        {
            SetDefaultField();
            ResetField();
            btnApplySaving.Enabled = true;
            cmbSavingMaster.SelectedIndex = 0;
            cmbSavingMaster.Enabled = true;
        }

        private void buttonReload_Click_1(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();

            SetSavingDropDown(db);
            SetDefaultField();
            ResetField();

            LoadSavingGrid(db);
        }
    }

}
