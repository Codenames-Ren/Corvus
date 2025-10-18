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
using Corvus.Models;

namespace Corvus.Forms
{
    public partial class TerminologiPage : UserControl
    {
        private Member? loggedMember;
        public TerminologiPage(Member? member)
        {
            loggedMember = member;
            InitializeComponent();
        }

        private async void TerminologiPage_Load(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();
            ConfigurationService service = new ConfigurationService(db);
            Configuration? configuration = await service.GetConfiguration();
            if (configuration != null) {
                lblAcross.Text = configuration.terminologi1;
                lblExchange.Text = configuration.terminologi2;
                lblInhouse.Text = configuration.terminolog3;
                labelExchange.Text += " " + configuration.exchangeRate.ToString();
                labelInhouse.Text += " " + configuration.transferInhouseFee.ToString();
                labelAcross.Text += " " + configuration.transferAcrossFee.ToString();
           }
        }
    }
}
