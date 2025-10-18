using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Corvus.Data;

namespace Corvus.Forms
{
    public partial class ConfigPage : UserControl
    {
        public ConfigPage()
        {
            InitializeComponent();
        }

        private async void ConfigPage_Load(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();
            ConfigurationService service = new ConfigurationService(db);
            Configuration config = await service.GetConfiguration();
            if (config != null)
            {
                textTerminologi1.Text = config.terminologi1;
                textTerminologi2.Text = config.terminologi2;
                textTerminologi3.Text = config.terminologi3;
                txtExchangeView.Text = config.exchangeRate.ToString();
                txtInhouseView.Text = config.transferInhouseFee.ToString();
                txtAcrossView.Text = config.transferAcrossFee.ToString();
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            decimal exchangeRate = decimal.Parse(txtExchangeView.Text);
            decimal inhouseFee = decimal.Parse(txtInhouseView.Text);
            decimal accrossFee = decimal.Parse(txtAcrossView.Text);

            AppDbContext db = new AppDbContext();
            ConfigurationService service = new ConfigurationService(db);
            await service.addOrUpdate(textTerminologi1.Text, textTerminologi2.Text, textTerminologi3.Text, exchangeRate, inhouseFee, accrossFee);
            MessageBox.Show("Configuration updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
