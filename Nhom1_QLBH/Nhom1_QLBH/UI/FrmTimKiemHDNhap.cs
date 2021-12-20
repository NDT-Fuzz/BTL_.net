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
    public partial class FrmTimKiemHDNhap : Form
    {
        public FrmTimKiemHDNhap()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();

        private void FrmTimKiemHDNhap_Load(object sender, EventArgs e)
        {
            DataTable dta = kn.Lay_DulieuBang("Select *  from  NhaCungCap order by Ncc_ID");
            cboMaNCC.DataSource = dta;
            cboMaNCC.DisplayMember = "Ncc_ID";
        }

        private void optNhapMa_CheckedChanged(object sender, EventArgs e)
        {
            txtMaHD.Focus();
            txtMaHD.Enabled = true;
            cboMaNCC.Enabled = false;
        }

        private void optNhapMaNCC_CheckedChanged(object sender, EventArgs e)
        {
            cboMaNCC.Focus();
            cboMaNCC.Enabled = true;
            txtMaHD.Clear();
            txtMaHD.Enabled = false;
            
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            string sql;
            if (optNhapMa.Checked == true)
            {
                sql = "Select * from HoaDonNhap where Hdn_ID ='" + txtMaHD.Text + "'";
                dta = kn.Lay_DulieuBang(sql);
            }
            if (optNhapMaNCC.Checked == true)
            {
                sql = "Select * from HoaDonNhap where Ncc_ID= '" + cboMaNCC.Text + "'";
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
