using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_NhatKiHeThong : DB_connect
    {
        public DataTable Select_NhatKiHeThong(string query)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand command = new SqlCommand();

            command.Connection = conn;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            Open_connection();
            da.SelectCommand = command;
            da.Fill(dt);
            Close_connection();
            return dt;
        }
        public void Insert_NhatKiHetThong(string nguoidung, string chucnang, string hanhdong)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into NhatKiHeThong Values('" + nguoidung + "',GETDATE(),N'" + chucnang + "', N'" + hanhdong + "')";
            Open_connection();
            command.ExecuteNonQuery();
            Close_connection();
        }
        public void Delete_NhatKiHeThong(int id)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandType = CommandType.Text;
            command.CommandText = "delete NhatKiHeThong where id = "+id;
            Open_connection();
            command.ExecuteNonQuery();
            Close_connection();
        }
    }
}
