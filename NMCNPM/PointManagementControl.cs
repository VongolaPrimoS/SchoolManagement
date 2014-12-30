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
    public partial class PointManagementControl : UserControl
    {
        private String _idTeacher;
        private NMCNPM.Class.iPoint _iPoint;
        private String[] _idTerm;
        private String[] _idSemester = new String[] {"HK01","HK02" };
        public PointManagementControl(String IDTeacher)
        {
            InitializeComponent();
            _iPoint = new Class.iPoint();
            _idTeacher = IDTeacher;
            LoadData();
        }
        public void LoadData()
        {
            var _getSourceTerm = (from P in frmLogin._database.NAMHOCs select P).ToList();
            _idTerm = new String[_getSourceTerm.Count];
            cbbTerm.Items.Clear();
            for (int i = 0; i < _getSourceTerm.Count; i++)
            {
                cbbTerm.Items.Add(_getSourceTerm[i].tennh);
                _idTerm[i] = _getSourceTerm[i].manh;
            }

        }

        private void btnFindClass_Click(object sender, EventArgs e)
        {
            if (cbbTerm.Text == "" && cbbSemester.Text == "")
            {
                var _classSchedule = (from P in frmLogin._database.PHANCONGs
                                      join Q in frmLogin._database.MONHOCs
                                      on P.mamh equals Q.mamh
                                      join K in frmLogin._database.LOPs
                                      on P.malop equals K.malop
                                      join M in frmLogin._database.KHOILOPs
                                      on P.makl equals M.makl
                                      join N in frmLogin._database.HOCKies
                                      on P.mahk equals N.mahk
                                      join I in frmLogin._database.NAMHOCs
                                      on P.manh equals I.manh
                                      where P.magv == _idTeacher
                                      select new
                                      {
                                          TENMON = Q.tenmh,
                                          TENLOP = K.tenlop,
                                          KHOILOP = M.tenkl,
                                          HOCKY = N.tenhk,
                                          NAMHOC = I.tennh
                                      }).ToList();
                dGVClass.DataSource = _classSchedule;
            }
            else
            {
                if (cbbTerm.Text != "" && cbbSemester.Text != "")
                {
                    var _classSchedule = (from P in frmLogin._database.PHANCONGs
                                          join Q in frmLogin._database.MONHOCs
                                          on P.mamh equals Q.mamh
                                          join K in frmLogin._database.LOPs
                                          on P.malop equals K.malop
                                          join M in frmLogin._database.KHOILOPs
                                          on P.makl equals M.makl
                                          join N in frmLogin._database.HOCKies
                                          on P.mahk equals N.mahk
                                          join I in frmLogin._database.NAMHOCs
                                          on P.manh equals I.manh
                                          where P.magv == _idTeacher && P.mahk==_idSemester[cbbSemester.SelectedIndex] && P.manh==_idTerm[cbbTerm.SelectedIndex]
                                          select new
                                          {
                                              TENMON = Q.tenmh,
                                              TENLOP = K.tenlop,
                                              KHOILOP = M.tenkl,
                                              HOCKY = N.tenhk,
                                              NAMHOC = I.tennh
                                          }).ToList();
                    dGVClass.DataSource = _classSchedule;
                }
                else
                {
                    if (cbbTerm.Text != "")
                    {
                        var _classSchedule = (from P in frmLogin._database.PHANCONGs
                                              join Q in frmLogin._database.MONHOCs
                                              on P.mamh equals Q.mamh
                                              join K in frmLogin._database.LOPs
                                              on P.malop equals K.malop
                                              join M in frmLogin._database.KHOILOPs
                                              on P.makl equals M.makl
                                              join N in frmLogin._database.HOCKies
                                              on P.mahk equals N.mahk
                                              join I in frmLogin._database.NAMHOCs
                                              on P.manh equals I.manh
                                              where P.magv == _idTeacher && P.manh==_idTerm[cbbTerm.SelectedIndex]
                                              select new
                                              {
                                                  TENMON = Q.tenmh,
                                                  TENLOP = K.tenlop,
                                                  KHOILOP = M.tenkl,
                                                  HOCKY = N.tenhk,
                                                  NAMHOC = I.tennh
                                              }).ToList();
                        dGVClass.DataSource = _classSchedule;
                    }
                    else
                    {
                        if (cbbSemester.Text != "")
                        {
                            var _classSchedule = (from P in frmLogin._database.PHANCONGs
                                                  join Q in frmLogin._database.MONHOCs
                                                  on P.mamh equals Q.mamh
                                                  join K in frmLogin._database.LOPs
                                                  on P.malop equals K.malop
                                                  join M in frmLogin._database.KHOILOPs
                                                  on P.makl equals M.makl
                                                  join N in frmLogin._database.HOCKies
                                                  on P.mahk equals N.mahk
                                                  join I in frmLogin._database.NAMHOCs
                                                  on P.manh equals I.manh
                                                  where P.magv == _idTeacher && P.mahk == _idSemester[cbbSemester.SelectedIndex]
                                                  select new
                                                  {
                                                      TENMON = Q.tenmh,
                                                      TENLOP = K.tenlop,
                                                      KHOILOP = M.tenkl,
                                                      HOCKY = N.tenhk,
                                                      NAMHOC = I.tennh
                                                  }).ToList();
                            dGVClass.DataSource = _classSchedule;
                        }
                    }
                }
            }
            
        }
        
        private void dGVClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvStudent.Rows.Clear();
            if (e.RowIndex!=-1)
            {
                _iPoint.LoadData(dGVClass[1, e.RowIndex].Value.ToString(), dGVClass[0, e.RowIndex].Value.ToString(), dGVClass[2, e.RowIndex].Value.ToString(), dGVClass[3, e.RowIndex].Value.ToString(), dGVClass[4, e.RowIndex].Value.ToString());
                
                //get Student in Class
                var _getStudentQuery = (from P in frmLogin._database.PHANLOPs
                                       join Q in frmLogin._database.LOPs
                                       on P.malop equals Q.malop
                                       join K in frmLogin._database.HOCSINHs
                                       on P.mahs equals K.mahs
                                       where Q.tenlop==_iPoint.NameClass
                                       select new
                                       {
                                           StudentID=K.mahs,
                                           StudentName = K.tenhs
                                       }).ToList();

                //Get Score In Student
                foreach (var _studentItem in _getStudentQuery)
                {
                    
                    var _getStudentScore = (from P in frmLogin._database.MONHOCs
                                            join Q in frmLogin._database.DIEMs
                                            on P.mamh equals Q.mamh
                                            join K in frmLogin._database.HOCSINHs
                                            on Q.mahs equals K.mahs
                                            join S in frmLogin._database.HOCKies
                                            on Q.mahk equals S.mahk
                                            where P.tenmh == _iPoint.NameSubject && S.tenhk==_iPoint.Semester && K.mahs == _studentItem.StudentID 
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
                    if (_getStudentScore.Count!=0)
                    {
                        dgvStudent.Rows.Add(_studentItem.StudentID, _studentItem.StudentName, _getStudentScore[0].Cot1, _getStudentScore[0].Cot2, _getStudentScore[0].Cot3, _getStudentScore[0].Cot4, _getStudentScore[0].Cot5, _getStudentScore[0].Cot6, _getStudentScore[0].Cot7, _getStudentScore[0].Cot8);
                    }
                    else
                    {
                        dgvStudent.Rows.Add(_studentItem.StudentID, _studentItem.StudentName);
                    }
                }
                
                
            }
        }
    }
}
