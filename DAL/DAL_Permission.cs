using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class DAL_Permission : DB_connect
    {
        public void Insert_Per_db(int id, int add, int del, int ins)
        {
            Open_connection();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO permission(ID_user,them,xoa,xua) VALUES("+id+","+add+","+del+","+ins+")";
            command.ExecuteNonQuery();
            Close_connection();
        }
        public void Update_per_db(int id, int ht, int dm, int cn, int tg, int t, int x, int s)
        {
            Open_connection();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandType = CommandType.Text;
            command.CommandText = "update permission set HeThong = "+ht+ ", DanhMuc = " + dm + ", ChucNang = " + cn + ", TroGiup = " + tg + ", them = " + t + ", xoa = " + x + ", xua = " + s + " where ID_user = " + id + "";
            command.ExecuteNonQuery();
            Close_connection();
        }
        public DataTable loadDataTable(string strQuery)
        {
            DataTable dt = new DataTable();
            SqlCommand command = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();

            command.Connection = conn;
            command.CommandType = CommandType.Text;
            command.CommandText = strQuery;

            Open_connection();
            da.SelectCommand = command;
            da.Fill(dt);
            Close_connection();
            return dt;
        }
        public List<DTO_Permission> Select_class_per()
        {
            List<DTO_Permission> L = new List<DTO_Permission>();
            Open_connection();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandType = CommandType.Text;
            command.CommandText = "select u.f_Username, p.HeThong, p.DanhMuc, p.ChucNang, p.TroGiup, p.them, p.xoa, p.xua from users u, permission p where u.f_ID = p.ID_user";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                DTO_Permission dt_per = new DTO_Permission();
                dt_per.Username = string.Format("{0}", reader["f_Username"]);
                dt_per.Add = string.Format("{0}", reader["them"]);
                dt_per.Del = string.Format("{0}", reader["xoa"]);
                dt_per.Insert = string.Format("{0}", reader["xua"]);
                dt_per.RW_ChungNang = string.Format("{0}", reader["ChucNang"]);
                dt_per.RW_DanhMuc = string.Format("{0}", reader["DanhMuc"]);
                dt_per.RW_HeThong = string.Format("{0}", reader["HeThong"]);
                dt_per.RW_TroGiup = string.Format("{0}", reader["TroGiup"]);
                L.Add(dt_per);
            }
            Close_connection();
            return L;
        }
        public void Delete_per(int id)
        {
            Open_connection();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandType = CommandType.Text;
            command.CommandText = "delete from permission where ID_user = "+id;
            command.ExecuteNonQuery();
            Close_connection();
        }
        public DTO_Permission select_per_pq(string name)
        {
            Open_connection();
            DTO_Permission dt_per = new DTO_Permission();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandType = CommandType.Text;
            command.CommandText = "select u.f_Username, p.HeThong, p.ChucNang, p.DanhMuc, p.TroGiup, p.them, p.xoa, p.xua from users u, permission p where u.f_ID = p.ID_user and u.f_Username = '"+name+"'";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                dt_per.Username = string.Format("{0}", reader["f_Username"]);
                dt_per.Add = string.Format("{0}", reader["them"]);
                dt_per.Del = string.Format("{0}", reader["xoa"]);
                dt_per.Insert = string.Format("{0}", reader["xua"]);
                dt_per.RW_ChungNang = string.Format("{0}", reader["ChucNang"]);
                dt_per.RW_DanhMuc = string.Format("{0}", reader["DanhMuc"]);
                dt_per.RW_HeThong = string.Format("{0}", reader["HeThong"]);
                dt_per.RW_TroGiup = string.Format("{0}", reader["TroGiup"]);
            }
            Close_connection();
            return dt_per;
        }
    }
}
