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
    public partial class ChucNang : Form
    {
        QuanLiNhanSuEntities data = new QuanLiNhanSuEntities();
        private string gioitinh, chucvu, phongban, trinhdo,chuyennganh;
        int luong;
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
            luong = Convert.ToInt32(combo.SelectedItem.ToString());
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

        public ChucNang()
        {
            InitializeComponent();
            loadCV();
            loadPb();
            loadluong();
        }
        private void add()
        {
            NhanVien nv = new NhanVien();
            nv.MaNV = tb_ma.Text;
            nv.HoTen = tb_hoten.Text;
            nv.GioiTinh = gioitinh;
            nv.DanToc = tb_dantoc.Text;
            nv.QueQuan = tb_quequan.Text;
            nv.SDT = tb_sdt.Text;
            var pb = (from p in data.PhongBans where(p.TenPb==phongban) select p);
            foreach (PhongBan item in pb){ nv.MaPB = item.MaPB;}
            //nv.MaPB = "PB01";
            var cv = from p in data.ChucVus where (p.TenCV ==chucvu) select p;
            foreach (ChucVu item in cv){ nv.MaCV = item.MaCV; }
            var l = from p in data.Luongs where (p.LuongCB == luong) select p;
            foreach (Luong item in l){ nv.MaLuong = item.MaLuong; }
            var td = from p in data.TrinhDoHVs.Where(p => p.ChuyenNganh == chuyennganh && p.TenTDHV == trinhdo) select p;
            foreach (TrinhDoHV item in td)
            { nv.MaTD = item.MaTD; }
            nv.Ngaysinh = dt_ngaysinh.Value;
            HopDong hd = new HopDong()
            {
                MaHD = tb_mahd.Text,
                LoaiHD = tb_loaihd.Text,
                TuNgay = dt_batdau.Value,
                DenNgay = dt_han.Value,
                MaNV = tb_ma.Text
            };
            data.NhanViens.Add(nv);
            data.HopDongs.Add(hd);
            data.SaveChanges();
        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            QuanliNhanvien f1 = new QuanliNhanvien();
            this.Visible = false;
            f1.ShowDialog();
        }

        private void bt_ki_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_ma.Text)||string.IsNullOrEmpty(tb_mahd.Text))
            {
                MessageBox.Show("Bạn phải điền đầy đủ thông tin!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                if(DataNhanSu.kiemtra("select dbo.kiemtramaNV('"+tb_ma.Text+"')")==false)
                {
                    if(DataNhanSu.kiemtra("select dbo.kiemtraSDT('" + tb_sdt.Text + "')") == false)
                    {
                        if(DataNhanSu.kiemtra("select dbo.kiemtramaHD('" + tb_mahd.Text + "')") == false)
                        {
                            add();
                            MessageBox.Show("Them thanh cong nhân viên:" + tb_hoten.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }else
                            MessageBox.Show(tb_mahd.Text + " Đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    MessageBox.Show(tb_sdt.Text + " Đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show(tb_ma.Text+" Đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
