using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_ly_nhan_su
{
    class DataNhanSu
    {
        public static string connection = @"Data Source=TINH-PC;Initial Catalog=QuanLiNhanSu;Integrated Security=True";
        public static DataSet Danhsach(string query)
        {
            DataSet data = new DataSet();
            using (SqlConnection conec=new SqlConnection(connection))
            {
                conec.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, conec);
                adapter.Fill(data);
                conec.Close();
            }
                return data;
        }
        public static bool kiemtra(string query)
        {
            SqlConnection conn = new SqlConnection(connection); //chuỗi kết nối
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            bool str = Convert.ToBoolean(dt.Rows[0][0]); //ở đây giá trị trả về chỉ là 1 bool           
            return str;
        }
        public static Boolean sua(string query)
        {
            Boolean check = true;
            SqlConnection connec = new SqlConnection(DataNhanSu.connection);
            connec.Open();
            try
            {
                SqlCommand command = new SqlCommand(query, connec);
                command.ExecuteNonQuery();
                check = true;
            }
            catch (Exception)
            {
                check = false;
            }
            return check;
            connec.Close();
        }
        public static int tinhluong(string query)
        {
            SqlConnection conn = new SqlConnection(connection); //chuỗi kết nối
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int str = Convert.ToInt32(dt.Rows[0][0]); //ở đây giá trị trả về chỉ là 1 bool           
            return str;
        }
    }
}
