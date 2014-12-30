namespace NMCNPM
{
    partial class PointManagementControl
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
            this.cbbTerm = new System.Windows.Forms.ComboBox();
            this.cbbSemester = new System.Windows.Forms.ComboBox();
            this.btnFindClass = new System.Windows.Forms.Button();
            this.dGVClass = new System.Windows.Forms.DataGridView();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGVClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbTerm
            // 
            this.cbbTerm.FormattingEnabled = true;
            this.cbbTerm.Location = new System.Drawing.Point(46, 19);
            this.cbbTerm.Name = "cbbTerm";
            this.cbbTerm.Size = new System.Drawing.Size(216, 21);
            this.cbbTerm.TabIndex = 0;
            // 
            // cbbSemester
            // 
            this.cbbSemester.FormattingEnabled = true;
            this.cbbSemester.Items.AddRange(new object[] {
            "Học Kỳ 1",
            "Học Kỳ 2"});
            this.cbbSemester.Location = new System.Drawing.Point(46, 46);
            this.cbbSemester.Name = "cbbSemester";
            this.cbbSemester.Size = new System.Drawing.Size(216, 21);
            this.cbbSemester.TabIndex = 0;
            // 
            // btnFindClass
            // 
            this.btnFindClass.Location = new System.Drawing.Point(268, 19);
            this.btnFindClass.Name = "btnFindClass";
            this.btnFindClass.Size = new System.Drawing.Size(75, 48);
            this.btnFindClass.TabIndex = 1;
            this.btnFindClass.Text = "Find Class";
            this.btnFindClass.UseVisualStyleBackColor = true;
            this.btnFindClass.Click += new System.EventHandler(this.btnFindClass_Click);
            // 
            // dGVClass
            // 
            this.dGVClass.AllowUserToAddRows = false;
            this.dGVClass.AllowUserToDeleteRows = false;
            this.dGVClass.AllowUserToResizeColumns = false;
            this.dGVClass.AllowUserToResizeRows = false;
            this.dGVClass.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVClass.Location = new System.Drawing.Point(19, 83);
            this.dGVClass.Name = "dGVClass";
            this.dGVClass.ReadOnly = true;
            this.dGVClass.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVClass.Size = new System.Drawing.Size(351, 410);
            this.dGVClass.TabIndex = 2;
            this.dGVClass.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVClass_CellClick);
            // 
            // dgvStudent
            // 
            this.dgvStudent.AllowUserToAddRows = false;
            this.dgvStudent.AllowUserToDeleteRows = false;
            this.dgvStudent.AllowUserToResizeColumns = false;
            this.dgvStudent.AllowUserToResizeRows = false;
            this.dgvStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column6,
            this.Column7,
            this.Column4,
            this.Column8,
            this.Column9,
            this.Column5});
            this.dgvStudent.Location = new System.Drawing.Point(389, 29);
            this.dgvStudent.MultiSelect = false;
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudent.Size = new System.Drawing.Size(823, 464);
            this.dgvStudent.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID Student";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name Student";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "PreTest1";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "PreTest2";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "PreTest3";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "MidTest1";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "MidTest2";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "MidTest3";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "FinalTest";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // PointManagementControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.dGVClass);
            this.Controls.Add(this.btnFindClass);
            this.Controls.Add(this.cbbSemester);
            this.Controls.Add(this.cbbTerm);
            this.Name = "PointManagementControl";
            this.Size = new System.Drawing.Size(1246, 513);
            ((System.ComponentModel.ISupportInitialize)(this.dGVClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbTerm;
        private System.Windows.Forms.ComboBox cbbSemester;
        private System.Windows.Forms.Button btnFindClass;
        private System.Windows.Forms.DataGridView dGVClass;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;

    }
}
