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
namespace BaiTapLon
{
    public partial class Qlsinhvien : Form
    {
        DialogResult dr;
        public Qlsinhvien()
        {
            InitializeComponent();
        }

        #region
        public void loadcombobox()
        {
            //Mã Lớp
            string sql = "select MaLop from LOP order by MaLop ASC";
            cbbmalop.DataSource = KetNoi.getData(sql);
            cbbmalop.ValueMember = "MaLop";
            //Khoa
            string sql1 = "select * from KHOA";
            cbbmakhoa.DataSource = KetNoi.getData(sql1);
            cbbmakhoa.ValueMember = "MaKhoa";
            cbbtenkhoa.DataSource = KetNoi.getData(sql1);
            cbbtenkhoa.ValueMember = "TenKhoa";
            cbbmakhoa2.DataSource = KetNoi.getData(sql1);
            cbbmakhoa2.ValueMember = "MaKhoa";
            //Mã sinh viên
            string sql2 = "select Masv from SINHVIEN order by Masv ASC";
            cbbmasv.DataSource = KetNoi.getData(sql2);
            cbbmasv.ValueMember = "Masv";

            //Môn Học
            string sql3 = "select * from MONHOC order by MaMH ASC";
            cbbmamonhoc.DataSource = KetNoi.getData(sql3);
            cbbmamonhoc.ValueMember = "MaMH";
            cbbtenmh.DataSource = KetNoi.getData(sql3);
            cbbtenmh.ValueMember = "TenMH";

            //account type
            string sql4 = "select LoaiTaiKhoan from USERS";

        }
        public void loadData()
        {
            //Sinh Viên
            string sql = "Select * from SINHVIEN";
            datashow.DataSource = KetNoi.getData(sql);
            //Khoa
            string sql1 = "select * from KHOA";
            datashow2.DataSource = KetNoi.getData(sql1);
            //Lớp
            string sql3 = "select * from LOP";
            datashow3.DataSource = KetNoi.getData(sql3);
            //Môn Học
            string sql4 = "select * from MONHOC";
            datashow4.DataSource = KetNoi.getData(sql4);
            //Kết Quả
            string sql5 = "select * from KETQUA ORDER BY DiemThi DESC";
            datashow5.DataSource = KetNoi.getData(sql5);
            //Users
            string sql6 = "select * from Users";
        }
        #endregion

        private void Qlsinhvien_Load(object sender, EventArgs e)
        {
            KetNoi.moketnoi();
            loadcombobox();
            loadData();

            if (datashow != null || datashow2 != null || datashow3 != null || datashow4 != null || datashow5 != null)
            {
                datashow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                datashow.Columns[datashow.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                datashow2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                datashow2.Columns[datashow2.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                datashow3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                datashow3.Columns[datashow3.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                datashow4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                datashow4.Columns[datashow4.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                datashow5.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                datashow5.Columns[datashow5.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }
        }
        
        // Hiển thị thông tin sinh viên
        private void datashow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = datashow.CurrentCell.RowIndex;
            tbmasv.Text = datashow.Rows[i].Cells[0].Value.ToString();
            tbhoten.Text = datashow.Rows[i].Cells[1].Value.ToString();
            dtpkdate.Text = datashow.Rows[i].Cells[2].Value.ToString();
            string gt = datashow.Rows[i].Cells[3].Value.ToString();
            if (gt == "True")
            {
                rdNam.Checked = true;
            }
            else
            {
                rdNu.Checked = true;
            }
            tbnienkhoa.Text = datashow.Rows[i].Cells[4].Value.ToString();
            cbbmalop.SelectedValue = datashow.Rows[i].Cells[5].Value.ToString();
        }


        // Thêm thông tin sinh viên
        private void btthem_Click(object sender, EventArgs e)
        {
            KetNoi.moketnoi();
            if (KetNoi.ktMaSV(tbmasv.Text) == 0)
            {   
                string sql = "Insert into SINHVIEN Values (@Masv, @HoTen, @NgaySinh, @GioiTinh, @NienKhoa, @MaLop)";
                string[] name = { "@Masv", "@HoTen", "@NgaySinh", "@GioiTinh", "@NienKhoa", "@MaLop" };
                bool gt = rdNam.Checked == true ? true : false;
                object[] value = { tbmasv.Text, tbhoten.Text, dtpkdate.Value, gt, tbnienkhoa.Text, cbbmalop.SelectedValue };

                KetNoi.updateData(sql, value, name, 6);
                loadData();
                loadcombobox();
                MessageBox.Show("Đã thêm thành công vào cơ sở dữ liệu");
                KetNoi.dongketnoi();
            }
            else
            {
                MessageBox.Show("Mã sinh viên đã tồn tại vui lòng nhập mã khác!");
            }
        }

        // Sửa thông tin sinh viên
        private void btsua_Click(object sender, EventArgs e)
        {
            dr = MessageBox.Show("Bạn có đồng ý sửa lại thông tin không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                string sql = String.Format(@"Update SINHVIEN set Masv = @Masv, HoTen = @HoTen, NgaySinh = @NgaySinh,
                                            GioiTinh = @GioiTinh, NienKhoa = @NienKhoa, MaLop = @MaLop where Masv = '{0}'", tbmasv.Text);
                string[] name = { "@Masv", "@HoTen", "@NgaySinh", "@GioiTinh", "@NienKhoa", "@MaLop" };
                bool gt = rdNam.Checked == true ? true : false;
                object[] value = { tbmasv.Text, tbhoten.Text, dtpkdate.Value, gt, tbnienkhoa.Text, cbbmalop.SelectedValue };
                KetNoi.moketnoi();
                KetNoi.updateData(sql, value, name, 6);
                loadData();
                KetNoi.dongketnoi();
                MessageBox.Show("Đã sửa thành công vào csdl");
            }
        }

        // Xóa thông tin sinh viên
        private void btxoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Bạn có muốn xoá không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                int i = datashow.CurrentCell.RowIndex;
                string ma = datashow.Rows[i].Cells[0].Value.ToString();
                string sql = string.Format("Delete from SINHVIEN where Masv = '{0}'", ma);
                string[] name = { };
                object[] value = { };
                KetNoi.moketnoi();
                KetNoi.updateData(sql, value, name, 0);
                loadData();
                loadcombobox();
                KetNoi.dongketnoi();
                MessageBox.Show("Bạn đã xoá thành công");
            }
            else
            {
                MessageBox.Show("Bạn đã huỷ đối tượng này");
            }
        }

        // Tìm thông tin sinh viên
        private void bttimkiem_Click(object sender, EventArgs e)
        {
            string ma = tbmasv.Text;
            string ten = tbhoten.Text;
            string sql1 = string.Format("select * from SINHVIEN where HoTen like N'%{0}'", ten);
            string sql2 = string.Format("select * from SINHVIEN where masv like '%{0}'", ma);
            string sql3 = string.Format("select * from SINHVIEN where masv like '%{0}' and hoten like  N'%{1}'", ma,ten);

            KetNoi.moketnoi();
            if(ma.Trim() == "")
            {
                datashow.DataSource = KetNoi.getData(sql1);
            }
            else if(ten.Trim() == "")
            {
                datashow.DataSource = KetNoi.getData(sql2);
            }
            else
            {
                datashow.DataSource = KetNoi.getData(sql3);
            }
            KetNoi.dongketnoi();
        }

        // Reload bảng sinh viên
        private void btlammoi_Click(object sender, EventArgs e)
        {
            string sql = "Select * from SINHVIEN";
            tbmasv.Text = "";
            tbhoten.Text = "";
            rdNam.Checked = false;
            rdNu.Checked = false;
            dtpkdate.Value = DateTime.Today;
            tbnienkhoa.Text = "";
            cbbmalop.SelectedValue = "";
            KetNoi.moketnoi();
            datashow.DataSource = KetNoi.getData(sql);
            loadData();
            KetNoi.dongketnoi();
        }

        // Chọn khoa
        private void datashow2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = datashow2.CurrentCell.RowIndex;
            cbbmakhoa.SelectedValue = datashow2.Rows[i].Cells[0].Value.ToString();
            cbbtenkhoa.SelectedValue = datashow2.Rows[i].Cells[1].Value.ToString();
            tbcbgv.Text = datashow2.Rows[i].Cells[2].Value.ToString();
        }

        // Cập nhật khoa

        private void btcapnhat_Click(object sender, EventArgs e)
        {
            dr = MessageBox.Show("Bạn có đồng ý cập nhật hay không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                string sql = string.Format(@"Update KHOA set MaKhoa = @MaKhoa, TenKhoa = @TenKhoa, SoCBGV = @SoCBGV
                                            where MaKhoa = @MaKhoa");

                string[] name = { "@MaKhoa", "@TenKhoa", "@SoCBGV" };
                object[] value = { cbbmakhoa.SelectedValue, cbbtenkhoa.SelectedValue, tbcbgv.Text };
                KetNoi.moketnoi();
                KetNoi.updateData(sql, value, name, 3);
                loadData();
                KetNoi.dongketnoi();
                MessageBox.Show("Đã cập nhật thành công");
            }
        }

        // Reload bảng khoa
        private void btlammoi1_Click(object sender, EventArgs e)
        {
            string sql = "select * from KHOA";
            cbbmakhoa.SelectedValue = "";
            cbbtenkhoa.SelectedValue = "";
            tbcbgv.Text = "";
            KetNoi.moketnoi();
            KetNoi.getData(sql);
            loadData();
            KetNoi.dongketnoi();
        }



        // Xóa lớp
        private void btxoa2_Click(object sender, EventArgs e)
        {
            dr = MessageBox.Show("Bạn có chắc chắn muốn xoá hay không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                string sql = string.Format("Delete from LOP where MaLop = '{0}'", tbmalop.Text);
                string[] name = { };
                object[] value = { };
                KetNoi.moketnoi();
                KetNoi.updateData(sql, value, name, 0);
                loadData();
                KetNoi.dongketnoi();
                MessageBox.Show("Bạn đã xoá thành công");
            }
        }
        //Tìm mã lớp trong bảng Lớp

        private void btimlop_Click(object sender, EventArgs e)
        {
            string sql = string.Format("Select * from LOP where MaLop = '{0}'", tbmalop.Text);
            KetNoi.moketnoi();
            datashow3.DataSource = KetNoi.getData(sql);
            KetNoi.dongketnoi();

        }
        // Hiển thị cell click
        private void datashow3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = datashow3.CurrentCell.RowIndex;
            tbmalop.Text = datashow3.Rows[i].Cells[0].Value.ToString();
            tbtenlop.Text = datashow3.Rows[i].Cells[1].Value.ToString();
            cbbmakhoa2.SelectedValue = datashow3.Rows[i].Cells[2].Value.ToString();
        }


        // Hiển thị cell click

        private void datashow4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = datashow4.CurrentCell.RowIndex;
            tbmamh.Text = datashow4.Rows[i].Cells[0].Value.ToString();
            tbtenmh.Text = datashow4.Rows[i].Cells[1].Value.ToString();
            tbtinchi.Text = datashow4.Rows[i].Cells[2].Value.ToString();
            tbsotiet.Text = datashow4.Rows[i].Cells[3].Value.ToString();
        }

        // Sửa thông tin môn học
        private void btsua2_Click(object sender, EventArgs e)
        {
            dr = MessageBox.Show("Bạn có đồng ý sửa hay không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                string sql = string.Format(@"Update MONHOC set MAMH = @MaMH, TenMH = @TenMH, TinChi = @TinChi, SoTiet = @SoTiet
                                            where MaMH = @MaMH");

                string[] name = { "@MaMH", "@TenMH", "@TinChi", "@SoTiet" };
                object[] value = { tbmamh.Text, tbtenmh.Text, tbtinchi.Text, tbsotiet.Text };
                KetNoi.moketnoi();
                KetNoi.updateData(sql, value, name, 4);
                loadData();
                KetNoi.dongketnoi();
            }
            MessageBox.Show("Đã cập nhật thành công");
        }

        //Reload
        private void btlammoi3_Click(object sender, EventArgs e)
        {
            tbmamh.Text = "";
            tbtenmh.Text = "";
            tbtinchi.Text = "";
            tbsotiet.Text = "";
            string sql = "select * from MONHOC";
            KetNoi.moketnoi();
            datashow4.DataSource = KetNoi.getData(sql);
            loadData();
            KetNoi.dongketnoi();
        }

        //Tìm kiếm môn học
        private void bttimkiem2_Click(object sender, EventArgs e)
        {
            string sql = string.Format("select * from MONHOC where MaMH = '{0}'", tbmamh.Text);
            KetNoi.moketnoi();
            datashow4.DataSource = KetNoi.getData(sql);
            KetNoi.dongketnoi();
        }

        //click cell
        private void datashow5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = datashow5.CurrentCell.RowIndex;
            cbbmamonhoc.SelectedValue = datashow5.Rows[i].Cells[0].Value.ToString();
            cbbmasv.SelectedValue = datashow5.Rows[i].Cells[1].Value.ToString();
            cbbtenmh.SelectedValue = datashow5.Rows[i].Cells[2].Value.ToString();
            tbdiemthi.Text = datashow5.Rows[i].Cells[3].Value.ToString();
        }

        //reload
        private void btlammoi5_Click(object sender, EventArgs e)
        {
            KetNoi.moketnoi();
            cbbmamonhoc.SelectedValue = "";
            cbbmasv.SelectedValue = "";
            cbbtenmh.SelectedValue = "";
            tbdiemthi.Text = "";
            loadData();
            KetNoi.dongketnoi();
        }
        
        // Cập nhật điểm sinh viên
        private void btthem4_Click(object sender, EventArgs e)
        {
            string sql = "Insert into KETQUA VALUES(@MaMH, @Masv, @TenMH, @DiemThi)";
            string sql2 = "Update KETQUA set DiemThi = @DiemThi WHERE Masv = @Masv and MaMH = @MaMH and TenMH = @TenMH";
            KetNoi.moketnoi();
            if (KetNoi.ktKetQua(cbbmasv.Text, cbbmamonhoc.Text) == 0)
            {
                string[] name = { "@MaMH", "@Masv", "@TenMH", "@DiemThi" };
                object[] value = { cbbmamonhoc.SelectedValue, cbbmasv.SelectedValue, cbbtenmh.SelectedValue, tbdiemthi.Text };
                KetNoi.updateData(sql, value, name, 4);
                loadData();
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                string[] name = { "@MaMH", "@Masv", "@TenMH", "@DiemThi" };
                object[] value = { cbbmamonhoc.SelectedValue, cbbmasv.SelectedValue, cbbtenmh.SelectedValue, tbdiemthi.Text };
                KetNoi.updateData(sql2, value, name, 4); 
                loadData();
                MessageBox.Show("Cập nhật thành công");
            }
            KetNoi.dongketnoi();
        }

        // Tìm điểm sinh viên
        private void bttimsv_Click(object sender, EventArgs e)
        {
            KetNoi.moketnoi();
            if (cbbmamonhoc.Text == "")
            {
                string sql = string.Format("select * from KETQUA where Masv = '{0}'", cbbmasv.Text);
                datashow5.DataSource = KetNoi.getData(sql);
            }
            else if (cbbmasv.Text == "")
            {
                string sql = string.Format("select * from KETQUA where MaMH = '{0}'", cbbmamonhoc.Text);
                datashow5.DataSource = KetNoi.getData(sql);

            }
            else if(cbbmasv.Text != "" && cbbmamonhoc.Text != "") {
                string sql = string.Format("select * from KETQUA where MaSV = '{0}' and MaMH = '{1}'", cbbmasv.Text, cbbmamonhoc.Text);
                datashow5.DataSource = KetNoi.getData(sql);
            }
            KetNoi.dongketnoi();
        }

        //Đăng xuất
        private void btdangxuat_Click(object sender, EventArgs e)
        {
            DANGNHAP dn = new DANGNHAP();
            dn.Show();
            Hide();
        }


    }
}
