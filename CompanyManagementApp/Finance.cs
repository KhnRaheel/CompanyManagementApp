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
using System.Configuration;
using CrystalDecisions.CrystalReports.Engine;
using System.IO;


namespace CompanyManagementApp
{
    public partial class Finance : Form
    {
        string connStr = "Data Source=HP;Initial Catalog=ERPDB;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;";

        public Finance()
        {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDesignation_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveEmployee_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtDesignation.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"
                    INSERT INTO Employees (CompanyID, Name, Designation, DateOfJoining)
                    VALUES (@cid, @n, @d, @j)", conn);

                cmd.Parameters.AddWithValue("@cid", Session.CompanyID);
                cmd.Parameters.AddWithValue("@n", txtName.Text);
                cmd.Parameters.AddWithValue("@d", txtDesignation.Text);
                cmd.Parameters.AddWithValue("@j", dtpJoiningDate.Value);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Employee added successfully.");
                txtName.Clear();
                txtDesignation.Clear();
                dtpJoiningDate.Value = DateTime.Today;
            }
        }

        private void btnViewEmployees_Click(object sender, EventArgs e)
        {
            string reportPath = Path.Combine(Application.StartupPath, "EmployeeReport.rpt");

            if (!File.Exists(reportPath))
            {
                MessageBox.Show("Report file not found:\n" + reportPath);
                return;
            }

            ReportDocument rpt = new ReportDocument();
            rpt.Load(reportPath); 

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlDataAdapter da = new SqlDataAdapter(@"
            SELECT Name, Designation, DateOfJoining
            FROM Employees
            WHERE CompanyID = @cid ", conn);

                da.SelectCommand.Parameters.AddWithValue("@cid", Session.CompanyID);

                DataSet ds = new DataSet();
                da.Fill(ds, "Employees");

                rpt.SetDataSource(ds.Tables["Employees"]);

                // Set the existing CrystalReportViewer's source
                crystalReportViewer1.ReportSource = rpt;
                crystalReportViewer1.Refresh();
            }
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
