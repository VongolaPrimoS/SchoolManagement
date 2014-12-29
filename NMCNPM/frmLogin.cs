using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NMCNPM
{
    public partial class frmLogin : Form
    {
        public static SchoolManagementDataContext _database;
        String _strConnectionString = "Data Source=MON;Initial Catalog=QLDIEMNEW;Integrated Security=True";

        public frmLogin()
        {
            InitializeComponent();
            try
            {
                _database = new SchoolManagementDataContext(_strConnectionString);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                var _allUser = from p in _database.TAIKHOANs select p;
                foreach (var item in _allUser)
                {
                    if (txtUser.Text==item.username && txtPassword.Text==item.pass)
                    {
                        if (txtUser.Text=="admin")
                        {
                            frmAdmin _frmAdmin = new frmAdmin();
                            _frmAdmin.OnFormCloseEventArg += new frmAdmin.FormCloseHandler(ShowHiddenForm);
                            _frmAdmin.Show();
                        }
                        else
                        {
                            if (txtUser.Text.Substring(0,2)=="GV")
                            {
                                frmTeacher _frmTeacher = new frmTeacher();
                                _frmTeacher.OnFormCloseEventArg += new frmTeacher.FormCloseHandler(ShowHiddenForm);
                                _frmTeacher.Show();
                            }
                            else
                            {
                                frmStudent _frmStudent = new frmStudent(txtUser.Text);
                                _frmStudent.OnFormCloseEventArg += new frmStudent.FormCloseHandler(ShowHiddenForm);
                                _frmStudent.Show();
                            }
                        }
                        this.Hide();
                        return;
                    }
                }
                MessageBox.Show("Sai Tài Khoản Hoặc Mật Khẩu");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                Application.Exit();
            }
        }

        private void ShowHiddenForm()
        {
            this.Show();
        }
    }
}
