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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            kn.KetNoi_Dulieu();
            string DN = txtTenDN.Text;
            string MK = txtMatKhau.Text;
        
            string sql_login = "Select TENTN, MATKHAU FROM HeThong Where TenTN='" + DN + "' AND MATKHAU= '" + MK + "'";

            SqlCommand cmd = new SqlCommand(sql_login, kn.cnn);
            SqlDataReader datRed = cmd.ExecuteReader();
            if (datRed.Read() == true)
            {
                //MessageBox.Show("Đăng nhập thành công");
                Form frmmain = new FormMain(DN);
                frmmain.Show();
                this.Hide();

                //FormMain tenDN = new FormMain(DN); //Thực hiện truyền biến 
                //frmmain.Show();


            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại. Hãy kiểm tra lại thông tin đăng nhập",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn Có Muốn Thoát Không?", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thongbao == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            Form frm = new FrmDangKi();
            frm.Show();
            this.Hide();
        }

        private void txtTenDN_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
