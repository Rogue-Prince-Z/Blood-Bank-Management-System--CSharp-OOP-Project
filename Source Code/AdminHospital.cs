using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BloodBankManagementSystem
{
    public partial class AdminHospital : Form
    {
        public AdminHospital()
        {
            InitializeComponent();
        }

        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\Desktop\BloodBankManagementSystem\BloodBankDatabase.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";
        
        private void AdminHospital_Load(object sender, EventArgs e)
        {
            PopulateHospitals();
        }

        private void PopulateHospitals()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM HospitalTable";
                    using (SqlDataAdapter sda = new SqlDataAdapter(query, con))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        HDGV.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading hospitals: " + ex.Message);
            }
        }

        private void Reset()
        {
            HNameTb.Text = "";
            HPassTb.Text = "";
            key = 0;
        }

        private int key = 0;

        private void HDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && HDGV.Rows[e.RowIndex].Cells[0].Value != null)
            {
                HNameTb.Text = HDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
                HPassTb.Text = HDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
                key = Convert.ToInt32(HDGV.Rows[e.RowIndex].Cells[0].Value);
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(HNameTb.Text) || string.IsNullOrWhiteSpace(HPassTb.Text))
            {
                MessageBox.Show("Missing Information!!");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "INSERT INTO HospitalTable (HospitalName, HospitalPass) VALUES (@name, @pass)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@name", HNameTb.Text);
                        cmd.Parameters.AddWithValue("@pass", HPassTb.Text);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Hospital Successfully Saved!!");
                Reset();
                PopulateHospitals();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving hospital: " + ex.Message);
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (key == 0 || string.IsNullOrWhiteSpace(HNameTb.Text) || string.IsNullOrWhiteSpace(HPassTb.Text))
            {
                MessageBox.Show("Missing Information!!");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "UPDATE HospitalTable SET HospitalName = @name, HospitalPass = @pass WHERE HNum = @key";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@name", HNameTb.Text);
                        cmd.Parameters.AddWithValue("@pass", HPassTb.Text);
                        cmd.Parameters.AddWithValue("@key", key);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Hospital Successfully Updated!!");
                Reset();
                PopulateHospitals();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating hospital: " + ex.Message);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("First Select The Hospital To Delete!!");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "DELETE FROM HospitalTable WHERE HNum = @key";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@key", key);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Hospital Successfully Deleted!!");
                Reset();
                PopulateHospitals();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting hospital: " + ex.Message);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.Show();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            Admin user = new Admin();
            user.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            AdminRequest adminRequest = new AdminRequest();
            adminRequest.Show();
            this.Hide();
        }
    }
}
