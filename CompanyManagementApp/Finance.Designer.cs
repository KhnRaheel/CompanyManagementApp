namespace CompanyManagementApp
{
    partial class Finance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.btnSaveEmployee = new System.Windows.Forms.Button();
            this.btnViewEmployees = new System.Windows.Forms.Button();
            this.dtpJoiningDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(147, 53);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(170, 20);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtDesignation
            // 
            this.txtDesignation.Location = new System.Drawing.Point(517, 55);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(202, 20);
            this.txtDesignation.TabIndex = 1;
            this.txtDesignation.TextChanged += new System.EventHandler(this.txtDesignation_TextChanged);
            // 
            // btnSaveEmployee
            // 
            this.btnSaveEmployee.Location = new System.Drawing.Point(201, 161);
            this.btnSaveEmployee.Name = "btnSaveEmployee";
            this.btnSaveEmployee.Size = new System.Drawing.Size(75, 23);
            this.btnSaveEmployee.TabIndex = 2;
            this.btnSaveEmployee.Text = "Save";
            this.btnSaveEmployee.UseVisualStyleBackColor = true;
            this.btnSaveEmployee.Click += new System.EventHandler(this.btnSaveEmployee_Click);
            // 
            // btnViewEmployees
            // 
            this.btnViewEmployees.Location = new System.Drawing.Point(473, 161);
            this.btnViewEmployees.Name = "btnViewEmployees";
            this.btnViewEmployees.Size = new System.Drawing.Size(75, 23);
            this.btnViewEmployees.TabIndex = 3;
            this.btnViewEmployees.Text = "View";
            this.btnViewEmployees.UseVisualStyleBackColor = true;
            this.btnViewEmployees.Click += new System.EventHandler(this.btnViewEmployees_Click);
            // 
            // dtpJoiningDate
            // 
            this.dtpJoiningDate.Location = new System.Drawing.Point(258, 107);
            this.dtpJoiningDate.Name = "dtpJoiningDate";
            this.dtpJoiningDate.Size = new System.Drawing.Size(200, 20);
            this.dtpJoiningDate.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(45, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(382, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Designation ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(95, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Date of Joining ";
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(67, 238);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(672, 212);
            this.crystalReportViewer1.TabIndex = 9;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // Finance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpJoiningDate);
            this.Controls.Add(this.btnViewEmployees);
            this.Controls.Add(this.btnSaveEmployee);
            this.Controls.Add(this.txtDesignation);
            this.Controls.Add(this.txtName);
            this.Name = "Finance";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.Button btnSaveEmployee;
        private System.Windows.Forms.Button btnViewEmployees;
        private System.Windows.Forms.DateTimePicker dtpJoiningDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}