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
    public partial class FrmKhachHang : Form
    {
        BangTam _bangTam;
        IQLKhachHangService _qlKhachHang;
        IBangTamService _qlbangTam;
        public FrmKhachHang()
        {
            InitializeComponent();
            _bangTam = new BangTam();
            _qlbangTam = new BangTamService();
            _bangTam = _qlbangTam.getBangTam().FirstOrDefault();
            _qlKhachHang = new QLKhachHangService();
            LoadData();
        }
        void LoadData()
        {
            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();


            Dgrid_KhachHang.ColumnCount = 3;
            Dgrid_KhachHang.Columns[0].Name = "Số điện thoại";
            Dgrid_KhachHang.Columns[1].Name = "Họ và tên";
            Dgrid_KhachHang.Columns[2].Name = "Địa chỉ";
            Dgrid_KhachHang.Rows.Clear();
            foreach (var x in _qlKhachHang.getlstKhachHang().Where(c=>c.TrangThai==0))
            {
                Dgrid_KhachHang.Rows.Add(x.DienThoai,x.TenKhach,x.DiaChi);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Btn_TroLai_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain();
            this.Hide();
            frmMain.Show();
        }

        private void Btn_Xoa_Click(object sender, EventArgs e)
        {
            KhachHang khach = new KhachHang();
            khach.DienThoai = Txt_SDT.Text;
            khach.DiaChi = Txt_DiaChi.Text;
            khach.MaNv = _bangTam.Manv;
            khach.TenKhach = Txt_HoVaTen.Text;
            khach.Phai = Rbt_Nam.Checked ? "Nam" : "Nữ";
            khach.TrangThai = 0;
            MessageBox.Show(_qlKhachHang.Add(khach),"Thông báo");
            LoadData();
        }
    }
}
