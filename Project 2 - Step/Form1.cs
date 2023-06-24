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
    public partial class MainPage : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-PS7OKKF;Initial Catalog=StepAutoShop_db;Integrated Security=True");
        public static bool IsLoggedIn { get; set; } = false;
        public static string[] UserIdnName { get; set; }
        public static bool isSeller { get; set; }
        public MainPage()
        {
            InitializeComponent();
        }
        //Methods
        private void UpdateMainGridView()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Cars_Tb", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            con.Close();
            CarsDGV.DataSource = tb;
        }

        //Load
        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateMainGridView();
            if (IsLoggedIn)
            {
                SignUpBtn.Text = "Log Out";
                RegisterBtn.Visible = false;
            }
            else
            {
                SignUpBtn.Text = "Log In";
                RegisterBtn.Visible = true;
            }
        }

        //Other Methods
        private void SignUpBtn_Click(object sender, EventArgs e)
        {
           

            if (!IsLoggedIn)
            {
                //if (MainPanel.Controls.Count > 0)
                //{
                //    MainPanel.Controls.RemoveAt(0);
                //}
                Login l = new Login();
                //l.Dock = DockStyle.Fill;
                //l.TopLevel = false;
                //MainPanel.Controls.Add(l);
                //l.Show();
                
                
                
                
                l.ShowDialog();
                if (IsLoggedIn)
                {
                    CheckRole(UserIdnName);
                }    
            }
            else
            {
                UserIdnName = null;
                IsLoggedIn = false;
                SignUpBtn.Text = "Log in";
                RegisterBtn.Visible = true;
                Unamelabel.Visible = false;
                AddBtn.Visible = false;
                RemoveBtn.Visible = false;
                ShowAllCarBtn.Visible = false;
                ShowMyCarBtn.Visible = false;
            }
        }

        private void getAdvs()
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from Cars_Tb",con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            con.Close();

            foreach (DataRow row in dt.Rows)
            {
                ManufacturersCB.Items.Add(row[2]);
                ModelCB.Items.Add(row[3]);
                ColorsCB.Items.Add(row[4]);
            }
            
            for (int i = 0; i < ManufacturersCB.Items.Count; i++)
            {
                int c = 0;
                for (int k = i+1; k < ManufacturersCB.Items.Count; k++)
                {
                    if (ManufacturersCB.Items[i] == ManufacturersCB.Items[k])
                    {
                        c++;
                        if (c == 2)
                        {
                            ManufacturersCB.Items.Remove(ManufacturersCB.Items[i]);
                        }
                    }
                }
            }

            foreach (var i in ModelCB.Items)
            {
                int c = 0;
                foreach (var k in ModelCB.Items)
                {
                    if (i == k)
                    {
                        c++;
                        if (c == 2)
                        {
                            ModelCB.Items.Remove(i);
                        }
                    }
                }
            }

            foreach (var i in ColorsCB.Items)
            {
                int c = 0;
                foreach (var k in ColorsCB.Items)
                {
                    if (i == k)
                    {
                        c++;
                        if (c == 2)
                        {
                            ColorsCB.Items.Remove(i);
                        }
                    }
                }
            }

        }

        private void CheckRole(string[] useridandusername)
        {
            // array[0] - id / [1] - username
            con.Open();
            SqlCommand cmd = new SqlCommand($"select * from Buyer_Tb where Username = '{useridandusername[1]}' and Id = '{useridandusername[0]}'", con);
            SqlCommand cmd2 = new SqlCommand($"select * from Seller_Tb where Username = '{useridandusername[1]}' and Id = '{useridandusername[0]}'", con);
            SqlDataAdapter adapter1 = new SqlDataAdapter(cmd);
            SqlDataAdapter adapter2 = new SqlDataAdapter(cmd2);
            DataTable BuyerDt = new DataTable();
            DataTable SellerDt = new DataTable();
            adapter1.Fill(BuyerDt);
            adapter2.Fill(SellerDt);
            con.Close();

            if (BuyerDt.Rows.Count < 1)
            {
                isSeller = true;
            }
            else
            {
                isSeller = false;
            }

            if (isSeller)
            {
                MessageBox.Show("You are Seller", "Role");
            }
            else
            {
                MessageBox.Show("You are Buyer", "Role");
            }
            
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            Register R = new Register();
            R.ShowDialog();
        }

        private void MainPage_Activated(object sender, EventArgs e)
        {
            if (IsLoggedIn)
            {
                Unamelabel.Visible = true;
                Unamelabel.Text = $"USER: {UserIdnName[1]}";
                RegisterBtn.Visible = false;
                SignUpBtn.Text = "Log Out";
                if (isSeller)
                {
                    AddBtn.Visible = true;
                    RemoveBtn.Visible = true;
                    ShowAllCarBtn.Visible = true;
                    ShowMyCarBtn.Visible = true;
                }
                else
                {
                    AddBtn.Visible = false;
                    RemoveBtn.Visible = false;
                    ShowAllCarBtn.Visible = false;
                    ShowMyCarBtn.Visible = false;
                    BuyBtn.Visible = true;
                }
            }
            else if (!IsLoggedIn)
            {
                BuyBtn.Visible = false;
                Unamelabel.Visible = false;
                RegisterBtn.Visible = true;
                SignUpBtn.Text = "Log in";
            }
            
        }

        private void AdvancedSearchPBtn_Click(object sender, EventArgs e)
        {
            List<Control> advsearch = new List<Control>
            {
                ManufacturersCB,
                ModelCB,
                ColorsCB,
                MinYearL,
                MinYearNUAD,
                MaxYearL,
                MaxYearNUAD,
                MinPriceL,
                MinPriceNUAD,
                MaxPriceL,
                MaxPriceNUAD,
                TItleL,
                TitleTb,
                SellerUsernameL,
                SellerUsernameTb,
                AdvSearchPBtn,
            };
            if (advsearch[0].Visible)
            {
                foreach (var item in advsearch)
                {
                    item.Visible = false;
                }
            }
            else
            {
                foreach (var item in advsearch)
                {
                    item.Visible = true;
                }
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT Manufacturer FROM Cars_Tb ", con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dtManufacturers = new DataTable();
                adapter.Fill(dtManufacturers);

                foreach (DataRow row in dtManufacturers.Rows)
                {
                    if(!ManufacturersCB.Items.Contains(row[0].ToString()))
                    {
                        ManufacturersCB.Items.Add(row[0]);
                    }
                }
                SqlCommand cmd2 = new SqlCommand("SELECT Model FROM Cars_Tb ", con);
                SqlDataAdapter adapter2 = new SqlDataAdapter(cmd2);
                DataTable dtModels = new DataTable();
                adapter2.Fill(dtModels);

                foreach (DataRow row in dtModels.Rows)
                {
                    if(!ModelCB.Items.Contains(row[0].ToString()))
                    {
                            ModelCB.Items.Add(row[0]);
                    }
                }
                SqlCommand cmd3 = new SqlCommand("SELECT Color FROM Cars_Tb ", con);
                SqlDataAdapter adapter3 = new SqlDataAdapter(cmd3);
                DataTable dtColors = new DataTable();
                adapter3.Fill(dtColors);

                foreach (DataRow row in dtColors.Rows)
                {
                    if (!ColorsCB.Items.Contains(row[0].ToString()))
                    {
                        ColorsCB.Items.Add(row[0]);
                    }
                    
                }
                con.Close();  
            }
        }
        private void AdvSearchPBtn_Click_1(object sender, EventArgs e)
        {
            string command = $"SELECT * FROM Cars_Tb WHERE Year >= {MinYearNUAD.Value} AND Year <= {MaxYearNUAD.Value} AND Price >= {MinPriceNUAD.Value} AND Price <= {MaxPriceNUAD.Value} ";
            if (ManufacturersCB.SelectedIndex > -1)
            {
                command += $"AND Manufacturer = '{ManufacturersCB.SelectedItem.ToString()}' ";
            }
            if (ModelCB.SelectedIndex > -1)
            {
                command += $"AND Model = '{ModelCB.SelectedItem.ToString()}' ";
            }
            if (ColorsCB.SelectedIndex > -1)
            {
                command += $"AND Color = '{ColorsCB.SelectedItem.ToString()}' ";
            }
            command += $"AND Title LIKE '%{TitleTb.Text}%' ";
            if (!string.IsNullOrWhiteSpace(SellerUsernameTb.Text))
            {
                command += $"AND SellerUsername = '{SellerUsernameTb.Text}'";
            }

            con.Open();

            SqlCommand cmd = new SqlCommand(command, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            CarsDGV.DataSource = dt;
            con.Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Add a = new Add();
            a.ShowDialog();
            UpdateMainGridView();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            Remove r = new Remove();
            r.ShowDialog();
            UpdateMainGridView();
        }

        private void ShowAllCarBtn_Click(object sender, EventArgs e)
        {
            UpdateMainGridView();
        }

        private void ShowMyCarBtn_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand($"SELECT * FROM Cars_Tb WHERE SellerUsername = '{UserIdnName[1]}'", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            CarsDGV.DataSource = dt;

            con.Close();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SearchTb.Text))
            {
                UpdateMainGridView();
            }
            else
            {
                con.Open();

                SqlCommand cmd = new SqlCommand($"SELECT * FROM Cars_Tb WHERE Title LIKE '%{SearchTb.Text}%'", con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                CarsDGV.DataSource = dt;

                con.Close();
            }
            
        }

        private void BuyBtn_Click(object sender, EventArgs e)
        {
            Buy b = new Buy();
            b.ShowDialog();
            UpdateMainGridView();
        }
    }
}
