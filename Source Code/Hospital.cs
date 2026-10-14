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
    public partial class Hospital : Form
    {
        public Hospital()
        {
            InitializeComponent();
            fillHospitalCb();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\Desktop\BloodBankManagementSystem\BloodBankDatabase.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");

        private void fillHospitalCb()
        {
            try
            {
                Con.Open();
                string query = "select HNum, HospitalId from HospitalTable";
                SqlCommand cmd = new SqlCommand(query, Con);
                SqlDataReader rdr;
                rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("HNum", typeof(int));
                dt.Columns.Add("HospitalId", typeof(string));
                dt.Load(rdr);
                HospitalIdCb.ValueMember = "HNum";
                HospitalIdCb.DataSource = dt;
                HospitalIdCb.SelectedIndex = -1;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Con.Close();
        }

        

        private void GetData()
        {
            if (HospitalIdCb.SelectedValue != null)
            {
                try
                {
                    //Helps to get the actual Hospital Name

                    Con.Open();
                    string query = " select * from HospitalTable where HNum = '" + HospitalIdCb.SelectedValue.ToString() + "' ";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    DataTable dt = new DataTable();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        HNameTb.Text = dr["HospitalId"].ToString();
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Con.Close();
            }
            else
            {
                MessageBox.Show("Please select a valid hospital.");
            }

        }
        private void Hospital_Load(object sender, EventArgs e)
        {

        }
        int stock;
        private void GetStock(string Bgroup)
        {
            //Helps to get the actual stock of Blood based on particular Blood Group

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

        private void HospitalIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetData();
        }

        private void Reset()
        {
            HospitalIdCb.SelectedIndex = -1;
            BGroupCb.SelectedIndex = -1;
            HNameTb.Text = "";
            AvailableLbl.Visible = false;
            RequestBtn.Visible = false;
        }

        private void RequestBtn_Click(object sender, EventArgs e)
        {
            if (HNameTb.Text == "")
            {
                MessageBox.Show("Missing Information!!");
            }
            else
            {
                try
                {

                    string query = "insert into RequestTable values('" + HNameTb.Text + "','" + BGroupCb.SelectedItem.ToString() + "', '')";
                    Con.Open();
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Request Sent Successfully!!");
                    Con.Close();
                    Reset();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void BGroupCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (BGroupCb.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select A Blood Group To Proceed!!");
            }
            else
            {
                GetStock(BGroupCb.SelectedItem.ToString());
                if (stock > 0)
                {
                    RequestBtn.Visible = true;
                    AvailableLbl.Text = "Available";
                    AvailableLbl.Visible = true;
                }
                else
                {
                    RequestBtn.Visible = false;
                    AvailableLbl.Text = "Stock Not Available";
                    AvailableLbl.Visible = true;
                }
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
