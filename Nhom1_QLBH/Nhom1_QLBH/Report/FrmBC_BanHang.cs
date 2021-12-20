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
    public partial class FrmBC_BanHang : Form
    {
        public FrmBC_BanHang()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void FrmBC_HangTonKhocs_Load(object sender, EventArgs e)
        {
            //DataTable dta = new DataTable();
           // dta = kn.Lay_DulieuBang("Select * from SanPham");
           // BC_HangTonKho bc = new BC_HangTonKho();
           // bc.SetDataSource(dta);
           // CRV_TonKho.ReportSource = bc;

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select * from BanHang1 where NgayBan between CONVERT(datetime,'" + dtpFrom.Value.Date.ToString("MM/dd/yyyy") + "')and CONVERT(datetime,'" + dtpTo.Value.Date.ToString("MM/dd/yyyy") + "')");
            BC_BanHang BC = new BC_BanHang();
            BC.SetDataSource(dta);
            CRV_BanHang.ReportSource = BC;
        }
    }
}
