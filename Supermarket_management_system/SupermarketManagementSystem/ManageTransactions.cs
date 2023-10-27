using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermarketManagementSystem
{
    public partial class ManageTransactions : Form
    {
        string ordb = "Data Source=ORCL;User id=hr;Password=hr;";
        OracleConnection conn;

        public ManageTransactions()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "viewtransactions";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("cursor", OracleDbType.RefCursor, ParameterDirection.Output);
            
            OracleDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                combobox_ManageTransactions_TID.Items.Add(dr[0]);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            AdminPage adminPage = new AdminPage();
            adminPage.Show();
            Visible = false;
        }


        private void button_ManageTransactions_Insert_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            string str = DateTime.Now.ToString();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "addtransactions";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("TID",combobox_ManageTransactions_TID.Text);
            cmd.Parameters.Add("Cname", textbox_ManageTransactions_Cname.Text);
            cmd.Parameters.Add("DOT", Convert.ToDateTime(str));
            cmd.ExecuteNonQuery();

            MessageBox.Show("New Transaction Added");

        }

        private void combobox_ManageTransactions_TID_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select customername, date_transaction from transactions where transactionid=:id";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("id", combobox_ManageTransactions_TID.SelectedItem.ToString());

            OracleDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                textbox_ManageTransactions_Cname.Text = dr[0].ToString();
                textbox_ManageTransactions_DOT.Text = dr[1].ToString();
            }
        }

        private void button_ManageTransactions_Edit_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "update transactions set customername =:name, date_transaction = :dt where transactionid=:id";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("name", textbox_ManageTransactions_Cname.Text);
            cmd.Parameters.Add("dt", Convert.ToDateTime(textbox_ManageTransactions_DOT.Text));
            cmd.Parameters.Add("id", combobox_ManageTransactions_TID.SelectedItem.ToString());
            cmd.ExecuteNonQuery();

            MessageBox.Show("Transaction Updated");
        }

        private void button_ManageTransactions_Delete_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "deletetransactions";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("id", combobox_ManageTransactions_TID.SelectedItem.ToString());
            cmd.ExecuteNonQuery();

            MessageBox.Show("Transaction Deleted");

            textbox_ManageTransactions_Cname.Text = "";
            textbox_ManageTransactions_DOT.Text = "";
        }

        private void getbydate_Click(object sender, EventArgs e)
        {
            transactionsreportpage trrptpage = new transactionsreportpage();
            trrptpage.Show();
            Visible = false;
        }
    }
}
