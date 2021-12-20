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
    public partial class FrmNCC : Form
    {
        public FrmNCC()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();
        public void BangNCC()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select * From NhaCungCap");
            DGVNhaCungCap.DataSource = dta;
            Hienthi_Dulieu();
        }

        private void Hienthi_Dulieu()
        {
            txtMaNCC.DataBindings.Clear();
            txtMaNCC.DataBindings.Add("Text", DGVNhaCungCap.DataSource, "NCC_ID");

            txtTenNCC.DataBindings.Clear();
            txtTenNCC.DataBindings.Add("Text", DGVNhaCungCap.DataSource, "TenNcc");

            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", DGVNhaCungCap.DataSource, "SoDT");

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", DGVNhaCungCap.DataSource, "DiaChi");
        }
        private void FrmNCC_Load(object sender, EventArgs e)
        {
            BangNCC();
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {

            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string strKtra = "Select NCC_ID from NhaCungCap where NCC_ID = '" + txtMaNCC.Text + "'";
            SqlCommand cmd = new SqlCommand(strKtra, kn.cnn);
            SqlDataReader doc = cmd.ExecuteReader();
            if (doc.Read() == true)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại, nhập lại mã khác", "Thông báo");
                txtMaNCC.Focus();
                doc.Close();
                doc.Dispose();

            }
            else
            {
                string sql_save = "Insert into NhaCungCap Values('" + txtMaNCC.Text + "','" + txtTenNCC.Text + "','" + txtDiaChi.Text + "','" + txtSDT.Text + "')";
                kn.ThucThi(sql_save);
                BangNCC();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
           
                string sql_sua = "Update NhaCungCap Set TenNCC = N'" + txtTenNCC.Text + "'";
                sql_sua = sql_sua + ",DiaChi = N'" + txtDiaChi.Text + "',";
                sql_sua = sql_sua + "SoDT = '" + txtSDT.Text;
                sql_sua = sql_sua + "'where NCC_ID = '" + txtMaNCC.Text + "'";
                kn.ThucThi(sql_sua);
                BangNCC();
     
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql_xoa = "Delete NhaCungCap where Ncc_ID = '" + txtMaNCC.Text + "'";
            kn.ThucThi(sql_xoa);
            BangNCC();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
