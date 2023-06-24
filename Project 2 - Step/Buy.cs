using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_2___Step
{
    public partial class Buy : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-PS7OKKF;Initial Catalog=StepAutoShop_db;Integrated Security=True");
        public Buy()
        {
            InitializeComponent();
        }

        private void buybtn_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand($"Select * from Cars_Tb where Id = {IdNUAD.Value}",con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            SqlCommand cmd2 = new SqlCommand($"Select * from Buyer_Tb where Id = {MainPage.UserIdnName[0]}", con);
            SqlDataAdapter adapter2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            adapter2.Fill(dt2);

            int Balance = Convert.ToInt32(dt2.Rows[0][5]);
            int price = Convert.ToInt32(dt.Rows[0][6]);
            if (Balance > price)
            {
                Balance -= price;
                SqlCommand cmd3 = new SqlCommand($"Update Buyer_Tb Set Balance = {Balance} WHERE Id = {MainPage.UserIdnName[0]}", con);
                cmd3.ExecuteNonQuery();
                SqlCommand cmd4 = new SqlCommand($"DELETE FROM Cars_Tb WHERE Id = {dt.Rows[0][0]}", con);
                cmd4.ExecuteNonQuery();
                SqlCommand cmd5 = new SqlCommand($"Update Seller_Tb Set Balance += {price} where Username = '{dt.Rows[0][8]}'", con);
                cmd5.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Not enough on balance");
            }
            con.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
