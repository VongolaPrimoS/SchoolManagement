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
    public partial class frmStudent : Form
    {
        public delegate void FormCloseHandler();
        public event FormCloseHandler OnFormCloseEventArg;

        public static StudyResultControl _studyResultControl;
        public frmStudent()
        {
            InitializeComponent();
            _studyResultControl = new StudyResultControl();
            _studyResultControl.Location = new Point((panel2.Width + _studyResultControl.Width) / 2 - _studyResultControl.Width, (panel2.Height + _studyResultControl.Height) / 2 - _studyResultControl.Height);
        }

        private void frmStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            OnFormCloseEventArg();
        }

        private void btnStudyResult_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(_studyResultControl);
        }
    }
}
