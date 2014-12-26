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
        public ClassManagementControl()
        {
            InitializeComponent();
        }

        private void ClassManagementControl_Load(object sender, EventArgs e)
        {
            var _getClassQuery = from _classResult in frmLogin._database.GetTable<LOP>()
                                 from _grade in frmLogin._database.GetTable<KHOILOP>()
                                 from _teacher in frmLogin._database.GetTable<GIAOVIEN>()
                                 where _grade.makl==_classResult.makl && _teacher.magv==_classResult.magv

                                 select new ClassRoom
                                 {
                                     IdClass = _classResult.malop,
                                     NameClass=_classResult.tenlop,
                                     Sum =_classResult.siso.ToString(),
                                     Teacher=_teacher.tengv,
                                     Grade=_grade.tenkl
                                 };
            dgvClass.DataSource = _getClassQuery;
        }
    }
}
