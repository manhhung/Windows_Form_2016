using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;

namespace BussinessLogicLayer
{
    public class LoaiHang_BLL
    {
        LoaiHang_DAL LHdal = new LoaiHang_DAL();
        //phương thức này gọi phương thức LH_select() ở lớp LoaiHang_DAL (tầng DAL)
        public DataTable LOAIHANG_Select()
        {
            return LHdal.LoaiHang_select();
        }

        //phương thức này gọi phương thức LH_insert() ở lớp LoaiHang_DAL (tầng DAL)
        public int LOAIHANG_Insert(string MaLoaiHang, string TenLoaiHang, string MoTa)
    {
        return LHdal.LoaiHang_Insert(MaLoaiHang, TenLoaiHang, MoTa);
    }
        public int LOAIHANG_Update(string MaLoaiHang, string TenLoaiHang, string MoTa)
        {
            return LHdal.LoaiHang_update(MaLoaiHang, TenLoaiHang, MoTa);
        }



 
    }
}
