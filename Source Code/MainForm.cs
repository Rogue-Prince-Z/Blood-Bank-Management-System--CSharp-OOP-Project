using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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

        private void label7_Click(object sender, EventArgs e)
        {
            DonateBlood donateBlood = new DonateBlood();    
            donateBlood.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ViewDonor VD = new ViewDonor();    
            VD.Show();  
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
    }
}
