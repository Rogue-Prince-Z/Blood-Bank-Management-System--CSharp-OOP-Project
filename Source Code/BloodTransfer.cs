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

namespace BloodBankManagementSystem
{
    public partial class BloodTransfer : Form
    {
        public BloodTransfer()
        {
            InitializeComponent();
            fillPatientCb();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\Desktop\BloodBankManagementSystem\BloodBankDatabase.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");


        private void fillPatientCb()
        {
            
            Con.Open();
            string query = "select PNum from PatientTable";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("PNum", typeof(int));
            dt.Load(rdr);
            PatientIdCb.ValueMember = "PNum";
            PatientIdCb.DataSource = dt;
            PatientIdCb.SelectedIndex = -1;
            Con.Close();
        }

        private void GetData()
        {
            //Helps to get the actual BloodGroup and Patient Name

            Con.Open();
            string query = " select * from PatientTable where PNum = '" + PatientIdCb.SelectedValue.ToString() + "' ";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                PatNameTb.Text = dr["PName"].ToString();
                BloodGroupTb.Text = dr["PBGroup"].ToString();
            }
            Con.Close();

        }

        int stock;
        private void GetStock(string Bgroup)
        {
            Con.Open();
            string query = " select * from BloodTable where BGroup = '" + Bgroup + "' ";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                stock = Convert.ToInt32(dr["BStock"].ToString());
            }
            Con.Close();

        }

        private void BloodTransfer_Load(object sender, EventArgs e)
        {

        }

        private void PatientIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetData();
            GetStock(BloodGroupTb.Text);
            if(stock > 0)
            {
                TransferBtn.Visible = true;
                AvailableLbl.Text = "Available";
                AvailableLbl.Visible = true;
            }
            else
            {
                AvailableLbl.Text = "Stock Not Available";
                AvailableLbl.Visible = true;
            }
        }

        private void Reset()
        {
            PatNameTb.Text = "";
            BloodGroupTb.Text = "";
            AvailableLbl.Visible = false;
            TransferBtn.Visible = false;
        }


        private void updateStock()
        {
            int newstock = stock - 1;
            try
            {

                string query = " update BloodTable set BStock = '" + newstock + "' where BGroup = '" + BloodGroupTb.Text + "' ";
                Con.Open();
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void TransferBtn_Click(object sender, EventArgs e)
        {
            if (PatNameTb.Text == "" )
            {
                MessageBox.Show("Missing Information!!");
            }
            else
            {
                try
                {

                    string query = "insert into TransferTable1 values('" + PatNameTb.Text + "','" + BloodGroupTb.Text + "')";
                    Con.Open();
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successful Transfer!!");
                    Con.Close();
                    GetStock(BloodGroupTb.Text);
                    updateStock();
                    Reset();
                    
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Donor donor = new Donor();
            donor.Show();
            this.Hide();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            DonateBlood donateBlood = new DonateBlood();
            donateBlood.Show();
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
            Patient Pat = new Patient();
            Pat.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            ViewPatients viewPatients = new ViewPatients();
            viewPatients.Show();
            this.Hide();
        }
        private void label10_Click(object sender, EventArgs e)
        {
            BloodStock Bstock = new BloodStock();
            Bstock.Show();
            this.Hide();
        }
    }
}
