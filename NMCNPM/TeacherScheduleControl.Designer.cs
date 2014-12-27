namespace NMCNPM
{
    partial class TeacherScheduleControl
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sua = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.them = new System.Windows.Forms.Button();
            this.lop = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.khoi_lop = new System.Windows.Forms.ComboBox();
            this.hoc_ky = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nam_hoc = new System.Windows.Forms.ComboBox();
            this.mon_hoc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ten_giao_vien = new System.Windows.Forms.ComboBox();
            this.ma_giao_vien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PCTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.xoa_tim_kiem = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tiem_kiem = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCTable)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 388);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sua);
            this.groupBox1.Controls.Add(this.xoa);
            this.groupBox1.Controls.Add(this.them);
            this.groupBox1.Controls.Add(this.lop);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.khoi_lop);
            this.groupBox1.Controls.Add(this.hoc_ky);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.nam_hoc);
            this.groupBox1.Controls.Add(this.mon_hoc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ten_giao_vien);
            this.groupBox1.Controls.Add(this.ma_giao_vien);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 382);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thong Tin Phan Cong";
            // 
            // sua
            // 
            this.sua.Location = new System.Drawing.Point(188, 311);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(78, 53);
            this.sua.TabIndex = 17;
            this.sua.Text = "Sua";
            this.sua.UseVisualStyleBackColor = true;
            this.sua.Click += new System.EventHandler(this.sua_Click);
            // 
            // xoa
            // 
            this.xoa.Location = new System.Drawing.Point(93, 311);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(81, 53);
            this.xoa.TabIndex = 16;
            this.xoa.Text = "Xoa";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // them
            // 
            this.them.Location = new System.Drawing.Point(6, 311);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(75, 53);
            this.them.TabIndex = 1;
            this.them.Text = "Them";
            this.them.UseVisualStyleBackColor = true;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // lop
            // 
            this.lop.FormattingEnabled = true;
            this.lop.Location = new System.Drawing.Point(93, 229);
            this.lop.Name = "lop";
            this.lop.Size = new System.Drawing.Size(173, 21);
            this.lop.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Lop: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Khoi Lop:";
            // 
            // khoi_lop
            // 
            this.khoi_lop.FormattingEnabled = true;
            this.khoi_lop.Location = new System.Drawing.Point(93, 196);
            this.khoi_lop.Name = "khoi_lop";
            this.khoi_lop.Size = new System.Drawing.Size(173, 21);
            this.khoi_lop.TabIndex = 12;
            // 
            // hoc_ky
            // 
            this.hoc_ky.FormattingEnabled = true;
            this.hoc_ky.Location = new System.Drawing.Point(93, 164);
            this.hoc_ky.Name = "hoc_ky";
            this.hoc_ky.Size = new System.Drawing.Size(173, 21);
            this.hoc_ky.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Hoc Ky:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nam Hoc: ";
            // 
            // nam_hoc
            // 
            this.nam_hoc.FormattingEnabled = true;
            this.nam_hoc.Location = new System.Drawing.Point(93, 128);
            this.nam_hoc.Name = "nam_hoc";
            this.nam_hoc.Size = new System.Drawing.Size(173, 21);
            this.nam_hoc.TabIndex = 8;
            // 
            // mon_hoc
            // 
            this.mon_hoc.Enabled = false;
            this.mon_hoc.FormattingEnabled = true;
            this.mon_hoc.Location = new System.Drawing.Point(93, 93);
            this.mon_hoc.Name = "mon_hoc";
            this.mon_hoc.Size = new System.Drawing.Size(173, 21);
            this.mon_hoc.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mon Hoc: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ten Giao Vien:";
            // 
            // ten_giao_vien
            // 
            this.ten_giao_vien.FormattingEnabled = true;
            this.ten_giao_vien.Location = new System.Drawing.Point(93, 19);
            this.ten_giao_vien.Name = "ten_giao_vien";
            this.ten_giao_vien.Size = new System.Drawing.Size(173, 21);
            this.ten_giao_vien.TabIndex = 1;
            this.ten_giao_vien.SelectedIndexChanged += new System.EventHandler(this.ten_giao_vien_SelectedIndexChanged);
            // 
            // ma_giao_vien
            // 
            this.ma_giao_vien.Enabled = false;
            this.ma_giao_vien.Location = new System.Drawing.Point(93, 55);
            this.ma_giao_vien.Name = "ma_giao_vien";
            this.ma_giao_vien.Size = new System.Drawing.Size(173, 20);
            this.ma_giao_vien.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ma Giao Vien: ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.PCTable);
            this.panel2.Location = new System.Drawing.Point(281, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(691, 352);
            this.panel2.TabIndex = 1;
            // 
            // PCTable
            // 
            this.PCTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PCTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.PCTable.Location = new System.Drawing.Point(0, 0);
            this.PCTable.Name = "PCTable";
            this.PCTable.Size = new System.Drawing.Size(691, 352);
            this.PCTable.TabIndex = 0;
            this.PCTable.SelectionChanged += new System.EventHandler(this.PCTable_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ma Phan Cong";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nam Hoc";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Khoi Lop";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Hoc Ky";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Ten Lop";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Mon Hoc";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Ma Giao Vien";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Ten Giao Vien";
            this.Column8.Name = "Column8";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.xoa_tim_kiem);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.tiem_kiem);
            this.panel3.Location = new System.Drawing.Point(281, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(691, 26);
            this.panel3.TabIndex = 0;
            // 
            // xoa_tim_kiem
            // 
            this.xoa_tim_kiem.Location = new System.Drawing.Point(363, 3);
            this.xoa_tim_kiem.Name = "xoa_tim_kiem";
            this.xoa_tim_kiem.Size = new System.Drawing.Size(88, 20);
            this.xoa_tim_kiem.TabIndex = 3;
            this.xoa_tim_kiem.Text = "Xoa Tim Kiem";
            this.xoa_tim_kiem.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(4, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(271, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // tiem_kiem
            // 
            this.tiem_kiem.Location = new System.Drawing.Point(281, 3);
            this.tiem_kiem.Name = "tiem_kiem";
            this.tiem_kiem.Size = new System.Drawing.Size(75, 20);
            this.tiem_kiem.TabIndex = 1;
            this.tiem_kiem.Text = "Tim Kiem";
            this.tiem_kiem.UseVisualStyleBackColor = true;
            // 
            // TeacherScheduleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "TeacherScheduleControl";
            this.Size = new System.Drawing.Size(975, 391);
            this.Load += new System.EventHandler(this.TeacherScheduleControl_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PCTable)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ten_giao_vien;
        private System.Windows.Forms.TextBox ma_giao_vien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox mon_hoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox hoc_ky;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox nam_hoc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox khoi_lop;
        private System.Windows.Forms.Button sua;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.ComboBox lop;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button tiem_kiem;
        private System.Windows.Forms.DataGridView PCTable;
        private System.Windows.Forms.Button xoa_tim_kiem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}
