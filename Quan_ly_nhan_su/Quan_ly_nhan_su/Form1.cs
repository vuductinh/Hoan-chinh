using System;
using System.Collections;
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
    public partial class Form1 : Form
    {
        QuanLiNhanSuEntities dt = new QuanLiNhanSuEntities();
        List<NhanVien> lb = new List<NhanVien>();
        NhanVien nv = new NhanVien();
        public static string dulieu;
        string query_danhsachnhanvien = "select *from dbo.DanhsachNV()";
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = DataNhanSu.Danhsach(query_danhsachnhanvien).Tables[0];
            biding();
        }
        
        private void bt_dangxuat_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            this.Visible = false;
            dn.ShowDialog();
        }
        private void biding()
        {
            tb_hoten.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Họ và tên", true, DataSourceUpdateMode.Never));
            dt_ngaysinh.DataBindings.Add(new Binding("Value", dataGridView1.DataSource, "Ngày sinh", true, DataSourceUpdateMode.Never));
            tb_gioitinh.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Giới tính", true, DataSourceUpdateMode.Never));
            tb_phongban.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Phòng ban", true, DataSourceUpdateMode.Never));
            tb_trinhdo.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Trình độ học vấn", true, DataSourceUpdateMode.Never));
            tb_chuyennganh.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Chuyên ngành", true, DataSourceUpdateMode.Never));
            tb_chucvu.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Chức vụ", true, DataSourceUpdateMode.Never));
            tb_dantoc.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Dân tộc", true, DataSourceUpdateMode.Never));
            tb_quequan.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Quê quán", true, DataSourceUpdateMode.Never));
        }
       
        private void bt_timkiem_Click(object sender, EventArgs e)
        {
            string query_tim_kiem = "select nv.STT,nv.HoTen N'Họ và tên',nv.Ngaysinh N'Ngày sinh',nv.GioiTinh N'Giới tính',pb.TenPB N'Phòng Ban',cv.TenCV N'Chức vụ',td.TenTDHV N'Trình độ học vấn',td.ChuyenNganh N'Chuyên ngành',nv.DanToc N'Dân tộc',nv.QueQuan N'Quê quán' from dbo.NhanVien nv,dbo.ChucVu cv, dbo.TrinhDoHV td, dbo.PhongBan pb where nv.MaCV = cv.MaCV and nv.MaTD = td.MaTD and nv.MaPB = pb.MaPB and nv.HoTen like N'"+tb_timkiem.Text+"%'";
            dataGridView1.DataSource = DataNhanSu.Danhsach(query_tim_kiem).Tables[0];
        }
        private void bt_dangxuat_Click_1(object sender, EventArgs e)
        {
            DangNhap f = new DangNhap();
            this.Visible = false;
            f.ShowDialog();
        }

        private void bt_nhanvien_Click(object sender, EventArgs e)
        {
            QuanliNhanvien f = new QuanliNhanvien();
            this.Visible = false;
            f.ShowDialog();
        }

        private void bt_phongban_Click(object sender, EventArgs e)
        {
            Quanliphongban f = new Quanliphongban();
            this.Visible = false;
            f.ShowDialog();
        }

        private void bt_quanliluong_Click(object sender, EventArgs e)
        {
            Luongnhanvien f = new Luongnhanvien();
            this.Visible = false;
            f.ShowDialog();
        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DataNhanSu.Danhsach(query_danhsachnhanvien).Tables[0];
        }
    }
}
