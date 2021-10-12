
namespace _3_GUI_PresetationLayer
{
    partial class FrmQLNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Dgrid_NhanVien = new System.Windows.Forms.DataGridView();
            this.Cbx_KHD = new System.Windows.Forms.CheckBox();
            this.Cbx_HD = new System.Windows.Forms.CheckBox();
            this.Rbt_QuanLy = new System.Windows.Forms.RadioButton();
            this.Rbt_NhanVien = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_DiaChiNv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_TenNv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_EmailNv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_TimKiemNv = new System.Windows.Forms.TextBox();
            this.Btn_XoaNv = new System.Windows.Forms.Button();
            this.Btn_SuaNv = new System.Windows.Forms.Button();
            this.Btn_ThemNv = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.Dgrid_NhanVien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dgrid_NhanVien
            // 
            this.Dgrid_NhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgrid_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgrid_NhanVien.Location = new System.Drawing.Point(6, 22);
            this.Dgrid_NhanVien.Name = "Dgrid_NhanVien";
            this.Dgrid_NhanVien.RowTemplate.Height = 25;
            this.Dgrid_NhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgrid_NhanVien.Size = new System.Drawing.Size(965, 318);
            this.Dgrid_NhanVien.TabIndex = 0;
            this.Dgrid_NhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgrid_NhanVien_CellClick);
            // 
            // Cbx_KHD
            // 
            this.Cbx_KHD.AutoSize = true;
            this.Cbx_KHD.Location = new System.Drawing.Point(487, 102);
            this.Cbx_KHD.Name = "Cbx_KHD";
            this.Cbx_KHD.Size = new System.Drawing.Size(119, 19);
            this.Cbx_KHD.TabIndex = 61;
            this.Cbx_KHD.Text = "Không hoạt động";
            this.Cbx_KHD.UseVisualStyleBackColor = true;
            this.Cbx_KHD.CheckedChanged += new System.EventHandler(this.Cbx_KHD_CheckedChanged);
            // 
            // Cbx_HD
            // 
            this.Cbx_HD.AutoSize = true;
            this.Cbx_HD.Location = new System.Drawing.Point(385, 102);
            this.Cbx_HD.Name = "Cbx_HD";
            this.Cbx_HD.Size = new System.Drawing.Size(83, 19);
            this.Cbx_HD.TabIndex = 60;
            this.Cbx_HD.Text = "Hoạt động";
            this.Cbx_HD.UseVisualStyleBackColor = true;
            this.Cbx_HD.CheckedChanged += new System.EventHandler(this.Cbx_HD_CheckedChanged);
            // 
            // Rbt_QuanLy
            // 
            this.Rbt_QuanLy.AutoSize = true;
            this.Rbt_QuanLy.Location = new System.Drawing.Point(856, 47);
            this.Rbt_QuanLy.Name = "Rbt_QuanLy";
            this.Rbt_QuanLy.Size = new System.Drawing.Size(66, 19);
            this.Rbt_QuanLy.TabIndex = 59;
            this.Rbt_QuanLy.TabStop = true;
            this.Rbt_QuanLy.Text = "Quản lý";
            this.Rbt_QuanLy.UseVisualStyleBackColor = true;
            // 
            // Rbt_NhanVien
            // 
            this.Rbt_NhanVien.AutoSize = true;
            this.Rbt_NhanVien.Location = new System.Drawing.Point(771, 47);
            this.Rbt_NhanVien.Name = "Rbt_NhanVien";
            this.Rbt_NhanVien.Size = new System.Drawing.Size(79, 19);
            this.Rbt_NhanVien.TabIndex = 58;
            this.Rbt_NhanVien.TabStop = true;
            this.Rbt_NhanVien.Text = "Nhân viên";
            this.Rbt_NhanVien.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(682, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 19);
            this.label6.TabIndex = 57;
            this.label6.Text = "Vai trò:";
            // 
            // Txt_DiaChiNv
            // 
            this.Txt_DiaChiNv.Location = new System.Drawing.Point(385, 46);
            this.Txt_DiaChiNv.Name = "Txt_DiaChiNv";
            this.Txt_DiaChiNv.Size = new System.Drawing.Size(190, 23);
            this.Txt_DiaChiNv.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(293, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 19);
            this.label5.TabIndex = 55;
            this.label5.Text = "Tình trạng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(315, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 19);
            this.label4.TabIndex = 54;
            this.label4.Text = "Địa chỉ:";
            // 
            // Txt_TenNv
            // 
            this.Txt_TenNv.Location = new System.Drawing.Point(75, 100);
            this.Txt_TenNv.Name = "Txt_TenNv";
            this.Txt_TenNv.Size = new System.Drawing.Size(190, 23);
            this.Txt_TenNv.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(5, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 52;
            this.label3.Text = "Tên Nv:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 19);
            this.label2.TabIndex = 51;
            this.label2.Text = "Email:";
            // 
            // Txt_EmailNv
            // 
            this.Txt_EmailNv.Location = new System.Drawing.Point(75, 46);
            this.Txt_EmailNv.Name = "Txt_EmailNv";
            this.Txt_EmailNv.Size = new System.Drawing.Size(190, 23);
            this.Txt_EmailNv.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(31, 512);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 19);
            this.label1.TabIndex = 49;
            this.label1.Text = "Tìm kiếm tại đây:";
            // 
            // Txt_TimKiemNv
            // 
            this.Txt_TimKiemNv.Location = new System.Drawing.Point(149, 511);
            this.Txt_TimKiemNv.Name = "Txt_TimKiemNv";
            this.Txt_TimKiemNv.Size = new System.Drawing.Size(190, 23);
            this.Txt_TimKiemNv.TabIndex = 48;
            this.Txt_TimKiemNv.TextChanged += new System.EventHandler(this.Txt_TimKiemNv_TextChanged);
            // 
            // Btn_XoaNv
            // 
            this.Btn_XoaNv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_XoaNv.Location = new System.Drawing.Point(819, 495);
            this.Btn_XoaNv.Name = "Btn_XoaNv";
            this.Btn_XoaNv.Size = new System.Drawing.Size(117, 49);
            this.Btn_XoaNv.TabIndex = 47;
            this.Btn_XoaNv.Text = "Xóa";
            this.Btn_XoaNv.UseVisualStyleBackColor = true;
            this.Btn_XoaNv.Click += new System.EventHandler(this.Btn_XoaNv_Click);
            // 
            // Btn_SuaNv
            // 
            this.Btn_SuaNv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_SuaNv.Location = new System.Drawing.Point(682, 495);
            this.Btn_SuaNv.Name = "Btn_SuaNv";
            this.Btn_SuaNv.Size = new System.Drawing.Size(116, 49);
            this.Btn_SuaNv.TabIndex = 46;
            this.Btn_SuaNv.Text = "Sửa";
            this.Btn_SuaNv.UseVisualStyleBackColor = true;
            this.Btn_SuaNv.Click += new System.EventHandler(this.Btn_SuaNv_Click);
            // 
            // Btn_ThemNv
            // 
            this.Btn_ThemNv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_ThemNv.Location = new System.Drawing.Point(540, 495);
            this.Btn_ThemNv.Name = "Btn_ThemNv";
            this.Btn_ThemNv.Size = new System.Drawing.Size(117, 49);
            this.Btn_ThemNv.TabIndex = 45;
            this.Btn_ThemNv.Text = "Thêm";
            this.Btn_ThemNv.UseVisualStyleBackColor = true;
            this.Btn_ThemNv.Click += new System.EventHandler(this.Btn_ThemNv_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Dgrid_NhanVien);
            this.groupBox1.Location = new System.Drawing.Point(5, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(977, 346);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách nhân viên";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1006, 24);
            this.menuStrip1.TabIndex = 64;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýSảnPhẩmToolStripMenuItem,
            this.quảnLýNhânViênToolStripMenuItem,
            this.quảnLýKháchHàngToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem,
            this.đổiMậtKhẩuToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // quảnLýSảnPhẩmToolStripMenuItem
            // 
            this.quảnLýSảnPhẩmToolStripMenuItem.Name = "quảnLýSảnPhẩmToolStripMenuItem";
            this.quảnLýSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.quảnLýSảnPhẩmToolStripMenuItem.Text = "Quản lý Sản Phẩm";
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            this.quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            this.quảnLýNhânViênToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.quảnLýNhânViênToolStripMenuItem.Text = "Quản lý Nhân Viên";
            // 
            // quảnLýKháchHàngToolStripMenuItem
            // 
            this.quảnLýKháchHàngToolStripMenuItem.Name = "quảnLýKháchHàngToolStripMenuItem";
            this.quảnLýKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.quảnLýKháchHàngToolStripMenuItem.Text = "Quản lý Khách Hàng";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            // 
            // FrmQLNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 566);
            this.Controls.Add(this.Cbx_KHD);
            this.Controls.Add(this.Cbx_HD);
            this.Controls.Add(this.Rbt_QuanLy);
            this.Controls.Add(this.Rbt_NhanVien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Txt_DiaChiNv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt_TenNv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_EmailNv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_TimKiemNv);
            this.Controls.Add(this.Btn_XoaNv);
            this.Controls.Add(this.Btn_SuaNv);
            this.Controls.Add(this.Btn_ThemNv);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmQLNhanVien";
            this.Text = "FrmQLNhanVien";
            ((System.ComponentModel.ISupportInitialize)(this.Dgrid_NhanVien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Dgrid_NhanVien;
        private System.Windows.Forms.CheckBox Cbx_KHD;
        private System.Windows.Forms.CheckBox Cbx_HD;
        private System.Windows.Forms.RadioButton Rbt_QuanLy;
        private System.Windows.Forms.RadioButton Rbt_NhanVien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_DiaChiNv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_TenNv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_EmailNv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_TimKiemNv;
        private System.Windows.Forms.Button Btn_XoaNv;
        private System.Windows.Forms.Button Btn_SuaNv;
        private System.Windows.Forms.Button Btn_ThemNv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýSảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
    }
}