using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NMCNPM.Class;
namespace NMCNPM
{
    public partial class frmSetPoint : Form
    {
        private iPoint _iPoint;
        private String _idStudent;
        public frmSetPoint(String IDStudent,iPoint Input)
        {
            InitializeComponent();
            _iPoint=Input;
            _idStudent = IDStudent;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var _getStudentScore = (from P in frmLogin._database.MONHOCs
                                    join Q in frmLogin._database.DIEMs
                                    on P.mamh equals Q.mamh
                                    join K in frmLogin._database.HOCSINHs
                                    on Q.mahs equals K.mahs
                                    join S in frmLogin._database.HOCKies
                                    on Q.mahk equals S.mahk
                                    where P.tenmh == _iPoint.NameSubject && S.tenhk == _iPoint.Semester && K.mahs == _idStudent
                                    select new NMCNPM.Score
                                    {
                                        Cot1 = Q.mieng.Value,
                                        Cot2 = Q.mlp1.Value,
                                        Cot3 = Q.mlp2.Value,
                                        Cot4 = Q.mlp3.Value,
                                        Cot5 = Q.blp1.Value,
                                        Cot6 = Q.blp2.Value,
                                        Cot7 = Q.blp3.Value,
                                        Cot8 = Q.thi.Value
                                    }).ToList();
        }

        
    }
}
