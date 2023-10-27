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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SupermarketManagementSystem
{
    public partial class ManageItems : Form
    {
        string ordb2 = "Data Source=ORCL;User Id=hr;Password=hr;";
        OracleConnection con;
        public ManageItems()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminPage adminPage = new AdminPage();
            adminPage.Show();
            Visible = false;
        }

        private void ManageItems_Load(object sender, EventArgs e)
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
                combobox_ManageItems_Category.Items.Add(dr[0]);
            }
            dr.Close();

        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = @"INSERT into ITEM values (:ITEMID,:ITEMNAME,:PRICE,:CATEGORIES,:NUMBER_OF_ITEM)";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("ITEMID", textbox_ManageItems_ID.Text);
            cmd.Parameters.Add("ITEMNAME", textbox_ManageItems_Name.Text);
            cmd.Parameters.Add("PRICE", textbox_ManageItems_Price.Text);
            cmd.Parameters.Add("CATEGORIES", combobox_ManageItems_Category.SelectedItem.ToString());
            cmd.Parameters.Add("NUMBER_OF_ITEM", textbox_ManageItems_Quantity.Text);
            
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {

                MessageBox.Show(" new Item is added");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = @"Delete from ITEM where ITEMID =: ID";
            cmd.Parameters.Add("ID", textbox_ManageItems_ID.Text);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("Item Deleted");

            }
        }
    }
}
