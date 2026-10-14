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
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\Desktop\BloodBankManagementSystem\BloodBankDatabase.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");

        private void Reset()
        {
            PNameTb.Text = "";
            PAgeTb.Text = "";
            PPhoneTb.Text = "";
            PAddressTb.Text = "";
            PGenCb.SelectedIndex = -1;
            PBGroupCb.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PNameTb.Text == "" || PPhoneTb.Text == "" || PAgeTb.Text == "" || PGenCb.SelectedIndex == -1 || PBGroupCb.SelectedIndex == -1 || PAddressTb.Text == "" )
            {
                MessageBox.Show("Missing Information!!");
            }
            else
            {
                try
                {
                    string query = "insert into PatientTable values('" + PNameTb.Text + "','" + PAgeTb.Text + "','" + PPhoneTb.Text + "','" + PGenCb.SelectedItem.ToString() + "','" + PBGroupCb.SelectedItem.ToString() + "','" + PAddressTb.Text + "')";
                    Con.Open();
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient Successfully Saved!!");
                    Con.Close();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            ViewPatients VP = new ViewPatients();
            this.Hide();
            VP.Show();
            
        }

        private void Patient_Load(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            BloodTransfer Bt = new BloodTransfer();
            Bt.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            patient.Show();
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
            ViewDonor Vd = new ViewDonor();
            Vd.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            BloodStock bloodStock = new BloodStock();
            bloodStock.Show();
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
