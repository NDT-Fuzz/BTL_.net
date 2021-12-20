namespace Nhom1_QLBH.UI
{
    partial class FrmTimKiemKhachHang
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
            this.optNhapTen = new System.Windows.Forms.RadioButton();
            this.optNhapMa = new System.Windows.Forms.RadioButton();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Grid_KetQua = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_KetQua)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // optNhapTen
            // 
            this.optNhapTen.AutoSize = true;
            this.optNhapTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.optNhapTen.Location = new System.Drawing.Point(56, 97);
            this.optNhapTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.optNhapTen.Name = "optNhapTen";
            this.optNhapTen.Size = new System.Drawing.Size(172, 36);
            this.optNhapTen.TabIndex = 23;
            this.optNhapTen.TabStop = true;
            this.optNhapTen.Text = "Nhập Tên";
            this.optNhapTen.UseVisualStyleBackColor = true;
            this.optNhapTen.CheckedChanged += new System.EventHandler(this.optNhapTen_CheckedChanged);
            // 
            // optNhapMa
            // 
            this.optNhapMa.AutoSize = true;
            this.optNhapMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.optNhapMa.Location = new System.Drawing.Point(56, 32);
            this.optNhapMa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.optNhapMa.Name = "optNhapMa";
            this.optNhapMa.Size = new System.Drawing.Size(161, 36);
            this.optNhapMa.TabIndex = 24;
            this.optNhapMa.TabStop = true;
            this.optNhapMa.Text = "Nhập Mã";
            this.optNhapMa.UseVisualStyleBackColor = true;
            this.optNhapMa.CheckedChanged += new System.EventHandler(this.optNhapMa_CheckedChanged);
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTen.Location = new System.Drawing.Point(289, 99);
            this.txtTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(327, 35);
            this.txtTen.TabIndex = 20;
            // 
            // txtMa
            // 
            this.txtMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMa.Location = new System.Drawing.Point(289, 34);
            this.txtMa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(327, 35);
            this.txtMa.TabIndex = 21;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(20, 96);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(177, 52);
            this.btnThoat.TabIndex = 18;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimKiem.Location = new System.Drawing.Point(20, 22);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(177, 52);
            this.btnTimKiem.TabIndex = 19;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(110, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(678, 52);
            this.label1.TabIndex = 17;
            this.label1.Text = "Tìm kiếm thông tin Khách Hàng";
            // 
            // Grid_KetQua
            // 
            this.Grid_KetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_KetQua.Location = new System.Drawing.Point(5, 4);
            this.Grid_KetQua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Grid_KetQua.Name = "Grid_KetQua";
            this.Grid_KetQua.RowHeadersWidth = 51;
            this.Grid_KetQua.RowTemplate.Height = 24;
            this.Grid_KetQua.Size = new System.Drawing.Size(883, 256);
            this.Grid_KetQua.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(8, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(899, 100);
            this.panel1.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.optNhapTen);
            this.panel2.Controls.Add(this.optNhapMa);
            this.panel2.Controls.Add(this.txtTen);
            this.panel2.Controls.Add(this.txtMa);
            this.panel2.Location = new System.Drawing.Point(8, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(668, 187);
            this.panel2.TabIndex = 26;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(this.btnThoat);
            this.panel3.Controls.Add(this.btnTimKiem);
            this.panel3.Location = new System.Drawing.Point(682, 119);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(219, 184);
            this.panel3.TabIndex = 27;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Grid_KetQua);
            this.panel4.Location = new System.Drawing.Point(8, 309);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(891, 264);
            this.panel4.TabIndex = 28;
            // 
            // FrmTimKiemKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 587);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmTimKiemKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTimKiemKhachHang";
            this.Load += new System.EventHandler(this.FrmTimKiemKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_KetQua)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton optNhapTen;
        private System.Windows.Forms.RadioButton optNhapMa;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Grid_KetQua;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}