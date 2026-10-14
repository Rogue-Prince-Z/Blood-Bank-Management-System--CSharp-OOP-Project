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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\Desktop\BloodBankManagementSystem\BloodBankDatabase.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");


        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (chooserCb.SelectedIndex != -1)
            {
                string selectedRole = chooserCb.SelectedItem.ToString(); // ComboBox containing User, Admin, Hospital
                string id = EmpIdTb.Text;
                string pass = EmpPassTb.Text;

                if (EmpIdTb.Text == "" || EmpPassTb.Text == "")
                {
                    MessageBox.Show("Please Enter Both ID and Password!!");
                }

                switch (selectedRole)
                {
                    case "User":
                        Logintry1("UserTable", id, pass);
                        break;

                    case "Admin":
                        Logintry2("AdminTable", id, pass);
                        break;

                    case "Hospital":
                        Logintry3("HospitalTable", id, pass);
                        break;

                    default:
                        MessageBox.Show("Please select a valid role!");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Please select a valid role!");
            }
        }

        private void Logintry1(string tableName, string id, string pass)
        {
            try
            {
                Con.Open();
                string query = $"SELECT * FROM {tableName} WHERE UserId = '" + id + "' AND UserPass = '" + pass + "'";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@pass", pass);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show($"Login Successful as {chooserCb.SelectedItem}!");
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid ID or Password!");
                }

                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Logintry2(string tableName, string id, string pass)
        {
            try
            {
                Con.Open();
                string query = $"SELECT * FROM {tableName} WHERE AdminId = '" + id + "' AND AdminPass = '" + pass + "'";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@pass", pass);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show($"Login Successful as {chooserCb.SelectedItem}!");
                    Admin user = new Admin();
                    user.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid ID or Password!");
                }

                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Logintry3(string tableName, string id, string pass)
        {
            try
            {
                Con.Open();
                string query = $"SELECT * FROM {tableName} WHERE HospitalId = '" + id + "' AND HospitalPass = '" + pass + "'";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@pass", pass);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show($"Login Successful as {chooserCb.SelectedItem}!");
                    Hospital hospital = new Hospital();
                    hospital.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid ID or Password!");
                }

                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
