namespace Nhom1_QLBH.UI
{
    partial class FrmTimKiemHDBancs
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
            this.optNhapMaKH = new System.Windows.Forms.RadioButton();
            this.cboMaKH = new System.Windows.Forms.ComboBox();
            this.optNhapMa = new System.Windows.Forms.RadioButton();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Grid_KetQua = new System.Windows.Forms.DataGridView();
            this.optNhapMaNV = new System.Windows.Forms.RadioButton();
            this.cboNhapMaNV = new System.Windows.Forms.ComboBox();
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
            // optNhapMaKH
            // 
            this.optNhapMaKH.AutoSize = true;
            this.optNhapMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.optNhapMaKH.Location = new System.Drawing.Point(87, 97);
            this.optNhapMaKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.optNhapMaKH.Name = "optNhapMaKH";
            this.optNhapMaKH.Size = new System.Drawing.Size(210, 36);
            this.optNhapMaKH.TabIndex = 35;
            this.optNhapMaKH.TabStop = true;
            this.optNhapMaKH.Text = "Nhập Mã KH";
            this.optNhapMaKH.UseVisualStyleBackColor = true;
            this.optNhapMaKH.CheckedChanged += new System.EventHandler(this.optNhapMaKH_CheckedChanged);
            // 
            // cboMaKH
            // 
            this.cboMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboMaKH.FormattingEnabled = true;
            this.cboMaKH.Location = new System.Drawing.Point(394, 96);
            this.cboMaKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboMaKH.Name = "cboMaKH";
            this.cboMaKH.Size = new System.Drawing.Size(326, 37);
            this.cboMaKH.TabIndex = 34;
            // 
            // optNhapMa
            // 
            this.optNhapMa.AutoSize = true;
            this.optNhapMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.optNhapMa.Location = new System.Drawing.Point(86, 29);
            this.optNhapMa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.optNhapMa.Name = "optNhapMa";
            this.optNhapMa.Size = new System.Drawing.Size(211, 36);
            this.optNhapMa.TabIndex = 33;
            this.optNhapMa.TabStop = true;
            this.optNhapMa.Text = "Nhập Mã HĐ";
            this.optNhapMa.UseVisualStyleBackColor = true;
            this.optNhapMa.CheckedChanged += new System.EventHandler(this.optNhapMa_CheckedChanged);
            // 
            // txtMaHD
            // 
            this.txtMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaHD.Location = new System.Drawing.Point(394, 33);
            this.txtMaHD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(327, 35);
            this.txtMaHD.TabIndex = 32;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(42, 116);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(177, 52);
            this.btnThoat.TabIndex = 30;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimKiem.Location = new System.Drawing.Point(42, 34);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(177, 52);
            this.btnTimKiem.TabIndex = 31;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(163, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(701, 52);
            this.label1.TabIndex = 29;
            this.label1.Text = "Tìm kiếm thông tin Hóa Đơn Bán";
            // 
            // Grid_KetQua
            // 
            this.Grid_KetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_KetQua.Location = new System.Drawing.Point(3, 13);
            this.Grid_KetQua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Grid_KetQua.Name = "Grid_KetQua";
            this.Grid_KetQua.RowHeadersWidth = 51;
            this.Grid_KetQua.RowTemplate.Height = 24;
            this.Grid_KetQua.Size = new System.Drawing.Size(1059, 311);
            this.Grid_KetQua.TabIndex = 28;
            // 
            // optNhapMaNV
            // 
            this.optNhapMaNV.AutoSize = true;
            this.optNhapMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.optNhapMaNV.Location = new System.Drawing.Point(87, 169);
            this.optNhapMaNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.optNhapMaNV.Name = "optNhapMaNV";
            this.optNhapMaNV.Size = new System.Drawing.Size(210, 36);
            this.optNhapMaNV.TabIndex = 35;
            this.optNhapMaNV.TabStop = true;
            this.optNhapMaNV.Text = "Nhập Mã NV";
            this.optNhapMaNV.UseVisualStyleBackColor = true;
            this.optNhapMaNV.CheckedChanged += new System.EventHandler(this.optNhapMaNV_CheckedChanged);
            // 
            // cboNhapMaNV
            // 
            this.cboNhapMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboNhapMaNV.FormattingEnabled = true;
            this.cboNhapMaNV.Location = new System.Drawing.Point(395, 168);
            this.cboNhapMaNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboNhapMaNV.Name = "cboNhapMaNV";
            this.cboNhapMaNV.Size = new System.Drawing.Size(326, 37);
            this.cboNhapMaNV.TabIndex = 34;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1078, 110);
            this.panel1.TabIndex = 36;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.optNhapMaNV);
            this.panel2.Controls.Add(this.optNhapMaKH);
            this.panel2.Controls.Add(this.cboNhapMaNV);
            this.panel2.Controls.Add(this.cboMaKH);
            this.panel2.Controls.Add(this.optNhapMa);
            this.panel2.Controls.Add(this.txtMaHD);
            this.panel2.Location = new System.Drawing.Point(13, 131);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(797, 232);
            this.panel2.TabIndex = 37;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(this.btnThoat);
            this.panel3.Controls.Add(this.btnTimKiem);
            this.panel3.Location = new System.Drawing.Point(820, 131);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(263, 231);
            this.panel3.TabIndex = 38;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Grid_KetQua);
            this.panel4.Location = new System.Drawing.Point(17, 380);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1065, 335);
            this.panel4.TabIndex = 39;
            // 
            // FrmTimKiemHDBancs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 738);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmTimKiemHDBancs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTimKiemHDBancs";
            this.Load += new System.EventHandler(this.FrmTimKiemHDBancs_Load);
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

        private System.Windows.Forms.RadioButton optNhapMaKH;
        private System.Windows.Forms.ComboBox cboMaKH;
        private System.Windows.Forms.RadioButton optNhapMa;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Grid_KetQua;
        private System.Windows.Forms.RadioButton optNhapMaNV;
        private System.Windows.Forms.ComboBox cboNhapMaNV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}