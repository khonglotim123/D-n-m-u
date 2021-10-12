using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1_DAL_DataAccessLayer.Models;
using _2_BUS_BusinessLayer.Services;
using _2_BUS_BusinessLayer.IServices;

namespace _3_GUI_PresetationLayer
{
    public partial class FrmQuanLySanPham : Form
    {
        IBangTamService _BT;
        IQLSanPhamService _QLSP;
        BangTam _bangTam;
        int IdWhenClick;
        string link;
        public FrmQuanLySanPham()
        {
            InitializeComponent();
            _BT = new BangTamService();
            _QLSP = new QLSanPhamService();
            _bangTam = new BangTam();
            _bangTam = _BT.getBangTam().FirstOrDefault();
            LoadData();
        }
        void LoadData()
        {
            Dgrid_DSSanPham.ColumnCount = 5;
            Dgrid_DSSanPham.Columns[0].Name = "Tên sản phẩm";
            Dgrid_DSSanPham.Columns[1].Name = "Số lượng";
            Dgrid_DSSanPham.Columns[2].Name = "Đơn giá nhập";
            Dgrid_DSSanPham.Columns[3].Name = "Đơn giá bán";
            Dgrid_DSSanPham.Columns[4].Name = "Ghi chú";
            Dgrid_DSSanPham.Rows.Clear();
            foreach (var x in _QLSP.getlstSanPham().Where(c => c.TrangThai == 0))
            {
                Dgrid_DSSanPham.Rows.Add(x.TenHang, x.SoLuong, x.DonGiaNhap, x.DonGiaBan, x.GhiChu);
            }
        }

        private void Btn_ThemSP_Click(object sender, EventArgs e)
        {
            Hang hang = new Hang();
            hang.MaHang = (_QLSP.getlstSanPham().Count() + 1);
            hang.TenHang = Txt_TenSP.Text;
            hang.SoLuong = Convert.ToInt32(Nbx_SoLuong.Value.ToString());
            hang.DonGiaBan = Convert.ToDouble(Txt_DonGiaBan.Text);
            hang.DonGiaNhap = Convert.ToDouble(Txt_DonGiaNhap.Text);
            hang.GhiChu = Txt_GhiChu.Text;
            hang.MaNv = _bangTam.Manv;
            hang.HinhAnh = link;
            hang.TrangThai = 0;
            MessageBox.Show(_QLSP.Add(hang), "Thông báo");
            LoadData();
        }

        private void Dgrid_DSSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex == _QLSP.getlstSanPham().Count) return;
            Txt_TenSP.Text = Dgrid_DSSanPham.Rows[rowIndex].Cells[0].Value.ToString();
            Txt_DonGiaNhap.Text = Dgrid_DSSanPham.Rows[rowIndex].Cells[2].Value.ToString();
            Nbx_SoLuong.Value =Convert.ToInt32(Dgrid_DSSanPham.Rows[rowIndex].Cells[1].Value);
            Txt_TenSP.Text = Dgrid_DSSanPham.Rows[rowIndex].Cells[0].Value.ToString();
            Txt_TenSP.Text = Dgrid_DSSanPham.Rows[rowIndex].Cells[0].Value.ToString();
            IdWhenClick = _QLSP.getlstSanPham().Where(c => c.TenHang == Txt_TenSP.Text).Select(c => c.MaHang).FirstOrDefault();
            Pict_Anh.Image = Image.FromFile(_QLSP.getlstSanPham().Where(c=>c.MaHang==IdWhenClick).Select(c=>c.HinhAnh).FirstOrDefault());
        }

        private void Btn_SuaSP_Click(object sender, EventArgs e)
        {
            Hang hang = _QLSP.getlstSanPham().FirstOrDefault(c=>c.MaHang==IdWhenClick);
            hang.TenHang = Txt_TenSP.Text;
            hang.SoLuong = Convert.ToInt32(Nbx_SoLuong.Value.ToString());
            hang.DonGiaBan = Convert.ToDouble(Txt_DonGiaBan.Text);
            hang.DonGiaNhap = Convert.ToDouble(Txt_DonGiaNhap.Text);
            hang.GhiChu = Txt_GhiChu.Text;
            hang.MaNv = _bangTam.Manv;
            hang.HinhAnh = link;
            MessageBox.Show(_QLSP.Update(hang), "Thông báo");
            LoadData();
        }

        private void Btn_XoaSP_Click(object sender, EventArgs e)
        {
            Hang hang = _QLSP.getlstSanPham().FirstOrDefault(c => c.MaHang == IdWhenClick);
            hang.TrangThai = 1;
            MessageBox.Show(_QLSP.Delete(hang), "Thông báo");
            LoadData();
        }

        private void Pict_Anh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                link = openFileDialog.FileName;
                Pict_Anh.Image = Image.FromFile(link);
            }
        }
    }
}
