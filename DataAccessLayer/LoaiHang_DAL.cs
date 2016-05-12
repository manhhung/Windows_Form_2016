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
       // ThaoTac_CoSoDuLieu thaotac = new ThaoTac_CoSoDuLieu();
       // //khai báo 2 mảng để truyền tên tham số và giá trị tham số vào Stored Procedures
       // string[] name = { };
       // object[] value = { };
       // //phương thức này gọi phương thức SQL_Laydulieu ở lớp ThaoTac_CoSoDuLieu để thực hiện lấy dữ liệu
       // public DataTable sv_select()
       // {
       //     //thaotac.KetnoiCSDL();
       //     return thaotac.SQL_Laydulieu("KHACHHANG_Select");
       // }

       // //phương thức này gọi phương thức SQL_Thuchien ở lớp ThaoTac_CoSoDuLieu để thực hiện insert
       // public int LH_insert(string MaKhachHang, string HoTen, string DiaChi, int DienThoai, int GioiTinh, string NgaySinh)
       // {
       //     //thaotac.KetnoiCSDL();
       //     name = new string[6];
       //     value = new object[6];
       //     name[0] = "@MaKhachHang"; value[0] = MaKhachHang;//@MaKhachHang,... là các tham số phải giống với tham số khai báo ở Stores Procedures trong CSDL
       //     name[1] = "@HoTen"; value[1] = HoTen;
       //     name[2] = "@DiaChi"; value[2] = DiaChi;
       //     name[3] = "@DienThoai"; value[3] = DienThoai;
       //     name[4] = "@GioiTinh"; value[4] = GioiTinh;
       //     name[5] = "@NgaySinh"; value[5] = NgaySinh;
       //     return thaotac.SQL_Thuchien("KHACHHANG_Insert", name, value, 6);
       // }
       // //phương thức này gọi phương thức SQL_Thuchien ở lớp ThaoTac_CoSoDuLieu để thực hiện update
       // public int LH_insert(string MaKhachHang, string HoTen, string DiaChi, int DienThoai, int GioiTinh, string NgaySinh)
       // {
       //     name = new string[4];
       //     value = new object[4];
       //     name[0] = "@MaKhachHang"; value[0] = MaKhachHang;//@MaKhachHang,... là các tham số phải giống với tham số khai báo ở Stores Procedures trong CSDL
       //     name[1] = "@HoTen"; value[1] = HoTen;
       //     name[2] = "@DiaChi"; value[2] = DiaChi;
       //     name[3] = "@DienThoai"; value[3] = DienThoai;
       //     name[4] = "@GioiTinh"; value[4] = GioiTinh;
       //     name[5] = "@NgaySinh"; value[5] = NgaySinh;
       //     return thaotac.SQL_Thuchien("KHACHHANG_Update", name, value, 6);
       // }
       // //phương thức này gọi phương thức SQL_Thuchien ở lớp ThaoTac_CoSoDuLieu để thực hiện delete
       //public int LH_insert(string MaKhachHang)
       // {
       //     name = new string[1];
       //     value = new object[1];
       //     name[0] = "@MaKhachHang"; value[0] = MaKhachHang;
       //     return thaotac.SQL_Thuchien("KHACHHANG_Delete", name, value, 1);
       // }

       ThaoTac_CoSoDuLieu thaotac = new ThaoTac_CoSoDuLieu();
       //khai báo 2 mảng để truyền tên tham số và giá trị tham số vào Stored Procedures
       string[] name = { };
       object[] value = { };
       //phương thức này gọi phương thức SQL_Laydulieu ở lớp ThaoTac_CoSoDuLieu để thực hiện lấy dữ liệu
       public DataTable LH_select()
       {
           //thaotac.KetnoiCSDL();
           return thaotac.SQL_Laydulieu("LOAIHANG_Select");
       }

       //phương thức này gọi phương thức SQL_Thuchien ở lớp ThaoTac_CoSoDuLieu để thực hiện insert
       public int LH_insert(string MaLoaiHang, string TenLoaiHang, string MoTa)
       {
           //thaotac.KetnoiCSDL();
           name = new string[3];
           value = new object[3];
           name[0] = "@MaLoaiHang"; value[0] = MaLoaiHang;//@MaLoaiHang,... là các tham số phải giống với tham số khai báo ở Stores Procedures trong CSDL
           name[1] = "@TenLoaiHang"; value[1] = TenLoaiHang;
           name[2] = "@MoTa"; value[2] = MoTa;
           return thaotac.SQL_Thuchien("LOAIHANG_Insert", name, value, 3);
       }
       //phương thức này gọi phương thức SQL_Thuchien ở lớp ThaoTac_CoSoDuLieu để thực hiện update
       public int LH_update(string MaLoaiHang, string TenLoaiHang, string MoTa)
       {
           name = new string[4];
           value = new object[4];
           name[0] = "@MaLoaiHang"; value[0] = MaLoaiHang;//@MaLoaiHang,... là các tham số phải giống với tham số khai báo ở Stores Procedures trong CSDL
           name[1] = "@TenLoaiHang"; value[1] = TenLoaiHang;
           name[2] = "@MoTa"; value[2] = MoTa;
           return thaotac.SQL_Thuchien("LOAIHANG_Update", name, value, 4);
       }
       //phương thức này gọi phương thức SQL_Thuchien ở lớp ThaoTac_CoSoDuLieu để thực hiện delete
       public int LH_delete(string MaLoaiHang)
       {
           name = new string[1];
           value = new object[1];
           name[0] = "@MaLoaiHang"; value[0] = MaLoaiHang;
           return thaotac.SQL_Thuchien("LOAI_Delete", name, value, 1);
       }


    }
}
