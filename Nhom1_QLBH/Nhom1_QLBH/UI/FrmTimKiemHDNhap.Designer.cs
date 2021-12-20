namespace Nhom1_QLBH.UI
{
    partial class FrmTimKiemHDNhap
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
            this.optNhapMaNCC = new System.Windows.Forms.RadioButton();
            this.cboMaNCC = new System.Windows.Forms.ComboBox();
            this.optNhapMa = new System.Windows.Forms.RadioButton();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Grid_KetQua = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
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
            // optNhapMaNCC
            // 
            this.optNhapMaNCC.AutoSize = true;
            this.optNhapMaNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.optNhapMaNCC.Location = new System.Drawing.Point(67, 117);
            this.optNhapMaNCC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.optNhapMaNCC.Name = "optNhapMaNCC";
            this.optNhapMaNCC.Size = new System.Drawing.Size(232, 36);
            this.optNhapMaNCC.TabIndex = 27;
            this.optNhapMaNCC.TabStop = true;
            this.optNhapMaNCC.Text = "Nhập Mã NCC";
            this.optNhapMaNCC.UseVisualStyleBackColor = true;
            this.optNhapMaNCC.CheckedChanged += new System.EventHandler(this.optNhapMaNCC_CheckedChanged);
            // 
            // cboMaNCC
            // 
            this.cboMaNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboMaNCC.FormattingEnabled = true;
            this.cboMaNCC.Location = new System.Drawing.Point(356, 119);
            this.cboMaNCC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboMaNCC.Name = "cboMaNCC";
            this.cboMaNCC.Size = new System.Drawing.Size(326, 37);
            this.cboMaNCC.TabIndex = 25;
            // 
            // optNhapMa
            // 
            this.optNhapMa.AutoSize = true;
            this.optNhapMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.optNhapMa.Location = new System.Drawing.Point(67, 45);
            this.optNhapMa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.optNhapMa.Name = "optNhapMa";
            this.optNhapMa.Size = new System.Drawing.Size(211, 36);
            this.optNhapMa.TabIndex = 24;
            this.optNhapMa.TabStop = true;
            this.optNhapMa.Text = "Nhập Mã HĐ";
            this.optNhapMa.UseVisualStyleBackColor = true;
            this.optNhapMa.CheckedChanged += new System.EventHandler(this.optNhapMa_CheckedChanged);
            // 
            // txtMaHD
            // 
            this.txtMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaHD.Location = new System.Drawing.Point(355, 46);
            this.txtMaHD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(327, 35);
            this.txtMaHD.TabIndex = 21;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.White;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(58, 120);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(177, 52);
            this.btnThoat.TabIndex = 18;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.White;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimKiem.Location = new System.Drawing.Point(58, 43);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(177, 52);
            this.btnTimKiem.TabIndex = 19;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(161, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(730, 52);
            this.label1.TabIndex = 17;
            this.label1.Text = "Tìm kiếm thông tin Hóa Đơn Nhập";
            // 
            // Grid_KetQua
            // 
            this.Grid_KetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_KetQua.Location = new System.Drawing.Point(3, 4);
            this.Grid_KetQua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Grid_KetQua.Name = "Grid_KetQua";
            this.Grid_KetQua.RowHeadersWidth = 51;
            this.Grid_KetQua.RowTemplate.Height = 24;
            this.Grid_KetQua.Size = new System.Drawing.Size(1051, 355);
            this.Grid_KetQua.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(8, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1063, 108);
            this.panel1.TabIndex = 28;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(716, 54);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 17);
            this.flowLayoutPanel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.optNhapMaNCC);
            this.panel2.Controls.Add(this.cboMaNCC);
            this.panel2.Controls.Add(this.optNhapMa);
            this.panel2.Controls.Add(this.txtMaHD);
            this.panel2.Location = new System.Drawing.Point(11, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(762, 206);
            this.panel2.TabIndex = 29;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(this.btnThoat);
            this.panel3.Controls.Add(this.btnTimKiem);
            this.panel3.Location = new System.Drawing.Point(779, 128);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(292, 206);
            this.panel3.TabIndex = 30;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Grid_KetQua);
            this.panel4.Location = new System.Drawing.Point(11, 343);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1059, 363);
            this.panel4.TabIndex = 31;
            // 
            // FrmTimKiemHDNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 713);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmTimKiemHDNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTimKiemHDNhap";
            this.Load += new System.EventHandler(this.FrmTimKiemHDNhap_Load);
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

        private System.Windows.Forms.RadioButton optNhapMaNCC;
        private System.Windows.Forms.ComboBox cboMaNCC;
        private System.Windows.Forms.RadioButton optNhapMa;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Grid_KetQua;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}