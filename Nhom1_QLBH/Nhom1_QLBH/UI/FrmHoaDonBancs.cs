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
    public partial class FrmHoaDonBancs : Form
    {
        public FrmHoaDonBancs()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();
        private void HienThiDuLieu()
        {
            txtMaHDB.DataBindings.Clear();
            txtMaHDB.DataBindings.Add("Text", DGVHoaDonBan.DataSource, "HoaDonBan_ID");

            dtNgayBan.DataBindings.Clear();
            dtNgayBan.DataBindings.Add("Value", DGVHoaDonBan.DataSource, "NgayBan");

            txtPTTT.DataBindings.Clear();
            txtPTTT.DataBindings.Add("Text", DGVHoaDonBan.DataSource, "PhuongThucThanhToan");

            txtTrangThai.DataBindings.Clear();
            txtTrangThai.DataBindings.Add("Text", DGVHoaDonBan.DataSource, "TrangThai");

            txtTongTien.DataBindings.Clear();
            txtTongTien.DataBindings.Add("Text", DGVHoaDonBan.DataSource, "TongTien");

            cboMaKH.DataBindings.Clear();
            cboMaKH.DataBindings.Add("Text", DGVHoaDonBan.DataSource, "KhachHang_ID");

            cboMaNV.DataBindings.Clear();
            cboMaNV.DataBindings.Add("Text", DGVHoaDonBan.DataSource, "NhanVien_ID");

        }
        private void BangHoaDonNhap()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select * from HoaDonBan");
            DGVHoaDonBan.DataSource = dta;
            HienThiDuLieu();
        }
        private void BangKH()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select * from KhachHang");
            cboMaKH.DataSource = dta;
            cboMaKH.DisplayMember = "KhachHang_ID";
            cboMaKH.ValueMember = "KhachHang_ID";

        }
        private void BangNhanVien()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select * from NhanVien");
            cboMaNV.DataSource = dta;
            cboMaNV.DisplayMember = "NhanVien_ID";
            cboMaNV.ValueMember = "NhanVien_ID";

        }
        private void FrmHoaDonBancs_Load(object sender, EventArgs e)
        {
            BangHoaDonNhap();
            BangKH();
            BangNhanVien();
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txtMaHDB.Text = "";
            txtPTTT.Text = "";
            txtTongTien.Text = "";
            txtTrangThai.Text = "";
            dtNgayBan.Value = DateTime.Now;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string strKtra = "Select HoaDonBan_ID from HoaDonBan where HoaDonBan_ID = '" + txtMaHDB.Text + "'";
            SqlCommand cmd = new SqlCommand(strKtra, kn.cnn);
            SqlDataReader doc = cmd.ExecuteReader();
            if (doc.Read() == true)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại, nhập lại mã khác", "Thông báo");
                txtMaHDB.Focus();
                doc.Close();
                doc.Dispose();

            }
            else
            {
                string sql_save = "Insert into HoaDonBan Values(' " + txtMaHDB.Text + "', '" + dtNgayBan.Value + "', '"
                + txtTrangThai.Text + "', '" + txtPTTT.Text + "', '" + txtTongTien.Text + "', '" + cboMaKH.Text + "', '" + cboMaNV.Text + "')";
                kn.ThucThi(sql_save);
                BangHoaDonNhap();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql_save = "UPDATE HoaDonBan SET NgayBan ='" + dtNgayBan.Value + "', PhuongThucThanhToan = N'" + txtPTTT.Text + "', TrangThai=N'" + txtTrangThai.Text +
            "', TongTien='" + txtTongTien.Text + "', KhachHang_ID='" + cboMaKH.Text + "', NhanVien_ID='" + cboMaNV.Text + "'WHERE HoaDonBan_ID='" + txtMaHDB.Text + "'";
            kn.ThucThi(sql_save);
            BangHoaDonNhap();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql_xoa = "Delete HoaDonBan where HoaDonBan_ID = '" + txtMaHDB.Text + "'";
            kn.ThucThi(sql_xoa);
            BangHoaDonNhap();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
