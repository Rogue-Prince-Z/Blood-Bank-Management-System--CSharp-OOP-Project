using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BloodBankManagementSystem
{
    public partial class DonateBlood : Form
    {
        public DonateBlood()
        {
            InitializeComponent();
            populate();
            bloodStock();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\Desktop\BloodBankManagementSystem\BloodBankDatabase.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");

        private void populate()
        {
            Con.Open();
            string Query = "select * from DonorTable";
            SqlCommand cmd = new SqlCommand(Query, Con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            DataTable dt = ds.Tables[0];
            DonateDGV.DataSource = dt;
            DonateDGV.Refresh();
            Con.Close();
        }

        private void bloodStock()
        {
            Con.Open();
            string Query = "select * from BloodTable";
            SqlCommand cmd = new SqlCommand(Query, Con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            DataTable dt = ds.Tables[0];
            BloodStockDGV.DataSource = dt;
            BloodStockDGV.Refresh();
            Con.Close();
        }

        private void Reset()
        {
            DNameTb.Text = "";
            BGroupTb.Text = "";
        }
        private void DonateBlood_Load(object sender, EventArgs e)
        {

        }

        int oldstock;
        private void GetStock(string Bgroup)
        {
            Con.Open();
            string query = " select * from BloodTable where BGroup = '" + Bgroup + "' ";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                oldstock = Convert.ToInt32(dr["BStock"].ToString());
            }
            Con.Close();

        }

        private void DonorDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DNameTb.Text = DonateDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
            BGroupTb.Text = DonateDGV.Rows[e.RowIndex].Cells[6].Value.ToString();
            GetStock(BGroupTb.Text);
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if(DNameTb.Text == "")
            {
                MessageBox.Show("Select A Donor Please");
            }
            else
            {
                try
                {
                    int stock = oldstock + 1;
                    string query = " update BloodTable set BStock = '" + stock + "' where BGroup = '" + BGroupTb.Text + "' ";
                    Con.Open();
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Donation Successfull!!");
                    Con.Close();
                    Reset();
                    bloodStock();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        

        private void label2_Click(object sender, EventArgs e)
        {
            Donor donor = new Donor();
            donor.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ViewDonor donor = new ViewDonor();
            donor.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();    
            patient.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            ViewPatients vp = new ViewPatients();
            vp.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            BloodStock bloodStock = new BloodStock();
            bloodStock.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            BloodTransfer bloodTransfer = new BloodTransfer();
            bloodTransfer.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
