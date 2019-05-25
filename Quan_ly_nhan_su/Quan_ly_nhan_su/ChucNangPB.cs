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
    public partial class ChucNangPB : Form
    {
        QuanLiNhanSuEntities dt = new QuanLiNhanSuEntities();
        private string maluachon;
        private string tenluachon;
        public ChucNangPB()
        {
            InitializeComponent();
            loadmapb();
        }
        private void loadmapb()
        {
            var model = from p in dt.PhongBans select p;
            foreach(PhongBan item in model)
            {
                cb_ma.Items.Add(item.MaPB);
                cb_luachon.Items.Add(item.TenPb);
            }
        }
        private void add()
        {
            PhongBan pb = new PhongBan();
            pb.MaPB = tb_ma.Text;
            pb.TenPb = tb_ten.Text;
            pb.SDT = tb_sdt.Text;
            pb.Diachi = tb_diachi.Text;
            dt.PhongBans.Add(pb);
            dt.SaveChanges();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tb_ma.Text))
            {
                MessageBox.Show("Bạn chưa điền thông tin", "Thông báo",MessageBoxButtons.OK);
            }
            else
            {
                if(DataNhanSu.kiemtra("select dbo.kiemtramaPB('"+tb_ma.Text+"')")==false)
                {
                    add();
                    MessageBox.Show("Thêm thành công phòng ban " + tb_ten.Text, "Thông báo", MessageBoxButtons.OK);
                }else
                    MessageBox.Show("Mã " +tb_ma.Text+" Đã tồn tại", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void cb_ma_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox;
            maluachon = combo.SelectedItem.ToString();
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(maluachon))
            {
                MessageBox.Show("Vui lòng lựa chọn mã cần sửa", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                DataNhanSu.sua("Update dbo.PhongBan set TenPB=N'"+tb_tensua.Text+"',SDT='"+tb_sdtsua.Text+"',DiaChi=N'"+tb_diachisua.Text+"' Where MaPB='" + maluachon + "'");
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            Quanliphongban f = new Quanliphongban();
            this.Visible = false;
            f.ShowDialog();
        }

        private void cb_luachon_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox;
            tenluachon = combo.SelectedItem.ToString();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tenluachon))
            {
                MessageBox.Show("Vui lòng lựa chọn tên phòng ban cần xóa", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                DataNhanSu.sua("exec dbo.xoapb N'" + tenluachon + "'");
                MessageBox.Show("Xóa thành công phòng ban " + tenluachon, "Thông báo", MessageBoxButtons.OK);
            }
        }
    }
}
