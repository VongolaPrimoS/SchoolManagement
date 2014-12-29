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
    public partial class GroupStudentControl : UserControl
    {
        public GroupStudentControl()
        {
            InitializeComponent();
            LoadData();
        }

        private String[] _idSourceTerm;
        private String[] _idSourceGrade;
        private String[] _idSourceClass;
        private String[] _idDesTerm;
        private String[] _idDesGrade;
        private String[] _idDesClass;

        public void LoadData()
        {
            //Load Data For Term
            var _getSourceTerm = (from P in frmLogin._database.NAMHOCs select P).ToList();
            cbbSourceTerm.Items.Clear();
            cbbDesTerm.Items.Clear();
            _idSourceTerm = new String[_getSourceTerm.Count];
            for (int i = 0; i < _getSourceTerm.Count; i++)
            {
                cbbSourceTerm.Items.Add(_getSourceTerm[i].tennh);
                cbbDesTerm.Items.Add(_getSourceTerm[i].tennh);
                _idSourceTerm[i] = _getSourceTerm[i].manh;
            }
            cbbSourceTerm.Items.Add("Học Sinh Mới");
            _idDesTerm = _idSourceTerm;

            //Load Data For Grade
            var _getGrade=(from P in frmLogin._database.KHOILOPs select P).ToList();
            cbbDesClass.Items.Clear();
            cbbDesGrade.Items.Clear();
            _idSourceGrade = new String[_getGrade.Count];
            for (int i = 0; i < _getGrade.Count; i++)
            {
                _idSourceGrade[i] = _getGrade[i].makl;
                cbbSourceGrade.Items.Add(_getGrade[i].tenkl);
                cbbDesGrade.Items.Add(_getGrade[i].tenkl);
            }
            _idDesGrade = _idSourceGrade;
        }

        private void GroupStudentControl_Load(object sender, EventArgs e)
        {

        }

        private void cbbSourceTerm_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbSourceClass.Text = "";
            cbbSourceGrade.Text = "";
            if (cbbSourceTerm.Text=="Học Sinh Mới")
            {
                cbbSourceClass.Enabled = false;
                cbbSourceGrade.Enabled = false; 
            }
            else
            {
                cbbSourceClass.Enabled = true;
                cbbSourceGrade.Enabled = true;
                var _getSourceClass = (from P in frmLogin._database.LOPs where P.manh == _idSourceTerm[cbbSourceTerm.SelectedIndex] select P).ToList();
                _idSourceClass = new String[_getSourceClass.Count];
                cbbSourceClass.Items.Clear();
                for (int i = 0; i < _getSourceClass.Count; i++)
                {
                    cbbSourceClass.Items.Add(_getSourceClass[i].tenlop);
                    _idSourceClass[i] = _getSourceClass[i].malop;
                }
            }
        }

        private void cbbSourceGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbSourceClass.Text = "";
            cbbSourceClass.Items.Clear();
            var _getSourceClass = (from P in frmLogin._database.LOPs 
                                   where P.manh == _idSourceTerm[cbbSourceTerm.SelectedIndex] && P.makl==_idSourceGrade[cbbSourceGrade.SelectedIndex]
                                   select P).ToList();
            for (int i = 0; i < _getSourceClass.Count; i++)
            {
                cbbSourceClass.Items.Add(_getSourceClass[i].tenlop);
                _idSourceClass[i] = _getSourceClass[i].malop;
            }
        }

        private void btnSourceFind_Click(object sender, EventArgs e)
        {
            if (cbbSourceTerm.Text=="Học Sinh Mới")
            {
                var _getOldStudent = from P in frmLogin._database.PHANLOPs select new { ID =P.mahs};
                var _getAllStudentQuery = from StudentData in frmLogin._database.GetTable<HOCSINH>()
                                      select new
                                      {
                                          IdStudent = StudentData.mahs,
                                          NameStudent = StudentData.tenhs
                                      };
                dgvSource.DataSource = _getAllStudentQuery;
                for (int i = 0; i < dgvSource.Rows.Count; i++)
                {
                    foreach (var _compareItem in _getOldStudent)
                    {
                        if (dgvSource.Rows[i].Cells[0].Value.ToString()==_compareItem.ID)
                        {
                            dgvSource.Rows.Remove(dgvSource.Rows[i]);
                            i--;
                            break;
                        }
                    }
                }
            }
            else
            {
                if (cbbSourceClass.Text != "" && cbbSourceTerm.Text != "")
                {
                    var _getOldStudent = from P in frmLogin._database.GetTable<PHANLOP>()
                                         join Q in frmLogin._database.GetTable<HOCSINH>()
                                         on P.mahs equals Q.mahs
                                         where P.manh == _idSourceTerm[cbbSourceTerm.SelectedIndex] && P.malop == _idSourceClass[cbbSourceClass.SelectedIndex]
                                         select new
                                         {
                                             IdStudent = P.mahs,
                                             NameStudent=Q.tenhs
                                         };

                    dgvSource.DataSource = _getOldStudent;
                }
            }
        }

        private void cbbDesTerm_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbDesClass.Text = "";
            var _getDesClass = (from P in frmLogin._database.LOPs where P.manh == _idDesTerm[cbbDesTerm.SelectedIndex] select P).ToList();
            _idDesClass = new String[_getDesClass.Count];
            cbbDesClass.Items.Clear();
            for (int i = 0; i < _getDesClass.Count; i++)
            {
                cbbDesClass.Items.Add(_getDesClass[i].tenlop);
                _idDesClass[i] = _getDesClass[i].malop;
            }
        }


        private void cbbDesGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbDesClass.Text = "";
            cbbDesClass.Items.Clear();
            var _getDesClass = (from P in frmLogin._database.LOPs
                                where P.manh == _idDesTerm[cbbDesTerm.SelectedIndex] && P.makl == _idDesGrade[cbbDesGrade.SelectedIndex]
                                select P).ToList();
            for (int i = 0; i < _getDesClass.Count; i++)
            {
                cbbDesClass.Items.Add(_getDesClass[i].tenlop);
                _idDesClass[i] = _getDesClass[i].malop;
            }
        }

        private void btnDesFind_Click(object sender, EventArgs e)
        {
            dGVDes.Rows.Clear();
            if (cbbDesClass.Text != "" && cbbDesTerm.Text != "")
            {
                var _getOldStudent = from P in frmLogin._database.GetTable<PHANLOP>()
                                     join Q in frmLogin._database.GetTable<HOCSINH>()
                                     on P.mahs equals Q.mahs
                                     where P.manh == _idDesTerm[cbbDesTerm.SelectedIndex] && P.malop == _idDesClass[cbbDesClass.SelectedIndex]
                                     select new
                                     {
                                         P.mahs,
                                         Q.tenhs
                                     };

                foreach (var _oldStudentItem in _getOldStudent.ToList())
                {
                    dGVDes.Rows.Add(_oldStudentItem.mahs, _oldStudentItem.tenhs,"1");
                }
            }
        }

        private void btnGroupStudent_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow _dgvSourceItem in dgvSource.SelectedRows)
            {
                bool _isAccept = true;
                foreach (DataGridViewRow _dgvDesItem in dGVDes.Rows)
                {
                    if (_dgvDesItem.Cells[0].Value.ToString()==_dgvSourceItem.Cells[0].Value.ToString())
                    {
                        _isAccept = false;
                        break;
                    }
                }
                if (_isAccept)
                {
                    dGVDes.Rows.Add(_dgvSourceItem.Cells[0].Value.ToString(), _dgvSourceItem.Cells[1].Value.ToString());
                    dgvSource.Rows.Remove(_dgvSourceItem);
                }
                else
                {
                    MessageBox.Show("Student " + _dgvSourceItem.Cells[0].Value.ToString() + " Is Exists");
                }   
            }
        }

        private void btnUnGroup_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow _dgvDesItem in dGVDes.SelectedRows)
            {
                DialogResult _dialogResult = MessageBox.Show("Do you want to remove "+_dgvDesItem.Cells[1].Value.ToString()+" from "+cbbDesClass.Text+" ?", "Confirm", MessageBoxButtons.YesNo);
                if (_dialogResult==DialogResult.Yes)
                {
                    var _getStudent = from P in frmLogin._database.PHANLOPs
                                      where P.mahs == _dgvDesItem.Cells[0].Value.ToString()
                                      select P;
                    if (_getStudent.ToList().Count==1)
                    {
                        try
                        {
                            frmLogin._database.PHANLOPs.DeleteAllOnSubmit(_getStudent);
                            frmLogin._database.SubmitChanges();
                        }
                        catch (Exception Ex)
                        {
                            MessageBox.Show(Ex.Message);
                        }
                    }
                    dGVDes.Rows.Remove(_dgvDesItem);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbbDesClass.Text != "" && cbbDesTerm.Text != "" && cbbDesGrade.Text!="")
            {
                foreach (DataGridViewRow _studentDesItem in dGVDes.Rows)
                {
                    if (_studentDesItem.Cells[2].Value == null)
                    {
                        var _checkClassQuery = (from P in frmLogin._database.GetTable<PHANLOP>()
                                                where P.mahs == _studentDesItem.Cells[0].Value.ToString()
                                                select P).ToList();
                        if (_checkClassQuery.Count == 1)
                        {
                            _checkClassQuery[0].manh = _idDesTerm[cbbDesTerm.SelectedIndex];
                            _checkClassQuery[0].makl = _idDesGrade[cbbDesGrade.SelectedIndex];
                            _checkClassQuery[0].malop = _idDesClass[cbbDesClass.SelectedIndex];
                        }
                        else
                        {
                            PHANLOP _newMember = new PHANLOP();
                            _newMember.mahs = _studentDesItem.Cells[0].Value.ToString();
                            _newMember.manh = _idDesTerm[cbbDesTerm.SelectedIndex];
                            _newMember.malop = _idDesClass[cbbDesClass.SelectedIndex];
                            _newMember.makl = _idDesGrade[cbbDesGrade.SelectedIndex];
                            frmLogin._database.PHANLOPs.InsertOnSubmit(_newMember);
                        }
                    }
                }
                try
                {
                    frmLogin._database.SubmitChanges();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void cbbDesClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            var _getGradeQuery = (from P in frmLogin._database.GetTable<LOP>()
                                 where P.malop == _idDesClass[cbbDesClass.SelectedIndex]
                                 select P.makl).ToList();
            for (int i = 0; i < _idDesGrade.Count(); i++)
            {
                if (_idDesGrade[i]==_getGradeQuery[0])
                {
                    cbbDesGrade.SelectedIndex = i;
                }
            }
        }



        

    }
}
