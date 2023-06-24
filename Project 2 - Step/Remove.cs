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
    public partial class Remove : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-PS7OKKF;Initial Catalog=StepAutoShop_db;Integrated Security=True");
        public Remove()
        {
            InitializeComponent();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            if (IdNUAD.Value != 0)
            {
                DataGridView dgv = CarsDGV;
                con.Open();
                SqlCommand cmd = new SqlCommand($"DELETE FROM Cars_Tb WHERE Id = {IdNUAD.Value} AND SellerUsername = '{MainPage.UserIdnName[1]}'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                IdNUAD.Value = 0;
                dgvrestart();
                DataGridView dgv2 = CarsDGV;
                if (dgv.RowCount != dgv2.RowCount)
                {
                    MessageBox.Show("Success");
                }
            }
            else
            {
                MessageBox.Show("You Forgot to input Id");
            }
        }
        private void dgvrestart()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Cars_Tb", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            con.Close();

            CarsDGV.DataSource = dt;
        }
        private void Remove_Load(object sender, EventArgs e)
        {
            dgvrestart();
        }

        private void ShowmycarsBtn_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand($"SELECT * FROM Cars_Tb WHERE SellerUsername = '{MainPage.UserIdnName[1]}'", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            CarsDGV.DataSource = dt;

            con.Close();
        }
    }
}
