using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom1_QLBH.UI
{
    public partial class FrmDangKi : Form
    {
        public FrmDangKi()
        {
            InitializeComponent();
        }

        KetNoi kn = new KetNoi();
        private void FrmDangKi_Load(object sender, EventArgs e)
        {

        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUsername.Text) || String.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");

            }

            else if (txtNhapLai.Text == txtPassword.Text)
            {

                string sql_them = "Insert into HETHONG Values('" + txtUsername.Text + "' ,'" + txtSDT.Text + "' , '" + txtPassword.Text + "' )";
                kn.ThucThi(sql_them);
                DialogResult thongbao1;
                thongbao1 = MessageBox.Show("Tạo Tài Khoản Thành Công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                DialogResult thongbao1;
                thongbao1 = MessageBox.Show("Mật Khẩu Không Khớp", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            Form frm = new FrmLogin();
            frm.Show();
            this.Hide();
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

        private void txtTenDN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
