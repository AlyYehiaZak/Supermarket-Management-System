using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SupermarketManagementSystem
{
    public partial class manage_employee : Form
    {
        Thread th;
        string ordb = "Data Source=ORCL;User Id=hr;Password=hr;";
        OracleConnection conn;
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;

        public manage_employee()
        {
            InitializeComponent();
        }

        private void manage_employee_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select DISTINCT emp_role from market_employees";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                combobox_role.Items.Add(dr[0]);
            }
            dr.Close();

            

            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn;
            cmd2.CommandText = "select DISTINCT emp_role  from market_employees";
            cmd2.CommandType = CommandType.Text;
            OracleDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                comboBox_role_manage.Items.Add(dr2[0]);
            }
            dr2.Close();

            OracleCommand cmd10 = new OracleCommand();
            cmd10.Connection = conn;
            cmd10.CommandText = "select DISTINCT branchid from supermarket";
            cmd10.CommandType = CommandType.Text;
            OracleDataReader dr3 = cmd10.ExecuteReader();
            while (dr3.Read())
            {
                comboBox_branchid.Items.Add(dr3[0]);
            }
            dr3.Close();

            int maxID, newID;

            OracleCommand cmd12 = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Get_Emp_ID";
            cmd.CommandType = CommandType.StoredProcedure;
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
            textBox_ID.Text = newID.ToString();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            th = new Thread(openform11);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }

        private void button_cashier_Click(object sender, EventArgs e)
        {
            string constr = "Data Source=ORCL;User Id=hr;Password=hr;";
            string cmdstr = @"SELECT *
                              FROM market_employees me,market_accounts ma
                              WHERE ma.empid=me.empid
                              AND me.emp_role =:role";
            adapter = new OracleDataAdapter(cmdstr, constr);
            adapter.SelectCommand.Parameters.Add("role", combobox_role.SelectedItem.ToString());
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void manage_employee_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
        }
        private void openform11()
        {
            Application.Run(new AdminPage());
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_ManageEmp_Insert_Click(object sender, EventArgs e)
        {
            
            OracleCommand cmd = new OracleCommand(); 
            cmd.Connection = conn;

            cmd.CommandText = "insert into market_employees values(:emp,:sal,:role)";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("emp", Convert.ToInt32(textBox_ID.Text));
            cmd.Parameters.Add("sal", textBox_salary.Text);
            cmd.Parameters.Add("role", comboBox_role_manage.SelectedItem.ToString());

            cmd.ExecuteNonQuery();

            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn;

            cmd2.CommandText = "insert into market_accounts values(:u,:p,:eid,:bid)";
            cmd2.CommandType = CommandType.Text;
            cmd2.Parameters.Add("u", textBox_username.Text);
            cmd2.Parameters.Add("p", textBox_password.Text);
            cmd2.Parameters.Add("eid", Convert.ToInt32(textBox_ID.Text));
            cmd2.Parameters.Add("bid", Convert.ToInt32(comboBox_branchid.SelectedItem.ToString()));

            cmd2.ExecuteNonQuery();
           
 
            MessageBox.Show("Employee Added Successfully!");
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            OracleCommand cmd3 = new OracleCommand();
            cmd3.Connection = conn;

            cmd3.CommandText = "delete from market_employees where empid =:emp";
            cmd3.CommandType = CommandType.Text;
            cmd3.Parameters.Add("emp", Convert.ToInt32(textBox_ID.Text));

            cmd3.ExecuteNonQuery();

            OracleCommand cmd4 = new OracleCommand();
            cmd4.Connection = conn;

            cmd4.CommandText = "delete from market_accounts where empid = :eid";
            cmd4.CommandType = CommandType.Text;
            cmd4.Parameters.Add("eid", Convert.ToInt32(textBox_ID.Text));
            

            cmd4.ExecuteNonQuery();


            MessageBox.Show("Employee Deleted Successfully!");
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            OracleCommand cmd5 = new OracleCommand();
            cmd5.Connection = conn;

            cmd5.CommandText = @"update market_employees set salary=:sal, emp_role=:role where empid=:eid"; ;
            cmd5.CommandType = CommandType.Text;
            cmd5.Parameters.Add("sal", Convert.ToInt32(textBox_salary.Text));
            cmd5.Parameters.Add("role", comboBox_role_manage.Text);
            cmd5.Parameters.Add("eid", Convert.ToInt32(textBox_ID.Text));
            cmd5.ExecuteNonQuery();

            OracleCommand cmd6 = new OracleCommand();
            cmd6.Connection = conn;

            cmd6.CommandText = @"update market_accounts set username =:u, acc_password=:p, branchid =:bid where empid=:eid";
            cmd6.CommandType = CommandType.Text;
            cmd6.Parameters.Add("u", textBox_username.Text);
            cmd6.Parameters.Add("p", textBox_password.Text);
            cmd6.Parameters.Add("bid", Convert.ToInt32(comboBox_branchid.SelectedItem.ToString()));
            cmd6.Parameters.Add("eid", Convert.ToInt32(textBox_ID.Text));


            cmd6.ExecuteNonQuery();
            

            MessageBox.Show("Employee Updated Successfully!");
        }
    }
}

