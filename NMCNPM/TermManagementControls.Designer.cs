namespace NMCNPM
{
    partial class TermManagementControls
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
            this.dgvTerm = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnTestID = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNameTerm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTerm)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTerm
            // 
            this.dgvTerm.AllowUserToAddRows = false;
            this.dgvTerm.AllowUserToDeleteRows = false;
            this.dgvTerm.AllowUserToResizeColumns = false;
            this.dgvTerm.AllowUserToResizeRows = false;
            this.dgvTerm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTerm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTerm.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvTerm.Location = new System.Drawing.Point(41, 100);
            this.dgvTerm.MultiSelect = false;
            this.dgvTerm.Name = "dgvTerm";
            this.dgvTerm.ReadOnly = true;
            this.dgvTerm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTerm.Size = new System.Drawing.Size(470, 259);
            this.dgvTerm.TabIndex = 0;
            this.dgvTerm.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTerm_CellClick);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(188, 15);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(167, 20);
            this.txtID.TabIndex = 1;
            // 
            // btnTestID
            // 
            this.btnTestID.Enabled = false;
            this.btnTestID.Location = new System.Drawing.Point(361, 14);
            this.btnTestID.Name = "btnTestID";
            this.btnTestID.Size = new System.Drawing.Size(76, 23);
            this.btnTestID.TabIndex = 2;
            this.btnTestID.Text = "Kiểm Tra Mã";
            this.btnTestID.UseVisualStyleBackColor = true;
            this.btnTestID.Click += new System.EventHandler(this.btnTestID_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã Khóa";
            // 
            // txtNameTerm
            // 
            this.txtNameTerm.Location = new System.Drawing.Point(188, 41);
            this.txtNameTerm.Name = "txtNameTerm";
            this.txtNameTerm.Size = new System.Drawing.Size(249, 20);
            this.txtNameTerm.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Khóa";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(280, 67);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(361, 67);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(118, 67);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(199, 67);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // TermManagementControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTestID);
            this.Controls.Add(this.txtNameTerm);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dgvTerm);
            this.Name = "TermManagementControls";
            this.Size = new System.Drawing.Size(555, 383);
            this.Load += new System.EventHandler(this.TermManagementControls_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTerm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTerm;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnTestID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNameTerm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnCancel;
    }
}
