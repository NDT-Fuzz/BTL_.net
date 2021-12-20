using Nhom1_QLBH.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom1_QLBH.UI
{
    public partial class FormMain : Form
    {
        private string _tenDN;
        public FormMain()
        {
            InitializeComponent();
        }

        public FormMain(string tenDN) : this()
        {
            //InitializeComponent();
            _tenDN = tenDN; 
            lblTenDN.Text ="Xin chào "+ _tenDN + " !";
            mnuAdmin.Text = _tenDN; 

        }
        

        private void danhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void btnQLTK_Click(object sender, EventArgs e)
        {
            Form frm = new FrmLogin();
            frm.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new FrmNhanVien();
            frm.Show();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new FrmNCC();
            frm.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new FrmKhachHang();
            frm.Show();
        }

        private void loạiSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new FrmDMSP();
            frm.Show();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new FrmSanPham();
            frm.Show();
        }

        private void hóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new FrmHoaDonNhap();
            frm.Show();
        }

        private void hóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new FrmHoaDonBancs();
            frm.Show();
        }

        private void kháchHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new FrmTimKiemKhachHang();
            frm.Show();
        }

        private void hóaĐơnBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new FrmTimKiemHDBancs();
            frm.Show();
        }

        private void hóaĐơnNhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new FrmTimKiemHDNhap();
            frm.Show();
        }

        private void mnuBCTK_Click(object sender, EventArgs e)
        {
            Form frm = new FrmBC_BanHang();
            frm.Show();
        }

        private void mnuThuChi_Click(object sender, EventArgs e)
        {
            Form frm = new FrmBC_TonKho();
            frm.Show();
        }

        private void ThoatToolStripMenuItem19_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn Có Muốn Thoát Không?", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thongbao == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        
        KetNoi kn = new KetNoi();


        private void FormMain_Load(object sender, EventArgs e)
        {
           /* String DN = FrmLogin.; 
;
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select TENTN FROM HeThong Where TenTN='" + DN + "' ");
            dataGrid_NV.DataSource = dta;

            txtTK.DataBindings.Clear();
            txtTK.DataBindings.Add("Text", dataGrid_NV.DataSource, "TENTN");*/
        }

        private void SanPhamToolStripMenuItem12_Click(object sender, EventArgs e)
        {
            Form frm = new FrmTimKiemSanPham();
            frm.Show();
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            Form frm = new FrmLogin();
            frm.Show();
            this.Hide();
        }

        private void mnuTaiKhoan_Click(object sender, EventArgs e)
        {
            Form frm = new FormDoiMK();
            frm.Show();
            this.Hide();
        }

        private void SanPhamMenuItem7_Click(object sender, EventArgs e)
        {

        }

        private void baoCaoToolStripMenuItem13_Click(object sender, EventArgs e)
        {

        }

        private void mnuAdmin_Click(object sender, EventArgs e)
        {

        }
    }
}
