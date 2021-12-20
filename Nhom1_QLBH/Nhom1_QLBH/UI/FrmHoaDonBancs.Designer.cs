namespace Nhom1_QLBH.UI
{
    partial class FrmHoaDonBancs
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
            this.dtNgayBan = new System.Windows.Forms.DateTimePicker();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.cboMaKH = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.txtPTTT = new System.Windows.Forms.TextBox();
            this.txtMaHDB = new System.Windows.Forms.TextBox();
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.lblNguoiNhap = new System.Windows.Forms.Label();
            this.lblNgayBan = new System.Windows.Forms.Label();
            this.lblMaHD = new System.Windows.Forms.Label();
            this.DGVHoaDonBan = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cboMaNV = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DGVHoaDonBan)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtNgayBan
            // 
            this.dtNgayBan.CustomFormat = "dd/MM/yyyy";
            this.dtNgayBan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayBan.Location = new System.Drawing.Point(436, 99);
            this.dtNgayBan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtNgayBan.Name = "dtNgayBan";
            this.dtNgayBan.Size = new System.Drawing.Size(367, 26);
            this.dtNgayBan.TabIndex = 88;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(25, 356);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(152, 70);
            this.btnThoat.TabIndex = 83;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.Location = new System.Drawing.Point(25, 275);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(152, 70);
            this.btnXoa.TabIndex = 84;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.Location = new System.Drawing.Point(25, 193);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(152, 70);
            this.btnSua.TabIndex = 85;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuu.Location = new System.Drawing.Point(25, 115);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(152, 70);
            this.btnLuu.TabIndex = 86;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTaoMoi.Location = new System.Drawing.Point(25, 37);
            this.btnTaoMoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(152, 70);
            this.btnTaoMoi.TabIndex = 87;
            this.btnTaoMoi.Text = "Tạo Mới";
            this.btnTaoMoi.UseVisualStyleBackColor = true;
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // cboMaKH
            // 
            this.cboMaKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaKH.FormattingEnabled = true;
            this.cboMaKH.Location = new System.Drawing.Point(431, 328);
            this.cboMaKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboMaKH.Name = "cboMaKH";
            this.cboMaKH.Size = new System.Drawing.Size(372, 28);
            this.cboMaKH.TabIndex = 82;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(320, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(527, 52);
            this.label1.TabIndex = 81;
            this.label1.Text = "Thông Tin Hóa Đơn Bán";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(436, 265);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(367, 26);
            this.txtTongTien.TabIndex = 78;
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Location = new System.Drawing.Point(436, 211);
            this.txtTrangThai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(367, 26);
            this.txtTrangThai.TabIndex = 79;
            // 
            // txtPTTT
            // 
            this.txtPTTT.Location = new System.Drawing.Point(436, 152);
            this.txtPTTT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPTTT.Name = "txtPTTT";
            this.txtPTTT.Size = new System.Drawing.Size(367, 26);
            this.txtPTTT.TabIndex = 77;
            // 
            // txtMaHDB
            // 
            this.txtMaHDB.Location = new System.Drawing.Point(436, 38);
            this.txtMaHDB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaHDB.Name = "txtMaHDB";
            this.txtMaHDB.Size = new System.Drawing.Size(367, 26);
            this.txtMaHDB.TabIndex = 80;
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.AutoSize = true;
            this.lblKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblKhachHang.Location = new System.Drawing.Point(171, 321);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(230, 32);
            this.lblKhachHang.TabIndex = 74;
            this.lblKhachHang.Text = "Mã Khách Hàng";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTongTien.Location = new System.Drawing.Point(249, 258);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(152, 32);
            this.lblTongTien.TabIndex = 73;
            this.lblTongTien.Text = "Tổng Tiền";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTrangThai.Location = new System.Drawing.Point(239, 204);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(162, 32);
            this.lblTrangThai.TabIndex = 72;
            this.lblTrangThai.Text = "Trạng Thái";
            // 
            // lblNguoiNhap
            // 
            this.lblNguoiNhap.AutoSize = true;
            this.lblNguoiNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNguoiNhap.Location = new System.Drawing.Point(35, 145);
            this.lblNguoiNhap.Name = "lblNguoiNhap";
            this.lblNguoiNhap.Size = new System.Drawing.Size(366, 32);
            this.lblNguoiNhap.TabIndex = 71;
            this.lblNguoiNhap.Text = "Phương Thức Thanh Toán";
            // 
            // lblNgayBan
            // 
            this.lblNgayBan.AutoSize = true;
            this.lblNgayBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNgayBan.Location = new System.Drawing.Point(241, 93);
            this.lblNgayBan.Name = "lblNgayBan";
            this.lblNgayBan.Size = new System.Drawing.Size(147, 32);
            this.lblNgayBan.TabIndex = 75;
            this.lblNgayBan.Text = "Ngày Bán";
            // 
            // lblMaHD
            // 
            this.lblMaHD.AutoSize = true;
            this.lblMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaHD.Location = new System.Drawing.Point(219, 38);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(182, 32);
            this.lblMaHD.TabIndex = 76;
            this.lblMaHD.Text = "Mã Hóa Đơn";
            // 
            // DGVHoaDonBan
            // 
            this.DGVHoaDonBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVHoaDonBan.Location = new System.Drawing.Point(13, 13);
            this.DGVHoaDonBan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DGVHoaDonBan.Name = "DGVHoaDonBan";
            this.DGVHoaDonBan.RowHeadersWidth = 51;
            this.DGVHoaDonBan.RowTemplate.Height = 24;
            this.DGVHoaDonBan.Size = new System.Drawing.Size(1094, 269);
            this.DGVHoaDonBan.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(182, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 32);
            this.label2.TabIndex = 74;
            this.label2.Text = "Mã Nhân Viên";
            // 
            // cboMaNV
            // 
            this.cboMaNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaNV.FormattingEnabled = true;
            this.cboMaNV.Location = new System.Drawing.Point(431, 390);
            this.cboMaNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(372, 28);
            this.cboMaNV.TabIndex = 82;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnTaoMoi);
            this.panel1.Location = new System.Drawing.Point(946, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 474);
            this.panel1.TabIndex = 89;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.dtNgayBan);
            this.panel2.Controls.Add(this.cboMaNV);
            this.panel2.Controls.Add(this.cboMaKH);
            this.panel2.Controls.Add(this.txtTongTien);
            this.panel2.Controls.Add(this.txtTrangThai);
            this.panel2.Controls.Add(this.txtPTTT);
            this.panel2.Controls.Add(this.txtMaHDB);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblKhachHang);
            this.panel2.Controls.Add(this.lblTongTien);
            this.panel2.Controls.Add(this.lblTrangThai);
            this.panel2.Controls.Add(this.lblNguoiNhap);
            this.panel2.Controls.Add(this.lblNgayBan);
            this.panel2.Controls.Add(this.lblMaHD);
            this.panel2.Location = new System.Drawing.Point(12, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(928, 474);
            this.panel2.TabIndex = 90;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gold;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(9, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1136, 82);
            this.panel3.TabIndex = 91;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.DGVHoaDonBan);
            this.panel4.Location = new System.Drawing.Point(16, 584);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1129, 286);
            this.panel4.TabIndex = 92;
            // 
            // FrmHoaDonBancs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 887);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmHoaDonBancs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmHoaDonBancs";
            this.Load += new System.EventHandler(this.FrmHoaDonBancs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVHoaDonBan)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtNgayBan;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnTaoMoi;
        private System.Windows.Forms.ComboBox cboMaKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.TextBox txtPTTT;
        private System.Windows.Forms.TextBox txtMaHDB;
        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Label lblNguoiNhap;
        private System.Windows.Forms.Label lblNgayBan;
        private System.Windows.Forms.Label lblMaHD;
        private System.Windows.Forms.DataGridView DGVHoaDonBan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboMaNV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}