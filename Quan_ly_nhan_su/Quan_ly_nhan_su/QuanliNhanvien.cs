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
    public partial class QuanliNhanvien : Form
    {
        QuanLiNhanSuEntities data = new QuanLiNhanSuEntities();
        private string tenpb,tennv, tenCV,phongban,gioitinh,chucvu,trinhdo,chuyennganh,loaihopdong;
        private int luong;
        string query_allnhanvien = "select *from dbo.DanhsachNV()";
        public QuanliNhanvien()
        {
            InitializeComponent();
            dataGridView1.DataSource = DataNhanSu.Danhsach(query_allnhanvien).Tables[0];
            load();
            loadCV();
            loadluong();
            loadPb();
            loadtenv();
            nd_soluong.Value = DataNhanSu.tinhluong("select dbo.soluongNV()");
        }
        
        private void bt_them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_ma.Text) || string.IsNullOrEmpty(tb_mahd.Text))
            {
                MessageBox.Show("Bạn phải điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (DataNhanSu.kiemtra("select dbo.kiemtramaNV('" + tb_ma.Text + "')") == false)
                {
                    if (DataNhanSu.kiemtra("select dbo.kiemtraSDT('" + tb_sdt.Text + "')") == false)
                    {
                        if (DataNhanSu.kiemtra("select dbo.kiemtramaHD('" + tb_mahd.Text + "')") == false)
                        {
                            add();
                            MessageBox.Show("Them thanh cong nhân viên:" + cb_hoten.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dataGridView1.DataSource = DataNhanSu.Danhsach(query_allnhanvien).Tables[0];
                        }
                        else
                            MessageBox.Show(tb_mahd.Text + " Đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show(tb_sdt.Text + " Đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show(tb_ma.Text + " Đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void load()
        {
            var model = from p in data.PhongBans select p;
            foreach(PhongBan item in model)
            {
                cb_nhanvienpb.Items.Add(item.TenPb);
            }
        }
        private void loadtenv()
        {
            var model = from p in data.NhanViens select p;
            foreach (NhanVien item in model)
            {
                cb_hoten.Items.Add(item.HoTen);
            }
        }
        private void cb_gioitinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox;
            gioitinh = combo.SelectedItem.ToString();
        }

        private void cb_phongban_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox;
            phongban = combo.SelectedItem.ToString();
        }

        private void cb_chucvu_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox;
            chucvu = combo.SelectedItem.ToString();
        }

        private void cb_luong_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox;
            luong =Convert.ToInt32(combo.SelectedItem.ToString());
        }

        private void cb_trinhdo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox;
            trinhdo = combo.SelectedItem.ToString();
        }

        private void cb_chuyennganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox;
            chuyennganh = combo.SelectedItem.ToString();
        }
        private void loadPb()
        {
            var pb = data.PhongBans.ToList();
            foreach (PhongBan item in pb)
            {
                cb_phongban.Items.Add(item.TenPb);
            }
        }
        private void loadluong()
        {
            var l = data.Luongs.ToList();
            foreach (Luong item in l)
            {
                cb_luong.Items.Add(item.LuongCB);
            }
        }
        private void loadCV()
        {
            var cv = data.ChucVus.ToList();
            foreach (ChucVu item in cv)
            {
                cb_chucvu.Items.Add(item.TenCV);
            }
        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            nd_soluong.Value = DataNhanSu.tinhluong("select dbo.soluongNV()");
            dataGridView1.DataSource = DataNhanSu.Danhsach(query_allnhanvien).Tables[0];
        }

        private void cb_hoten_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox;
            tennv = combo.SelectedItem.ToString();
        }

        private void cb_loaihd_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox;
            loaihopdong = combo.SelectedItem.ToString();
        }

        private void add()
        {
            NhanVien nv = new NhanVien();
            nv.MaNV = tb_ma.Text;
            nv.HoTen = cb_hoten.Text;
            nv.GioiTinh = gioitinh;
            nv.DanToc = tb_dantoc.Text;
            nv.QueQuan = tb_quequan.Text;
            nv.SDT = tb_sdt.Text;
            var pb = (from p in data.PhongBans where (p.TenPb == phongban) select p);
            foreach (PhongBan item in pb) { nv.MaPB = item.MaPB; }
            //nv.MaPB = "PB01";
            var cv = from p in data.ChucVus where (p.TenCV == chucvu) select p;
            foreach (ChucVu item in cv) { nv.MaCV = item.MaCV; }
            var l = from p in data.Luongs where (p.LuongCB == luong) select p;
            foreach (Luong item in l) { nv.MaLuong = item.MaLuong; }
            var td = from p in data.TrinhDoHVs.Where(p => p.ChuyenNganh == chuyennganh && p.TenTDHV == trinhdo) select p;
            foreach (TrinhDoHV item in td)
            { nv.MaTD = item.MaTD; }
            nv.Ngaysinh = dt_ngaysinh.Value;
            HopDong hd = new HopDong()
            {
                MaHD = tb_mahd.Text,
                LoaiHD = loaihopdong,
                TuNgay = dt_batdau.Value,
                DenNgay = dt_han.Value,
                MaNV = tb_ma.Text
            };
            data.NhanViens.Add(nv);
            data.HopDongs.Add(hd);
            data.SaveChanges();
        }
        private void bt_exit_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Visible = false;
            f.ShowDialog();
        }

        private void bt_timkiem_Click(object sender, EventArgs e)
        {
            if (DataNhanSu.kiemtra("select dbo._kiemtrahoten(N'" + tb_timkiem.Text + "')") == true)
            {
                TimKiem t = new TimKiem(tb_timkiem.Text);
                this.Visible = false;
                t.ShowDialog();
            }
            else
                MessageBox.Show("Không tìm thấy nhân viên có họ tên " + tb_timkiem.Text);
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            if (cb_hoten.Text != "")
            {
                DialogResult result= MessageBox.Show("ban có chắc muốn xóa", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                switch (result)
                {
                    case DialogResult.OK:
                        {
                            MessageBox.Show("Xóa thành công nhân viên!" + tennv);
                            DataNhanSu.sua("exec dbo.xoanv1 N'" + tennv + "'");
                            break;
                        }
                    case DialogResult.Cancel:
                        {
                            break;
                        }
                }
            }
            else MessageBox.Show("Bạn chưa điền thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cb_nhanvienpb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox;
            phongban = combo.SelectedItem.ToString();
            lb_thongtin.Text = "Nhân viên phòng " + phongban;
            nd_soluong.Value = DataNhanSu.tinhluong("select dbo.soluongNVPB(N'"+phongban+"')");
            dataGridView1.DataSource = DataNhanSu.Danhsach("select *from dbo.Nhanvienphongban(N'" + phongban + "')").Tables[0];
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            if (cb_hoten.Text != "")
            {
                DataNhanSu.sua("exec sua N'" + tennv + "',N'" + phongban + "',N'" + chucvu + "'," + luong + ",N'" + tb_quequan.Text + "'");
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Bạn chưa nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
