
namespace _3_GUI_PresetationLayer
{
    partial class FrmDangNhap
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
            this.Btn_DangNhap = new System.Windows.Forms.Button();
            this.Btn_Thoat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Cbx_NhoMatKhau = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_MatKhau = new System.Windows.Forms.TextBox();
            this.Cmb_Email = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Btn_DangNhap
            // 
            this.Btn_DangNhap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_DangNhap.Location = new System.Drawing.Point(223, 306);
            this.Btn_DangNhap.Name = "Btn_DangNhap";
            this.Btn_DangNhap.Size = new System.Drawing.Size(100, 42);
            this.Btn_DangNhap.TabIndex = 26;
            this.Btn_DangNhap.Text = "Đăng nhập";
            this.Btn_DangNhap.UseVisualStyleBackColor = true;
            this.Btn_DangNhap.Click += new System.EventHandler(this.Btn_DangNhap_Click);
            // 
            // Btn_Thoat
            // 
            this.Btn_Thoat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Thoat.Location = new System.Drawing.Point(83, 306);
            this.Btn_Thoat.Name = "Btn_Thoat";
            this.Btn_Thoat.Size = new System.Drawing.Size(100, 42);
            this.Btn_Thoat.TabIndex = 25;
            this.Btn_Thoat.Text = "Thoát";
            this.Btn_Thoat.UseVisualStyleBackColor = true;
            this.Btn_Thoat.Click += new System.EventHandler(this.Btn_Thoat_Click);
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(128, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 37);
            this.label3.TabIndex = 24;
            this.label3.Text = "ĐĂNG NHẬP";
            // 
            // Cbx_NhoMatKhau
            // 
            this.Cbx_NhoMatKhau.AutoSize = true;
            this.Cbx_NhoMatKhau.Location = new System.Drawing.Point(107, 243);
            this.Cbx_NhoMatKhau.Name = "Cbx_NhoMatKhau";
            this.Cbx_NhoMatKhau.Size = new System.Drawing.Size(102, 19);
            this.Cbx_NhoMatKhau.TabIndex = 23;
            this.Cbx_NhoMatKhau.Text = "Nhớ mật khẩu";
            this.Cbx_NhoMatKhau.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(223, 244);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(89, 15);
            this.linkLabel1.TabIndex = 22;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Quên mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Mật khẩu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Email: ";
            // 
            // Txt_MatKhau
            // 
            this.Txt_MatKhau.Location = new System.Drawing.Point(107, 213);
            this.Txt_MatKhau.Name = "Txt_MatKhau";
            this.Txt_MatKhau.Size = new System.Drawing.Size(205, 23);
            this.Txt_MatKhau.TabIndex = 19;
            // 
            // Cmb_Email
            // 
            this.Cmb_Email.FormattingEnabled = true;
            this.Cmb_Email.Location = new System.Drawing.Point(107, 159);
            this.Cmb_Email.Name = "Cmb_Email";
            this.Cmb_Email.Size = new System.Drawing.Size(205, 23);
            this.Cmb_Email.TabIndex = 27;
            // 
            // FrmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 401);
            this.Controls.Add(this.Cmb_Email);
            this.Controls.Add(this.Btn_DangNhap);
            this.Controls.Add(this.Btn_Thoat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Cbx_NhoMatKhau);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_MatKhau);
            this.Name = "FrmDangNhap";
            this.Text = "FrmDangNhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_DangNhap;
        private System.Windows.Forms.Button Btn_Thoat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox Cbx_NhoMatKhau;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_MatKhau;
        private System.Windows.Forms.ComboBox Cmb_Email;
    }
}