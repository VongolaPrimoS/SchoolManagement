namespace NMCNPM
{
    partial class GroupStudentControl
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSourceFind = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbSourceGrade = new System.Windows.Forms.ComboBox();
            this.cbbSourceTerm = new System.Windows.Forms.ComboBox();
            this.cbbSourceClass = new System.Windows.Forms.ComboBox();
            this.dgvSource = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDesFind = new System.Windows.Forms.Button();
            this.dGVDes = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbDesGrade = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbDesTerm = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbDesClass = new System.Windows.Forms.ComboBox();
            this.btnGroupStudent = new System.Windows.Forms.Button();
            this.btnUnGroup = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSourceFind);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbbSourceGrade);
            this.groupBox1.Controls.Add(this.cbbSourceTerm);
            this.groupBox1.Controls.Add(this.cbbSourceClass);
            this.groupBox1.Controls.Add(this.dgvSource);
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 512);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Source Student";
            // 
            // btnSourceFind
            // 
            this.btnSourceFind.Location = new System.Drawing.Point(361, 30);
            this.btnSourceFind.Name = "btnSourceFind";
            this.btnSourceFind.Size = new System.Drawing.Size(88, 48);
            this.btnSourceFind.TabIndex = 3;
            this.btnSourceFind.Text = "Find";
            this.btnSourceFind.UseVisualStyleBackColor = true;
            this.btnSourceFind.Click += new System.EventHandler(this.btnSourceFind_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Class";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Grade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Term";
            // 
            // cbbSourceGrade
            // 
            this.cbbSourceGrade.FormattingEnabled = true;
            this.cbbSourceGrade.Location = new System.Drawing.Point(84, 45);
            this.cbbSourceGrade.Name = "cbbSourceGrade";
            this.cbbSourceGrade.Size = new System.Drawing.Size(257, 21);
            this.cbbSourceGrade.TabIndex = 1;
            this.cbbSourceGrade.SelectedIndexChanged += new System.EventHandler(this.cbbSourceGrade_SelectedIndexChanged);
            // 
            // cbbSourceTerm
            // 
            this.cbbSourceTerm.FormattingEnabled = true;
            this.cbbSourceTerm.Location = new System.Drawing.Point(84, 19);
            this.cbbSourceTerm.Name = "cbbSourceTerm";
            this.cbbSourceTerm.Size = new System.Drawing.Size(257, 21);
            this.cbbSourceTerm.TabIndex = 1;
            this.cbbSourceTerm.SelectedIndexChanged += new System.EventHandler(this.cbbSourceTerm_SelectedIndexChanged);
            // 
            // cbbSourceClass
            // 
            this.cbbSourceClass.FormattingEnabled = true;
            this.cbbSourceClass.Location = new System.Drawing.Point(84, 72);
            this.cbbSourceClass.Name = "cbbSourceClass";
            this.cbbSourceClass.Size = new System.Drawing.Size(257, 21);
            this.cbbSourceClass.TabIndex = 1;
            // 
            // dgvSource
            // 
            this.dgvSource.AllowUserToAddRows = false;
            this.dgvSource.AllowUserToDeleteRows = false;
            this.dgvSource.AllowUserToResizeColumns = false;
            this.dgvSource.AllowUserToResizeRows = false;
            this.dgvSource.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSource.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSource.Location = new System.Drawing.Point(16, 111);
            this.dgvSource.Name = "dgvSource";
            this.dgvSource.ReadOnly = true;
            this.dgvSource.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSource.Size = new System.Drawing.Size(448, 395);
            this.dgvSource.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDesFind);
            this.groupBox2.Controls.Add(this.dGVDes);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbbDesGrade);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cbbDesTerm);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbbDesClass);
            this.groupBox2.Location = new System.Drawing.Point(618, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(480, 512);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Destination Student";
            // 
            // btnDesFind
            // 
            this.btnDesFind.Location = new System.Drawing.Point(357, 30);
            this.btnDesFind.Name = "btnDesFind";
            this.btnDesFind.Size = new System.Drawing.Size(88, 48);
            this.btnDesFind.TabIndex = 3;
            this.btnDesFind.Text = "Find";
            this.btnDesFind.UseVisualStyleBackColor = true;
            this.btnDesFind.Click += new System.EventHandler(this.btnDesFind_Click);
            // 
            // dGVDes
            // 
            this.dGVDes.AllowUserToAddRows = false;
            this.dGVDes.AllowUserToDeleteRows = false;
            this.dGVDes.AllowUserToResizeColumns = false;
            this.dGVDes.AllowUserToResizeRows = false;
            this.dGVDes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVDes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Column2});
            this.dGVDes.Location = new System.Drawing.Point(19, 111);
            this.dGVDes.Name = "dGVDes";
            this.dGVDes.ReadOnly = true;
            this.dGVDes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVDes.Size = new System.Drawing.Size(444, 395);
            this.dGVDes.TabIndex = 0;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "ID Student";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name Student";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Flag";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Class";
            // 
            // cbbDesGrade
            // 
            this.cbbDesGrade.FormattingEnabled = true;
            this.cbbDesGrade.Location = new System.Drawing.Point(83, 45);
            this.cbbDesGrade.Name = "cbbDesGrade";
            this.cbbDesGrade.Size = new System.Drawing.Size(257, 21);
            this.cbbDesGrade.TabIndex = 1;
            this.cbbDesGrade.SelectedIndexChanged += new System.EventHandler(this.cbbDesGrade_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Grade";
            // 
            // cbbDesTerm
            // 
            this.cbbDesTerm.FormattingEnabled = true;
            this.cbbDesTerm.Location = new System.Drawing.Point(83, 19);
            this.cbbDesTerm.Name = "cbbDesTerm";
            this.cbbDesTerm.Size = new System.Drawing.Size(257, 21);
            this.cbbDesTerm.TabIndex = 1;
            this.cbbDesTerm.SelectedIndexChanged += new System.EventHandler(this.cbbDesTerm_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Term";
            // 
            // cbbDesClass
            // 
            this.cbbDesClass.FormattingEnabled = true;
            this.cbbDesClass.Location = new System.Drawing.Point(83, 72);
            this.cbbDesClass.Name = "cbbDesClass";
            this.cbbDesClass.Size = new System.Drawing.Size(257, 21);
            this.cbbDesClass.TabIndex = 1;
            this.cbbDesClass.SelectedIndexChanged += new System.EventHandler(this.cbbDesClass_SelectedIndexChanged);
            // 
            // btnGroupStudent
            // 
            this.btnGroupStudent.Location = new System.Drawing.Point(489, 189);
            this.btnGroupStudent.Name = "btnGroupStudent";
            this.btnGroupStudent.Size = new System.Drawing.Size(123, 38);
            this.btnGroupStudent.TabIndex = 1;
            this.btnGroupStudent.Text = "Nhận Lớp";
            this.btnGroupStudent.UseVisualStyleBackColor = true;
            this.btnGroupStudent.Click += new System.EventHandler(this.btnGroupStudent_Click);
            // 
            // btnUnGroup
            // 
            this.btnUnGroup.Location = new System.Drawing.Point(489, 332);
            this.btnUnGroup.Name = "btnUnGroup";
            this.btnUnGroup.Size = new System.Drawing.Size(123, 38);
            this.btnUnGroup.TabIndex = 1;
            this.btnUnGroup.Text = "Rời Lớp";
            this.btnUnGroup.UseVisualStyleBackColor = true;
            this.btnUnGroup.Click += new System.EventHandler(this.btnUnGroup_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(489, 233);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(123, 38);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // GroupStudentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUnGroup);
            this.Controls.Add(this.btnGroupStudent);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GroupStudentControl";
            this.Size = new System.Drawing.Size(1101, 521);
            this.Load += new System.EventHandler(this.GroupStudentControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGroupStudent;
        private System.Windows.Forms.Button btnUnGroup;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvSource;
        private System.Windows.Forms.DataGridView dGVDes;
        private System.Windows.Forms.ComboBox cbbSourceTerm;
        private System.Windows.Forms.ComboBox cbbSourceClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSourceFind;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbDesTerm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbDesClass;
        private System.Windows.Forms.Button btnDesFind;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbSourceGrade;
        private System.Windows.Forms.ComboBox cbbDesGrade;
        private System.Windows.Forms.Label label6;
    }
}
