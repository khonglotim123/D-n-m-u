
namespace _3_GUI_PresetationLayer
{
    partial class FrmKhachHang
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
            this.Dgrid_KhachHang = new System.Windows.Forms.DataGridView();
            this.Txt_SDT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_HoVaTen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Rbt_Nam = new System.Windows.Forms.RadioButton();
            this.Rbt_Nu = new System.Windows.Forms.RadioButton();
            this.Txt_DiaChi = new System.Windows.Forms.TextBox();
            this.Txt_Seach = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Btn_Xoa = new System.Windows.Forms.Button();
            this.Btn_TroLai = new System.Windows.Forms.Button();
            this.Btn_Sua = new System.Windows.Forms.Button();
            this.Btn_XoaKH = new System.Windows.Forms.Button();
            this.Txt_Id = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgrid_KhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Dgrid_KhachHang);
            this.groupBox1.Location = new System.Drawing.Point(12, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(871, 277);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách khách hàng";
            // 
            // Dgrid_KhachHang
            // 
            this.Dgrid_KhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgrid_KhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgrid_KhachHang.Location = new System.Drawing.Point(6, 22);
            this.Dgrid_KhachHang.Name = "Dgrid_KhachHang";
            this.Dgrid_KhachHang.RowTemplate.Height = 25;
            this.Dgrid_KhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgrid_KhachHang.Size = new System.Drawing.Size(859, 249);
            this.Dgrid_KhachHang.TabIndex = 0;
            this.Dgrid_KhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgrid_KhachHang_CellClick);
            // 
            // Txt_SDT
            // 
            this.Txt_SDT.Location = new System.Drawing.Point(172, 75);
            this.Txt_SDT.Name = "Txt_SDT";
            this.Txt_SDT.Size = new System.Drawing.Size(149, 23);
            this.Txt_SDT.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(302, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 54);
            this.label2.TabIndex = 3;
            this.label2.Text = "Khách Hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số điện thoại:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hộ và tên:";
            // 
            // Txt_HoVaTen
            // 
            this.Txt_HoVaTen.Location = new System.Drawing.Point(172, 117);
            this.Txt_HoVaTen.Name = "Txt_HoVaTen";
            this.Txt_HoVaTen.Size = new System.Drawing.Size(149, 23);
            this.Txt_HoVaTen.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(459, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Địa chỉ:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(450, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Giới tính:";
            // 
            // Rbt_Nam
            // 
            this.Rbt_Nam.AutoSize = true;
            this.Rbt_Nam.Location = new System.Drawing.Point(538, 118);
            this.Rbt_Nam.Name = "Rbt_Nam";
            this.Rbt_Nam.Size = new System.Drawing.Size(51, 19);
            this.Rbt_Nam.TabIndex = 8;
            this.Rbt_Nam.TabStop = true;
            this.Rbt_Nam.Text = "Nam";
            this.Rbt_Nam.UseVisualStyleBackColor = true;
            // 
            // Rbt_Nu
            // 
            this.Rbt_Nu.AutoSize = true;
            this.Rbt_Nu.Location = new System.Drawing.Point(626, 118);
            this.Rbt_Nu.Name = "Rbt_Nu";
            this.Rbt_Nu.Size = new System.Drawing.Size(41, 19);
            this.Rbt_Nu.TabIndex = 9;
            this.Rbt_Nu.TabStop = true;
            this.Rbt_Nu.Text = "Nữ";
            this.Rbt_Nu.UseVisualStyleBackColor = true;
            // 
            // Txt_DiaChi
            // 
            this.Txt_DiaChi.Location = new System.Drawing.Point(538, 75);
            this.Txt_DiaChi.Name = "Txt_DiaChi";
            this.Txt_DiaChi.Size = new System.Drawing.Size(149, 23);
            this.Txt_DiaChi.TabIndex = 10;
            // 
            // Txt_Seach
            // 
            this.Txt_Seach.Location = new System.Drawing.Point(130, 442);
            this.Txt_Seach.Name = "Txt_Seach";
            this.Txt_Seach.Size = new System.Drawing.Size(149, 23);
            this.Txt_Seach.TabIndex = 11;
            this.Txt_Seach.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 445);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tìm kiếm tại đây:";
            // 
            // Btn_Xoa
            // 
            this.Btn_Xoa.Location = new System.Drawing.Point(568, 445);
            this.Btn_Xoa.Name = "Btn_Xoa";
            this.Btn_Xoa.Size = new System.Drawing.Size(75, 38);
            this.Btn_Xoa.TabIndex = 13;
            this.Btn_Xoa.Text = "Thêm";
            this.Btn_Xoa.UseVisualStyleBackColor = true;
            this.Btn_Xoa.Click += new System.EventHandler(this.Btn_Xoa_Click);
            // 
            // Btn_TroLai
            // 
            this.Btn_TroLai.Location = new System.Drawing.Point(420, 447);
            this.Btn_TroLai.Name = "Btn_TroLai";
            this.Btn_TroLai.Size = new System.Drawing.Size(75, 34);
            this.Btn_TroLai.TabIndex = 14;
            this.Btn_TroLai.Text = "Trở lại";
            this.Btn_TroLai.UseVisualStyleBackColor = true;
            this.Btn_TroLai.Click += new System.EventHandler(this.Btn_TroLai_Click);
            // 
            // Btn_Sua
            // 
            this.Btn_Sua.Location = new System.Drawing.Point(659, 445);
            this.Btn_Sua.Name = "Btn_Sua";
            this.Btn_Sua.Size = new System.Drawing.Size(75, 38);
            this.Btn_Sua.TabIndex = 15;
            this.Btn_Sua.Text = "Sửa";
            this.Btn_Sua.UseVisualStyleBackColor = true;
            this.Btn_Sua.Click += new System.EventHandler(this.Btn_Sua_Click);
            // 
            // Btn_XoaKH
            // 
            this.Btn_XoaKH.Location = new System.Drawing.Point(750, 445);
            this.Btn_XoaKH.Name = "Btn_XoaKH";
            this.Btn_XoaKH.Size = new System.Drawing.Size(75, 38);
            this.Btn_XoaKH.TabIndex = 16;
            this.Btn_XoaKH.Text = "Xóa";
            this.Btn_XoaKH.UseVisualStyleBackColor = true;
            this.Btn_XoaKH.Click += new System.EventHandler(this.Btn_XoaKH_Click);
            // 
            // Txt_Id
            // 
            this.Txt_Id.Location = new System.Drawing.Point(830, 75);
            this.Txt_Id.Name = "Txt_Id";
            this.Txt_Id.Size = new System.Drawing.Size(20, 23);
            this.Txt_Id.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(770, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Id:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // FrmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 491);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Txt_Id);
            this.Controls.Add(this.Btn_XoaKH);
            this.Controls.Add(this.Btn_Sua);
            this.Controls.Add(this.Btn_TroLai);
            this.Controls.Add(this.Btn_Xoa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Txt_Seach);
            this.Controls.Add(this.Txt_DiaChi);
            this.Controls.Add(this.Rbt_Nu);
            this.Controls.Add(this.Rbt_Nam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt_HoVaTen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_SDT);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FrmKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmKhachHang";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgrid_KhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView Dgrid_KhachHang;
        private System.Windows.Forms.TextBox Txt_SDT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_HoVaTen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton Rbt_Nam;
        private System.Windows.Forms.RadioButton Rbt_Nu;
        private System.Windows.Forms.TextBox Txt_DiaChi;
        private System.Windows.Forms.TextBox Txt_Seach;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Btn_Xoa;
        private System.Windows.Forms.Button Btn_TroLai;
        private System.Windows.Forms.Button Btn_Sua;
        private System.Windows.Forms.Button Btn_XoaKH;
        private System.Windows.Forms.TextBox Txt_Id;
        private System.Windows.Forms.Label label7;
    }
}