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
    public partial class Add : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-PS7OKKF;Initial Catalog=StepAutoShop_db;Integrated Security=True");
        public Add()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            bool can = true;
            List<TextBox> tbs = new List<TextBox>() 
            {
                TitleTb,
                ManufacturerTb,
                ModelTb,
                ColorTb,
            };

            if (MainPage.UserIdnName == null)
            {
                can = false;
            }

            foreach (var item in tbs)
            {
                if (string.IsNullOrWhiteSpace(item.Text))
                {
                    can = false;
                    item.BackColor = Color.Red;
                    MessageBox.Show("You forgot to input");
                    break;
                }
            }

            if (PriceNUAD.Value == 0)
            {
                can = false;
                MessageBox.Show("You forgot to Input Price");
            }

            if (can)
            {
                con.Open();

                SqlCommand cmd = new SqlCommand($"Insert into Cars_Tb (Title, Manufacturer, Model, Color, Year, Price, Description, SellerUsername) " +
                    $"values ('{TitleTb.Text}','{ManufacturerTb.Text}','{ModelTb.Text}','{ColorTb.Text}','{YearNUAD.Value}','{PriceNUAD.Value}','{DescriptionTb.Text}','{MainPage.UserIdnName[1]}')",con);

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Successfully Added Car To Database.");

                foreach (var item in tbs)
                {
                    item.Clear();
                }
            }
            else
            {
                MessageBox.Show("niiga we fucked up, cant add");
            }

        }
    }
}
