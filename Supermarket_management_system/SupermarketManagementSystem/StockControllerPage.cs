using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Types;
using Oracle.DataAccess.Client;

namespace SupermarketManagementSystem
{
    public partial class StockControllerPage : Form
    {
        string ordb = "Data Source=ORCL;User id=hr;Password=hr;";
        OracleConnection conn;
        OracleDataAdapter adapter;
        DataSet ds;

        public StockControllerPage()
        {
            InitializeComponent();
        }
        private void StockControllerPage_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select DISTINCT categories from item";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                combobox_Categories_StockController.Items.Add(dr[0]);
            }
            dr.Close();
        }


        private void LOGOUT_Click(object sender, EventArgs e)
        {
            LoginPage loginPage= new LoginPage();
            loginPage.Show();
            Visible = false;
        }

        private void button_ViewData_StockController_Click(object sender, EventArgs e)
        {
            string constr = "Data Source=ORCL;User Id=hr;Password=hr;";
            string cmdstr = "select * from item where categories = :n";

            adapter = new OracleDataAdapter(cmdstr, constr);
            adapter.SelectCommand.Parameters.Add("n", combobox_Categories_StockController.SelectedItem.ToString());
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView_StockController.DataSource = ds.Tables[0];
        }

        private void button_StockController_GoStock_Click(object sender, EventArgs e)
        {
            RestockPage restockPage = new RestockPage();
            restockPage.Show();
            Visible = false;
        }
    }
}
