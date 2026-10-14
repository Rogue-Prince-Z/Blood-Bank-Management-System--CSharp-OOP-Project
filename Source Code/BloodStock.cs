using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BloodBankManagementSystem
{
    public partial class BloodStock : Form
    {
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\Desktop\BloodBankManagementSystem\BloodBankDatabase.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";

        public BloodStock()
        {
            InitializeComponent();
        }

        private void BloodStock_Load(object sender, EventArgs e)
        {
            LoadBloodStock();
        }

        private void LoadBloodStock()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM BloodTable";
                    using (SqlDataAdapter sda = new SqlDataAdapter(query, con))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        BloodStockDGV.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading blood stock: " + ex.Message);
            }
        }

        private void DBGroupCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DBGroupCb.SelectedItem == null)
                return;

            string grp = DBGroupCb.SelectedItem.ToString();
            
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM BloodTable WHERE BGroup = @group";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@group", grp);
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            BloodStockDGV.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering blood stock: " + ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            OpenNewForm(new Donor());
        }

        private void label17_Click(object sender, EventArgs e)
        {
            OpenNewForm(new DonateBlood());
        }

        private void label3_Click(object sender, EventArgs e)
        {
            OpenNewForm(new ViewDonor());
        }

        private void label5_Click(object sender, EventArgs e)
        {
            OpenNewForm(new Patient());
        }

        private void label6_Click(object sender, EventArgs e)
        {
            OpenNewForm(new ViewPatients());
        }

        private void label4_Click(object sender, EventArgs e)
        {
            OpenNewForm(new BloodTransfer());
        }

        private void label9_Click(object sender, EventArgs e)
        {
            OpenNewForm(new Login());
        }

        private void label10_Click(object sender, EventArgs e)
        {
            LoadBloodStock();
        }

        private void OpenNewForm(Form newForm)
        {
            newForm.Show();
            this.Hide();
        }
    }
}
