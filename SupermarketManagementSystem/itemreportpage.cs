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
    public partial class itemreportpage : Form
    {
        itemsreport itrpt ;
        public itemreportpage()
        {
            InitializeComponent();
        }

        private void returntosales_Click(object sender, EventArgs e)
        {
            SalesPage slpage = new SalesPage();
            slpage.Show();
            Visible = false;
        }

        private void itemreportpage_Load(object sender, EventArgs e)
        {
            itrpt = new itemsreport();
            crystalReportViewer1.ReportSource = itrpt;
        }
    }
}
