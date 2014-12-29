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
    public partial class ClassManagementControl : UserControl
    {
        private String[] _idGrade;
        private String[] _idTeacher;
        private String[] _idTerm;
        public ClassManagementControl()
        {
            InitializeComponent();
        }
        private void ClassManagementControl_Load(object sender, EventArgs e)
        {
            dGVClassLoadData();
        }

        private void dGVClassLoadData()
        {
            var _getClassQuery = from _classResult in frmLogin._database.GetTable<LOP>()
                                 from _grade in frmLogin._database.GetTable<KHOILOP>()
                                 from _teacher in frmLogin._database.GetTable<GIAOVIEN>()
                                 from _term in frmLogin._database.GetTable<NAMHOC>()
                                 where _grade.makl == _classResult.makl && _teacher.magv == _classResult.magv && _classResult.manh==_term.manh
                                 select new ClassRoom
                                 {
                                     IdClass = _classResult.malop,
                                     NameClass = _classResult.tenlop,
                                     Sum = _classResult.siso.ToString(),
                                     Term=_term.tennh,
                                     Teacher = _teacher.tengv,
                                     Grade = _grade.tenkl
                                 };
            dgvClass.DataSource = _getClassQuery;

            cbbGrade.Items.Clear();
            var _getGradeQuery = (from _grade in frmLogin._database.GetTable<KHOILOP>() select _grade).ToList();
            _idGrade = new String[_getGradeQuery.ToList().Count];
            for (int i = 0; i < _getGradeQuery.Count; i++)
            {
                cbbGrade.Items.Add(_getGradeQuery[i].tenkl);
                _idGrade[i] = _getGradeQuery[i].makl;
            }

            cbbTeacher.Items.Clear();
            var _getTeacherQuery = (from _teacher in frmLogin._database.GetTable<GIAOVIEN>()
                                    select _teacher).ToList();
            _idTeacher = new String[_getTeacherQuery.Count];
            for (int i = 0; i < _getTeacherQuery.Count; i++)
            {
                cbbTeacher.Items.Add(_getTeacherQuery[i].tengv);
                _idTeacher[i] = _getTeacherQuery[i].magv;
            }

            cbbTerm.Items.Clear();
            var _getTermQuery = (from _term in frmLogin._database.GetTable<NAMHOC>() select _term).ToList();
            _idTerm = new String[_getTermQuery.Count];
            for (int i = 0; i < _getTermQuery.Count; i++)
            {
                _idTerm[i] = _getTermQuery[i].manh;
                cbbTerm.Items.Add(_getTermQuery[i].tennh);
            }
        }

        private void cbbGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(_idGrade[cbbGrade.SelectedIndex]);
        }

        private void cbbTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(_idTeacher[cbbTeacher.SelectedIndex]);
        }

        private void dgvClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex!=-1)
            {
                txtIDClass.Text = dgvClass.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNameClass.Text = dgvClass.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtNameClass.Tag = txtIDClass.Text;
                txtSum.Text = dgvClass.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtSum.Tag = txtSum.Text;
                for (int i = 0; i < cbbGrade.Items.Count; i++)
                {
                    if (cbbGrade.Items[i].ToString() == dgvClass.Rows[e.RowIndex].Cells[2].Value.ToString())
                    {
                        cbbGrade.SelectedIndex = i;
                        cbbGrade.Tag = i;
                        break;
                    }
                }
                for (int i = 0; i < cbbTeacher.Items.Count; i++)
                {
                    if (cbbTeacher.Items[i].ToString() == dgvClass.Rows[e.RowIndex].Cells[5].Value.ToString())
                    {
                        cbbTeacher.SelectedIndex = i;
                        cbbTeacher.Tag = i.ToString();
                       break;
                    }
                }
                for (int i = 0; i < cbbTerm.Items.Count; i++)
                {
                    if (cbbTerm.Items[i].ToString() == dgvClass.Rows[e.RowIndex].Cells[3].Value.ToString())
                    {
                        cbbTerm.SelectedIndex = i;
                        cbbTerm.Tag = i.ToString();
                        break;
                    }
                }
            }
            
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ChangeStt(true);
        }

        private void ChangeStt(bool Flag)
        {
            txtIDClass.Enabled = Flag;
            btnTest.Enabled = Flag;
            txtNameClass.Clear();
            txtNameClass.Enabled = !Flag;
            txtSum.Clear();
            txtSum.Enabled = !Flag;
            cbbTeacher.Text = "";
            cbbGrade.Text = "";
            cbbTerm.Text = "";
            cbbTerm.Enabled = !Flag;
            cbbTeacher.Enabled = !Flag;
            cbbGrade.Enabled = !Flag;
            btnCancel.Enabled = Flag;
            btnNew.Enabled = !Flag;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtIDClass.Clear();
            ChangeStt(false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!btnNew.Enabled)
            {
                if (txtIDClass.Text != "" && cbbGrade.Text != "" && cbbTeacher.Text != "" && cbbTerm.Text != "" )
                {
                    LOP _newClass = new LOP();
                    _newClass.malop = txtIDClass.Text;
                    
                    //_newClass.siso = Int32.Parse(txtSum.Text);
                    int SumClass=0;
                    bool isNum = int.TryParse(txtSum.Text, out SumClass);

                    _newClass.siso = SumClass;
                    _newClass.tenlop = txtNameClass.Text;
                    _newClass.makl = _idGrade[cbbGrade.SelectedIndex];
                    _newClass.magv = _idTeacher[cbbTeacher.SelectedIndex];
                    _newClass.manh = _idTerm[cbbTerm.SelectedIndex];
                    try
                    {
                        frmLogin._database.LOPs.InsertOnSubmit(_newClass);
                        frmLogin._database.SubmitChanges();
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }
                    finally
                    {
                        ChangeStt(false);
                        dGVClassLoadData();
                    }
                }
                else
                {
                    MessageBox.Show("Input Not Fill");
                }
            }
            else
            {
                if (txtNameClass.Text != txtNameClass.Tag.ToString() || txtSum.Text != txtNameClass.Tag.ToString() || cbbGrade.SelectedIndex.ToString() != cbbGrade.Tag.ToString() || cbbTeacher.SelectedIndex.ToString() != cbbTeacher.Tag.ToString() || cbbTerm.SelectedIndex.ToString() != cbbTeacher.Tag.ToString())
                {
                    //HOCSINH _iStudent = frmLogin._database.HOCSINHs.Single(p => p.mahs == txtIDStudent.Text);
                    LOP _iClass = frmLogin._database.LOPs.Single(p=>p.malop==txtIDClass.Text);
                    _iClass.tenlop = txtNameClass.Text;
                    _iClass.siso = Int32.Parse(txtSum.Text);
                    _iClass.makl = _idGrade[cbbGrade.SelectedIndex];
                    _iClass.magv = _idTeacher[cbbTeacher.SelectedIndex];
                    _iClass.manh = _idTerm[cbbTerm.SelectedIndex];
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
                        ChangeStt(false);
                        dGVClassLoadData();
                    }
                }
            }
            frmAdmin._groupStudentControl.LoadData();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            var _getIdClass = from P in frmLogin._database.LOPs where P.malop==txtIDClass.Text select new { ID=P.malop };
           
            
            if (_getIdClass.ToList().Count() != 0)
            {
                MessageBox.Show("Cannot Use ID");
            }
            else
            {
                MessageBox.Show("ID Can Use. Continue Type Another Infomation");
                ChangeStt(false);
                btnTest.Enabled = false;
                btnNew.Enabled = false;
               btnCancel.Enabled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var _iPhanCong = from P in frmLogin._database.GetTable<PHANCONG>()
                            where P.malop == txtIDClass.Text
                            select P;
            var _iPhanLop = from P in frmLogin._database.GetTable<PHANLOP>()
                           where P.malop == txtIDClass.Text
                           select P;
            var _iKetQuaHKTongHop = from P in frmLogin._database.GetTable<KQHKTONGHOP>()
                                    where P.malop == txtIDClass.Text
                                    select P;
            var _iKetQuaNHMonHoc = from P in frmLogin._database.GetTable<KQNHMONHOC>()
                                   where P.malop == txtIDClass.Text
                                   select P;
            var _iKetQuaHKMonHoc = from P in frmLogin._database.GetTable<KQHKMONHOC>()
                                   where P.malop == txtIDClass.Text
                                   select P;
            var _iKetQuaNHTongHop = from P in frmLogin._database.GetTable<KQNHTONGHOP>()
                                    where P.malop == txtIDClass.Text
                                    select P;
            var _iDiem = from P in frmLogin._database.GetTable<DIEM>()
                         where P.malop == txtIDClass.Text
                         select P;
            DialogResult _dialogResult = MessageBox.Show("Do you want to delete Class ?", "Confirm", MessageBoxButtons.YesNo);
            if (_dialogResult==DialogResult.Yes)
            {
                try
                {
                    frmLogin._database.PHANCONGs.DeleteAllOnSubmit(_iPhanCong);
                    frmLogin._database.PHANLOPs.DeleteAllOnSubmit(_iPhanLop);
                    frmLogin._database.KQHKMONHOCs.DeleteAllOnSubmit(_iKetQuaHKMonHoc);
                    frmLogin._database.KQNHMONHOCs.DeleteAllOnSubmit(_iKetQuaNHMonHoc);
                    frmLogin._database.KQHKTONGHOPs.DeleteAllOnSubmit(_iKetQuaHKTongHop);
                    frmLogin._database.KQNHTONGHOPs.DeleteAllOnSubmit(_iKetQuaNHTongHop);
                    frmLogin._database.DIEMs.DeleteAllOnSubmit(_iDiem);

                    LOP _deleteClass = frmLogin._database.LOPs.Single(p => p.malop == txtIDClass.Text);
                    frmLogin._database.LOPs.DeleteOnSubmit(_deleteClass);

                    frmLogin._database.SubmitChanges();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                finally
                {
                    dGVClassLoadData();
                }
            }
        }
    }
}













