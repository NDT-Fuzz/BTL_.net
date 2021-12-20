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
    public partial class FrmHoaDonNhap : Form
    {
        public FrmHoaDonNhap()
        {
            InitializeComponent();
            dtNgayNhap.ShowUpDown = true;
        }
        KetNoi kn = new KetNoi();
        private void HienThiDuLieu()
        {
            txtMaHDN.DataBindings.Clear();
            txtMaHDN.DataBindings.Add("Text", DGVHoaDon.DataSource, "Hdn_ID");

            dtNgayNhap.DataBindings.Clear();
            dtNgayNhap.DataBindings.Add("Value", DGVHoaDon.DataSource, "NgayNhapHang");

            txtNguoiNhap.DataBindings.Clear();
            txtNguoiNhap.DataBindings.Add("Text", DGVHoaDon.DataSource, "NguoiNhap");

            txtTrangThai.DataBindings.Clear();
            txtTrangThai.DataBindings.Add("Text", DGVHoaDon.DataSource, "TrangThai");

            txtTongTien.DataBindings.Clear();
            txtTongTien.DataBindings.Add("Text", DGVHoaDon.DataSource, "TongTien");

            cboMaNCC.DataBindings.Clear();
            cboMaNCC.DataBindings.Add("Text", DGVHoaDon.DataSource, "Ncc_ID");

        }
        private void BangHoaDonNhap()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select * from HoaDonNhap");
            DGVHoaDon.DataSource = dta;
            HienThiDuLieu();
        }
        private void BangNCC()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select * from NhaCungCap");
            cboMaNCC.DataSource = dta;
            cboMaNCC.DisplayMember = "Ncc_ID";
            cboMaNCC.ValueMember = "Ncc_ID";
            
        }
        private void FrmHoaDonNhap_Load(object sender, EventArgs e)
        {
            BangHoaDonNhap();
            BangNCC();
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txtMaHDN.Text = "";
            txtNguoiNhap.Text = "";
            txtTongTien.Text = "";
            txtTrangThai.Text = "";
            dtNgayNhap.Value = DateTime.Now;

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            string strKtra = "Select Hdn_ID from HoaDonNhap where Hdn_ID = '" + txtMaHDN.Text + "'";
            SqlCommand cmd = new SqlCommand(strKtra, kn.cnn);
            SqlDataReader doc = cmd.ExecuteReader();
            if (doc.Read() == true)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại, nhập lại mã khác", "Thông báo");
                txtMaHDN.Focus();
                doc.Close();
                doc.Dispose();

            }
            else
            {
                string sql_save = "Insert into HoaDonNhap Values(' " + txtMaHDN.Text + "', '" + dtNgayNhap.Value + "', '"
                + txtNguoiNhap.Text + "', '" + txtTrangThai.Text + "', '" + txtTongTien.Text + "', '" + cboMaNCC.Text + "')";
                kn.ThucThi(sql_save);
                BangHoaDonNhap();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql_save = "UPDATE HoaDonNhap SET NgayNhapHang ='" +dtNgayNhap.Value + "', NguoiNhap = '" + txtNguoiNhap.Text + "', TrangThai=N'" + txtTrangThai.Text +
             "', TongTien='" + txtTongTien.Text + "', Ncc_ID='" + cboMaNCC.Text + "'WHERE Hdn_ID='" + txtMaHDN.Text + "'";
            kn.ThucThi(sql_save);
            BangHoaDonNhap();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql_xoa = "Delete HoaDonNhap where Hdn_ID = '" + txtMaHDN.Text + "'";
            kn.ThucThi(sql_xoa);
            BangHoaDonNhap();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
