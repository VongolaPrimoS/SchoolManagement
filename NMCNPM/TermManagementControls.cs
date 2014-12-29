using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NMCNPM.Class;
namespace NMCNPM
{
    public partial class TermManagementControls : UserControl
    {
        public TermManagementControls()
        {
            InitializeComponent();
            dGVTermLoadData();
        }

        private void dGVTermLoadData()
        {
            var _getTermQuery = from _getTerm in frmLogin._database.GetTable<NAMHOC>()
                                select new Term { IdTerm = _getTerm.manh, NameTerm = _getTerm.tennh };
            dgvTerm.DataSource = _getTermQuery;
        }

        private void TermManagementControls_Load(object sender, EventArgs e)
        {

        }

        private void dgvTerm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(e.RowIndex.ToString());
            if (e.RowIndex!=-1)
            {
                txtID.Text = dgvTerm.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNameTerm.Text = dgvTerm.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ChangeSttControl(true);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ChangeSttControl(false);
        }

        private void btnTestID_Click(object sender, EventArgs e)
        {
            var Term = from _Term in frmLogin._database.GetTable<NAMHOC>()
                       where _Term.manh == txtID.Text
                       select _Term;
            if (Term.ToList().Count==0)
            {
                MessageBox.Show("ID Term Is Accepted");
                txtNameTerm.Enabled = true;
                txtID.Enabled = false;
            }
            else
            {
                MessageBox.Show("ID Term Exised");
            }
            
        }   

        private void ChangeSttControl(bool Flag)
        {
            txtID.Clear();
            txtNameTerm.Clear();
            btnNew.Enabled = !Flag;
            txtID.Enabled = Flag;
            txtNameTerm.Enabled = !Flag;
            btnCancel.Enabled = Flag;
            btnTestID.Enabled = Flag;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            NAMHOC _deleteTerm = frmLogin._database.NAMHOCs.Single(p => p.manh == txtID.Text);
            DialogResult _dialogResult = MessageBox.Show("Do you want to delete term "+txtID.Text+"?", "Confirm", MessageBoxButtons.YesNo);
            if (_dialogResult==DialogResult.Yes)
            {
                try
                {
                    frmLogin._database.NAMHOCs.DeleteOnSubmit(_deleteTerm);
                    frmLogin._database.SubmitChanges();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                finally
                {
                    dGVTermLoadData();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!btnNew.Enabled)
            {
                NAMHOC _newTerm = new NAMHOC();
                _newTerm.manh = txtID.Text;
                _newTerm.tennh = txtNameTerm.Text;
                try
                {
                    frmLogin._database.NAMHOCs.InsertOnSubmit(_newTerm);
                    frmLogin._database.SubmitChanges();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                finally
                {
                    dGVTermLoadData();
                    ChangeSttControl(false);
                    MessageBox.Show("New Term Create Successfull");
                }
            }
            else
            {
                if (txtID.Text != "")
                {
                    NAMHOC _editTerm = frmLogin._database.NAMHOCs.Single(p => p.manh == txtID.Text);
                    _editTerm.tennh = txtNameTerm.Text;
                    DialogResult _dialogResult = MessageBox.Show("Do you want to edit term ?", "Confirm", MessageBoxButtons.YesNo);
                    if (_dialogResult == DialogResult.Yes)
                    {
                        try
                        {
                            frmLogin._database.SubmitChanges();
                        }
                        catch (Exception Ex)
                        {
                            MessageBox.Show(Ex.Message);
                        }
                        finally
                        {
                            dGVTermLoadData();
                        }
                    }
                }
            }
        }
    }
}
