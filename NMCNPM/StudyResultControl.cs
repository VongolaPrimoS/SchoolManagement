using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NMCNPM
{
    public partial class StudyResultControl : UserControl
    {
        private String _idStudent;
        private List<String> _idClass;
        private String[] _idSemester={"HK01","HK02"};
        public StudyResultControl(String IDInput)
        {
            InitializeComponent();
            _idStudent = IDInput;
            _idClass = new List<string>();
        }

        private void StudyResultControl_Load(object sender, EventArgs e)
        {
            var _getClass = (from P in frmLogin._database.GetTable<DIEM>()
                            join Q in frmLogin._database.GetTable<LOP>()
                            on P.malop equals Q.malop
                            where P.mahs == _idStudent
                            select Q).ToList();
            _idClass.Clear();
            foreach (var item in _getClass)
            {
                if (!cbbClass.Items.Contains(item.tenlop))
                {
                    cbbClass.Items.Add(item.tenlop);
                    _idClass.Add(item.malop);
                }
            }
            
        }

        private void cbbClass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLook_Click(object sender, EventArgs e)
        {
            if (cbbClass.Text!="" && cbbHK.Text!="")
            {
                var _getClass = from P in frmLogin._database.GetTable<DIEM>()
                                join Q in frmLogin._database.GetTable<MONHOC>()
                                on P.mamh equals Q.mamh
                                where P.mahs == _idStudent && P.malop == _idClass[cbbClass.SelectedIndex] && P.mahk == _idSemester[cbbHK.SelectedIndex]
                                select new { Mon = Q.tenmh, PreTest = P.mlp1, MidTest = P.blp1, FinalTest = P.thi };
                dgvPoint.DataSource = _getClass;
            }
            
        }
    }
}

















