using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class BLL_NhatKiHeThong
    {
        DAL_NhatKiHeThong d_nkht = new DAL_NhatKiHeThong();
        public DataTable Call_Select_NhatKiHeThong()
        {
            DataTable dt = d_nkht.Select_NhatKiHeThong("select * from NhatKiHeThong");
            return dt;
        }
        public void Call_Insert_NhatKiHeThong(string nguoidung, string chucnang, string hanhdong)
        {
            d_nkht.Insert_NhatKiHetThong(nguoidung, chucnang, hanhdong);
        }
        public void Call_Delete_NhatKiHeThong(int id)
        {
            d_nkht.Delete_NhatKiHeThong(id);
        }
    }
}
