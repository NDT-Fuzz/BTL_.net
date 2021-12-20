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
    public partial class FrmTimKiemKhachHang : Form
    {
        public FrmTimKiemKhachHang()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();

       

        private void optNhapMa_CheckedChanged(object sender, EventArgs e)
        {
            txtMa.Focus();
            txtMa.Enabled = true;
            txtTen.Clear();
            txtTen.Enabled = false;
        }

        private void optNhapTen_CheckedChanged(object sender, EventArgs e)
        {
            txtTen.Focus();
            txtTen.Enabled = true;
            txtMa.Clear();
            txtMa.Enabled = false;
        }
        private void FrmTimKiemKhachHang_Load(object sender, EventArgs e)
        {
           
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            string sql;
            if (optNhapMa.Checked == true)
            {
                sql = "Select * from KhachHang where KhachHang_ID ='" + txtMa.Text + "'";
                dta = kn.Lay_DulieuBang(sql);
            }
            if (optNhapTen.Checked == true)
            {
                sql = "Select * from KhachHang where TenKhachHang like '%" + txtTen.Text + "%'";
                dta = kn.Lay_DulieuBang(sql);
            }

            Grid_KetQua.DataSource = dta;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
