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
    public partial class FrmThongKeTonKho : Form
    {
        IQLSanPhamService _qLSanPham;
        List<Hang> _lstHang;
        BangTam _bangtam;
        IBangTamService _BT;
        public FrmThongKeTonKho()
        {
            _qLSanPham = new QLSanPhamService();
            _lstHang = new List<Hang>();
            _lstHang = _qLSanPham.getlstSanPham();
            _bangtam = new BangTam();
            _BT = new BangTamService();
            _bangtam = _BT.getBangTam().FirstOrDefault();
            LoadData();
        }
        void LoadData()
        {
            Dgrid_TonKho.ColumnCount = 2;
            Dgrid_TonKho.Columns[0].Name = "Tên sản phẩm";
            Dgrid_TonKho.Columns[1].Name = "Số lượng tồn kho";
            Dgrid_TonKho.Rows.Clear();
            foreach (var x in _lstHang.Where(c=>c.TrangThai==0))
            {
                Dgrid_TonKho.Rows.Add(x.TenHang,x.SoLuong);
            }
        }

        private void Btn_TroLai_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain();
            this.Hide();
            frmMain.Show();
        }

        private void FrmThongKeTonKho_FormClosed(object sender, FormClosedEventArgs e)
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
