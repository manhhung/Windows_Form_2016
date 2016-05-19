using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    class ThaoTac_CoSoDuLieu
    {
        SqlConnection cn;
        private void KetnoiCSDL()
        {
            cn = new SqlConnection(@"Data Source=DESKTOP-15RE755\SQLEXPRESS;Initial Catalog=PHILONG;Integrated Security=True");
            cn.Open();
        }
        private void NgatKetNoi()
        {
            cn.Close();
            cn.Dispose();
        }
        //phương thức thực thi Select dữ liệu
        public DataTable SQL_Laydulieu(string HIENTHILOAIHANG)
        {
            KetnoiCSDL();
            //thực thi lấy dữ liệu từ CSDL
            SqlCommand cmd = new SqlCommand(HIENTHILOAIHANG, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            //ngắt kết nối
            NgatKetNoi();
            //trả về bảng chứa dữ liệu lấy được.
            return dt;
        }
        //phương thức thực thi Insert, Update, Delete
        public int SQL_Thuchien(string HIENTHILOAIHANG, string[] name, object[] value, int Npara)
        {
            KetnoiCSDL();
            SqlCommand cmd = new SqlCommand(HIENTHILOAIHANG, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < Npara; i++)
            {
                cmd.Parameters.AddWithValue(name[i], value[i]);
            }
            return cmd.ExecuteNonQuery();
        }
    }

}
