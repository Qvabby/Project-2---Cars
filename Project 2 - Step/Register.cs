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
    public partial class Register : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-PS7OKKF;Initial Catalog=StepAutoShop_db;Integrated Security=True");
        public Register()
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

        private bool checkUsername(string Username)
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
                if (Convert.ToString(row[3]) == Username)
                {
                    return false;
                }
            }
            foreach (DataRow row1 in SellerDt.Rows)
            {
                if (Convert.ToString(row1[3]) == Username)
                {
                    return false;
                }
            }

            return true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (!BuyerR.Checked || !SellerR.Checked)
            {
                bool can = true;
                can = redbg(FNameTb, can); can = redbg(LNameTb, can); can = redbg(UnameTb, can); can = redbg(PasswordTb, can);
                if (checkUsername(UnameTb.Text))
                {
                    string role = SellerR.Checked ? "seller" : "buyer";
                    if (can)
                    {
                        con.Open();
                        SqlCommand cmd;
                        if (role == "seller")
                        {
                            cmd = new SqlCommand($"insert into Seller_Tb(Name, LastName, Username, Password, Balance, UserRole)" +
                                $"values ('{FNameTb.Text}','{LNameTb.Text}','{UnameTb.Text}','{PasswordTb.Text}','{BalanceNUAD.Value}','{role}')", con);
                        }
                        else
                        {
                            cmd = new SqlCommand($"insert into Buyer_Tb(Name, LastName, Username, Password, Balance, UserRole)" +
                                $"values ('{FNameTb.Text}','{LNameTb.Text}','{UnameTb.Text}','{PasswordTb.Text}','{BalanceNUAD.Value}','{role}')", con);
                        }

                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Registeration went successfully", "Registration Complete", MessageBoxButtons.OK, MessageBoxIcon.None);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Cant register with because it has wrong input", "Can't Register.");
                    }
                }
                else
                {
                    usernameerrorlabel.Visible = true;  
                }
                
            }
        }

        private void ChangeColor(TextBox tb)
        {
            if (tb.BackColor == Color.Red)
            {
                tb.BackColor = Color.White;
            }
        }
        private void FNameTb_TextChanged(object sender, EventArgs e)
        {
            ChangeColor(FNameTb);
        }

        private void LNameTb_TextChanged(object sender, EventArgs e)
        {
            ChangeColor(LNameTb);
        }

        private void UnameTb_TextChanged(object sender, EventArgs e)
        {
            ChangeColor(UnameTb);
        }

        private void PasswordTb_TextChanged(object sender, EventArgs e)
        {
            ChangeColor(PasswordTb);
        }
    }
}
