using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BloodBankManagementSystem
{
    public partial class ViewDonor : Form
    {
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\Desktop\BloodBankManagementSystem\BloodBankDatabase.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";

        public ViewDonor()
        {
            InitializeComponent();
        }

        private void ViewDonor_Load(object sender, EventArgs e)
        {
            PopulateDonorList();
        }

        private void PopulateDonorList()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM DonorTable";
                    using (SqlDataAdapter sda = new SqlDataAdapter(query, con))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        DonorDGV.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading donor list: " + ex.Message);
            }
        }

        private void SearchDonor()
        {
            if (string.IsNullOrWhiteSpace(SearchTb.Text))
            {
                MessageBox.Show("Please enter a donor name to search.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM DonorTable WHERE DName = @DName";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@DName", SearchTb.Text);
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            DonorDGV.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching donor: " + ex.Message);
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            SearchDonor();
        }

        private void OpenNewForm(Form newForm)
        {
            newForm.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e) => OpenNewForm(new Donor());
        private void label17_Click(object sender, EventArgs e) => OpenNewForm(new DonateBlood());
        private void label6_Click(object sender, EventArgs e) => OpenNewForm(new ViewPatients());
        private void label10_Click(object sender, EventArgs e) => OpenNewForm(new BloodStock());
        private void label4_Click(object sender, EventArgs e) => OpenNewForm(new BloodTransfer());
        private void label9_Click(object sender, EventArgs e) => OpenNewForm(new Login());
        private void label5_Click(object sender, EventArgs e) => OpenNewForm(new Patient());

        private void label3_Click(object sender, EventArgs e)
        {
            PopulateDonorList();
        }
    }
}
