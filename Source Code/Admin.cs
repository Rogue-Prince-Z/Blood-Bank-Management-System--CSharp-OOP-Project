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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            populate();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\Desktop\BloodBankManagementSystem\BloodBankDatabase.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");

        private void label9_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.Show();
        }

        private void Reset()
        {
            UserNameTb.Text = "";
            UserPassTb.Text = "";
            key = 0;
        }

        private void populate()
        {
            Con.Open();
            string Query = "select * from UserTable";
            SqlCommand cmd = new SqlCommand(Query, Con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            DataTable dt = ds.Tables[0];
            userDGV.DataSource = dt;
            userDGV.Refresh();
            Con.Close();
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (UserNameTb.Text == "" || UserPassTb.Text == "")
            {
                MessageBox.Show("Missing Information!!");
            }
            else
            {
                try
                {

                    string query = "insert into UserTable values('" + UserNameTb.Text + "','" + UserPassTb.Text + "')";
                    Con.Open();
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Successfully Saved!!");
                    Con.Close();
                    Reset();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        int key = 0;

        private void userDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UserNameTb.Text = userDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
            UserPassTb.Text = userDGV.Rows[e.RowIndex].Cells[2].Value.ToString();

            if (UserNameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(userDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("First Select The User To Delete!!");
            }
            else
            {
                try
                {
                    string query = " Delete from UserTable where UserNum = " + key + ";";
                    Con.Open();
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Successfully Deleted!!");
                    Con.Close();
                    Reset();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UserNameTb.Text == "" || UserPassTb.Text == "")
            {
                MessageBox.Show("Missing Information!!");
            }
            else
            {
                try
                {
                    string query = " update UserTable set UserId = '" + UserNameTb.Text + "' , UserPass = '" + UserPassTb.Text + "' where UserNum = '" + key + "' ";
                    Con.Open();
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient Successfully Updated!!");
                    Con.Close();
                    Reset();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {
            Admin user = new Admin();
            user.Show();
            this.Hide();
        }

        private void User_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            AdminRequest adminRequest = new AdminRequest();
            adminRequest.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            AdminHospital hospital = new AdminHospital();
            hospital.Show();
            this.Hide();
        }
    }
}
