namespace Nhom1_QLBH.UI
{
    partial class FrmTimKiemSanPham
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
            this.optNhapMaDMSP = new System.Windows.Forms.RadioButton();
            this.cboMaDMSP = new System.Windows.Forms.ComboBox();
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
            // optNhapMaDMSP
            // 
            this.optNhapMaDMSP.AutoSize = true;
            this.optNhapMaDMSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.optNhapMaDMSP.Location = new System.Drawing.Point(24, 154);
            this.optNhapMaDMSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.optNhapMaDMSP.Name = "optNhapMaDMSP";
            this.optNhapMaDMSP.Size = new System.Drawing.Size(254, 36);
            this.optNhapMaDMSP.TabIndex = 27;
            this.optNhapMaDMSP.TabStop = true;
            this.optNhapMaDMSP.Text = "Nhập Mã DMSP";
            this.optNhapMaDMSP.UseVisualStyleBackColor = true;
            this.optNhapMaDMSP.CheckedChanged += new System.EventHandler(this.optNhapMaDMSP_CheckedChanged);
            // 
            // cboMaDMSP
            // 
            this.cboMaDMSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboMaDMSP.FormattingEnabled = true;
            this.cboMaDMSP.Location = new System.Drawing.Point(332, 153);
            this.cboMaDMSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboMaDMSP.Name = "cboMaDMSP";
            this.cboMaDMSP.Size = new System.Drawing.Size(326, 37);
            this.cboMaDMSP.TabIndex = 25;
            // 
            // optNhapTen
            // 
            this.optNhapTen.AutoSize = true;
            this.optNhapTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.optNhapTen.Location = new System.Drawing.Point(24, 92);
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
            this.optNhapMa.Location = new System.Drawing.Point(24, 31);
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
            this.txtTen.Location = new System.Drawing.Point(332, 92);
            this.txtTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(327, 35);
            this.txtTen.TabIndex = 20;
            // 
            // txtMa
            // 
            this.txtMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMa.Location = new System.Drawing.Point(333, 33);
            this.txtMa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(327, 35);
            this.txtMa.TabIndex = 21;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(25, 128);
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
            this.btnTimKiem.Location = new System.Drawing.Point(25, 51);
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
            this.label1.Location = new System.Drawing.Point(186, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(637, 52);
            this.label1.TabIndex = 17;
            this.label1.Text = "Tìm kiếm thông tin Sản Phẩm";
            // 
            // Grid_KetQua
            // 
            this.Grid_KetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_KetQua.Location = new System.Drawing.Point(3, 4);
            this.Grid_KetQua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Grid_KetQua.Name = "Grid_KetQua";
            this.Grid_KetQua.RowHeadersWidth = 51;
            this.Grid_KetQua.RowTemplate.Height = 24;
            this.Grid_KetQua.Size = new System.Drawing.Size(974, 260);
            this.Grid_KetQua.TabIndex = 16;
            this.Grid_KetQua.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_KetQua_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.optNhapMaDMSP);
            this.panel1.Controls.Add(this.cboMaDMSP);
            this.panel1.Controls.Add(this.optNhapTen);
            this.panel1.Controls.Add(this.optNhapMa);
            this.panel1.Controls.Add(this.txtTen);
            this.panel1.Controls.Add(this.txtMa);
            this.panel1.Location = new System.Drawing.Point(19, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(735, 238);
            this.panel1.TabIndex = 28;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.btnThoat);
            this.panel2.Controls.Add(this.btnTimKiem);
            this.panel2.Location = new System.Drawing.Point(770, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 239);
            this.panel2.TabIndex = 29;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gold;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(19, 17);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(983, 96);
            this.panel3.TabIndex = 30;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Grid_KetQua);
            this.panel4.Location = new System.Drawing.Point(21, 371);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(980, 268);
            this.panel4.TabIndex = 31;
            // 
            // FrmTimKiemSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 651);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmTimKiemSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTimKiemSanPham";
            this.Load += new System.EventHandler(this.FrmTimKiemSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_KetQua)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton optNhapMaDMSP;
        private System.Windows.Forms.ComboBox cboMaDMSP;
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