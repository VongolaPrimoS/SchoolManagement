namespace NMCNPM
{
    partial class StudentManagementControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dGVStudentManagement = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnTestID = new System.Windows.Forms.Button();
            this.btnNewStudent = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtIDStudent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMotherName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSex = new System.Windows.Forms.ComboBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVStudentManagement)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVStudentManagement
            // 
            this.dGVStudentManagement.AllowUserToAddRows = false;
            this.dGVStudentManagement.AllowUserToDeleteRows = false;
            this.dGVStudentManagement.AllowUserToResizeColumns = false;
            this.dGVStudentManagement.AllowUserToResizeRows = false;
            this.dGVStudentManagement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVStudentManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVStudentManagement.Location = new System.Drawing.Point(225, 0);
            this.dGVStudentManagement.MultiSelect = false;
            this.dGVStudentManagement.Name = "dGVStudentManagement";
            this.dGVStudentManagement.ReadOnly = true;
            this.dGVStudentManagement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVStudentManagement.Size = new System.Drawing.Size(881, 516);
            this.dGVStudentManagement.TabIndex = 0;
            this.dGVStudentManagement.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVStudentManagement_CellClick);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(112, 413);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 32);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(28, 451);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 32);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnTestID
            // 
            this.btnTestID.Enabled = false;
            this.btnTestID.Location = new System.Drawing.Point(154, 43);
            this.btnTestID.Name = "btnTestID";
            this.btnTestID.Size = new System.Drawing.Size(56, 20);
            this.btnTestID.TabIndex = 1;
            this.btnTestID.Text = "Test ID";
            this.btnTestID.UseVisualStyleBackColor = true;
            this.btnTestID.Click += new System.EventHandler(this.btnTestID_Click);
            // 
            // btnNewStudent
            // 
            this.btnNewStudent.Location = new System.Drawing.Point(28, 413);
            this.btnNewStudent.Name = "btnNewStudent";
            this.btnNewStudent.Size = new System.Drawing.Size(78, 32);
            this.btnNewStudent.TabIndex = 1;
            this.btnNewStudent.Text = "New";
            this.btnNewStudent.UseVisualStyleBackColor = true;
            this.btnNewStudent.Click += new System.EventHandler(this.btnNewStudent_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(112, 451);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 32);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtIDStudent
            // 
            this.txtIDStudent.Enabled = false;
            this.txtIDStudent.Location = new System.Drawing.Point(12, 43);
            this.txtIDStudent.Name = "txtIDStudent";
            this.txtIDStudent.Size = new System.Drawing.Size(136, 20);
            this.txtIDStudent.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID Student";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(12, 86);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(198, 20);
            this.txtFullName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Full Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date of birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Father Name";
            // 
            // txtFatherName
            // 
            this.txtFatherName.Location = new System.Drawing.Point(12, 220);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(198, 20);
            this.txtFatherName.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mother Name";
            // 
            // txtMotherName
            // 
            this.txtMotherName.Location = new System.Drawing.Point(12, 264);
            this.txtMotherName.Name = "txtMotherName";
            this.txtMotherName.Size = new System.Drawing.Size(198, 20);
            this.txtMotherName.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Sex";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(12, 307);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(198, 20);
            this.txtPhoneNumber.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Phone Number";
            // 
            // txtSex
            // 
            this.txtSex.FormattingEnabled = true;
            this.txtSex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.txtSex.Location = new System.Drawing.Point(12, 125);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(198, 21);
            this.txtSex.TabIndex = 4;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(12, 172);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(200, 20);
            this.dtpDOB.TabIndex = 5;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(12, 349);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(198, 20);
            this.txtAddress.TabIndex = 2;
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(3, 333);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(45, 13);
            this.lb.TabIndex = 3;
            this.lb.Text = "Address";
            // 
            // StudentManagementControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.txtSex);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtMotherName);
            this.Controls.Add(this.txtFatherName);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtIDStudent);
            this.Controls.Add(this.btnTestID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNewStudent);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dGVStudentManagement);
            this.Name = "StudentManagementControl";
            this.Size = new System.Drawing.Size(1106, 516);
            this.Load += new System.EventHandler(this.StudentManagementControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVStudentManagement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVStudentManagement;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnTestID;
        private System.Windows.Forms.Button btnNewStudent;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtIDStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMotherName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox txtSex;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lb;
    }
}
