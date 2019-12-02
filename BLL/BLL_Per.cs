using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLL_Per
    {
        DAL_Permission d_per = new DAL_Permission();
        public void Call_Insert_per(int id)
        {
            d_per.Insert_Per_db(id, 0, 0, 0);
        }
        public DataTable load_DS_User_Per()
        {
            DataTable dt = new DataTable();
            dt = d_per.loadDataTable("select u.f_Name, p.them, p.xoa, p.xua from users u, permission p where u.f_ID = p.ID_user");
            return dt;
        }
        public List<DTO_Permission> Call_class_per()
        {
            List<DTO_Permission> L = d_per.Select_class_per();
            return L;
        }
        public DataTable Call_Select_Per(string s)
        {
            DataTable dt = new DataTable();
            dt = d_per.loadDataTable("select u.f_Username, p.HeThong, p.DanhMuc, p.ChucNang, p.TroGiup, p.them, p.xoa, p.xua from users u, permission p where u.f_ID = p.ID_user and u.f_Username ='"+s+"'");
            return dt;
        }
        public void Call_Update_Per(int id, int ht, int dm, int cn, int tg, int t, int x, int s)
        {
            d_per.Update_per_db(id, ht, dm, cn, tg, t, x, s);

        }
        public void Call_Delete_per(int id)
        {
            d_per.Delete_per(id);
        }
        public DTO_Permission Call_DTO_Per(string name)
        {
            DTO_Permission d = d_per.select_per_pq(name);
            return d;
        }
    }
}
