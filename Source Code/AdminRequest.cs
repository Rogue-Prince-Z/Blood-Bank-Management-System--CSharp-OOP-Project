using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class AdminRequest : Form
    {
        public AdminRequest()
        {
            InitializeComponent();
            populate();
            bloodStock();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\Desktop\BloodBankManagementSystem\BloodBankDatabase.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");

        private void bloodStock()
        {
            Con.Open();
            string Query = "select * from BloodTable";
            SqlCommand cmd = new SqlCommand(Query, Con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            DataTable dt = ds.Tables[0];
            BloodStockDGV.DataSource = dt;
            BloodStockDGV.Refresh();
            Con.Close();
        }
        private void populate()
        {
            Con.Open();
            string Query = "select * from RequestTable";
            SqlCommand cmd = new SqlCommand(Query, Con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            DataTable dt = ds.Tables[0];
            ReqDGV.DataSource = dt;
            ReqDGV.Refresh();
            Con.Close();
        }
        private void AdminRequest_Load(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            AdminRequest admin = new AdminRequest();
            admin.Show();
            this.Hide();
        }

        private void ReqDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ReqNoTb.Text = ReqDGV.Rows[e.RowIndex].Cells[0].Value.ToString();
            HNameTb.Text = ReqDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
            BGroupTb.Text = ReqDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
            GetStock(BGroupTb.Text);
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
        private void Reset()
        {
            HNameTb.Text = "";
            BGroupTb.Text = "";
            ReqNoTb.Text = "";
        }
        private void updateStock()
        {
            int newstock = stock - 1;
            try
            {

                string query = " update BloodTable set BStock = '" + newstock + "' where BGroup = '" + BGroupTb.Text + "' ";
                Con.Open();
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void ApproveBtn_Click(object sender, EventArgs e)
        {
            if (HNameTb.Text == "")
            {
                MessageBox.Show("Select A Request Please!!");
            }
            else
            {
                try
                {
                    string query1 = "select ApprovalState from RequestTable where RequestNum = '" + ReqNoTb.Text + "' ";
                    Con.Open();
                    SqlCommand cmd1 = new SqlCommand(query1, Con);
                    SqlDataReader rdr = cmd1.ExecuteReader();
                    if (rdr.Read())
                    {
                        string approvalState = rdr["ApprovalState"].ToString();
                        if (approvalState == "Approved" || approvalState == "Rejected")
                        {
                            MessageBox.Show("Request already processed: " + approvalState);
                            Con.Close();
                            return;
                        }
                    }
                    rdr.Close();
                    Con.Close();

                    if (stock > 0)
                    {
                        string query = "update RequestTable set ApprovalState = 'Approved' where RequestNum = '"+ ReqNoTb .Text+ "'";
                        Con.Open();
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Request Approved!!");
                        Con.Close();

                        GetStock(BGroupTb.Text);
                        updateStock();
                        Reset();
                        populate();
                        bloodStock();
                    }
                    else
                    {
                        MessageBox.Show("Insufficient Stock!!");
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void RejectBtn_Click(object sender, EventArgs e)
        {
            if (HNameTb.Text == "")
            {
                MessageBox.Show("Select A Request Please!!");
            }
            else
            {
                try
                {
                    string query1 = "select ApprovalState from RequestTable where RequestNum = '" + ReqNoTb.Text + "' ";
                    Con.Open();
                    SqlCommand cmd1 = new SqlCommand(query1, Con);
                    SqlDataReader rdr = cmd1.ExecuteReader();
                    if (rdr.Read())
                    {
                        string approvalState = rdr["ApprovalState"].ToString();
                        if (approvalState == "Approved" || approvalState == "Rejected")
                        {
                            MessageBox.Show("Request already processed: " + approvalState);
                            Con.Close();
                            return;
                        }
                    }
                    rdr.Close();
                    Con.Close();

                    string query = "update RequestTable set ApprovalState = 'Rejected' where RequestNum = '" + ReqNoTb.Text + "'";
                    Con.Open();
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Request Rejected!!");
                    Con.Close();
                    GetStock(BGroupTb.Text);
                    Reset();
                    populate();
                    bloodStock();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (HNameTb.Text == "")
            {
                MessageBox.Show("Select A Request Please!!");
            }
            else
            {
                try
                {
                    DialogResult result = MessageBox.Show("Are You Sure You Want To Delete The Request Data?",
                                      "Delete Confirmation",
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        string query = " Delete from RequestTable where RequestNum = " + ReqNoTb.Text + ";";
                        Con.Open();
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Request Deleted!!");
                        Con.Close();
                        GetStock(BGroupTb.Text);
                        Reset();
                        populate();
                        bloodStock();
                    }
                    
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            AdminHospital ad = new AdminHospital();
            ad.Show();
            this.Hide();
        }


    }
}
