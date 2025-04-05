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

namespace CompanyManagementApp
{
    public partial class Login : Form
    {
        string connStr = "Data Source=HP;Initial Catalog=ERPDB;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;";

        public Login()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCompanies();
        }
        private void LoadCompanies()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT CompanyID, CompanyName FROM Companies", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbCompany.DataSource = dt;
                cbCompany.DisplayMember = "CompanyName";
                cbCompany.ValueMember = "CompanyID";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textUser.Text.Trim();
            string password = textPassword.Text;
            int companyId = Convert.ToInt32(cbCompany.SelectedValue);

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"
                    SELECT UserID FROM Users
                    WHERE Name = @u AND PasswordHash = @p AND CompanyID = @c AND IsActive = 1", conn);
                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@p", password);
                cmd.Parameters.AddWithValue("@c", companyId);

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    Session.UserID = Convert.ToInt32(result);
                    Session.CompanyID = companyId;

                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username, password, or company.");
                }
            }
        }

     

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttoncancel_Click(object sender, EventArgs e)
        {

        }

        private void cbCompany_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
