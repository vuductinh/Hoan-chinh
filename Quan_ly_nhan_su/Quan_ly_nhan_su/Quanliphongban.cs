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
    public partial class Quanliphongban : Form
    {
        private string query_pb = "select MaPB N'Mã phòng ban',TenPB N'Tên phòng ban',SDT N'Số điện thoại',Diachi N'Địa chỉ' from dbo.PhongBan";
        public Quanliphongban()
        {
            InitializeComponent();
            dataGridView1.DataSource = DataNhanSu.Danhsach(query_pb).Tables[0];
            biding();
        }
        private void biding()
        {
            tb_ma1.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Mã phòng ban", true, DataSourceUpdateMode.Never));
            tb_ten.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Tên phòng ban", true, DataSourceUpdateMode.Never));
            tb_sdt.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Số điện thoại", true, DataSourceUpdateMode.Never));
            tb_diachi.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Địa chỉ", true, DataSourceUpdateMode.Never));
            
        }
        private void bt_chucnang_Click(object sender, EventArgs e)
        {
            ChucNangPB f = new ChucNangPB();
            this.Visible = false;
            f.ShowDialog();
        }

        private void bt_timkiem_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tb_timkiem.Text))
            {
                MessageBox.Show("vui lòng nhập thông tin", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {

                string query = "select MaPB N'Mã phòng ban',TenPB N'Tên phòng ban',SDT N'Số điện thoại',Diachi N'Địa chỉ' from dbo.PhongBan where MaPB like '" + tb_timkiem.Text + "%' or MaPB like '%" + tb_timkiem.Text + "' or TenPB like N'" + tb_timkiem.Text + "%' or TenPB like N'%" + tb_timkiem.Text + "'";
                dataGridView1.DataSource = DataNhanSu.Danhsach(query).Tables[0];
            }
        }

        private void bt_thoát_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Visible = false;
            f.ShowDialog();
        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DataNhanSu.Danhsach(query_pb).Tables[0];
        }
    }
}
