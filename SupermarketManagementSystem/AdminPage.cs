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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SupermarketManagementSystem
{
    public partial class AdminPage : Form
    {
        Thread th;
        OracleConnection conn;
        string ordb = "Data source =orcl;user id=hr;password=hr;";
        public AdminPage()
        {
            InitializeComponent();
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            conn=new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd12 = new OracleCommand();
            cmd12.Connection = conn;
            cmd12.CommandText = "select distinct branchid from supermarket";
            cmd12.CommandType = CommandType.Text;
            OracleDataReader dr2 = cmd12.ExecuteReader();
            while (dr2.Read())
            {
                comboBox1.Items.Add(dr2[0]);
            }
            dr2.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void LOGOUT_Click(object sender, EventArgs e)
        {
            th = new Thread(openform8);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }

        private void button_manage_employees_Click(object sender, EventArgs e)
        {
            th = new Thread(openform9);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }
        private void openform8()
        {
            Application.Run(new LoginPage());
        }
        private void openform9()
        {
            Application.Run(new manage_employee());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageItems manageItems = new ManageItems();
            manageItems.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManageTransactions manageTransactions = new ManageTransactions();
            manageTransactions.Show();
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OracleCommand cmd13 = new OracleCommand();
            cmd13.Connection = conn;
            cmd13.CommandText = "select budget from supermarket where branchid=:bran";
            cmd13.CommandType = CommandType.Text;
            cmd13.Parameters.Add("bran", comboBox1.SelectedItem.ToString());
            OracleDataReader dr3 = cmd13.ExecuteReader();
            if (dr3.Read())
            {
                textBox2.Text = dr3[0].ToString();
            }
            dr3.Close();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double budget = 0;
            budget = Convert.ToDouble(textBox2.Text)+ Convert.ToDouble(textBox1.Text);
            OracleCommand cmd1 = new OracleCommand();
            cmd1.Connection = conn;
            cmd1.CommandText = "update supermarket set budget =:bud where branchid=:bran";
            cmd1.CommandType = CommandType.Text;
            cmd1.Parameters.Add("bud", budget);
            cmd1.Parameters.Add("bran", comboBox1.SelectedItem.ToString());
            int r = cmd1.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("Price Deposited");
                textBox2.Text = budget.ToString();
                textBox1.Text = "";
            }
        }
    }
}

