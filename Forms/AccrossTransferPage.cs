using Corvus.Api.Connectors;
using Corvus.Api.Models;
using Corvus.Data;
using Corvus.Models;
using Corvus.Services;
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
        Member loggedMember;
        public AccrossTransferPage(Member member)
        {
            loggedMember = member;
            InitializeComponent();
        }

        private async void AccrossTransferPage_Load(object sender, EventArgs e)
        {
            timerInbox.Enabled = true;
            if (loggedMember.ReferenceId == null || loggedMember.ReferenceId == "" || loggedMember.ReferenceId == "-")
            {
                DialogResult result = MessageBox.Show("You do not have a previlage to use Across Transfer. Registration now?",
                    "Invalid", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    String message;
                    using (var db = new AppDbContext())
                    {
                        message = await MemberRegistration(db);
                    }
                    MessageBox.Show(message, "Registration info", MessageBoxButtons.OK);
                }
            }
            else
            {
                timerInbox.Enabled = true;
            }
        }

        private async Task<string> MemberRegistration(AppDbContext db)
        {
            String message = "Succes";
            MemberService memberService = new MemberService(db);
            ConnectorPost connectorPost = new ConnectorPost();
            ConfigurationServices configurationServices = new ConfigurationServices(db);
            Configuration? configuration = await configurationServices.GetConfig();
            if (configuration == null)
                message = "Configuration not found!";
            if (configuration != null)
                if (configuration.terminologi3 == null || configuration.terminologi3 == "-")
                {
                    message = " Coop not registered to Across System. Please Contact administrator.";
                }
                try
                {
                    MemberApiResponse? memberApiResponse = await connectorPost.MemberRegistrationAsync(
                        new MemberPayload
                        {
                            name = loggedMember.Fullname,
                            address = loggedMember.Adress,
                            code = loggedMember.MemberId,
                            coopCode = configuration.terminologi3!
                        });
                    if (memberApiResponse != null && memberApiResponse.ResponseCode == "00")
                    {
                    loggedMember.ReferenceId = configuration.terminologi3!;
                    memberService.Update(loggedMember);

                    BalanceService balanceService = new BalanceService(db);
                    balanceService.setBalance(loggedMember.MemberId);

                    timerInbox.Enabled = true;
                    }
                    else
                    {
                    message = "Failed to register to across system: " + memberApiResponse?.ResponseMessage;
                    }
                }
            catch (Exception ex)
            {
                message = ex.Message;
            }
        }
        
        private void timerInbox_Tick(object sender, EventArgs e)
        {

        }

        
    }
}
