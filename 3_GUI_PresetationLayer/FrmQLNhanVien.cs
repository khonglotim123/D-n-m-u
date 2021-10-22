using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1_DAL_DataAccessLayer.DALService;
using _1_DAL_DataAccessLayer.DALServices;
using _1_DAL_DataAccessLayer.Models;
using _2_BUS_BusinessLayer.IServices;
using _2_BUS_BusinessLayer.Services;

namespace _3_GUI_PresetationLayer
{
    public partial class FrmQLNhanVien : Form
    {
        List<NhanVien> _lstNhanVien;
        IQLNhanVienService _qlNhanVien;
        NhanVien _nv;
        string IdWhenClick;
        public FrmQLNhanVien()
        {
            InitializeComponent();
            _lstNhanVien = new List<NhanVien>();
            _qlNhanVien = new QLNhanVienService();
            _nv = new NhanVien();
            _lstNhanVien = _qlNhanVien.getlstNhanVien();
            LoadData();
        }
        void LoadData()
        {
            Dgrid_NhanVien.ColumnCount = 7;
            Dgrid_NhanVien.Columns[0].Name = "Mã nhân viên";
            Dgrid_NhanVien.Columns[1].Name = "Email";
            Dgrid_NhanVien.Columns[2].Name = "Tên nhân viên";
            Dgrid_NhanVien.Columns[3].Name = "Địa chỉ";
            Dgrid_NhanVien.Columns[4].Name = "Tình trạng";
            Dgrid_NhanVien.Columns[5].Name = "Mật khẩu";
            Dgrid_NhanVien.Columns[6].Name = "Vai trò";
            Dgrid_NhanVien.Rows.Clear();
            foreach (var x in _qlNhanVien.getlstNhanVien().Where(c => c.TrangThai == 0))
            {
                Dgrid_NhanVien.Rows.Add(x.MaNv, x.Email, x.TeNv, x.DiaChi, x.TinhTrang == 1 ? "Hoạt động" : "Không hoạt động", x.MatKhau, x.VaiTro == 1 ? "Nhân viên" : "Quản lý");
            }
        }
        void LoadData(string timkiem)
        {
            Dgrid_NhanVien.ColumnCount = 7;
            Dgrid_NhanVien.Columns[0].Name = "Mã nhân viên";
            Dgrid_NhanVien.Columns[1].Name = "Email";
            Dgrid_NhanVien.Columns[2].Name = "Tên nhân viên";
            Dgrid_NhanVien.Columns[3].Name = "Địa chỉ";
            Dgrid_NhanVien.Columns[4].Name = "Tình trạng";
            Dgrid_NhanVien.Columns[5].Name = "Mật khẩu";
            Dgrid_NhanVien.Columns[6].Name = "Vai trò";
            Dgrid_NhanVien.Rows.Clear();
            foreach (var x in _qlNhanVien.getlstNhanVien().Where(c => c.TrangThai == 0 && c.TeNv.ToLower().StartsWith(timkiem)))
            {
                Dgrid_NhanVien.Rows.Add(x.MaNv, x.Email, x.TeNv, x.DiaChi, x.TinhTrang == 1 ? "Hoạt động" : "Không hoạt động", x.MatKhau, x.VaiTro == 1 ? "Nhân viên" : "Quản lý");
            }
        }
        private void Btn_ThemNv_Click(object sender, EventArgs e)
        {
            NhanVien nhanVien = new NhanVien();
            nhanVien.Id = (_qlNhanVien.getlstNhanVien().Count() + 1);
            nhanVien.MaNv = "NV" + (_qlNhanVien.getlstNhanVien().Count() + 1);
            nhanVien.Email = Txt_EmailNv.Text;
            nhanVien.DiaChi = Txt_DiaChiNv.Text;
            nhanVien.TeNv = Txt_TenNv.Text;
            nhanVien.TinhTrang = (byte)(Cbx_HD.Checked ? 1 : 0);
            nhanVien.MatKhau = (_qlNhanVien.CreatPassWord(6));
            nhanVien.VaiTro = (byte)(Rbt_NhanVien.Checked ? 1 : 0);
            nhanVien.So = 0;
            nhanVien.TrangThai = 0;
            _qlNhanVien.Add(nhanVien);
            _qlNhanVien.SendMail(nhanVien.Email, nhanVien.MatKhau);
            nhanVien.MatKhau = CreateMD5(nhanVien.MatKhau);
            MessageBox.Show("Thêm thành công",_qlNhanVien.Update(nhanVien));
            LoadData();
        }
        public static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

        private void Btn_SuaNv_Click(object sender, EventArgs e)
        {
            NhanVien nhanVien = new NhanVien();
            nhanVien = _qlNhanVien.getlstNhanVien().Where(c => c.MaNv == IdWhenClick).FirstOrDefault();
            nhanVien.Email = Txt_EmailNv.Text;
            nhanVien.DiaChi = Txt_DiaChiNv.Text;
            nhanVien.TeNv = Txt_TenNv.Text;
            nhanVien.TinhTrang = (byte)(Cbx_HD.Checked ? 1 : 0);
            nhanVien.VaiTro = (byte)(Rbt_NhanVien.Checked ? 1 : 0);
            MessageBox.Show("Sửa thành công",_qlNhanVien.Update(nhanVien));
            LoadData();
        }

        private void Dgrid_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex == _qlNhanVien.getlstNhanVien().Count) return;
            Txt_EmailNv.Text = Dgrid_NhanVien.Rows[rowIndex].Cells[1].Value.ToString();
            Txt_TenNv.Text = Dgrid_NhanVien.Rows[rowIndex].Cells[2].Value.ToString();
            Txt_DiaChiNv.Text = Dgrid_NhanVien.Rows[rowIndex].Cells[3].Value.ToString();
            Cbx_HD.Checked = Dgrid_NhanVien.Rows[rowIndex].Cells[4].Value.ToString() == "Hoạt động" ? true : false;
            Cbx_KHD.Checked = Dgrid_NhanVien.Rows[rowIndex].Cells[4].Value.ToString() == "Không hoạt động" ? true : false;
            Rbt_NhanVien.Checked = Dgrid_NhanVien.Rows[rowIndex].Cells[6].Value.ToString() == "Nhân viên" ? true : false;
            Rbt_QuanLy.Checked = Dgrid_NhanVien.Rows[rowIndex].Cells[6].Value.ToString() == "Quản lý" ? true : false;
            IdWhenClick = _qlNhanVien.getlstNhanVien().Where(c => c.Email == Txt_EmailNv.Text).Select(c => c.MaNv).FirstOrDefault();
        }

        private void Btn_XoaNv_Click(object sender, EventArgs e)
        {
            var nhanVien = _qlNhanVien.getlstNhanVien().FirstOrDefault(c => c.MaNv == IdWhenClick);
            nhanVien.TrangThai = 1;
            MessageBox.Show(_qlNhanVien.Delete(nhanVien), "Thông báo");
            LoadData();
            //LoadData(); alo
        }
        private void Cbx_HD_CheckedChanged(object sender, EventArgs e)
        {
            if (Cbx_HD.Checked)
            {
                Cbx_KHD.Checked = false;
            }
        }

        private void Cbx_KHD_CheckedChanged(object sender, EventArgs e)
        {
            if (Cbx_KHD.Checked)
            {
                Cbx_HD.Checked = false;
            }
        }

        private void Txt_TimKiemNv_TextChanged(object sender, EventArgs e)
        {
            LoadData(Txt_TimKiemNv.Text);
        }
    }
}
