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
    public partial class frmAdmin : Form
    {
        public delegate void FormCloseHandler();
        public event FormCloseHandler OnFormCloseEventArg;
        public static UserManagementControl _userManagementControl;
        public static StudentManagementControl _studentManagementControl;
        public static TeacherManagementControl _teacherManagementControl;
        public frmAdmin()
        {
            InitializeComponent();
            _userManagementControl = new UserManagementControl();
            _studentManagementControl = new StudentManagementControl();
            _teacherManagementControl = new TeacherManagementControl();
            _userManagementControl.Location = new Point((panel2.Width + _userManagementControl.Width) / 2 - _userManagementControl.Width, (panel2.Height + _userManagementControl.Height) / 2 - _userManagementControl.Height);
            _studentManagementControl.Location = new Point((panel2.Width + _studentManagementControl.Width) / 2 - _studentManagementControl.Width, (panel2.Height + _studentManagementControl.Height) / 2 - _studentManagementControl.Height);
            _teacherManagementControl.Location = new Point((panel2.Width + _teacherManagementControl.Width) / 2 - _teacherManagementControl.Width, (panel2.Height + _teacherManagementControl.Height) / 2 - _teacherManagementControl.Height);
        }

        private void frmAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            OnFormCloseEventArg();
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(_userManagementControl);
        }

        private void btnStudentManagement_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(_studentManagementControl);
        }

        private void btnTeacherManagement_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(_teacherManagementControl);
        }
    }
}
