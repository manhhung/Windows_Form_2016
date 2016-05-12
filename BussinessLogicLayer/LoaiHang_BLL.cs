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
            return LHdal.LH_select();
        }

        //phương thức này gọi phương thức LH_insert() ở lớp LoaiHang_DAL (tầng DAL)
        public int LOAIHANG_insert(string MaLoaiHang, string TenLoaiHang, string MoTa)
        {
            return LHdal.LH_insert(MaLoaiHang, TenLoaiHang, MoTa);
        }



        //phương thức này gọi phương thức LH_update() ở lớp LoaiHang_DAL (tầng DAL)
        public int LOAIHANG_Update(string MaLoaiHang, string TenLoaiHang, string MoTa)
        {
            return LHdal.LH_update(MaLoaiHang, TenLoaiHang, MoTa);
        }

        //phương thức này gọi phương thức LH_delete() ở lớp LoaiHang_DAL (tầng DAL)
        public int LOAIHANG_Delete(string MaLoaiHang)
        {
            return LHdal.LH_delete(MaLoaiHang);
        }

    }
}
