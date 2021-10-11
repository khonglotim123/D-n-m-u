
namespace _3_GUI_PresetationLayer
{
    partial class FrmQuanLySanPham
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Dgrid_DSSanPham = new System.Windows.Forms.DataGridView();
            this.Txt_TenSP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Nbx_SoLuong = new System.Windows.Forms.NumericUpDown();
            this.Txt_GhiChu = new System.Windows.Forms.TextBox();
            this.Txt_DonGiaBan = new System.Windows.Forms.TextBox();
            this.Btn_ThemSP = new System.Windows.Forms.Button();
            this.Btn_SuaSP = new System.Windows.Forms.Button();
            this.Btn_XoaSP = new System.Windows.Forms.Button();
            this.Txt_DonGiaNhap = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgrid_DSSanPham)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nbx_SoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Dgrid_DSSanPham);
            this.groupBox1.Location = new System.Drawing.Point(1, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(964, 295);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sản phẩm";
            // 
            // Dgrid_DSSanPham
            // 
            this.Dgrid_DSSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgrid_DSSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgrid_DSSanPham.Location = new System.Drawing.Point(6, 22);
            this.Dgrid_DSSanPham.Name = "Dgrid_DSSanPham";
            this.Dgrid_DSSanPham.RowTemplate.Height = 25;
            this.Dgrid_DSSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgrid_DSSanPham.Size = new System.Drawing.Size(947, 267);
            this.Dgrid_DSSanPham.TabIndex = 0;
            this.Dgrid_DSSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgrid_DSSanPham_CellClick);
            // 
            // Txt_TenSP
            // 
            this.Txt_TenSP.Location = new System.Drawing.Point(100, 45);
            this.Txt_TenSP.Name = "Txt_TenSP";
            this.Txt_TenSP.Size = new System.Drawing.Size(159, 23);
            this.Txt_TenSP.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tên hàng:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(169, 455);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(159, 23);
            this.textBox2.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(694, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 19);
            this.label5.TabIndex = 22;
            this.label5.Text = "Ghi chú:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(384, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "Đơn giá nhập:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(392, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "Đơn giá bán:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "Số lượng:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(965, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýSảnPhẩmToolStripMenuItem,
            this.quảnLýNhânViênToolStripMenuItem,
            this.quảnLýKháchHàngToolStripMenuItem});
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
            this.quảnLýNhânViênToolStripMenuItem.Text = "Quản lý Nhân viên";
            // 
            // quảnLýKháchHàngToolStripMenuItem
            // 
            this.quảnLýKháchHàngToolStripMenuItem.Name = "quảnLýKháchHàngToolStripMenuItem";
            this.quảnLýKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.quảnLýKháchHàngToolStripMenuItem.Text = "Quản lý Khách Hàng";
            // 
            // Nbx_SoLuong
            // 
            this.Nbx_SoLuong.Location = new System.Drawing.Point(100, 87);
            this.Nbx_SoLuong.Name = "Nbx_SoLuong";
            this.Nbx_SoLuong.Size = new System.Drawing.Size(159, 23);
            this.Nbx_SoLuong.TabIndex = 24;
            // 
            // Txt_GhiChu
            // 
            this.Txt_GhiChu.Location = new System.Drawing.Point(771, 48);
            this.Txt_GhiChu.Name = "Txt_GhiChu";
            this.Txt_GhiChu.Size = new System.Drawing.Size(159, 23);
            this.Txt_GhiChu.TabIndex = 25;
            // 
            // Txt_DonGiaBan
            // 
            this.Txt_DonGiaBan.Location = new System.Drawing.Point(501, 86);
            this.Txt_DonGiaBan.Name = "Txt_DonGiaBan";
            this.Txt_DonGiaBan.Size = new System.Drawing.Size(159, 23);
            this.Txt_DonGiaBan.TabIndex = 26;
            // 
            // Btn_ThemSP
            // 
            this.Btn_ThemSP.Location = new System.Drawing.Point(600, 445);
            this.Btn_ThemSP.Name = "Btn_ThemSP";
            this.Btn_ThemSP.Size = new System.Drawing.Size(75, 40);
            this.Btn_ThemSP.TabIndex = 27;
            this.Btn_ThemSP.Text = "Thêm";
            this.Btn_ThemSP.UseVisualStyleBackColor = true;
            this.Btn_ThemSP.Click += new System.EventHandler(this.Btn_ThemSP_Click);
            // 
            // Btn_SuaSP
            // 
            this.Btn_SuaSP.Location = new System.Drawing.Point(694, 445);
            this.Btn_SuaSP.Name = "Btn_SuaSP";
            this.Btn_SuaSP.Size = new System.Drawing.Size(75, 40);
            this.Btn_SuaSP.TabIndex = 28;
            this.Btn_SuaSP.Text = "Sửa";
            this.Btn_SuaSP.UseVisualStyleBackColor = true;
            // 
            // Btn_XoaSP
            // 
            this.Btn_XoaSP.Location = new System.Drawing.Point(787, 445);
            this.Btn_XoaSP.Name = "Btn_XoaSP";
            this.Btn_XoaSP.Size = new System.Drawing.Size(75, 40);
            this.Btn_XoaSP.TabIndex = 29;
            this.Btn_XoaSP.Text = "Xóa";
            this.Btn_XoaSP.UseVisualStyleBackColor = true;
            // 
            // Txt_DonGiaNhap
            // 
            this.Txt_DonGiaNhap.Location = new System.Drawing.Point(501, 48);
            this.Txt_DonGiaNhap.Name = "Txt_DonGiaNhap";
            this.Txt_DonGiaNhap.Size = new System.Drawing.Size(159, 23);
            this.Txt_DonGiaNhap.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(43, 456);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 19);
            this.label6.TabIndex = 31;
            this.label6.Text = "Tìm kiếm tại đây:";
            // 
            // FrmQuanLySanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 497);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Txt_DonGiaNhap);
            this.Controls.Add(this.Btn_XoaSP);
            this.Controls.Add(this.Btn_SuaSP);
            this.Controls.Add(this.Btn_ThemSP);
            this.Controls.Add(this.Txt_DonGiaBan);
            this.Controls.Add(this.Txt_GhiChu);
            this.Controls.Add(this.Nbx_SoLuong);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Txt_TenSP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmQuanLySanPham";
            this.Text = "FrmQuanLySanPham";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgrid_DSSanPham)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nbx_SoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView Dgrid_DSSanPham;
        private System.Windows.Forms.TextBox Txt_TenSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýSảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýKháchHàngToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown Nbx_SoLuong;
        private System.Windows.Forms.TextBox Txt_GhiChu;
        private System.Windows.Forms.TextBox Txt_DonGiaBan;
        private System.Windows.Forms.Button Btn_ThemSP;
        private System.Windows.Forms.Button Btn_SuaSP;
        private System.Windows.Forms.Button Btn_XoaSP;
        private System.Windows.Forms.TextBox Txt_DonGiaNhap;
        private System.Windows.Forms.Label label6;
    }
}