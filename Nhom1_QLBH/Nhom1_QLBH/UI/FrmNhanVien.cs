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
    public partial class FrmNhanVien : Form
    {
        public FrmNhanVien()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();
        private void HienThiDuLieu()
        {
            txtMaNV.DataBindings.Clear();
            txtMaNV.DataBindings.Add("Text", DGVNhanVien.DataSource, "NhanVien_ID");

            txtTenNV.DataBindings.Clear();
            txtTenNV.DataBindings.Add("Text", DGVNhanVien.DataSource, "TenNhanVien");

            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", DGVNhanVien.DataSource, "SoDT");

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", DGVNhanVien.DataSource, "DiaChi");

            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", DGVNhanVien.DataSource, "Email");

            cboVaiTro.DataBindings.Clear();
            cboVaiTro.DataBindings.Add("Text", DGVNhanVien.DataSource, "VaiTro_ID");

        }
        private void BangNhanVien()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select * from NHANVIEN");
            DGVNhanVien.DataSource = dta;
            HienThiDuLieu();
        }
        private void BangVaiTro()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select * from VaiTro");
            cboVaiTro.DataSource = dta;
            cboVaiTro.DisplayMember = "VaiTro_ID";
            cboVaiTro.ValueMember = "VaiTro_ID";
        }
        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            BangNhanVien();
            BangVaiTro();
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string strKtra = "Select NhanVien_ID from NHANVIEN where NhanVien_ID = '" + txtMaNV.Text + "'";
            SqlCommand cmd = new SqlCommand(strKtra, kn.cnn);
            SqlDataReader doc = cmd.ExecuteReader();
            if (doc.Read() == true)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại, nhập lại mã khác", "Thông báo");
                txtMaNV.Focus();
                doc.Close();
                doc.Dispose();

            }
            else
            {
                string sql_save = "Insert into NHANVIEN Values(' " + txtMaNV.Text + "', '" + txtTenNV.Text + "', "
                + txtSDT.Text + ", '" + txtDiaChi.Text + "', '" + txtEmail.Text + "', '" + cboVaiTro.Text + "')";
                kn.ThucThi(sql_save);
                BangNhanVien();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql_save = "UPDATE NHANVIEN SET TenNhanVien ='" + txtTenNV.Text + "', SoDT = " + txtSDT.Text + ", DiaChi='" + txtDiaChi.Text +
               "', Email='" + txtEmail.Text + "', VaiTro_ID='" + cboVaiTro.Text + "'WHERE NhanVien_ID='" + txtMaNV.Text + "'";
            kn.ThucThi(sql_save);
            BangNhanVien();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql_xoa = "Delete NHANVIEN where NhanVien_ID = '" + txtMaNV.Text + "'";
            kn.ThucThi(sql_xoa);
            BangNhanVien();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }






        private void lblSDT_Click(object sender, EventArgs e)
        {

        }

        private void txtTenNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboVaiTro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTenNV_Click(object sender, EventArgs e)
        {

        }

        private void lblMaNV_Click(object sender, EventArgs e)
        {

        }

        private void DGVNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
