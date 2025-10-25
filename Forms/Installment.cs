using Corvus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corvus.Forms
{
    public class Installment : UserControl
    {
        // --- variabel internal
        private Member member;
        private int loanId;

        // --- constructor
        public Installment(Member member, int loanId)
        {
            this.member = member;
            this.loanId = loanId;

            // inisialisasi tampilan manual
            InitializeManualUI();
        }

        // --- bikin tampilan UI manual
        private void InitializeManualUI()
        {
            Label labelInfo = new Label();
            labelInfo.Text = "Installment View Loaded";
            labelInfo.AutoSize = true;
            labelInfo.Location = new System.Drawing.Point(20, 20);
            this.Controls.Add(labelInfo);
        }

        // --- method untuk set ID pinjaman
        public void SetLoan(int id)
        {
            this.loanId = id;
        }
    }
}