namespace NMCNPM
{
    partial class frmAdmin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTerm = new System.Windows.Forms.Button();
            this.btnClass = new System.Windows.Forms.Button();
            this.btnTeacherManagement = new System.Windows.Forms.Button();
            this.btnStudentManagement = new System.Windows.Forms.Button();
            this.btnUserManagement = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTeacherSchedule = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnTerm);
            this.panel1.Controls.Add(this.btnClass);
            this.panel1.Controls.Add(this.btnTeacherSchedule);
            this.panel1.Controls.Add(this.btnTeacherManagement);
            this.panel1.Controls.Add(this.btnStudentManagement);
            this.panel1.Controls.Add(this.btnUserManagement);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1260, 56);
            this.panel1.TabIndex = 0;
            // 
            // btnTerm
            // 
            this.btnTerm.Location = new System.Drawing.Point(150, 12);
            this.btnTerm.Name = "btnTerm";
            this.btnTerm.Size = new System.Drawing.Size(123, 33);
            this.btnTerm.TabIndex = 0;
            this.btnTerm.Text = "Quản Lý Khóa Học";
            this.btnTerm.UseVisualStyleBackColor = true;
            this.btnTerm.Click += new System.EventHandler(this.btnTerm_Click);
            // 
            // btnClass
            // 
            this.btnClass.Location = new System.Drawing.Point(289, 12);
            this.btnClass.Name = "btnClass";
            this.btnClass.Size = new System.Drawing.Size(123, 33);
            this.btnClass.TabIndex = 0;
            this.btnClass.Text = "Quản Lý Lớp";
            this.btnClass.UseVisualStyleBackColor = true;
            this.btnClass.Click += new System.EventHandler(this.btnClass_Click);
            // 
            // btnTeacherManagement
            // 
            this.btnTeacherManagement.Location = new System.Drawing.Point(967, 12);
            this.btnTeacherManagement.Name = "btnTeacherManagement";
            this.btnTeacherManagement.Size = new System.Drawing.Size(123, 33);
            this.btnTeacherManagement.TabIndex = 0;
            this.btnTeacherManagement.Text = "Quản Lý Giáo Viên";
            this.btnTeacherManagement.UseVisualStyleBackColor = true;
            this.btnTeacherManagement.Click += new System.EventHandler(this.btnTeacherManagement_Click);
            // 
            // btnStudentManagement
            // 
            this.btnStudentManagement.Location = new System.Drawing.Point(428, 12);
            this.btnStudentManagement.Name = "btnStudentManagement";
            this.btnStudentManagement.Size = new System.Drawing.Size(123, 33);
            this.btnStudentManagement.TabIndex = 0;
            this.btnStudentManagement.Text = "Quản Lý Sinh Viên";
            this.btnStudentManagement.UseVisualStyleBackColor = true;
            this.btnStudentManagement.Click += new System.EventHandler(this.btnStudentManagement_Click);
            // 
            // btnUserManagement
            // 
            this.btnUserManagement.Location = new System.Drawing.Point(12, 12);
            this.btnUserManagement.Name = "btnUserManagement";
            this.btnUserManagement.Size = new System.Drawing.Size(123, 33);
            this.btnUserManagement.TabIndex = 0;
            this.btnUserManagement.Text = "Quản Lý User";
            this.btnUserManagement.UseVisualStyleBackColor = true;
            this.btnUserManagement.Click += new System.EventHandler(this.btnUserManagement_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1260, 605);
            this.panel2.TabIndex = 1;
            // 
            // btnTeacherSchedule
            // 
            this.btnTeacherSchedule.Location = new System.Drawing.Point(1096, 12);
            this.btnTeacherSchedule.Name = "btnTeacherSchedule";
            this.btnTeacherSchedule.Size = new System.Drawing.Size(123, 33);
            this.btnTeacherSchedule.TabIndex = 0;
            this.btnTeacherSchedule.Text = "Phân công giảng dạy";
            this.btnTeacherSchedule.UseVisualStyleBackColor = true;
            this.btnTeacherSchedule.Click += new System.EventHandler(this.btnTeacherSchedule_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 661);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdmin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAdmin_FormClosed);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUserManagement;
        private System.Windows.Forms.Button btnStudentManagement;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTeacherManagement;
        private System.Windows.Forms.Button btnClass;
        private System.Windows.Forms.Button btnTerm;
        private System.Windows.Forms.Button btnTeacherSchedule;
    }
}