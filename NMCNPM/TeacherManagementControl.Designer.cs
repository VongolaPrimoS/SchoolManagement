namespace NMCNPM
{
    partial class TeacherManagementControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ngay_vao_lam = new System.Windows.Forms.DateTimePicker();
            this.ngay_sinh = new System.Windows.Forms.DateTimePicker();
            this.button4 = new System.Windows.Forms.Button();
            this.sua = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.them = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.hinh_anh = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.so_dien_thoai = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dia_chi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bo_mon = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gioi_tinh = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ho_ten = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.GVtable = new System.Windows.Forms.DataGridView();
            this.magv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVtable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(-206, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 468);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(243, 493);
            this.panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ngay_vao_lam);
            this.groupBox1.Controls.Add(this.ngay_sinh);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.sua);
            this.groupBox1.Controls.Add(this.xoa);
            this.groupBox1.Controls.Add(this.them);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.hinh_anh);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.so_dien_thoai);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dia_chi);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.bo_mon);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.gioi_tinh);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ho_ten);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 486);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thong Tin";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ngay_vao_lam
            // 
            this.ngay_vao_lam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngay_vao_lam.Location = new System.Drawing.Point(85, 113);
            this.ngay_vao_lam.Name = "ngay_vao_lam";
            this.ngay_vao_lam.Size = new System.Drawing.Size(142, 20);
            this.ngay_vao_lam.TabIndex = 22;
            // 
            // ngay_sinh
            // 
            this.ngay_sinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngay_sinh.Location = new System.Drawing.Point(85, 81);
            this.ngay_sinh.Name = "ngay_sinh";
            this.ngay_sinh.Size = new System.Drawing.Size(142, 20);
            this.ngay_sinh.TabIndex = 21;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(200, 254);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(27, 20);
            this.button4.TabIndex = 20;
            this.button4.Text = "...";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // sua
            // 
            this.sua.Location = new System.Drawing.Point(152, 430);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(67, 50);
            this.sua.TabIndex = 19;
            this.sua.Text = "Sua";
            this.sua.UseVisualStyleBackColor = true;
            this.sua.Click += new System.EventHandler(this.sua_Click);
            // 
            // xoa
            // 
            this.xoa.Location = new System.Drawing.Point(79, 430);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(67, 50);
            this.xoa.TabIndex = 18;
            this.xoa.Text = "Xoa";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // them
            // 
            this.them.Location = new System.Drawing.Point(6, 430);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(67, 50);
            this.them.TabIndex = 17;
            this.them.Text = "Them";
            this.them.UseVisualStyleBackColor = true;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Location = new System.Drawing.Point(127, 298);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(101, 116);
            this.panel4.TabIndex = 16;
            // 
            // hinh_anh
            // 
            this.hinh_anh.Location = new System.Drawing.Point(85, 254);
            this.hinh_anh.Name = "hinh_anh";
            this.hinh_anh.Size = new System.Drawing.Size(110, 20);
            this.hinh_anh.TabIndex = 15;
            this.hinh_anh.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Hinh Anh:";
            // 
            // so_dien_thoai
            // 
            this.so_dien_thoai.Location = new System.Drawing.Point(85, 220);
            this.so_dien_thoai.Name = "so_dien_thoai";
            this.so_dien_thoai.Size = new System.Drawing.Size(143, 20);
            this.so_dien_thoai.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "So Dien Thoai:";
            // 
            // dia_chi
            // 
            this.dia_chi.Location = new System.Drawing.Point(85, 185);
            this.dia_chi.Name = "dia_chi";
            this.dia_chi.Size = new System.Drawing.Size(143, 20);
            this.dia_chi.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Dia Chi:";
            // 
            // bo_mon
            // 
            this.bo_mon.FormattingEnabled = true;
            this.bo_mon.Location = new System.Drawing.Point(85, 149);
            this.bo_mon.Name = "bo_mon";
            this.bo_mon.Size = new System.Drawing.Size(143, 21);
            this.bo_mon.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Bo Mon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ngay Vao Lam:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngay Sinh:";
            // 
            // gioi_tinh
            // 
            this.gioi_tinh.FormattingEnabled = true;
            this.gioi_tinh.Items.AddRange(new object[] {
            "Nam",
            "Nu"});
            this.gioi_tinh.Location = new System.Drawing.Point(85, 50);
            this.gioi_tinh.Name = "gioi_tinh";
            this.gioi_tinh.Size = new System.Drawing.Size(143, 21);
            this.gioi_tinh.Sorted = true;
            this.gioi_tinh.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gioi Tinh:";
            // 
            // ho_ten
            // 
            this.ho_ten.Location = new System.Drawing.Point(85, 17);
            this.ho_ten.Name = "ho_ten";
            this.ho_ten.Size = new System.Drawing.Size(143, 20);
            this.ho_ten.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ho Ten: ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.GVtable);
            this.panel3.Location = new System.Drawing.Point(249, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(944, 490);
            this.panel3.TabIndex = 2;
            // 
            // GVtable
            // 
            this.GVtable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVtable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.magv,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.GVtable.Location = new System.Drawing.Point(4, 3);
            this.GVtable.Name = "GVtable";
            this.GVtable.Size = new System.Drawing.Size(937, 487);
            this.GVtable.TabIndex = 0;
            this.GVtable.SelectionChanged += new System.EventHandler(this.GVtable_SelectionChanged);
            // 
            // magv
            // 
            this.magv.HeaderText = "Ma Giao Vien";
            this.magv.Name = "magv";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ho Ten";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Gioi Tinh";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ngay Sinh";
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Ngay Vao Lam";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Bo Mon";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Dia Chi";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "So Dien Thoai";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Hinh Anh";
            this.Column9.Name = "Column9";
            // 
            // TeacherManagementControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "TeacherManagementControl";
            this.Size = new System.Drawing.Size(1196, 493);
            this.Load += new System.EventHandler(this.TeacherManagementControl_Load);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GVtable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox bo_mon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox gioi_tinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ho_ten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox hinh_anh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox so_dien_thoai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox dia_chi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button sua;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView GVtable;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn magv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewImageColumn Column9;
        private System.Windows.Forms.DateTimePicker ngay_sinh;
        private System.Windows.Forms.DateTimePicker ngay_vao_lam;
    }
}
