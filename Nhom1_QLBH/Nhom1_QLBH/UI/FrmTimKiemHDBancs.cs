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
    public partial class FrmTimKiemHDBancs : Form
    {
        public FrmTimKiemHDBancs()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();

        private void FrmTimKiemHDBancs_Load(object sender, EventArgs e)
        {
            DataTable dta = kn.Lay_DulieuBang("Select *  from  KhachHang order by KhachHang_ID");
            cboMaKH.DataSource = dta;
            cboMaKH.DisplayMember = "KhachHang_ID";

            DataTable dtb = kn.Lay_DulieuBang("Select *  from  NhanVien order by NhanVien_ID");
            cboNhapMaNV.DataSource = dtb;
            cboNhapMaNV.DisplayMember = "NhanVien_ID";
        }

        private void optNhapMa_CheckedChanged(object sender, EventArgs e)
        {
            txtMaHD.Focus();
            txtMaHD.Enabled = true;
            cboMaKH.Enabled = false;
            cboNhapMaNV.Enabled = false;
        }

        private void optNhapMaKH_CheckedChanged(object sender, EventArgs e)
        {
            cboMaKH.Focus();
            txtMaHD.Enabled = false;
            txtMaHD.Clear();
            cboMaKH.Enabled = true;
            cboNhapMaNV.Enabled = false;
        }

        private void optNhapMaNV_CheckedChanged(object sender, EventArgs e)
        {
            cboNhapMaNV.Focus();
            txtMaHD.Enabled = false;
            txtMaHD.Clear();
            cboNhapMaNV.Enabled = true;
            cboMaKH.Enabled = false;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            string sql;
            if (optNhapMa.Checked == true)
            {
                sql = "Select * from HoaDonBan where HoaDonBan_ID ='" + txtMaHD.Text + "'";
                dta = kn.Lay_DulieuBang(sql);
            }
            if (optNhapMaKH.Checked == true)
            {
                sql = "Select * from HoaDonBan where KhachHang_ID= '" + cboMaKH.Text + "'";
                dta = kn.Lay_DulieuBang(sql);
            }
            if (optNhapMaNV.Checked == true)
            {
                sql = "Select * from HoaDonBan where NhanVien_ID= '" + cboNhapMaNV.Text + "'";
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
