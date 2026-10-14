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
    public partial class ViewPatients : Form
    {
        public ViewPatients()
        {
            InitializeComponent();
            populate();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\Desktop\BloodBankManagementSystem\BloodBankDatabase.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");

        private void populate()
        {
            Con.Open();
            string Query = "select * from PatientTable";
            SqlCommand cmd = new SqlCommand(Query, Con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            DataTable dt = ds.Tables[0];
            PatientsDGV.DataSource = dt;
            PatientsDGV.Refresh();
            Con.Close();
        }

        private void Reset()
        {
            PNameTb.Text = "";
            PAgeTb.Text = "";
            PPhoneTb.Text = "";
            PAddressTb.Text = "";
            PGenCb.SelectedIndex = -1;
            PBGroupCb.SelectedIndex = -1;
            key = 0;
        }

        int key = 0;
        private void PatientsDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                PNameTb.Text = PatientsDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
                PAgeTb.Text = PatientsDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
                PPhoneTb.Text = PatientsDGV.Rows[e.RowIndex].Cells[3].Value.ToString();
                PGenCb.SelectedItem = PatientsDGV.Rows[e.RowIndex].Cells[4].Value.ToString();
                PBGroupCb.SelectedItem = PatientsDGV.Rows[e.RowIndex].Cells[5].Value.ToString();
                PAddressTb.Text = PatientsDGV.Rows[e.RowIndex].Cells[6].Value.ToString();
                if(PNameTb.Text == "")
                {
                    key = 0;
                }
                else
                {
                    key = Convert.ToInt32(PatientsDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
                }
            }

        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if(key == 0)
            {
                MessageBox.Show("First Select The Patient To Delete");
            }
            else
            {
                try
                {
                    string query = " Delete from PatientTable where PNum = "+key+";";
                    Con.Open();
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient Successfully Deleted!!");
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

        private void ViewPatients_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Patient Pat = new Patient();
            Pat.Show();
            this.Hide();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (PNameTb.Text == "" || PPhoneTb.Text == "" || PAgeTb.Text == "" || PGenCb.SelectedIndex == -1 || PBGroupCb.SelectedIndex == -1 || PAddressTb.Text == "")
            {
                MessageBox.Show("Missing Information!!");
            }
            else
            {
                try
                {
                    string query = " update PatientTable set PName = '" + PNameTb.Text + "' , PAge = '" + PAgeTb.Text + "' , PPhone = '" + PPhoneTb.Text + "' , PGender = '" + PGenCb.SelectedItem.ToString() + "' , PBGroup = '" + PBGroupCb.SelectedItem.ToString() + "' , PAddress = '" + PAddressTb.Text + "' where PNum = '" + key + "' ";
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

        private void label6_Click(object sender, EventArgs e)
        {
            ViewPatients donor = new ViewPatients();
            donor.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            BloodStock bloodStock = new BloodStock();
            bloodStock.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
