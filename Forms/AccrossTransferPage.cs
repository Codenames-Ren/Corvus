using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Corvus.Api.Connectors;
using Corvus.Api.Models;
using Corvus.Data;
using Corvus.Models;
using Corvus.Services;

namespace Corvus.Forms
{
    public partial class AccrossTransferPage : Form
    {
        public AccrossTransferPage()
        {
            InitializeComponent();
        }

        private void timerInbox_Tick(object sender, EventArgs e)
        {

        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();
            ConfigurationServices configService = new ConfigurationServices(db);
            Configuration? config = await configService.GetConfig();
            ConnectorPost connectorPost = new ConnectorPost();
            Double transferAmount = Double.Parse(txtAmount.Text);

            TransferApiResponse? response = await connectorPost.TransferAsync(new TransferPayload
            {
                amount = transferAmount,
                benefCode = txtBeneficiary.Text,
                coopCode = loggedMember.Member.id,
                fee = Double.Parse(config?.transferAcrossFee.ToString()),
                remarks = txtRemarks.Text,
                transferRef = txtTransfer.Text,
            });

            if (response != null && response.ResponseCode == "00") 
            {
                BalanceService balanceService = new BalanceService(db);
                Balance? balance = await balanceService.getBalance(loggedMember.Member.id);
                if (balance != null)
                {
                    balance.amount -= Decimal.Parse(txtAmount.ToString());
                    balance.updateOn = DateTime.Now;
                    balance.transactionName = "Across Transfer";
                    balance.flow = "OUT";
                    balanceService.Update(balance);

                    BalanceApiResponse? balanceApiResponse = await connectorPost.BalanceUpdateAsync(new BalancePayload
                    {
                        amount = Double.Parse(balance.amount.ToString()),
                        memberCode = loggedMember.MemberId,
                    });

                    if (balanceApiResponse != null && balanceApiResponse.ResponseCode == "00")
                    {
                        MessageBox.Show("Transfer Successful", "Success");
                    }
                }
            }
        }
    }
}
