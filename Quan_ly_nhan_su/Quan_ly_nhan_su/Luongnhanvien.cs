using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_ly_nhan_su
{
    public partial class Luongnhanvien : Form
    {
        QuanLiNhanSuEntities dt = new QuanLiNhanSuEntities();
        private string query_tinhluong= "select STT ,nv.MaNV,nv.HoTen N'Họ tên',l.HSLuong,l.HSPhuCap,l.BHYT,l.BHTN,l.BHXH,(l.LuongCB*l.HSLuong*HSPhuCap)-(l.LuongCB*l.bhyt*l.BHTN*l.BHXH) N'Lương thực lãnh'  from dbo.NhanVien nv join Luong l on nv.MaLuong=l.MaLuong";
        private string query_dsluongnv = "select STT ,nv.MaNV,nv.HoTen N'Họ tên',l.HSLuong,l.HSPhuCap,l.BHYT,l.BHTN,l.BHXH,l.LuongCB N'Lương cơ bản'  from dbo.NhanVien nv join Luong l on nv.MaLuong=l.MaLuong";
        private string ma;
        public Luongnhanvien()
        {
            InitializeComponent();
            dataGridView1.DataSource = DataNhanSu.Danhsach(query_dsluongnv).Tables[0];
            loadtenpb();
            loadmaluong();
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Visible = false;
            f.ShowDialog();
        }
        private void loadmaluong()
        {
            var mal = dt.Luongs;
            foreach (Luong item in mal)
                cb_ma.Items.Add(item.MaLuong);
        }
        private void loadtenpb()
        {
            var tenpb = dt.PhongBans;
            foreach(PhongBan item in tenpb)
            {
                cb_tháng.Items.Add(item.TenPb);
            }
        }
        private void bt_tinhluong_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DataNhanSu.Danhsach(query_tinhluong).Tables[0];
        }

        private void cb_tháng_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox;
            if (DataNhanSu.kiemtra("select dbo._kiemtraTenpb(N'" + combo.SelectedItem.ToString() + "')") == true)
            {
                tb_tongthuong.Text = (DataNhanSu.tinhluong("select  dbo._tongluong(N'" + combo.SelectedItem.ToString() + "')")).ToString();
            }
            else
                tb_tongthuong.Text = "0";
        }
        private void themluong()
        {
            Luong l = new Luong();
            l.MaLuong = cb_ma.Text;
            l.LuongCB =Convert.ToInt32( tb_luongcb.Text);
            l.HSLuong = Convert.ToDouble(tb_heso.Text);
            l.HSPhuCap = Convert.ToDouble(tb_hsphucap.Text);
            l.BHYT = Convert.ToDouble(tb_BHYT.Text);
            l.BHTN = Convert.ToDouble(tb_bhtn.Text);
            l.BHXH = Convert.ToDouble(tb_bhxh.Text);
            dt.Luongs.Add(l);
            dt.SaveChanges();
        }
        private void thaydoiluong()
        {
            DataNhanSu.sua("exec dbo.thaydoiluong '"+ma+"',"+tb_luongcb.Text+","+tb_heso.Text+","+tb_hsphucap.Text+","+tb_BHYT.Text+","+tb_bhxh.Text+","+tb_bhtn.Text+"");
        }
        private void bt_luong_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cb_ma.Text))
            {
                MessageBox.Show("Vui lòng chọn thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                thaydoiluong();
                MessageBox.Show("Đã thay đổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dataGridView1.DataSource = DataNhanSu.Danhsach(query_dsluongnv).Tables[0];
        }

        private void cb_ma_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox;
            ma = combo.SelectedItem.ToString();
           
        }

        private void addluong_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(cb_ma.Text))
            {
                if (DataNhanSu.kiemtra("select dbo.kiemtramaluong('" + cb_ma.Text + "')") == false)
                {
                    themluong();
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Mã " + cb_ma.Text + " đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
