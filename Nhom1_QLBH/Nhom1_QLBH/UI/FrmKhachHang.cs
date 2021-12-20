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
    public partial class FrmKhachHang : Form
    {
        public FrmKhachHang()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();
        private void HienThiDuLieu()
        {
            txtMaKH.DataBindings.Clear();
            txtMaKH.DataBindings.Add("Text", DGVKhachHang.DataSource, "KhachHang_ID");

            txtTenKH.DataBindings.Clear();
            txtTenKH.DataBindings.Add("Text", DGVKhachHang.DataSource, "TenKhachHang");

            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", DGVKhachHang.DataSource, "SoDT");

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", DGVKhachHang.DataSource, "DiaChi");

            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", DGVKhachHang.DataSource, "Email");

         

        }
        private void BangNhanVien()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select * from KhachHang");
            DGVKhachHang.DataSource = dta;
            HienThiDuLieu();
        }
        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            BangNhanVien();
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string strKtra = "Select KhachHang_ID from KhachHang where KhachHang_ID = '" + txtMaKH.Text + "'";
            SqlCommand cmd = new SqlCommand(strKtra, kn.cnn);
            SqlDataReader doc = cmd.ExecuteReader();
            if (doc.Read() == true)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại, nhập lại mã khác", "Thông báo");
                txtMaKH.Focus();
                doc.Close();
                doc.Dispose();

            }
            else
            {
                string sql_save = "Insert into KhachHang Values(' " + txtMaKH.Text + "', '" + txtTenKH.Text + "', "
                + txtSDT.Text + ", '" + txtDiaChi.Text + "', '" + txtEmail.Text + "')";
                kn.ThucThi(sql_save);
                BangNhanVien();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql_save = "UPDATE KhachHang SET TenKhachHang ='" + txtTenKH.Text + "', SoDT = " + txtSDT.Text + ", DiaChi='" + txtDiaChi.Text +
              "', Email='" + txtEmail.Text + "'WHERE KhachHang_ID='" + txtMaKH.Text + "'";
            kn.ThucThi(sql_save);
            BangNhanVien();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql_xoa = "Delete Khachhang where KhachHang_ID = '" + txtMaKH.Text + "'";
            kn.ThucThi(sql_xoa);
            BangNhanVien();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
