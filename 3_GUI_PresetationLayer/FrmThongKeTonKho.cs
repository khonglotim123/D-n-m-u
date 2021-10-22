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
        public FrmThongKeTonKho()
        {
            _qLSanPham = new QLSanPhamService();
        }
        void LoadData()
        {
            Dgrid_TonKho.ColumnCount = 2;
            Dgrid_TonKho.Columns[0].Name = "Tên sản phẩm";
            Dgrid_TonKho.Columns[1].Name = "Số lượng tồn kho";
            Dgrid_TonKho.Rows.Clear();
            foreach (var x in _qLSanPham.getlstSanPham().Where(c=>c.TrangThai==0))
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
    }
}
