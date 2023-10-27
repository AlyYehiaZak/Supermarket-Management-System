using Oracle.DataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;
namespace SupermarketManagementSystem
{
    public partial class RestockPage : Form
    {
        string ordb = "Data Source=ORCL;User id=hr;Password=hr;";
        OracleConnection conn;
        public RestockPage()
        {
            InitializeComponent();
        }

        private void RestockPage_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select itemname from item";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox_Restock_ItemName.Items.Add(dr[0]);
            }
            dr.Close();
        }

        private void button_Restock_GetNumber_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = "GetNumberRemaining";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("itemName",comboBox_Restock_ItemName.SelectedItem.ToString());
            cmd.Parameters.Add("remainingNumber", OracleDbType.Int32, ParameterDirection.Output);
            cmd.ExecuteNonQuery();

            textBox_Restock_ItemsRemain.Text = Convert.ToString(cmd.Parameters["remainingNumber"].Value.ToString());
        }

        private void button_Restock_GoBack_Click(object sender, EventArgs e)
        {
            StockControllerPage stockControllerPage = new StockControllerPage();
            stockControllerPage.Show();
            Visible = false;
        }

        private void button_Restock_Restock_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            int itemsRemains = Convert.ToInt32(textBox_Restock_ItemsRemain.Text);
            int itemsToBeAdded = Convert.ToInt32(textBox_Restock_NumberItemsAdded.Text);
            int new_NumberOfItems = itemsRemains + itemsToBeAdded;

            cmd.CommandText = "update item set number_of_item = :n where itemname = :name";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("n", new_NumberOfItems);
            cmd.Parameters.Add("name",comboBox_Restock_ItemName.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Restocked Successfully !");

            textBox_Restock_NumberItemsAdded.Text = "";
            textBox_Restock_ItemsRemain.Text = new_NumberOfItems.ToString();
        }
    }
}
