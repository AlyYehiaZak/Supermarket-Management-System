using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace SupermarketManagementSystem
{
    public partial class transactionsreportpage : Form
    {

        transactionreport trrpt;
        public transactionsreportpage()
        {
            InitializeComponent();
        }

        private void Returntotrans_Click(object sender, EventArgs e)
        {
            ManageTransactions mntr = new ManageTransactions();
            mntr.Show();
            Visible = false;
        }

        private void transactionsreportpage_Load(object sender, EventArgs e)
        {
            trrpt = new transactionreport();
            
        }

        private void gettrnsrpt_Click(object sender, EventArgs e)
        {
            trrpt.SetParameterValue(0, Convert.ToDateTime(written_date.Text));
            crystalReportViewer1.ReportSource = trrpt;
        }
    }
}
