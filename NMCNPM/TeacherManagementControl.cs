using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace NMCNPM
{
    public partial class TeacherManagementControl : UserControl
    {
        Dictionary<string, string> bomon_dict = new Dictionary<string, string>();
        string selected_mgv = "";
        int GVtable_selected_index = -1;
        // use for calling utility functions
        Utils utils = new Utils();
        public TeacherManagementControl()
        {
            InitializeComponent();
        }

        private void TeacherManagementControl_Load(object sender, EventArgs e)
        {
            LoadALLDB();

            // load ten mon hoc into bomon combobox

            var dataSource = from a in frmLogin._database.GetTable<MONHOC>()
                             select new { a.mamh, a.tenmh };

            foreach (var item in dataSource)
            {
                bo_mon.Items.Add(item.tenmh.ToString());
                bomon_dict.Add(item.tenmh.ToString(), item.mamh.ToString());
            }
            bo_mon.SelectedIndex = 0;
            bo_mon.DropDownStyle = ComboBoxStyle.DropDownList;
            gioi_tinh.SelectedIndex = 0;
            gioi_tinh.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void LoadALLDB()
        {
            // load all db
            var dataSource = from a in frmLogin._database.GetTable<GIAOVIEN>()
                             from b in frmLogin._database.GetTable<MONHOC>()
                             where a.mamh == b.mamh
                             select new
                             {
                                 a.magv,
                                 a.tengv,
                                 a.gt,
                                 a.ngaysinh,
                                 a.ngayvaolam,
                                 a.diachi,
                                 a.sdt,
                                 a.hinhanh,
                                 b.tenmh
                             };

            foreach (var item in dataSource)
            {
                Stream stream = new MemoryStream(item.hinhanh.ToArray());
                Image img = Image.FromStream(stream);
                GVtable.Rows.Add(item.magv, item.tengv, item.gt, item.ngaysinh, item.ngayvaolam,
                        item.tenmh, item.diachi, item.sdt, img);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Create an instance of the open file dialog box.
            OpenFileDialog openImage = new OpenFileDialog();

            // Set filter options and filter index.
            openImage.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            openImage.FilterIndex = 1;
            // Call the ShowDialog method to show the dialog box.
            DialogResult result = openImage.ShowDialog();

            // Process input if the user clicked OK.
            if (result == DialogResult.OK)
            {
                String fn = openImage.FileName;
                hinh_anh.Text = fn;
                Image img = Image.FromFile(fn);
                panel4.BackgroundImage = img;
            }
        }

        private void them_Click(object sender, EventArgs e)
        {
            if (ho_ten.Text != "" && dia_chi.Text != "" && so_dien_thoai.Text != "" && hinh_anh.Text != "")
            {
                if (!utils.validate_PhoneNumberInput(so_dien_thoai.Text))
                {
                    MessageBox.Show("So dien thoai khong hop le!");
                    return;
                }
                GIAOVIEN gv = new GIAOVIEN();
                gv.tengv = ho_ten.Text;
                gv.sdt = so_dien_thoai.Text;
                gv.diachi = dia_chi.Text;
                gv.mamh = bomon_dict[bo_mon.Items[bo_mon.SelectedIndex].ToString()];
                string sex = gioi_tinh.Items[gioi_tinh.SelectedIndex].ToString();
                if (sex == "Nam")
                {
                    gv.gt = true;
                }
                else
                {
                    gv.gt = false;
                }
                gv.ngaysinh = ngay_sinh.Value;
                gv.ngayvaolam = ngay_vao_lam.Value;
                Image img = Image.FromFile(hinh_anh.Text);
                //convert image into linq.binary
                using (MemoryStream ms = new MemoryStream())
                {
                    img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    var binary = new System.Data.Linq.Binary(ms.GetBuffer());
                    gv.hinhanh = binary;
                }
                gv.magv = utils.generatePrimaryKey("GV",GVtable.Rows.Count);

                // begin insert record
                frmLogin._database.GIAOVIENs.InsertOnSubmit(gv);
                try
                {
                    frmLogin._database.SubmitChanges();
                    GVtable.Rows.Add(gv.magv, gv.tengv, gv.gt, gv.ngaysinh, gv.ngayvaolam,
                        bo_mon.Items[bo_mon.SelectedIndex].ToString(), gv.diachi, gv.sdt, img);
                }
                catch (Exception err)
                {
                    MessageBox.Show("Them du lieu loi "+ err.Message);
                    Console.WriteLine(err.Message);
                }
            }
            else
            {
                //error
                MessageBox.Show("Mot so truong de trong, hay nhap vao!");
            }
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            if (selected_mgv != "" && GVtable_selected_index != -1)
            {
                var r = MessageBox.Show("Ban co muon xoa "+ho_ten.Text + " khong ?"
                    , "Chu Y", MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                {
                    GIAOVIEN gv = frmLogin._database.GIAOVIENs.Where(item => item.magv == selected_mgv).Single();
                    frmLogin._database.GIAOVIENs.DeleteOnSubmit(gv);
                    try
                    {
                        frmLogin._database.SubmitChanges();
                        GVtable.Rows.RemoveAt(GVtable_selected_index);
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Loi Xoa : " + ho_ten.Text);
                        MessageBox.Show(err.Message);
                        Console.WriteLine(err.Message);
                    }
                }
            }
        }

        private void GVtable_SelectionChanged(object sender, EventArgs e)
        {
            if (GVtable.SelectedRows.Count == 1)
            {
                GVtable_selected_index = GVtable.SelectedRows[0].Index;

                DataGridViewRow row = GVtable.Rows[GVtable_selected_index];
                selected_mgv = row.Cells["magv"].Value.ToString();

                // load into form
                ho_ten.Text = row.Cells["Column2"].Value.ToString();
                
                if ((bool)row.Cells["Column3"].Value)
                {
                    gioi_tinh.SelectedIndex = 0; //Nam
                }
                else
                {
                    gioi_tinh.SelectedIndex = 1;
                }
                ngay_sinh.Value = DateTime.Parse(row.Cells["Column4"].Value.ToString());
                ngay_vao_lam.Value = DateTime.Parse(row.Cells["Column5"].Value.ToString());
                bo_mon.SelectedIndex = bo_mon.Items.IndexOf(row.Cells["Column6"].Value);
                dia_chi.Text = row.Cells["Column7"].Value.ToString();
                so_dien_thoai.Text = row.Cells["Column8"].Value.ToString();
                panel4.BackgroundImage = (Image)row.Cells["Column9"].Value;
            }
        }

        private void sua_Click(object sender, EventArgs e)
        {
            if (selected_mgv != "" && GVtable_selected_index != -1)
            {
                var r = MessageBox.Show("Ban co muon sua " + ho_ten.Text + " khong ?"
                    , "Chu Y", MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                {
                    if (ho_ten.Text == "" || dia_chi.Text == "" || so_dien_thoai.Text == "")
                    {
                        //error
                        MessageBox.Show("Mot so truong de trong, hay nhap vao!");
                        return;
                    }
                    var dataSource = from item in frmLogin._database.GIAOVIENs
                                     where item.magv == selected_mgv
                                     select item;
                    //update item
                    foreach (var gv in dataSource)
                    {
                        gv.tengv = ho_ten.Text;
                        gv.sdt = so_dien_thoai.Text;
                        gv.diachi = dia_chi.Text;
                        gv.mamh = bomon_dict[bo_mon.Items[bo_mon.SelectedIndex].ToString()];
                        string sex = gioi_tinh.Items[gioi_tinh.SelectedIndex].ToString();
                        if (sex == "Nam")
                        {
                            gv.gt = true;
                        }
                        else
                        {
                            gv.gt = false;
                        }
                        gv.ngaysinh = ngay_sinh.Value;
                        gv.ngayvaolam = ngay_vao_lam.Value;
                        // update img
                        Image img;
                        if(File.Exists(hinh_anh.Text))
                        {
                            img = Image.FromFile(hinh_anh.Text);
                        }else{
                            //use old img
                            img = panel4.BackgroundImage;
                        }
                        //convert image into linq.binary
                        using (MemoryStream ms = new MemoryStream())
                        {
                            img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                            var binary = new System.Data.Linq.Binary(ms.GetBuffer());
                            gv.hinhanh = binary;
                        }
                    }

                    try
                    {
                        frmLogin._database.SubmitChanges();
                        //update row
                        updateRow(GVtable_selected_index);
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Loi Cap Nhat : " + ho_ten.Text);
                        //MessageBox.Show(err.Message);
                        Console.WriteLine(err.Message);
                    }
                }
            }
        }

        private void updateRow(int index)
        {
            DataGridViewRow row = GVtable.Rows[index];
            row.Cells["Column2"].Value = ho_ten.Text;
            if (gioi_tinh.SelectedIndex == 0) // Nam
            {
                row.Cells["Column3"].Value = true;
            }
            else
            {
                row.Cells["Column3"].Value = false;
            }
            row.Cells["Column4"].Value = ngay_sinh.Value;
            row.Cells["Column5"].Value = ngay_vao_lam.Value;
            row.Cells["Column6"].Value = bo_mon.Items[bo_mon.SelectedIndex];
            row.Cells["Column7"].Value = dia_chi.Text;
            row.Cells["Column8"].Value = so_dien_thoai.Text;
            row.Cells["Column9"].Value = panel4.BackgroundImage;
        }
    }
}
