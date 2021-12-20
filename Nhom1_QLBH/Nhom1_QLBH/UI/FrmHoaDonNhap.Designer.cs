namespace Nhom1_QLBH.UI
{
    partial class FrmHoaDonNhap
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.cboMaNCC = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.txtNguoiNhap = new System.Windows.Forms.TextBox();
            this.txtMaHDN = new System.Windows.Forms.TextBox();
            this.lblMaNCC = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.lblNguoiNhap = new System.Windows.Forms.Label();
            this.lblNgayNhapHang = new System.Windows.Forms.Label();
            this.lblMaHD = new System.Windows.Forms.Label();
            this.DGVHoaDon = new System.Windows.Forms.DataGridView();
            this.dtNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DGVHoaDon)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(22, 333);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(152, 70);
            this.btnThoat.TabIndex = 64;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.Location = new System.Drawing.Point(22, 255);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(152, 70);
            this.btnXoa.TabIndex = 65;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.Location = new System.Drawing.Point(22, 177);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(152, 70);
            this.btnSua.TabIndex = 66;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuu.Location = new System.Drawing.Point(22, 99);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(152, 70);
            this.btnLuu.TabIndex = 67;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTaoMoi.Location = new System.Drawing.Point(22, 21);
            this.btnTaoMoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(152, 70);
            this.btnTaoMoi.TabIndex = 68;
            this.btnTaoMoi.Text = "Tạo Mới";
            this.btnTaoMoi.UseVisualStyleBackColor = true;
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // cboMaNCC
            // 
            this.cboMaNCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaNCC.FormattingEnabled = true;
            this.cboMaNCC.Location = new System.Drawing.Point(369, 322);
            this.cboMaNCC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboMaNCC.Name = "cboMaNCC";
            this.cboMaNCC.Size = new System.Drawing.Size(346, 28);
            this.cboMaNCC.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(238, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(556, 52);
            this.label1.TabIndex = 62;
            this.label1.Text = "Thông Tin Hóa Đơn Nhập";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(369, 260);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(346, 26);
            this.txtTongTien.TabIndex = 59;
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Location = new System.Drawing.Point(369, 205);
            this.txtTrangThai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(346, 26);
            this.txtTrangThai.TabIndex = 60;
            // 
            // txtNguoiNhap
            // 
            this.txtNguoiNhap.Location = new System.Drawing.Point(369, 146);
            this.txtNguoiNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNguoiNhap.Name = "txtNguoiNhap";
            this.txtNguoiNhap.Size = new System.Drawing.Size(346, 26);
            this.txtNguoiNhap.TabIndex = 58;
            // 
            // txtMaHDN
            // 
            this.txtMaHDN.Location = new System.Drawing.Point(369, 33);
            this.txtMaHDN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaHDN.Name = "txtMaHDN";
            this.txtMaHDN.Size = new System.Drawing.Size(346, 26);
            this.txtMaHDN.TabIndex = 61;
            // 
            // lblMaNCC
            // 
            this.lblMaNCC.AutoSize = true;
            this.lblMaNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaNCC.Location = new System.Drawing.Point(164, 318);
            this.lblMaNCC.Name = "lblMaNCC";
            this.lblMaNCC.Size = new System.Drawing.Size(127, 32);
            this.lblMaNCC.TabIndex = 54;
            this.lblMaNCC.Text = "Mã NCC";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTongTien.Location = new System.Drawing.Point(139, 254);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(152, 32);
            this.lblTongTien.TabIndex = 53;
            this.lblTongTien.Text = "Tổng Tiền";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTrangThai.Location = new System.Drawing.Point(129, 199);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(162, 32);
            this.lblTrangThai.TabIndex = 52;
            this.lblTrangThai.Text = "Trạng Thái";
            // 
            // lblNguoiNhap
            // 
            this.lblNguoiNhap.AutoSize = true;
            this.lblNguoiNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNguoiNhap.Location = new System.Drawing.Point(116, 139);
            this.lblNguoiNhap.Name = "lblNguoiNhap";
            this.lblNguoiNhap.Size = new System.Drawing.Size(175, 32);
            this.lblNguoiNhap.TabIndex = 51;
            this.lblNguoiNhap.Text = "Người Nhập";
            // 
            // lblNgayNhapHang
            // 
            this.lblNgayNhapHang.AutoSize = true;
            this.lblNgayNhapHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNgayNhapHang.Location = new System.Drawing.Point(46, 86);
            this.lblNgayNhapHang.Name = "lblNgayNhapHang";
            this.lblNgayNhapHang.Size = new System.Drawing.Size(245, 32);
            this.lblNgayNhapHang.TabIndex = 55;
            this.lblNgayNhapHang.Text = "Ngày Nhập Hàng";
            // 
            // lblMaHD
            // 
            this.lblMaHD.AutoSize = true;
            this.lblMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaHD.Location = new System.Drawing.Point(109, 26);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(182, 32);
            this.lblMaHD.TabIndex = 56;
            this.lblMaHD.Text = "Mã Hóa Đơn";
            // 
            // DGVHoaDon
            // 
            this.DGVHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVHoaDon.Location = new System.Drawing.Point(7, 1);
            this.DGVHoaDon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DGVHoaDon.Name = "DGVHoaDon";
            this.DGVHoaDon.RowHeadersWidth = 51;
            this.DGVHoaDon.RowTemplate.Height = 24;
            this.DGVHoaDon.Size = new System.Drawing.Size(1007, 297);
            this.DGVHoaDon.TabIndex = 50;
            // 
            // dtNgayNhap
            // 
            this.dtNgayNhap.CustomFormat = "dd/MM/yyyy";
            this.dtNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayNhap.Location = new System.Drawing.Point(373, 91);
            this.dtNgayNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtNgayNhap.Name = "dtNgayNhap";
            this.dtNgayNhap.Size = new System.Drawing.Size(342, 26);
            this.dtNgayNhap.TabIndex = 69;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnTaoMoi);
            this.panel1.Location = new System.Drawing.Point(829, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 420);
            this.panel1.TabIndex = 70;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.dtNgayNhap);
            this.panel2.Controls.Add(this.cboMaNCC);
            this.panel2.Controls.Add(this.txtTongTien);
            this.panel2.Controls.Add(this.txtTrangThai);
            this.panel2.Controls.Add(this.txtNguoiNhap);
            this.panel2.Controls.Add(this.txtMaHDN);
            this.panel2.Controls.Add(this.lblMaNCC);
            this.panel2.Controls.Add(this.lblTongTien);
            this.panel2.Controls.Add(this.lblTrangThai);
            this.panel2.Controls.Add(this.lblNguoiNhap);
            this.panel2.Controls.Add(this.lblNgayNhapHang);
            this.panel2.Controls.Add(this.lblMaHD);
            this.panel2.Location = new System.Drawing.Point(8, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(815, 420);
            this.panel2.TabIndex = 71;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gold;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(8, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1009, 86);
            this.panel3.TabIndex = 72;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.DGVHoaDon);
            this.panel4.Location = new System.Drawing.Point(8, 524);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1017, 302);
            this.panel4.TabIndex = 73;
            // 
            // FrmHoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 847);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmHoaDonNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmHoaDonNhap";
            this.Load += new System.EventHandler(this.FrmHoaDonNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVHoaDon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnTaoMoi;
        private System.Windows.Forms.ComboBox cboMaNCC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.TextBox txtNguoiNhap;
        private System.Windows.Forms.TextBox txtMaHDN;
        private System.Windows.Forms.Label lblMaNCC;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Label lblNguoiNhap;
        private System.Windows.Forms.Label lblNgayNhapHang;
        private System.Windows.Forms.Label lblMaHD;
        private System.Windows.Forms.DataGridView DGVHoaDon;
        private System.Windows.Forms.DateTimePicker dtNgayNhap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}