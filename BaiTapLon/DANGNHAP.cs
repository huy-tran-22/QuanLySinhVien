using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;
namespace BaiTapLon
{
    public partial class DANGNHAP : Form
    {

        public DANGNHAP()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DANGKY myform = new DANGKY();
            myform.Show();
            Hide();
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btdangnhap_Click(object sender, EventArgs e)
        {
            try
            {
                KetNoi.moketnoi();
                string taikhoan = tbusers.Text;
                string matkhau = tbpass.Text;
                string sql = "select * from USERS where Magv = '" + taikhoan + "' and MatKhau = '" + matkhau + "' ";
                KetNoi.cmd = new SqlCommand(sql, KetNoi.conn);
                KetNoi.dtreader = KetNoi.cmd.ExecuteReader();
                if (KetNoi.dtreader.Read() == true)
                {
                    string sql1 = "select * from USERS where Magv = '" + taikhoan + "'";
                    DataTable dt = KetNoi.getData(sql1);
                    MessageBox.Show("Đăng nhập thành công");
                    Qlsinhvien mainform = new Qlsinhvien();
                    mainform.Show();
                    Hide()
;
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                KetNoi.dongketnoi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }

        private void cbhienthimk_CheckedChanged(object sender, EventArgs e)
        {
            if (cbhienthimk.Checked == true)
            {
                tbpass.PasswordChar = (char)0;
            }
            else
            {
                tbpass.PasswordChar = '✱';
            }
        }

        private void DANGNHAP_Load(object sender, EventArgs e)
        {
        }
    }
}
