namespace Nhom1_QLBH.Report
{
    partial class FrmBC_TonKho
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
            this.CRV_TonKho = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // CRV_TonKho
            // 
            this.CRV_TonKho.ActiveViewIndex = -1;
            this.CRV_TonKho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRV_TonKho.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRV_TonKho.Location = new System.Drawing.Point(0, 93);
            this.CRV_TonKho.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CRV_TonKho.Name = "CRV_TonKho";
            this.CRV_TonKho.Size = new System.Drawing.Size(1503, 643);
            this.CRV_TonKho.TabIndex = 0;
            this.CRV_TonKho.ToolPanelWidth = 225;
            this.CRV_TonKho.Load += new System.EventHandler(this.CRV_BanHang_Load);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gold;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1503, 80);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(543, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "BÁO CÁO TỒN KHO";
            // 
            // FrmBC_TonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1504, 737);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.CRV_TonKho);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmBC_TonKho";
            this.Text = "FrmBC_TonKho";
            this.Load += new System.EventHandler(this.Frm_BCBanHang_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRV_TonKho;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
    }
}