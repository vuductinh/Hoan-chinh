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

namespace Quan_ly_nhan_su
{
    public partial class SuaThongtinNV : Form
    {
        QuanLiNhanSuEntities dt = new QuanLiNhanSuEntities();
        private string tenpb;
        private string tencv;
        private string tennv;
        private int luong;
        public SuaThongtinNV()
        {
            InitializeComponent();
            danhsachPB();
            danhsachCV();
            danhsachhoten();
        }
        public void danhsachCV()
        {
            var model = from p in dt.ChucVus select p.TenCV;
            foreach (string item in model)
            {
                cb_chucvu.Items.Add(item);
            }
        }
        public void danhsachPB()
        {
            var model = from p in dt.PhongBans select p.TenPb;
            foreach (string item in model)
            {
                cb_phongban.Items.Add(item);
            }
        }
        public void danhsachhoten()
        {
            var model = from p in dt.NhanViens select p.HoTen;
            foreach (string item in model)
            {
                cb_hoten.Items.Add(item);
            }
        }
        private void bt_sua_Click(object sender, EventArgs e)
        {
            if (cb_hoten.Text !="")
            {
                        DataNhanSu.sua("exec sua N'" + tennv + "',N'" + tenpb + "',N'" + tencv + "'," + luong + ",N'" + tb_quequan.Text + "'");
                        MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Bạn chưa nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void cb_phongban_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox;
            tenpb = combo.SelectedItem.ToString();
        }

        private void cb_chucvu_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox;
            tencv = combo.SelectedItem.ToString();
        }

        private void cb_luong_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox;
            luong =Convert.ToInt32(combo.SelectedItem.ToString());
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            QuanliNhanvien f = new QuanliNhanvien();
            this.Visible = false;
            f.ShowDialog();
        }

        private void cb_hoten_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox;
            tennv = combo.SelectedItem.ToString();
        }
    }
}
