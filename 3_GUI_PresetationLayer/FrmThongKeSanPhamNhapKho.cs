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
using _2_BUS_BusinessLayer.IServices;
using _2_BUS_BusinessLayer.Services;

namespace _3_GUI_PresetationLayer
{
    public partial class FrmThongKeSanPhamNhapKho : Form
    {
        IQLNhanVienService _qlNhanVien;
        IQLSanPhamService _qlSanPham;
        BangTam _bangtam;
        IBangTamService _BT;
        public FrmThongKeSanPhamNhapKho()
        {
            InitializeComponent();
            _qlNhanVien = new QLNhanVienService();
            _qlSanPham = new QLSanPhamService();
            _bangtam = new BangTam();
            _BT = new BangTamService();
            _bangtam = _BT.getBangTam().FirstOrDefault();
            LoadData();
        }
        void LoadData()
        {
            Dgrid_SPNK.ColumnCount = 3;
            Dgrid_SPNK.Columns[0].Name = "Mã nhân viên";
            Dgrid_SPNK.Columns[1].Name = "Tên nhân viên";
            Dgrid_SPNK.Columns[2].Name = "Số lượng sản phẩm nhập";
            Dgrid_SPNK.Rows.Clear();
            foreach (var x in _qlNhanVien.getlstNhanVien().Where(c=>c.TrangThai==0))
            {
                Dgrid_SPNK.Rows.Add(x.MaNv,x.TeNv,_qlSanPham.getlstSanPham().Where(c=>c.MaNv==x.MaNv).Select(c=>c.MaNv).Count());
            }
        }

        private void Btn_TroLai_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain();
            this.Hide();
            frmMain.Show();
        }

        private void FrmThongKeSanPhamNhapKho_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (_bangtam != null)
                {
                    _BT.DeleteBangTam(_bangtam);
                    Application.Exit();
                }
                else
                {
                    Application.Exit();
                }

            }
        }
    }
}
