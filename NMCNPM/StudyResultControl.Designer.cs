namespace NMCNPM
{
    partial class StudyResultControl
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
            this.cbbClass = new System.Windows.Forms.ComboBox();
            this.cbbHK = new System.Windows.Forms.ComboBox();
            this.btnLook = new System.Windows.Forms.Button();
            this.dgvPoint = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoint)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbClass
            // 
            this.cbbClass.FormattingEnabled = true;
            this.cbbClass.Location = new System.Drawing.Point(326, 14);
            this.cbbClass.Name = "cbbClass";
            this.cbbClass.Size = new System.Drawing.Size(204, 21);
            this.cbbClass.TabIndex = 0;
            this.cbbClass.SelectedIndexChanged += new System.EventHandler(this.cbbClass_SelectedIndexChanged);
            // 
            // cbbHK
            // 
            this.cbbHK.FormattingEnabled = true;
            this.cbbHK.Items.AddRange(new object[] {
            "Học kì 1",
            "Học kì 2"});
            this.cbbHK.Location = new System.Drawing.Point(326, 41);
            this.cbbHK.Name = "cbbHK";
            this.cbbHK.Size = new System.Drawing.Size(204, 21);
            this.cbbHK.TabIndex = 1;
            // 
            // btnLook
            // 
            this.btnLook.Location = new System.Drawing.Point(536, 14);
            this.btnLook.Name = "btnLook";
            this.btnLook.Size = new System.Drawing.Size(98, 48);
            this.btnLook.TabIndex = 2;
            this.btnLook.Text = "Look";
            this.btnLook.UseVisualStyleBackColor = true;
            this.btnLook.Click += new System.EventHandler(this.btnLook_Click);
            // 
            // dgvPoint
            // 
            this.dgvPoint.AllowUserToAddRows = false;
            this.dgvPoint.AllowUserToDeleteRows = false;
            this.dgvPoint.AllowUserToResizeColumns = false;
            this.dgvPoint.AllowUserToResizeRows = false;
            this.dgvPoint.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPoint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPoint.Location = new System.Drawing.Point(116, 71);
            this.dgvPoint.Name = "dgvPoint";
            this.dgvPoint.ReadOnly = true;
            this.dgvPoint.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPoint.Size = new System.Drawing.Size(743, 434);
            this.dgvPoint.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Semester";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Class";
            // 
            // StudyResultControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPoint);
            this.Controls.Add(this.btnLook);
            this.Controls.Add(this.cbbHK);
            this.Controls.Add(this.cbbClass);
            this.Name = "StudyResultControl";
            this.Size = new System.Drawing.Size(977, 505);
            this.Load += new System.EventHandler(this.StudyResultControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbClass;
        private System.Windows.Forms.ComboBox cbbHK;
        private System.Windows.Forms.Button btnLook;
        private System.Windows.Forms.DataGridView dgvPoint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
