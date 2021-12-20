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
namespace Nhom1_QLBH.Report
{
    public partial class FrmBC_TonKho : Form
    {
        public FrmBC_TonKho()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();
        private void Frm_BCBanHang_Load(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select * from Sanpham");
            BC_HangTonKho bc = new BC_HangTonKho();
            bc.SetDataSource(dta);
            CRV_TonKho.ReportSource = bc;
        }

        private void CRV_BanHang_Load(object sender, EventArgs e)
        {

        }
    }
}
