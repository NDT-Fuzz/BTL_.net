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
    public partial class FrmTimKiemSanPham : Form
    {
        public FrmTimKiemSanPham()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();
        private void FrmTimKiemSanPham_Load(object sender, EventArgs e)
        {
            DataTable dta = kn.Lay_DulieuBang("Select *  from  DmSanPham order by Dm_ID");
            cboMaDMSP.DataSource = dta;
            cboMaDMSP.DisplayMember = "Dm_ID";


        }

        private void optNhapMa_CheckedChanged(object sender, EventArgs e)
        {
            txtMa.Focus();
            txtMa.Enabled = true;
            txtTen.Clear();
            txtTen.Enabled = false;
            cboMaDMSP.Enabled = false;
        }
    

        private void optNhapTen_CheckedChanged(object sender, EventArgs e)
        {
            txtTen.Focus();
            txtTen.Enabled = true;
            txtMa.Clear();
            txtMa.Enabled = false;
            cboMaDMSP.Enabled = false;
        }

        private void optNhapMaDMSP_CheckedChanged(object sender, EventArgs e)
        {
            cboMaDMSP.Focus();
            cboMaDMSP.Enabled = true;
            txtTen.Clear();
            txtMa.Clear();
            txtTen.Enabled = false;
            txtMa.Enabled = false;
            
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            string sql;
            if (optNhapMa.Checked == true)
            {
                sql = "Select * from SanPham where SP_ID ='" + txtMa.Text + "'";
                dta = kn.Lay_DulieuBang(sql);
            }
            if (optNhapTen.Checked == true)
            {
                sql = "Select * from SanPham where TenSanPham like '%" + txtTen.Text + "%'";
                dta = kn.Lay_DulieuBang(sql);
            }
            if (optNhapMaDMSP.Checked == true)
            {
                sql = "Select * from SanPham where Dm_ID= '" + cboMaDMSP.Text + "'";
                dta = kn.Lay_DulieuBang(sql);
            }
            Grid_KetQua.DataSource = dta;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Grid_KetQua_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
