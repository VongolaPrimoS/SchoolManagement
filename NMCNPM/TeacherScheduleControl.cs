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
    public partial class TeacherScheduleControl : UserControl
    {
        int PCSelectedIndex = -1;
        string mapcSelected = "";
        Dictionary<string, string> teacher_dict = new Dictionary<string, string>();
        Dictionary<string, string> monhoc_dict = new Dictionary<string, string>();
        Utils utils = new Utils();
        public TeacherScheduleControl()
        {
            InitializeComponent();
        }

        // loading all teachers into all combobox
        private void loadTeacherList()
        {
            var dataSource = from teachers in frmLogin._database.GetTable<GIAOVIEN>()
                             select new { teachers.magv, teachers.tengv, teachers.mamh};

            foreach (var teacher in dataSource)
            {
                ten_giao_vien.Items.Add(teacher.tengv);
                teacher_dict.Add(teacher.tengv, teacher.magv);
                monhoc_dict.Add(teacher.magv, teacher.mamh);
            }
            ten_giao_vien.SelectedIndex = 0;
        }

        // loadd all TenLop
        private void loadTenLop()
        {
            var lop_dataSource = from lops in frmLogin._database.GetTable<LOP>()
                                 select new { lops.tenlop };
            foreach(var lop_item in lop_dataSource)
            {
                lop.Items.Add(lop_item.tenlop);
            }
            lop.SelectedIndex = 0;
        }

        // load all NamHoc
        private void loadNamHoc()
        {
            var namhoc_dataSource = from namhocs in frmLogin._database.GetTable<NAMHOC>()
                                    select new { namhocs.tennh };

            foreach (var namhoc_item in namhoc_dataSource)
            {
                nam_hoc.Items.Add(namhoc_item.tennh);
            }
            nam_hoc.SelectedIndex = 0;
        }

        // load all KhoiLop
        private void loadKhoiLop()
        {
            var khoilop_dataSource = from khoilops in frmLogin._database.GetTable<KHOILOP>()
                                     select new { khoilops.tenkl };

            foreach (var khoilop_item in khoilop_dataSource)
            {
                khoi_lop.Items.Add(khoilop_item.tenkl);
            }
            khoi_lop.SelectedIndex = 0;
        }

        // load all HocKy
        private void loadHocKy()
        {
            var hocky_dataSource = from hockys in frmLogin._database.GetTable<HOCKY>()
                                   select new { hockys.tenhk };

            foreach (var hocky_item in hocky_dataSource)
            {
                hoc_ky.Items.Add(hocky_item.tenhk);
            }
            hoc_ky.SelectedIndex = 0;
        }

        //load all information of PHANCONG table
        private void loadPhanCongTable()
        {
            var phancong_dataSource = from teachers in frmLogin._database.GetTable<GIAOVIEN>()
                                      from lops in frmLogin._database.GetTable<LOP>()
                                      from namhocs in frmLogin._database.GetTable<NAMHOC>()
                                      from khoilops in frmLogin._database.GetTable<KHOILOP>()
                                      from hockys in frmLogin._database.GetTable<HOCKY>()
                                      from monhocs in frmLogin._database.GetTable<MONHOC>()
                                      from pc in frmLogin._database.GetTable<PHANCONG>()
                                      where teachers.mamh == monhocs.mamh && pc.magv == teachers.magv
                                               && pc.mahk == hockys.mahk && pc.malop == lops.malop
                                               && pc.manh == namhocs.manh && pc.makl == khoilops.makl
                                      select new { pc.mapc, namhocs.tennh, khoilops.tenkl,
                                                    hockys.tenhk, lops.tenlop, monhocs.tenmh,teachers.magv,teachers.tengv};
            
            foreach(var phancong in phancong_dataSource)
            {
                PCTable.Rows.Add(phancong.mapc, phancong.tennh, phancong.tenkl, phancong.tenhk, phancong.tenlop,
                    phancong.tenmh, phancong.magv, phancong.tengv);
            }
        }

        private void TeacherScheduleControl_Load(object sender, EventArgs e)
        {
            loadTeacherList();
            loadKhoiLop();
            loadNamHoc();
            loadTenLop();
            loadHocKy();
            loadPhanCongTable();
        }

        // update ma_giao_vien and mon_hoc while changing ten_giao_vien
        private void ten_giao_vien_SelectedIndexChanged(object sender, EventArgs e)
        {
            string magv = teacher_dict[ten_giao_vien.Items[ten_giao_vien.SelectedIndex].ToString()];
            string mamh = monhoc_dict[magv];

            var tenmonhoc = (from monhoc in frmLogin._database.GetTable<MONHOC>()
                            where monhoc.mamh == mamh
                            select new { monhoc.tenmh }).SingleOrDefault();

            ma_giao_vien.Text = magv;
            mon_hoc.Text = tenmonhoc.tenmh;
        }

        private void them_Click(object sender, EventArgs e)
        {
            string tengv = ten_giao_vien.Items[ten_giao_vien.SelectedIndex].ToString();
            string tenmh = mon_hoc.Text;
            string magv = teacher_dict[tengv];
            string mamh = monhoc_dict[magv];
            string namhoc = nam_hoc.Items[nam_hoc.SelectedIndex].ToString();
            string hocky = hoc_ky.Items[hoc_ky.SelectedIndex].ToString();
            string khoilop = khoi_lop.Items[khoi_lop.SelectedIndex].ToString();
            string tenlop = lop.Items[lop.SelectedIndex].ToString();

            var mahk = (    from hocky_item in frmLogin._database.GetTable<HOCKY>()
                            where hocky_item.tenhk == hocky
                            select new { hocky_item.mahk }
                       ).SingleOrDefault().mahk;

            var makl = (from khoilop_item in frmLogin._database.GetTable<KHOILOP>()
                        where khoilop_item.tenkl == khoilop
                        select new { khoilop_item.makl }
                        ).SingleOrDefault().makl;

            var malop = (from lop_item in frmLogin._database.GetTable<LOP>()
                         where lop_item.tenlop == tenlop
                         select new { lop_item.malop }
                         ).SingleOrDefault().malop;

            var manh = (from namhoc_item in frmLogin._database.GetTable<NAMHOC>()
                        where namhoc_item.tennh == namhoc
                        select new { namhoc_item.manh }
                        ).SingleOrDefault().manh;

            PHANCONG pc = new PHANCONG();
            pc.magv = magv;
            pc.mahk = mahk;
            pc.makl = makl;
            pc.malop = malop;
            pc.mamh = mamh;
            pc.manh = manh;
            pc.mapc = utils.generatePrimaryKey("PC", PCTable.Rows.Count + 1);

            frmLogin._database.PHANCONGs.InsertOnSubmit(pc);
            try
            {
                frmLogin._database.SubmitChanges();
                PCTable.Rows.Add(pc.mapc, namhoc, khoilop, hocky, tenlop,
                                tenmh,magv,tengv);
            }
            catch (Exception err)
            {
                MessageBox.Show("Them du lieu loi " + err.Message);
                Console.WriteLine(err.Message);
            }

        }

        private void xoa_Click(object sender, EventArgs e)
        {
            if (PCSelectedIndex > -1 && mapcSelected != "")
            {
                PHANCONG pc = frmLogin._database.PHANCONGs.Where(item => item.mapc == mapcSelected).Single();
                frmLogin._database.PHANCONGs.DeleteOnSubmit(pc);
                try
                {
                    frmLogin._database.SubmitChanges();
                    PCTable.Rows.RemoveAt(PCSelectedIndex);
                }
                catch (Exception err)
                {
                    MessageBox.Show("Loi Xoa : " + ten_giao_vien.Text);
                    MessageBox.Show(err.Message);
                    Console.WriteLine(err.Message);
                }
            }
        }

        private void PCTable_SelectionChanged(object sender, EventArgs e)
        {
            if (PCTable.SelectedRows.Count == 1)
            {
                PCSelectedIndex = PCTable.SelectedRows[0].Index;

                DataGridViewRow row = PCTable.Rows[PCSelectedIndex];

                mapcSelected = row.Cells["Column1"].Value.ToString();
                ten_giao_vien.SelectedIndex = ten_giao_vien.Items.IndexOf(row.Cells["Column8"].Value.ToString());
                ma_giao_vien.Text = row.Cells["Column7"].Value.ToString();
                mon_hoc.Text = row.Cells["Column6"].Value.ToString();
                nam_hoc.SelectedIndex = nam_hoc.Items.IndexOf(row.Cells["Column2"].Value.ToString());
                hoc_ky.SelectedIndex = hoc_ky.Items.IndexOf(row.Cells["Column4"].Value.ToString());
                khoi_lop.SelectedIndex = khoi_lop.Items.IndexOf(row.Cells["Column3"].Value.ToString());
                lop.SelectedIndex = lop.Items.IndexOf(row.Cells["Column5"].Value.ToString());
            }
        }

        //update value in PCtable when clicked "sua button"
        private void updateRow(int index)
        {
            DataGridViewRow row = PCTable.Rows[index];

            row.Cells["Column8"].Value = ten_giao_vien.Items[ten_giao_vien.SelectedIndex].ToString();
            row.Cells["Column7"].Value = teacher_dict[row.Cells["Column8"].Value.ToString()];
            row.Cells["Column6"].Value = mon_hoc.Text;
            row.Cells["Column5"].Value = lop.Items[lop.SelectedIndex].ToString();
            row.Cells["Column4"].Value = hoc_ky.Items[hoc_ky.SelectedIndex].ToString();
            row.Cells["Column3"].Value = khoi_lop.Items[khoi_lop.SelectedIndex].ToString();
            row.Cells["Column2"].Value = nam_hoc.Items[nam_hoc.SelectedIndex].ToString();
        }

        private void sua_Click(object sender, EventArgs e)
        {
            if (PCSelectedIndex > -1 && mapcSelected != "")
            {
                
            }
        }
    }
}
