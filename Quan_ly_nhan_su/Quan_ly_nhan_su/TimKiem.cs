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
    public partial class TimKiem : Form
    {
        QuanLiNhanSuEntities dt = new QuanLiNhanSuEntities();
        List<NhanVien> lb = new List<NhanVien>();
        List<ChucVu> lb1 = new List<ChucVu>();
        List<Luong> lb2 = new List<Luong>();
        List<PhongBan> lb3 = new List<PhongBan>();
        List<TrinhDoHV> lb4 = new List<TrinhDoHV>();
        private string dulieu;
        public TimKiem(string a)
        {
            InitializeComponent();
            dulieu = a;
            groupBox1.Text = "Thông tin nhân viên " + dulieu;
            load();
        }
        void load()
        {
            NhanVien nv = new NhanVien();
            DataSet data = new DataSet();
            string a = dulieu;
            string query = "select *from dbo.NhanVien nv,dbo.ChucVu cv where nv.MaCV = cv.MaCV and nv.HoTen = @hoten";
            using (SqlConnection connection = new SqlConnection(DataNhanSu.connection))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@hoten",dulieu);
                SqlDataReader adapter = command.ExecuteReader();
                if (adapter.Read() == true)
                {
                    var result = from c in dt.NhanViens
                                 where c.HoTen == dulieu
                                 select c;
                    lb = result.ToList();
                    foreach (NhanVien item in lb)
                    {
                        tb_hoten.Text = item.HoTen;
                        tb_ma.Text = item.MaNV;
                        tb_quequan.Text = item.QueQuan;
                        var result1 = from c in dt.ChucVus where c.MaCV==item.MaCV select c;
                        lb1 = result1.ToList();
                        foreach (ChucVu cv in lb1) { tb_macv.Text = cv.TenCV; }
                        //tb_macv.Text = item.MaCV;
                        //tb_ngaysinh.Text = item.Ngaysinh.ToString();
                        dt_ngaysinh.Value = Convert.ToDateTime(item.Ngaysinh);
                        tb_gioitinh.Text = item.GioiTinh;
                        var result2 = from c in dt.Luongs where c.MaLuong == item.MaLuong select c;
                        lb2 = result2.ToList();
                        foreach (Luong l in lb2) { tb_maluong.Text = Convert.ToString(l.LuongCB)+" $"; }
                        //tb_maluong.Text = item.MaLuong;
                        var result3 = from c in dt.PhongBans where c.MaPB == item.MaPB select c;
                        lb3 = result3.ToList();
                        foreach (PhongBan pb in lb3) { tb_mapb.Text = pb.TenPb; }
                        //tb_mapb.Text = item.MaPB;
                        var result4 = from c in dt.TrinhDoHVs where c.MaTD == item.MaTD select c;
                        lb4 = result4.ToList();
                        foreach (TrinhDoHV td in lb4) { tb_matd.Text = td.TenTDHV;tb_chuyennganh.Text = td.ChuyenNganh; }
                        //tb_matd.Text = item.MaTD;
                        tb_dantoc.Text = item.DanToc;
                        tb_sdt.Text = item.SDT;
                        lb_anh.Text = item.HoTen;
                        if (item.tenanh != null)
                        {
                            ptb_name.Image =new Bitmap(Application.StartupPath + item.tenanh);
                        }
                        else
                        {
                            ptb_name.Image=new Bitmap(Application.StartupPath+ "\\Resources\\error.jpg");
                        }
                    }
                }
                else
                {
                    MessageBox.Show(dulieu + " là tên không hợp lệ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                connection.Close();
            }
        }
        private void bt_back_Click(object sender, EventArgs e)
        {
            QuanliNhanvien f1 = new QuanliNhanvien();
            this.Visible = false;
            f1.ShowDialog();
        }
    }
}
