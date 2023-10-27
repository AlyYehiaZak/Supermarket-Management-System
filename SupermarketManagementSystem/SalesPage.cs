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
    public partial class SalesPage : Form
    {
        Thread th;
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;

        string ordb2 = "Data Source=ORCL;User Id=hr;Password=hr;";
        OracleConnection con;
        public SalesPage()
        {
            InitializeComponent();
        }

        private void SalesPage_Load(object sender, EventArgs e)
        {
            con = new OracleConnection(ordb2);
            con.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
           cmd.CommandText = "select DISTINCT CATEGORIES from ITEM";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Cat_box.Items.Add(dr[0]);
            }
            dr.Close();

        }

        private void LOGOUT_Click(object sender, EventArgs e)
        {
            th = new Thread(openform5);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }

        private void SalesPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Dispose();
        }

        private void button_viewsales_Click(object sender, EventArgs e)
        {
            string constr = "Data Source=ORCL;User Id=hr;Password=hr;";
            string cmdstr = @"select itemid ,itemname,price,number_of_item
                             from item 
                             where categories=:cat";
            adapter = new OracleDataAdapter(cmdstr, constr);
            adapter.SelectCommand.Parameters.Add("cat", Cat_box.SelectedItem.ToString());
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void Cat_box_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
        
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Sale Added");
            int days=0;
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
            days = Convert.ToInt32(textBox3.Text); 
            textBox1.Text = DateTime.Now.ToString();
            textBox2.Text = DateTime.Now.AddDays(days).ToString();
        }
       private void openform5()
        {
            Application.Run(new LoginPage());
        }

        private void seeitems_Click(object sender, EventArgs e)
        {
            itemreportpage itpage = new itemreportpage();
            itpage.Show();
            Visible = false;
        }
    }
}
