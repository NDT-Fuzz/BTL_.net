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
    public partial class FrmDMSP : Form
    {
        public FrmDMSP()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();
        private void DGVDMSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void HienThiDuLieu()
        {
            txtMaDM.DataBindings.Clear();
            txtMaDM.DataBindings.Add("Text", DGVDMSP.DataSource, "Dm_ID");

            txtTenDM.DataBindings.Clear();
            txtTenDM.DataBindings.Add("Text", DGVDMSP.DataSource, "TenDm");


        }
        private void BangDMSP()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select * from DmSanPham");
            DGVDMSP.DataSource = dta;
            HienThiDuLieu();
        }
      
        private void FrmDMSP_Load(object sender, EventArgs e)
        {
            BangDMSP();
        }
        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txtTenDM.Text = "";
            txtMaDM.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string strKtra = "Select Dm_ID from DmSanPham where Dm_ID = '" + txtMaDM.Text + "'";
            SqlCommand cmd = new SqlCommand(strKtra, kn.cnn);
            SqlDataReader doc = cmd.ExecuteReader();
            if (doc.Read() == true)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại, nhập lại mã khác", "Thông báo");
                txtMaDM.Focus();
                doc.Close();
                doc.Dispose();

            }
            else
            {
                string sql_save = "Insert into DmSanPham Values(' " + txtMaDM.Text + "', '" + txtTenDM.Text + "')";
                kn.ThucThi(sql_save);
                BangDMSP();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql_save = "UPDATE DmSanPham SET TenDm ='" + txtTenDM.Text + "' WHERE Dm_ID='" + txtMaDM.Text + "'";
            kn.ThucThi(sql_save);
            BangDMSP();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql_xoa = "Delete DmSanPham where Dm_ID = '" + txtMaDM.Text + "'";
            kn.ThucThi(sql_xoa);
            BangDMSP();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
