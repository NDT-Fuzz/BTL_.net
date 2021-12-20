using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Nhom1_QLBH.UI
{
    public partial class FrmSanPham : Form
    {
        public FrmSanPham()
        {
            InitializeComponent();
        }

        private void lblVaiTro_Click(object sender, EventArgs e)
        {

        }

        private void lblMaSP_Click(object sender, EventArgs e)
        {

        }
        KetNoi kn = new KetNoi();
        private void HienThiDuLieu()
        {
            txtMaSP.DataBindings.Clear();
            txtMaSP.DataBindings.Add("Text", DGVSP.DataSource, "SP_ID");

            txtTenSP.DataBindings.Clear();
            txtTenSP.DataBindings.Add("Text", DGVSP.DataSource, "TenSanPham");

            txtGiaNhap.DataBindings.Clear();
            txtGiaNhap.DataBindings.Add("Text", DGVSP.DataSource, "GiaNhap");

            txtGiaBan.DataBindings.Clear();
            txtGiaBan.DataBindings.Add("Text", DGVSP.DataSource, "GiaBan");

            txtMoTa.DataBindings.Clear();
            txtMoTa.DataBindings.Add("Text", DGVSP.DataSource, "MoTa");

            txtSoLuong.DataBindings.Clear();
            txtSoLuong.DataBindings.Add("Text", DGVSP.DataSource, "SoLuong");

            cboDMSP.DataBindings.Clear();
            cboDMSP.DataBindings.Add("Text", DGVSP.DataSource, "Dm_ID");

        }
        private void BangSP()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select * from SanPham");
            DGVSP.DataSource = dta;
            HienThiDuLieu();
        }
        private void BangDMSP()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select * from DMSanPham");
            cboDMSP.DataSource = dta;
            cboDMSP.DisplayMember = "Dm_ID";
            cboDMSP.ValueMember = "Dm_ID";
        }

        private void lblSanPham_Load(object sender, EventArgs e)
        {
            BangSP();
            BangDMSP();
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtGiaBan.Text = "";
            txtGiaNhap.Text = "";
            txtSoLuong.Text = "";
            txtMoTa.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string strKtra = "Select SP_ID from SanPham where SP_ID = '" + txtMaSP.Text + "'";
            SqlCommand cmd = new SqlCommand(strKtra, kn.cnn);
            SqlDataReader doc = cmd.ExecuteReader();
            if (doc.Read() == true)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại, nhập lại mã khác", "Thông báo");
                txtMaSP.Focus();
                doc.Close();
                doc.Dispose();

            }
            else
            {
                string sql_save = "Insert into SanPham Values(' " + txtMaSP.Text + "', '" + txtTenSP.Text + "', "
                + txtGiaNhap.Text + ", '" + txtGiaBan.Text + "', '" + txtMoTa.Text + "', '" + txtSoLuong.Text + "', '" + cboDMSP.Text + "')";
                kn.ThucThi(sql_save);
                BangSP();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql_save = "UPDATE SanPham SET TenSanPham ='" + txtTenSP.Text + "', GiaNhap = " + txtGiaNhap.Text + ", GiaBan='" + txtGiaBan.Text +
               "', SoLuong='" + txtSoLuong.Text + "', MoTa='" + txtMoTa.Text + "', Dm_ID='" + cboDMSP.Text + "'WHERE SP_ID='" + txtMaSP.Text + "'";
            kn.ThucThi(sql_save);
            BangSP();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql_xoa = "Delete SanPham where SP_ID = '" + txtMaSP.Text + "'";
            kn.ThucThi(sql_xoa);
            BangSP();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
