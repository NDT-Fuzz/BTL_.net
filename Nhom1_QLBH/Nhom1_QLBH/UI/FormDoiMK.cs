using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom1_QLBH.UI
{
    public partial class FormDoiMK : Form
    {
        public FormDoiMK()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi(); 
        private void btnDangKi_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUsername.Text) || String.IsNullOrEmpty(txtSDT.Text) || String.IsNullOrEmpty(txtMKMoi.Text) || String.IsNullOrEmpty(txtNhapLai.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");

            }
            else
            {
                kn.KetNoi_Dulieu();
                String TN = txtUsername.Text;
                String MK = txtMKMoi.Text;

                String sql_login = "Select TENDN, MATKHAU from HETHONG WHERE TENDN='" + TN + "'and MATKHAU='" + MK + "'";
                SqlCommand cmd = new SqlCommand(sql_login, kn.cnn);
                SqlDataReader datRead = cmd.ExecuteReader();

                if (datRead.Read() == true)
                {
                    String sql_sua = "Update HETHONG Set MATKHAU='" + txtMKMoi.Text + "'where TENDN='" + txtUsername.Text + "'";
                    kn.ThucThi(sql_sua);
                    DialogResult thongbao1;
                    thongbao1 = MessageBox.Show("Đổi Mật Khẩu thành công");
                }
                else
                {
                    DialogResult thongbao1;
                    thongbao1 = MessageBox.Show("Sai Mật Khẩu!");
                }
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            Form frmmain = new FormMain();
            frmmain.Show();
            this.Hide();
        }

        private void txtMKMoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click_1(object sender, EventArgs e)
        {
            Form frmmain = new FormMain();
            frmmain.Show();
            this.Hide();
        }

        private void FormDoiMK_Load(object sender, EventArgs e)
        {

        }
    }
}
