using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace SupermarketManagementSystem
{
    public partial class CashierPage : Form
    {
        Thread th;
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;

        public CashierPage()
        {
            InitializeComponent();
        }

        private void LOGOUT_Click(object sender, EventArgs e)
        {
            th = new Thread(openform14);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            th = new Thread(openform13);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }

        private void button_cashier_Click(object sender, EventArgs e)
        {
            string constr = "Data Source=ORCL;User Id=hr;Password=hr;";
            string cmdstr = @"SELECT *
                              FROM transactions 
                                    order by transactionID";
                             
            adapter = new OracleDataAdapter(cmdstr, constr);
            
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void openform13()
        {
            Application.Run(new add_transaction__casheir());
        }
        private void openform14()
        {
            Application.Run(new LoginPage());
        }
    }
}

