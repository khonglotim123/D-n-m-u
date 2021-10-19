﻿using System;
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
            DataGridViewButtonColumn Xacnhan = new DataGridViewButtonColumn();
            Xacnhan.Name = "Xacnhan";
            Xacnhan.HeaderText = "Xác nhận";
            Xacnhan.UseColumnTextForButtonValue = true;
            Xacnhan.Text = "Xác nhận";

            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();            
            cmb.HeaderText = "Chức năng";
            cmb.Items.Add("Xóa");
            cmb.Items.Add("Sửa");
            cmb.Name = "combobox";

            Dgrid_DSSanPham.ColumnCount = 7;
            Dgrid_DSSanPham.Columns[0].Name = "Tên sản phẩm";
            Dgrid_DSSanPham.Columns[1].Name = "Số lượng";
            Dgrid_DSSanPham.Columns[2].Name = "Đơn giá nhập";
            Dgrid_DSSanPham.Columns[3].Name = "Đơn giá bán";
            Dgrid_DSSanPham.Columns[4].Name = "Ghi chú";
            Dgrid_DSSanPham.Columns[5].Name = "Ảnh";
            Dgrid_DSSanPham.Columns.Add(cmb);
            Dgrid_DSSanPham.Columns.Add(Xacnhan);
            Dgrid_DSSanPham.Rows.Clear();
            foreach (var x in _QLSP.getlstSanPham().Where(c => c.TrangThai == 0))
            {
                Dgrid_DSSanPham.Rows.Add(x.TenHang, x.SoLuong, x.DonGiaNhap, x.DonGiaBan, x.GhiChu,x.HinhAnh);
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
            var columns = e.ColumnIndex;
            if (rowIndex == _QLSP.getlstSanPham().Count) return;
            Txt_TenSP.Text = Dgrid_DSSanPham.Rows[rowIndex].Cells[0].Value.ToString();
            Txt_DonGiaNhap.Text = Dgrid_DSSanPham.Rows[rowIndex].Cells[2].Value.ToString();
            Nbx_SoLuong.Value =Convert.ToInt32(Dgrid_DSSanPham.Rows[rowIndex].Cells[1].Value);
            Txt_DonGiaBan.Text = Dgrid_DSSanPham.Rows[rowIndex].Cells[3].Value.ToString();
            Txt_GhiChu.Text = Dgrid_DSSanPham.Rows[rowIndex].Cells[4].Value.ToString();
            IdWhenClick = _QLSP.getlstSanPham().Where(c => c.TenHang == Txt_TenSP.Text).Select(c => c.MaHang).FirstOrDefault();
            if (e.ColumnIndex == Dgrid_DSSanPham.Columns["Xacnhan"].Index)
            {
                if (e.ColumnIndex == Dgrid_DSSanPham.Columns["combobox"].Index)
                {

                }                
            }
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
        void LoadData(string timkiem)
        {
            Dgrid_DSSanPham.ColumnCount = 5;
            Dgrid_DSSanPham.Columns[0].Name = "Tên sản phẩm";
            Dgrid_DSSanPham.Columns[1].Name = "Số lượng";
            Dgrid_DSSanPham.Columns[2].Name = "Đơn giá nhập";
            Dgrid_DSSanPham.Columns[3].Name = "Đơn giá bán";
            Dgrid_DSSanPham.Columns[4].Name = "Ghi chú";
            Dgrid_DSSanPham.Rows.Clear();
            foreach (var x in _QLSP.getlstSanPham().Where(c => c.TrangThai == 0 && c.TenHang.ToLower().StartsWith(timkiem)))
            {
                Dgrid_DSSanPham.Rows.Add(x.TenHang, x.SoLuong, x.DonGiaNhap, x.DonGiaBan, x.GhiChu);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            LoadData(Txt_TimKiemSP.Text);
        }
    }
}
