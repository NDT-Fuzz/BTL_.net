namespace Nhom1_QLBH.UI
{
    partial class FrmSanPham
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
            this.cboDMSP = new System.Windows.Forms.ComboBox();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.lblDMSP = new System.Windows.Forms.Label();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.lblGiaBan = new System.Windows.Forms.Label();
            this.lblGiaNhap = new System.Windows.Forms.Label();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.DGVSP = new System.Windows.Forms.DataGridView();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSP)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(24, 336);
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
            this.btnXoa.Location = new System.Drawing.Point(24, 260);
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
            this.btnSua.Location = new System.Drawing.Point(24, 182);
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
            this.btnLuu.Location = new System.Drawing.Point(24, 104);
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
            this.btnTaoMoi.Location = new System.Drawing.Point(24, 28);
            this.btnTaoMoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(152, 70);
            this.btnTaoMoi.TabIndex = 68;
            this.btnTaoMoi.Text = "Tạo Mới";
            this.btnTaoMoi.UseVisualStyleBackColor = true;
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // cboDMSP
            // 
            this.cboDMSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDMSP.FormattingEnabled = true;
            this.cboDMSP.Location = new System.Drawing.Point(420, 401);
            this.cboDMSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboDMSP.Name = "cboDMSP";
            this.cboDMSP.Size = new System.Drawing.Size(325, 28);
            this.cboDMSP.TabIndex = 63;
            // 
            // lblThongBao
            // 
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblThongBao.Location = new System.Drawing.Point(203, 28);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(689, 52);
            this.lblThongBao.TabIndex = 62;
            this.lblThongBao.Text = "Thông Tin Danh Mục Sản Phẩm";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(420, 268);
            this.txtMoTa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(325, 26);
            this.txtMoTa.TabIndex = 59;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(420, 208);
            this.txtGiaBan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(325, 26);
            this.txtGiaBan.TabIndex = 60;
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Location = new System.Drawing.Point(420, 141);
            this.txtGiaNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(325, 26);
            this.txtGiaNhap.TabIndex = 58;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(420, 80);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(325, 26);
            this.txtTenSP.TabIndex = 57;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(420, 10);
            this.txtMaSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(325, 26);
            this.txtMaSP.TabIndex = 61;
            // 
            // lblDMSP
            // 
            this.lblDMSP.AutoSize = true;
            this.lblDMSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDMSP.Location = new System.Drawing.Point(32, 401);
            this.lblDMSP.Name = "lblDMSP";
            this.lblDMSP.Size = new System.Drawing.Size(299, 32);
            this.lblDMSP.TabIndex = 54;
            this.lblDMSP.Text = "Danh Mục Sản Phẩm";
            this.lblDMSP.Click += new System.EventHandler(this.lblVaiTro_Click);
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMoTa.Location = new System.Drawing.Point(232, 262);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(99, 32);
            this.lblMoTa.TabIndex = 53;
            this.lblMoTa.Text = "Mô Tả";
            // 
            // lblGiaBan
            // 
            this.lblGiaBan.AutoSize = true;
            this.lblGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGiaBan.Location = new System.Drawing.Point(206, 201);
            this.lblGiaBan.Name = "lblGiaBan";
            this.lblGiaBan.Size = new System.Drawing.Size(125, 32);
            this.lblGiaBan.TabIndex = 52;
            this.lblGiaBan.Text = "Giá Bán";
            // 
            // lblGiaNhap
            // 
            this.lblGiaNhap.AutoSize = true;
            this.lblGiaNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGiaNhap.Location = new System.Drawing.Point(188, 141);
            this.lblGiaNhap.Name = "lblGiaNhap";
            this.lblGiaNhap.Size = new System.Drawing.Size(143, 32);
            this.lblGiaNhap.TabIndex = 51;
            this.lblGiaNhap.Text = "Giá Nhập";
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenSP.Location = new System.Drawing.Point(116, 80);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(215, 32);
            this.lblTenSP.TabIndex = 55;
            this.lblTenSP.Text = "Tên Sản Phẩm";
            // 
            // lblMaSP
            // 
            this.lblMaSP.AutoSize = true;
            this.lblMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaSP.Location = new System.Drawing.Point(127, 10);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(204, 32);
            this.lblMaSP.TabIndex = 56;
            this.lblMaSP.Text = "Mã Sản Phẩm";
            this.lblMaSP.Click += new System.EventHandler(this.lblMaSP_Click);
            // 
            // DGVSP
            // 
            this.DGVSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVSP.Location = new System.Drawing.Point(3, 4);
            this.DGVSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DGVSP.Name = "DGVSP";
            this.DGVSP.RowHeadersWidth = 51;
            this.DGVSP.RowTemplate.Height = 24;
            this.DGVSP.Size = new System.Drawing.Size(1071, 259);
            this.DGVSP.TabIndex = 50;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSoLuong.Location = new System.Drawing.Point(186, 330);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(145, 32);
            this.lblSoLuong.TabIndex = 53;
            this.lblSoLuong.Text = "Số Lượng";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(420, 337);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(325, 26);
            this.txtSoLuong.TabIndex = 59;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnTaoMoi);
            this.panel1.Location = new System.Drawing.Point(896, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 449);
            this.panel1.TabIndex = 69;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.Controls.Add(this.lblThongBao);
            this.panel2.Location = new System.Drawing.Point(7, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1087, 117);
            this.panel2.TabIndex = 70;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(this.cboDMSP);
            this.panel3.Controls.Add(this.txtSoLuong);
            this.panel3.Controls.Add(this.txtMoTa);
            this.panel3.Controls.Add(this.txtGiaBan);
            this.panel3.Controls.Add(this.txtGiaNhap);
            this.panel3.Controls.Add(this.txtTenSP);
            this.panel3.Controls.Add(this.txtMaSP);
            this.panel3.Controls.Add(this.lblDMSP);
            this.panel3.Controls.Add(this.lblSoLuong);
            this.panel3.Controls.Add(this.lblMoTa);
            this.panel3.Controls.Add(this.lblGiaBan);
            this.panel3.Controls.Add(this.lblGiaNhap);
            this.panel3.Controls.Add(this.lblTenSP);
            this.panel3.Controls.Add(this.lblMaSP);
            this.panel3.Location = new System.Drawing.Point(14, 132);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(868, 449);
            this.panel3.TabIndex = 71;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.DGVSP);
            this.panel4.Location = new System.Drawing.Point(16, 589);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1077, 267);
            this.panel4.TabIndex = 72;
            // 
            // FrmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 886);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSanPham";
            this.Load += new System.EventHandler(this.lblSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVSP)).EndInit();
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
        private System.Windows.Forms.ComboBox cboDMSP;
        private System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label lblDMSP;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.Label lblGiaBan;
        private System.Windows.Forms.Label lblGiaNhap;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.DataGridView DGVSP;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}