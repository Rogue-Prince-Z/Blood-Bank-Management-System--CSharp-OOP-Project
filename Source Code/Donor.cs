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
    public partial class Donor : Form
    {
        public Donor()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\Desktop\BloodBankManagementSystem\BloodBankDatabase.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");

        private void Reset()
        {
            DNameTb.Text = "";
            DAgeTb.Text = "";
            DPhoneTb.Text = "";
            DAddressTb.Text = "";
            DGenCb.SelectedIndex = -1;
            DBGroupCb.SelectedIndex = -1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if( DNameTb.Text == "" || DPhoneTb.Text == "" || DAgeTb.Text == "" || DGenCb.SelectedIndex == -1 || DBGroupCb.SelectedIndex == -1 )
            {
                MessageBox.Show("Missing Information!!");
            }
            else
            {
                try
                {
                    
                    string query = "insert into DonorTable values('"+DNameTb.Text+"','"+DAgeTb.Text+"','"+DGenCb.SelectedItem.ToString()+"','"+DPhoneTb.Text+"','"+DAddressTb.Text+"','"+DBGroupCb.SelectedItem.ToString()+"')";
                    Con.Open();
                    SqlCommand cmd = new SqlCommand(query,Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Donor Successfully Saved!!");
                    Con.Close();
                    Reset();
                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Donor_Load(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {
            DonateBlood donateBlood = new DonateBlood();
            donateBlood.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ViewDonor viewDonor = new ViewDonor();
            viewDonor.Show();
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
            ViewPatients viewPatients = new ViewPatients(); 
            viewPatients.Show();
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
