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
    public partial class UserManagementControl : UserControl
    {
        public UserManagementControl()
        {
            InitializeComponent();
            var Query = from User in frmLogin._database.GetTable<TAIKHOAN>()
                        from TypeUser in frmLogin._database.GetTable<LOAINGUOIDUNG>()
                        where User.maloai == TypeUser.maloai
                        select new { UserName = User.username, Password = User.pass, TypeUser = TypeUser.tenloai };
            dGVUser.DataSource = Query;
        }

        private void UserManagementControl_Load(object sender, EventArgs e)
        {
            LoadUserData();
        }

        public void LoadUserData()
        {
            var Query = from User in frmLogin._database.GetTable<TAIKHOAN>()
                        from TypeUser in frmLogin._database.GetTable<LOAINGUOIDUNG>()
                        where User.maloai == TypeUser.maloai
                        select new User { UserName = User.username, Password = User.pass, MaLoai = TypeUser.tenloai, };
            dGVUser.DataSource = Query;


            foreach (DataGridViewRow _userItem in dGVUser.Rows)
            {
                if (_userItem.Cells[3].Value.ToString() == "Học sinh")
                {
                    var _IStudent = from Student in frmLogin._database.GetTable<HOCSINH>()
                                    where Student.mahs == _userItem.Cells[1].Value.ToString()
                                    select Student;
                    _userItem.Cells[0].Value = _IStudent.ToList()[0].tenhs;
                }
                else
                {
                    if (_userItem.Cells[3].Value.ToString() == "Giáo viên")
                    {

                        var _ITeacher = from Teacher in frmLogin._database.GetTable<GIAOVIEN>()
                                        where Teacher.magv == _userItem.Cells[1].Value.ToString()
                                        select Teacher;
                        _userItem.Cells[0].Value = _ITeacher.ToList()[0].tengv;
                    }
                }
            }
        }

        private void dGVUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPassword.Clear();
            txtUser.Text = dGVUser.Rows[e.RowIndex].Cells[1].Value.ToString();
            if (dGVUser.Rows[e.RowIndex].Cells[2].Value!=null)
            {
                txtPassword.Tag = txtPassword.Text;
                txtPassword.Text = dGVUser.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            else
            {
                txtPassword.Tag = "";
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPassword.Tag.ToString()!=txtPassword.Text)
            {
                TAIKHOAN _iUser = frmLogin._database.TAIKHOANs.Single(p => p.username == txtUser.Text);
                _iUser.pass = txtPassword.Text;
                DialogResult _dialogResult = MessageBox.Show("Do you want to change password ?", "Confirm", MessageBoxButtons.YesNo);
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
                    LoadUserData();
                }
            } 
        }

    }
}












