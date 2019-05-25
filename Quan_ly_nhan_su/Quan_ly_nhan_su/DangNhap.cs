using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_ly_nhan_su
{
    public partial class DangNhap : Form
    {
        QuanLiNhanSuEntities dta = new QuanLiNhanSuEntities();
        public DangNhap()
        {
            InitializeComponent();
            ActiveControl = tb_nguoidung;
        }
        private void bt_DangNhap_Click(object sender, EventArgs e)
        {
            if(tb_nguoidung.Text=="")
            {
                MessageBox.Show("Ban phai nhap ten tai khoan","Error",MessageBoxButtons.OK,MessageBoxIcon.Information);
                ActiveControl = tb_nguoidung;
                return;
            }
            if (tb_matkhau.Text == "")
            {
                MessageBox.Show("ban phai nhap mat khau", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActiveControl = tb_matkhau;
                return;
            }
            DataSet data = new DataSet();
            string query = "select * from dbo.NguoiDung nd where nd.taikhoan=@taikhoan and nd.matkhau=@matkhau";
            
                using (SqlConnection connection = new SqlConnection(DataNhanSu.connection))
            {
                connection.Open();
                SqlCommand command =  new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@taikhoan", tb_nguoidung.Text);
                command.Parameters.AddWithValue("@matkhau", tb_matkhau.Text);
                SqlDataReader adapter = command.ExecuteReader();
                if(adapter.Read()==true)
                {
                    Form1 f1 = new Form1();
                    this.Visible = false;
                    f1.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng","Error",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    ActiveControl = tb_nguoidung;
                }
                connection.Close();
            }
        }
        private void bt_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
