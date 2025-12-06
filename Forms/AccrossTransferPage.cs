using Corvus.Api.Connectors;
using Corvus.Api.Models;
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
    public partial class AccrossTransferPage : Form
    {
        public AccrossTransferPage()
        {
            InitializeComponent();
        }

        private async void timerInbox_Tick(object sender, EventArgs e)
        {
            timerInbox.Stop();
            try
            {
                //TimerInbox.Start
                Console.WriteLine("Retrieving...");
                ConnectorGet connecterGet = new ConnectorGet();
                TransferApiResponse responseOutgoing = await connecterGet.GetOutgoingByMemberAsync(loggedMember.MemberId);
                if (responseOutgoing != null && responseOutgoing.ResponseCode == "00")
                {
                    dgvOutgoing.DataSource = responseOutgoing.TransferList;
                    dgvOutgoing.Columns["Id"].Visible = false;
                    dgvOutgoing.Columns["MemberCode"].Visible = false;
                    dgvOutgoing.Columns["BenefCode"].HeaderText = "Beneficiary";
                    dgvOutgoing.Columns["CoopCode"].Visible = false;
                    dgvOutgoing.Columns["UpdatedOn"].Visible = false;
                    dgvOutgoing.Columns["TransferRef"].HeaderText = "Reference";
                    dgvOutgoing.Columns["TransferDate"].HeaderText = "Date";
                    dgvOutgoing.Columns["Amount"].HeaderText = "Amount";
                    dgvOutgoing.Columns["Fee"].HeaderText = "Fee";
                    dgvOutgoing.Columns["Remarks"].HeaderText = "Remarks";
                    dgvOutgoing.Columns["TransactionCode"].HeaderText = "Transaction Code";
                }

                String benefCode = loggedMember.ReferenceId + "-" + loggedMember.MemberId;
                TransferApiResponse responseIncoming = await connecterGet.GetIncomingByMemberAsync(loggedMember.MemberId);
                if (responseIncoming != null && responseOutgoing.ResponseCode == "00")
                {
                    dgvIncoming.Columns["Id"].Visible = false;
                    dgvIncoming.Columns["MemberCode"].HeaderText = "Member Code";
                    dgvIncoming.Columns["BenefCode"].Visible = false;
                    dgvIncoming.Columns["CoopCode"].Visible = false;
                    dgvOutgoing.Columns["UpdatedOn"].Visible = false;
                    dgvIncoming.Columns["TransferRef"].HeaderText = "Reference";
                    dgvIncoming.Columns["TransferDate"].HeaderText = "Date";
                    dgvIncoming.Columns["Amount"].HeaderText = "Amount";
                    dgvIncoming.Columns["Fee"].HeaderText = "Fee";
                    dgvIncoming.Columns["Remarks"].HeaderText = "Remarks";
                    dgvIncoming.Columns["TransactionCode"].HeaderText = "Transaction Code";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                timerInbox.Start(); // restart setelah selesai
            }
        }
    }
}
