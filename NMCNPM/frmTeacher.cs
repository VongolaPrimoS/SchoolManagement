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
    public partial class frmTeacher : Form
    {
        public delegate void FormCloseHandler();
        public event FormCloseHandler OnFormCloseEventArg;

        public static PointManagementControl _pointManagementControl; 
        public frmTeacher()
        {
            InitializeComponent();
            _pointManagementControl = new PointManagementControl();
            _pointManagementControl.Location = new Point((panel2.Width + _pointManagementControl.Width) / 2 - _pointManagementControl.Width, (panel2.Height + _pointManagementControl.Height) / 2 - _pointManagementControl.Height);

        }

        private void frmTeacher_FormClosed(object sender, FormClosedEventArgs e)
        {
            OnFormCloseEventArg();
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(_pointManagementControl);
        }
    }
}
