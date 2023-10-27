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
    public partial class LoginPage : Form
    {
        Thread th;

        string ordb = "Data Source=ORCL;User Id=hr;Password=hr;";
        OracleConnection conn;

        public LoginPage()
        {
            InitializeComponent();
        }


        private void LoginPage_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = @"SELECT ma.empid
                                FROM market_accounts ma, market_employees me
                                WHERE ma.empid = me.empid
                                AND ma.username =:name
                                AND ma.acc_password =:password
                                AND me.emp_role =:role";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("name", textbox_Username.Text);
            cmd.Parameters.Add("password", textbox_Password.Text);
            cmd.Parameters.Add("role", combobox_SelectRole.SelectedItem.ToString());

            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("Login Successful\n");
                switch(combobox_SelectRole.SelectedItem.ToString())
                {
                    case "Stock Controller":
                        {
                            th = new Thread(opennewform2);
                            th.SetApartmentState(ApartmentState.STA);
                            th.Start();
                            this.Close();
                            break;
                        }
                    case "Admin":
                        {
                            th = new Thread(opennewform1);
                            th.SetApartmentState(ApartmentState.STA);
                            th.Start();
                            this.Close();
                            break;
                        }
                    case "Sales":
                        {
                            th = new Thread(opennewform3);
                            th.SetApartmentState(ApartmentState.STA);
                            th.Start();
                            this.Close();
                            break;
                        }
                    case "Cashier":
                        {
                            th = new Thread(opennewform4);
                            th.SetApartmentState(ApartmentState.STA);
                            th.Start();
                            this.Close();
                            break;
                        }
                }
            }
            else
            {
                MessageBox.Show("Invalid Credentials\n");
                textbox_Username.Text = "";
                textbox_Password.Text = "";
                combobox_SelectRole.Text = "Select Role";
            }
               
        }

        private void LoginPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
            
        }
        private void opennewform1()
        {
            Application.Run(new AdminPage());
        }
        private void opennewform2()
        {
            Application.Run(new StockControllerPage());
        }
        private void opennewform3()
        {
            Application.Run(new SalesPage());
        }
        private void opennewform4()
        {
            Application.Run(new CashierPage());
        }

    }
}