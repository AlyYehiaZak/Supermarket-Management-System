using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;


namespace SupermarketManagementSystem
{

    public partial class add_transaction__casheir : Form
    {
        int maxID, newID;
        double total_price = 0;
        OracleConnection conn;
        Thread th;
        string ordb = "Data Source=ORCL;User Id=hr;Password=hr;";
        public add_transaction__casheir()
        {
            InitializeComponent();
        }
        private void add_transaction__casheir_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Get_TRANSACTION_ID";
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Parameters.Add("id", OracleDbType.Int32, ParameterDirection.Output);
            cmd.ExecuteNonQuery();
            try
            {
                maxID = Convert.ToInt32(cmd.Parameters["id"].Value.ToString());
                newID = maxID + 1;
            }
            catch
            {
                newID = 1;
            }
            textBox1.Text=newID.ToString();


            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn;
            cmd2.CommandText = "select ITEMNAME from ITEM";
            cmd2.CommandType = CommandType.Text;
            OracleDataReader dr = cmd2.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }
            dr.Close();
        


    }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand cmd3 = new OracleCommand();
            cmd3.Connection = conn;
            cmd3.CommandText = "select PRICE from item where ITEMNAME =:name";
            cmd3.CommandType = CommandType.Text;
            cmd3.Parameters.Add("name", comboBox1.SelectedItem);
            OracleDataReader dr = cmd3.ExecuteReader();
            if (dr.Read())
            {
                textBox2.Text = dr[0].ToString();
            }
            dr.Close();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CashierPage page = new CashierPage();
            page.Show();
            Visible = false;
        }
        private void button_cashier_Click(object sender, EventArgs e)
        {
            int itemid =0;
            OracleCommand cmd5 = new OracleCommand();
            cmd5.Connection = conn;
            cmd5.CommandText = "select ITEMID from item where ITEMNAME=:name";
            cmd5.CommandType = CommandType.Text;
            cmd5.Parameters.Add("name", comboBox1.SelectedItem);
            OracleDataReader dr =cmd5.ExecuteReader();
            if (dr.Read())
            {
                itemid = dr[0].GetHashCode();
            }
            dr.Close();
         

            OracleCommand cmd4= new OracleCommand();
            cmd4.Connection = conn;
            cmd4.CommandText = "insert into MARKET_INCLUDES values(:TID,:IID)";
            cmd4.CommandType = CommandType.Text;
            cmd4.Parameters.Add("TID", textBox1.Text);
            cmd4.Parameters.Add("IID", itemid);
            int r = cmd4.ExecuteNonQuery();
            if (r != -1)
            {
                
                MessageBox.Show(" new Item is added");
            }

            total_price = total_price + Convert.ToDouble(textBox2.Text);
            textBox7.Text=total_price.ToString();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd6 = new OracleCommand();
            cmd6.Connection = conn;
            cmd6.CommandText = "insert into TRANSACTIONS values(:id,:name,:datee)";
            cmd6.CommandType = CommandType.Text;

            cmd6.Parameters.Add("id", newID);
            cmd6.Parameters.Add("name", textBox4.Text);
            cmd6.Parameters.Add("datee", textBox3.Text);


            int r = cmd6.ExecuteNonQuery();
            if (r != -1)
            {

                MessageBox.Show(" new transaction is being  added");
                label2.Visible = true;
                comboBox1.Visible = true;
                label3.Visible = true;
                textBox2.Visible = true;
                button_cashier.Visible = true;
                button2.Visible = true;
                label8.Visible = true;
                textBox7.Visible = true;
            }


        }
        private void button2_Click(object sender, EventArgs e)
        {
            double newbudget = 0;
            double market_new_budget = 0;
            newbudget= Convert.ToDouble(textBox6.Text) - Convert.ToDouble(textBox7.Text);
            total_price = 0;
            if (newbudget >= 0)
            {
                OracleCommand cmd8 = new OracleCommand();
                cmd8.Connection = conn;
                cmd8.CommandText = "update credit_cards set budget =:bud where cardid=:id";
                cmd8.CommandType = CommandType.Text;
                cmd8.Parameters.Add("bud", newbudget);
                cmd8.Parameters.Add("id", Convert.ToInt32(textBox5.Text));

                int r = cmd8.ExecuteNonQuery();
                if (r != -1)
                {
                    MessageBox.Show("Transaction Complete");
                }

                OracleCommand cmd12 = new OracleCommand();
                cmd12.Connection = conn;
                cmd12.CommandText = "select budget from supermarket where branchid=:bran";
                cmd12.CommandType = CommandType.Text;
                cmd12.Parameters.Add("bran", comboBox2.SelectedItem.ToString());
                OracleDataReader dr2 = cmd12.ExecuteReader();
                if (dr2.Read())
                {
                    market_new_budget = Convert.ToDouble(dr2[0]);
                }
                dr2.Close();

                
                market_new_budget = market_new_budget + Convert.ToDouble(textBox7.Text);
                OracleCommand cmd11 = new OracleCommand();
                cmd11.Connection = conn;
                cmd11.CommandText = "update supermarket set budget =:bud where branchid=:bran";
                cmd11.CommandType = CommandType.Text;
                cmd11.Parameters.Add("bud", market_new_budget);
                cmd11.Parameters.Add("bran", comboBox2.SelectedItem.ToString());
                int r2 = cmd11.ExecuteNonQuery();
                if (r2 != -1)
                {
                    MessageBox.Show("Supermarket branch budget updated");
                }
                
            }
            else
            {
                MessageBox.Show("Not enough budget");
            }
            


            th = new Thread(openform10);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OracleCommand cmd7 = new OracleCommand();
            cmd7.Connection = conn;

            cmd7.CommandText = @"SELECT budget
                                FROM Credit_cards
                                WHERE CardID=:cardnum";
            cmd7.CommandType = CommandType.Text;
            cmd7.Parameters.Add("cardnum", textBox5.Text);

            OracleDataReader dr = cmd7.ExecuteReader();

            if (dr.Read())
            {
                textBox6.Text = dr[0].ToString();
                MessageBox.Show("Credit Card added\n");
                label1.Visible = true;
                textBox1.Visible = true;
                label5.Visible = true;
                textBox4.Visible = true;
                label4.Visible = true;
                textBox3.Visible = true;
                button1.Visible = true;
                label9.Visible = true;
                comboBox2.Visible = true;

                OracleCommand cmd10 = new OracleCommand();
                cmd10.Connection = conn;
                cmd10.CommandText = "select DISTINCT branchid from supermarket";
                cmd10.CommandType = CommandType.Text;
                OracleDataReader dr2 = cmd10.ExecuteReader();
                while (dr2.Read())
                {
                    comboBox2.Items.Add(dr2[0]);
                }
                dr2.Close();
            }
            else
            {
                MessageBox.Show("Credit Card invalid\n");
                textBox5.Text = "";
            }
            }

        private void add_transaction__casheir_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();   
        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void openform10()
        {
            Application.Run(new CashierPage());
        }

    }
}
