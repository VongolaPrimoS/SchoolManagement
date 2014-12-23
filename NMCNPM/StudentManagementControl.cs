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
    public partial class StudentManagementControl : UserControl
    {
        public StudentManagementControl()
        {
            InitializeComponent();
            LoadDGVStudent();
            //MessageBox.Show(_getAllStudentQuery.ToList()[0].gt.ToString());
        }

        private void LoadDGVStudent()
        {
            var _getAllStudentQuery = from StudentData in frmLogin._database.GetTable<HOCSINH>()
                                      select new Student
                                      {
                                          IdStudent = StudentData.mahs,
                                          NameStudent = StudentData.tenhs,
                                          SexStudent = StudentData.gt.ToString(),
                                          DateOfBirth = StudentData.ngaysinh.Value,
                                          FatherName = StudentData.tencha,
                                          MotherName = StudentData.tenme,
                                          PhoneNumber = StudentData.sdt,
                                          Address = StudentData.diachi,
                                      };

            dGVStudentManagement.DataSource = _getAllStudentQuery;
        }

        private void StudentManagementControl_Load(object sender, EventArgs e)
        {
            //var Query = from User in frmLogin._database.GetTable<TAIKHOAN>()
            //            from TypeUser in frmLogin._database.GetTable<LOAINGUOIDUNG>()
            //            where User.maloai == TypeUser.maloai
            //            select new { UserName = User.username, Password = User.pass, TypeUser = TypeUser.tenloai };
            //dGVUser.DataSource = Query;
            
        }

        private void dGVStudentManagement_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex!=-1)
            {
                txtIDStudent.Text = dGVStudentManagement.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtFullName.Text = dGVStudentManagement.Rows[e.RowIndex].Cells[1].Value.ToString();
                dtpDOB.Value = DateTime.Parse(dGVStudentManagement.Rows[e.RowIndex].Cells[3].Value.ToString());
                txtFatherName.Text = dGVStudentManagement.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtMotherName.Text = dGVStudentManagement.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtPhoneNumber.Text = dGVStudentManagement.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtAddress.Text = dGVStudentManagement.Rows[e.RowIndex].Cells[7].Value.ToString();
                if (dGVStudentManagement.Rows[e.RowIndex].Cells[2].Value.ToString()=="Male")
                {
                    txtSex.SelectedIndex = 0 ;
                }
                else
                {
                    txtSex.SelectedIndex = 1;
                }
                
            }
            
        }

        private void btnNewStudent_Click(object sender, EventArgs e)
        {
            ChangeNewStudentStt(true);
            btnNewStudent.Enabled = false;
            btnTestID.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void ChangeNewStudentStt(bool _isNew)
        {
            txtIDStudent.Enabled = _isNew;
            txtAddress.Enabled = !txtIDStudent.Enabled;
            txtFatherName.Enabled = !txtIDStudent.Enabled;
            txtFullName.Enabled = !txtIDStudent.Enabled;
            txtMotherName.Enabled = !txtIDStudent.Enabled;
            txtPhoneNumber.Enabled = !txtIDStudent.Enabled;
            txtSex.Enabled = !txtIDStudent.Enabled;
            dtpDOB.Enabled = !txtIDStudent.Enabled;
            if (!_isNew)
            {
                txtAddress.Clear();
                txtFatherName.Clear();
                txtFullName.Clear();
                txtMotherName.Clear();
                txtPhoneNumber.Clear();
                this.dtpDOB.Value = new DateTime(DateTime.Now.Year - 15, 1, 1);
            }
        }

        private void btnTestID_Click(object sender, EventArgs e)
        {
            var Query = from _IStudent in frmLogin._database.HOCSINHs
                        where _IStudent.mahs == txtIDStudent.Text
                        select _IStudent;
            if (Query.ToList().Count()!=0)
            {
                MessageBox.Show("Cannot Use ID");
            }
            else
            {
                MessageBox.Show("ID Can Use. Continue Type Another Infomation");
                ChangeNewStudentStt(false);
                btnTestID.Enabled = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ChangeNewStudentStt(false);
            btnCancel.Enabled = false;
            btnNewStudent.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Update Student
            if (btnNewStudent.Enabled)
            {
                //TAIKHOAN _iUser = frmLogin._database.TAIKHOANs.Single(p => p.username == txtUser.Text);
                HOCSINH _iStudent = frmLogin._database.HOCSINHs.Single(p => p.mahs == txtIDStudent.Text);
                _iStudent.tenhs = txtFullName.Text;
                _iStudent.ngaysinh = dtpDOB.Value;
                _iStudent.tencha = txtFatherName.Text;
                _iStudent.tenme = txtMotherName.Text;
                _iStudent.sdt = txtPhoneNumber.Text;
                _iStudent.diachi = txtAddress.Text;

                if (txtSex.SelectedItem.ToString() == "Male")
                {
                    _iStudent.gt = true;
                }
                else
                {
                    _iStudent.gt = false;
                }
                frmLogin._database.SubmitChanges();
                
            }
            else //Add New Student
            {
                HOCSINH _iStudent = new HOCSINH();
                _iStudent.mahs = txtIDStudent.Text;
                _iStudent.tenhs = txtFullName.Text;
                _iStudent.ngaysinh = dtpDOB.Value;
                _iStudent.tencha = txtFatherName.Text;
                _iStudent.tenme = txtMotherName.Text;
                _iStudent.sdt = txtPhoneNumber.Text;
                _iStudent.diachi = txtAddress.Text;
                frmLogin._database.HOCSINHs.InsertOnSubmit(_iStudent);
                TAIKHOAN _iUser = new TAIKHOAN();
                _iUser.username = txtIDStudent.Text;
                _iUser.maloai = "HS";
                frmLogin._database.TAIKHOANs.InsertOnSubmit(_iUser);
                frmLogin._database.SubmitChanges();
                btnNewStudent.Enabled = true;
                btnCancel.Enabled = false;
                frmAdmin._userManagementControl.LoadUserData();
            }
            LoadDGVStudent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var _iDiem = from _diemData in frmLogin._database.DIEMs
                         where _diemData.mahs == txtIDStudent.Text
                         select _diemData;
            var _iPhanLop = from _phanlopData in frmLogin._database.PHANLOPs
                            where _phanlopData.mahs == txtIDStudent.Text
                            select _phanlopData;

            var _iKQHKMonHoc = from _kqhkMonHoc in frmLogin._database.KQHKMONHOCs
                               where _kqhkMonHoc.mahs == txtIDStudent.Text
                               select _kqhkMonHoc;
            var _iKQHKTongHop = from _kqhkTongHop in frmLogin._database.KQHKTONGHOPs
                                where _kqhkTongHop.mahs == txtIDStudent.Text
                                select _kqhkTongHop;

            var _iKQNHTongHop = from _kqnhTongHop in frmLogin._database.KQNHTONGHOPs
                                where _kqnhTongHop.mahs == txtIDStudent.Text
                                select _kqnhTongHop;
            var _iKQNHMonHoc = from _kqnhMonHoc in frmLogin._database.KQNHMONHOCs
                               where _kqnhMonHoc.mahs == txtIDStudent.Text
                               select _kqnhMonHoc;

            TAIKHOAN _iUser = frmLogin._database.TAIKHOANs.Single(p => p.username == txtIDStudent.Text);

            DialogResult _dialogResult = MessageBox.Show("Do you want to delete student ?", "Confirm", MessageBoxButtons.YesNo);
            if (_dialogResult==DialogResult.Yes)
            {
                try
                {
                    foreach (var _diemItem in _iDiem.ToList())
                    {
                        frmLogin._database.DIEMs.DeleteOnSubmit(_diemItem);
                    }
                    foreach (var _phanLopItem in _iPhanLop.ToList())
                    {
                        frmLogin._database.PHANLOPs.DeleteOnSubmit(_phanLopItem);
                    }
                    foreach (var _kqhkMonHoc in _iKQHKMonHoc.ToList())
                    {
                        frmLogin._database.KQHKMONHOCs.DeleteOnSubmit(_kqhkMonHoc);
                    }
                    foreach (var _kqhkTongHop in _iKQHKTongHop.ToList())
                    {
                        frmLogin._database.KQHKTONGHOPs.DeleteOnSubmit(_kqhkTongHop);
                    }
                    foreach (var _kqnhMonHoc in _iKQNHMonHoc.ToList())
                    {
                        frmLogin._database.KQNHMONHOCs.DeleteOnSubmit(_kqnhMonHoc);
                    }
                    foreach (var _kqnhTongHop in _iKQNHTongHop)
                    {
                        frmLogin._database.KQNHTONGHOPs.DeleteOnSubmit(_kqnhTongHop);
                    }
                    frmLogin._database.TAIKHOANs.DeleteOnSubmit(_iUser);
                    HOCSINH _iStudent = frmLogin._database.HOCSINHs.Single(p => p.mahs == txtIDStudent.Text);
                    frmLogin._database.HOCSINHs.DeleteOnSubmit(_iStudent);
                    frmLogin._database.SubmitChanges();
                    LoadDGVStudent();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                frmAdmin._userManagementControl.LoadUserData();
            }
        }

    }
}
