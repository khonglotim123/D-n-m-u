
namespace _3_GUI_PresetationLayer
{
    partial class FrmThongKeSanPhamNhapKho
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
            this.Dgrid_SPNK = new System.Windows.Forms.DataGridView();
            this.Btn_TroLai = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgrid_SPNK)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Dgrid_SPNK);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 315);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách";
            // 
            // Dgrid_SPNK
            // 
            this.Dgrid_SPNK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgrid_SPNK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgrid_SPNK.Location = new System.Drawing.Point(7, 23);
            this.Dgrid_SPNK.Name = "Dgrid_SPNK";
            this.Dgrid_SPNK.RowTemplate.Height = 25;
            this.Dgrid_SPNK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgrid_SPNK.Size = new System.Drawing.Size(763, 286);
            this.Dgrid_SPNK.TabIndex = 0;
            // 
            // Btn_TroLai
            // 
            this.Btn_TroLai.Location = new System.Drawing.Point(12, 333);
            this.Btn_TroLai.Name = "Btn_TroLai";
            this.Btn_TroLai.Size = new System.Drawing.Size(75, 38);
            this.Btn_TroLai.TabIndex = 1;
            this.Btn_TroLai.Text = "Trở lại";
            this.Btn_TroLai.UseVisualStyleBackColor = true;
            this.Btn_TroLai.Click += new System.EventHandler(this.Btn_TroLai_Click);
            // 
            // FrmThongKeSanPhamNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 380);
            this.Controls.Add(this.Btn_TroLai);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmThongKeSanPhamNhapKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmThongKeSanPhamNhapKho";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgrid_SPNK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView Dgrid_SPNK;
        private System.Windows.Forms.Button Btn_TroLai;
    }
}