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
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-PS7OKKF;Initial Catalog=StepAutoShop_db;Integrated Security=True");
        public Login()
        {
            InitializeComponent();
        }
        private bool redbg(TextBox tb, bool can)
        {
            if (can)
            {
                tb.BackColor = string.IsNullOrWhiteSpace(tb.Text) ? Color.Red : Color.White;
                if (tb.BackColor == Color.Red)
                {
                    return false;
                }
                return true;
            }
            else
            {
                return false;
            }
            
        }
        private string[] Check(string Username, string Password)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Buyer_Tb", con);
            SqlCommand cmd2 = new SqlCommand("select * from Seller_Tb", con);
            SqlDataAdapter adapter1 = new SqlDataAdapter(cmd);
            SqlDataAdapter adapter2 = new SqlDataAdapter(cmd2);
            DataTable BuyerDt = new DataTable();
            DataTable SellerDt = new DataTable();
            adapter1.Fill(BuyerDt);
            adapter2.Fill(SellerDt);
            con.Close();

            string[] result;

            foreach (DataRow row in BuyerDt.Rows)
            {
                if (Convert.ToString(row[3]) == Username && Convert.ToString(row[4]) == Password)
                {
                    result = new string[] { Convert.ToString(row[0]), (string)row[3] };
                    return result;
                }
            }
            foreach (DataRow row1 in SellerDt.Rows)
            {
                if (Convert.ToString(row1[3]) == Username && Convert.ToString(row1[4]) == Password)
                {
                    result = new string[] { Convert.ToString(row1[0]), (string)row1[3] };
                    return result;
                }
            }

            return null;

        }
        private void LoginbBtn_Click(object sender, EventArgs e)
        {
            bool can = false;
            can = redbg(UsernameTb, true); can = redbg(PasswordTb, can);
            if (can)
            {
                string[] result = Check(UsernameTb.Text, PasswordTb.Text);
                if (result != null)
                {
                    MainPage.IsLoggedIn = true;
                    MainPage.UserIdnName = result;
                    MessageBox.Show("Success", $"Logged In as - {result[1]} with id - {result[0]}");       
                    Close();
                }
                else
                {
                    MessageBox.Show("Error", "can't login");
                }

            }
        }
    }
}
