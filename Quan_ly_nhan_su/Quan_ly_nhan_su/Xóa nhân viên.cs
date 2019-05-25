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
    public partial class XoaNV : Form
    {
        QuanLiNhanSuEntities dt = new QuanLiNhanSuEntities();
        public XoaNV()
        {
            InitializeComponent();
        }
        private void bt_xóa_Click(object sender, EventArgs e)
        {
            if (tb_maxoa.Text != "")
            {
                if (DataNhanSu.kiemtra("select dbo.kiemtramaNV('" + tb_maxoa.Text + "')")==true)
                {
                    var nhanvien = from p in dt.NhanViens where p.MaNV == tb_maxoa.Text select p;
                    foreach (NhanVien item in nhanvien)
                    {
                        MessageBox.Show("Xóa thành công nhân viên!" + item.HoTen);
                       DataNhanSu.sua("exec dbo.xoanv '" + tb_maxoa.Text + "'");
                    }
                }
                else
                    MessageBox.Show("Mã "+tb_maxoa.Text+" không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Bạn chưa điền thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            QuanliNhanvien f = new QuanliNhanvien();
            this.Visible = false;
            f.ShowDialog();
        }
    }
}
