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
        int id;
        public FrmKhachHang()
        {
            InitializeComponent();
            _bangTam = new BangTam();
            _qlbangTam = new BangTamService();
            _bangTam = _qlbangTam.getBangTam().FirstOrDefault();
            _qlKhachHang = new QLKhachHangService();
            Txt_Id.Enabled = false;
            LoadData();
        }
        void LoadData()
        {
            DataGridViewComboBoxColumn cmbchucnang = new DataGridViewComboBoxColumn();
            cmbchucnang.Name = "CmxChucNang";
            cmbchucnang.HeaderText = "Chức năng";
            cmbchucnang.Items.Add("Thêm");
            cmbchucnang.Items.Add("Sửa");
            cmbchucnang.Items.Add("Xóa");

            DataGridViewComboBoxColumn cmbgioitinh = new DataGridViewComboBoxColumn();
            cmbgioitinh.Name = "CmxGioiTinh";
            cmbgioitinh.HeaderText = "Giới tính";
            cmbgioitinh.Items.Add("Nam");
            cmbgioitinh.Items.Add("Nữ");

            DataGridViewButtonColumn Btn = new DataGridViewButtonColumn();
            Btn.Name = "Xacnhan";
            Btn.HeaderText = "Xác nhận";
            Btn.UseColumnTextForButtonValue = true;
            Btn.Text = "Xác Nhận";

            Dgrid_KhachHang.ColumnCount = 4;
            Dgrid_KhachHang.Columns[0].Name = "Số điện thoại";
            Dgrid_KhachHang.Columns[1].Name = "Họ và tên";
            Dgrid_KhachHang.Columns[2].Name = "Địa chỉ";
            Dgrid_KhachHang.Columns[3].Name = "Địa chỉ";            
            Dgrid_KhachHang.Columns.Add(cmbgioitinh);
            Dgrid_KhachHang.Columns.Add(cmbchucnang);
            Dgrid_KhachHang.Columns.Add(Btn);
            Dgrid_KhachHang.Columns[3].Visible = false;
            Dgrid_KhachHang.Rows.Clear();
            foreach (var x in _qlKhachHang.getlstKhachHang().Where(c=>c.TrangThai==0))
            {
                Dgrid_KhachHang.Rows.Add(x.DienThoai,x.TenKhach,x.DiaChi,x.Id,x.Phai);
            }
        }
        void LoadData(string a)
        {
            DataGridViewComboBoxColumn cmbchucnang = new DataGridViewComboBoxColumn();
            cmbchucnang.Name = "CmxChucNang";
            cmbchucnang.HeaderText = "Chức năng";
            cmbchucnang.Items.Add("Thêm");
            cmbchucnang.Items.Add("Sửa");
            cmbchucnang.Items.Add("Xóa");

            DataGridViewComboBoxColumn cmbgioitinh = new DataGridViewComboBoxColumn();
            cmbgioitinh.Name = "CmxGioiTinh";
            cmbgioitinh.HeaderText = "Giới tính";
            cmbgioitinh.Items.Add("Nam");
            cmbgioitinh.Items.Add("Nữ");

            DataGridViewButtonColumn Btn = new DataGridViewButtonColumn();
            Btn.Name = "Xacnhan";
            Btn.HeaderText = "Xác nhận";
            Btn.UseColumnTextForButtonValue = true;
            Btn.Text = "Xác Nhận";

            Dgrid_KhachHang.ColumnCount = 4;
            Dgrid_KhachHang.Columns[0].Name = "Số điện thoại";
            Dgrid_KhachHang.Columns[1].Name = "Họ và tên";
            Dgrid_KhachHang.Columns[2].Name = "Địa chỉ";
            Dgrid_KhachHang.Columns[3].Name = "id";            
            Dgrid_KhachHang.Columns.Add(cmbgioitinh);
            Dgrid_KhachHang.Columns.Add(cmbchucnang);
            Dgrid_KhachHang.Columns.Add(Btn);
            Dgrid_KhachHang.Columns[3].Visible = false;
            Dgrid_KhachHang.Rows.Clear();
            foreach (var x in _qlKhachHang.getlstKhachHang().Where(c => c.TrangThai == 0 && (c.TenKhach.ToLower().StartsWith(a) ||c.DienThoai.StartsWith(a))))
            {
                Dgrid_KhachHang.Rows.Add(x.DienThoai, x.TenKhach, x.DiaChi,x.Id, x.Phai);
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
            khach.Id = (_qlKhachHang.getlstKhachHang().Count + 1);
            khach.DienThoai = Txt_SDT.Text;
            khach.DiaChi = Txt_DiaChi.Text;
            khach.MaNv = _bangTam.Manv;
            khach.TenKhach = Txt_HoVaTen.Text;
            khach.Phai = Rbt_Nam.Checked ? "Nam" : "Nữ";
            khach.TrangThai = 0;
            MessageBox.Show(_qlKhachHang.Add(khach),"Thông báo");
            LoadData();
        }

        private void Dgrid_KhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            var columns = e.ColumnIndex;
            if (rowIndex == _qlKhachHang.getlstKhachHang().Count) return;
            //if (Dgrid_KhachHang.Rows[rowIndex].Cells[0].Value.ToString() == null)
            //{
            //    Txt_SDT.Text = null;
            //}
            Txt_SDT.Text = Dgrid_KhachHang.Rows[rowIndex].Cells[0].Value.ToString();
            Txt_Id.Text = Dgrid_KhachHang.Rows[rowIndex].Cells[3].Value.ToString();
            Txt_HoVaTen.Text = Dgrid_KhachHang.Rows[rowIndex].Cells[1].Value.ToString();
            Txt_DiaChi.Text = Dgrid_KhachHang.Rows[rowIndex].Cells[2].Value.ToString();
            Rbt_Nam.Checked = Dgrid_KhachHang.Rows[rowIndex].Cells[4].Value.ToString() == "Nam" ? false : true;
            Rbt_Nu.Checked = Dgrid_KhachHang.Rows[rowIndex].Cells[4].Value.ToString() == "Nữ" ? false : true;
            id = (int)_qlKhachHang.getlstKhachHang().Where(c=>c.Id==Convert.ToInt32(Txt_Id.Text)).Select(c=>c.Id).FirstOrDefault();
            if (e.ColumnIndex == Dgrid_KhachHang.Columns["Xacnhan"].Index)
            {
                if (Dgrid_KhachHang.Rows[rowIndex].Cells[5].Value.ToString() == "Thêm")
                {
                    KhachHang khach = new KhachHang();
                    khach.Id = (_qlKhachHang.getlstKhachHang().Count + 1);
                    khach.DienThoai = Dgrid_KhachHang.Rows[rowIndex].Cells[0].Value.ToString();
                    khach.TenKhach = Dgrid_KhachHang.Rows[rowIndex].Cells[1].Value.ToString();
                    khach.DiaChi = Dgrid_KhachHang.Rows[rowIndex].Cells[2].Value.ToString();
                    khach.Phai = Dgrid_KhachHang.Rows[rowIndex].Cells[4].Value.ToString();
                    khach.MaNv = _bangTam.Manv;
                    khach.TrangThai = 0;
                    MessageBox.Show(_qlKhachHang.Add(khach),"Thông báo");
                    LoadData();
                } else
                if (Dgrid_KhachHang.Rows[rowIndex].Cells[5].Value.ToString() == "Sửa")
                {
                    KhachHang khach = new KhachHang();
                    khach = _qlKhachHang.getlstKhachHang().FirstOrDefault(c=>c.Id==id);
                    khach.TenKhach = Dgrid_KhachHang.Rows[rowIndex].Cells[1].Value.ToString();
                    khach.DiaChi = Dgrid_KhachHang.Rows[rowIndex].Cells[2].Value.ToString();
                    khach.Phai = Dgrid_KhachHang.Rows[rowIndex].Cells[4].Value.ToString();
                    MessageBox.Show(_qlKhachHang.Update(khach),"thông báo");
                    LoadData();
                }else
                if (Dgrid_KhachHang.Rows[rowIndex].Cells[5].Value.ToString() == "Xóa")
                {
                    KhachHang khach = new KhachHang();
                    khach = _qlKhachHang.getlstKhachHang().FirstOrDefault(c=>c.Id==id);
                    khach.TrangThai = 1;
                    MessageBox.Show(_qlKhachHang.Delete(khach),"Thông báo");
                    LoadData();
                }
            }
        }

        private void Btn_Sua_Click(object sender, EventArgs e)
        {
            KhachHang khach = new KhachHang();
            khach = _qlKhachHang.getlstKhachHang().FirstOrDefault(c => c.Id == id);
            khach.DiaChi = Txt_SDT.Text;
            khach.TenKhach = Txt_HoVaTen.Text;
            khach.DiaChi = Txt_DiaChi.Text;
            khach.Phai = Rbt_Nam.Checked ? "Nam" : "Nữ";
            MessageBox.Show(_qlKhachHang.Update(khach), "thông báo");
            LoadData();
        }

        private void Btn_XoaKH_Click(object sender, EventArgs e)
        {
            KhachHang khach = new KhachHang();
            khach = _qlKhachHang.getlstKhachHang().FirstOrDefault(c => c.Id == id);
            khach.TrangThai = 1;
            MessageBox.Show(_qlKhachHang.Delete(khach), "Thông báo");
            LoadData();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            LoadData(Txt_Seach.Text);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
