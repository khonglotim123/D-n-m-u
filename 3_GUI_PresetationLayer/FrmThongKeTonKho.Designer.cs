
namespace _3_GUI_PresetationLayer
{
    partial class FrmThongKeTonKho
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
            this.Btn_TroLai = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Dgrid_TonKho = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgrid_TonKho)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_TroLai
            // 
            this.Btn_TroLai.Location = new System.Drawing.Point(12, 333);
            this.Btn_TroLai.Name = "Btn_TroLai";
            this.Btn_TroLai.Size = new System.Drawing.Size(75, 38);
            this.Btn_TroLai.TabIndex = 3;
            this.Btn_TroLai.Text = "Trở lại";
            this.Btn_TroLai.UseVisualStyleBackColor = true;
            this.Btn_TroLai.Click += new System.EventHandler(this.Btn_TroLai_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Dgrid_TonKho);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 315);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách";
            // 
            // Dgrid_TonKho
            // 
            this.Dgrid_TonKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgrid_TonKho.Location = new System.Drawing.Point(7, 23);
            this.Dgrid_TonKho.Name = "Dgrid_TonKho";
            this.Dgrid_TonKho.RowTemplate.Height = 25;
            this.Dgrid_TonKho.Size = new System.Drawing.Size(763, 286);
            this.Dgrid_TonKho.TabIndex = 0;
            // 
            // FrmThongKeTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 378);
            this.Controls.Add(this.Btn_TroLai);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmThongKeTonKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmThongKeTonKho";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgrid_TonKho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_TroLai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView Dgrid_TonKho;
    }
}