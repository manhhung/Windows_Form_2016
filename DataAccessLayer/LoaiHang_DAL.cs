using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class LoaiHang_DAL
    {
        ThaoTac_CoSoDuLieu thaotac = new ThaoTac_CoSoDuLieu();
       //khai báo 2 mảng để truyền tên tham số và giá trị tham số vào Stored Procedures
       string[] name = { };
       object[] value = { };
       // //phương thức này gọi phương thức SQL_Laydulieu ở lớp ThaoTac_CoSoDuLieu để thực hiện lấy dữ liệu
        public DataTable LoaiHang_select()
        {
            return thaotac.SQL_Laydulieu("LoaiHang_select");
        }

     
        public int LoaiHang_Insert(string MaLoaiHang, string TenLoaiHang, string MoTa)
        {

            name = new string[3];
            value = new object[3];
            name[0] = "@MaLoaiHang"; value[0] = MaLoaiHang;//@MaLoaiHang,... là các tham số phải giống với tham số khai báo ở Stores Procedures trong CSDL
            name[1] = "@TenLoaiHang"; value[1] = TenLoaiHang;
            name[2] = "@MoTa"; value[2] = MoTa;
            return thaotac.SQL_Thuchien("LOAIHANG_Insert", name, value, 3);
        }
       //phương thức này gọi phương thức SQL_Thuchien ở lớp ThaoTac_CoSoDuLieu để thực hiện update
       public int LoaiHang_update(string MaLoaiHang, string TenLoaiHang, string MoTa)
       {
           name = new string[3];
           value = new object[3];
           name[0] = "@MaLoaiHang"; value[0] = MaLoaiHang;//@MaLoaiHang,... là các tham số phải giống với tham số khai báo ở Stores Procedures trong CSDL
           name[1] = "@TenLoaiHang"; value[1] = TenLoaiHang;
           name[2] = "@MoTa"; value[2] = MoTa;
           return thaotac.SQL_Thuchien("LOAIHANG_Update", name, value, 3);
       }
       //phương thức này gọi phương thức SQL_Thuchien ở lớp ThaoTac_CoSoDuLieu để thực hiện delete
       //public int LH_delete(string MaLoaiHang)
       //{
       //    name = new string[1];
       //    value = new object[1];
       //    name[0] = "@MaLoaiHang"; value[0] = MaLoaiHang;
       //    return thaotac.SQL_Thuchien("LOAI_Delete", name, value, 1);
       //}


    }
}
