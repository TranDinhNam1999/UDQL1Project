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
    public class DAL_Users : DB_connect
    {
        public void Insert_Users_db(DTO_Users u)
        {
            Open_connection();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO users(f_Username,f_Password,f_Name,f_Email,f_DOB) VALUES(@f_Username,@f_Password,@f_Name,@f_Email,@f_DOB)";
            command.Parameters.Add(new SqlParameter("@f_Username", u.F_Username));
            command.Parameters.Add(new SqlParameter("@f_Password", u.F_Password));
            command.Parameters.Add(new SqlParameter("@f_Name", u.F_Name));
            command.Parameters.Add(new SqlParameter("@f_Email", u.F_Email));
            command.Parameters.Add(new SqlParameter("@f_DOB", u.F_DOB));
            command.ExecuteNonQuery();
            Close_connection();
        }
        public int Select_id_db(string u_name)
        {
            int id = 0;
            Open_connection();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandType = CommandType.Text;
            command.CommandText = "select f_ID from users where f_Username = '"+u_name+"'";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
               id = int.Parse(String.Format("{0}", reader[0]));
            }
            Close_connection();
            return id;
        }
        public string Slect_Username_db(string s)
        {
            string Urname = "";
            Open_connection();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandType = CommandType.Text;
            command.CommandText = "select f_Username from users where f_Username = @f_username";
            command.Parameters.Add(new SqlParameter("@f_username", SqlDbType.NVarChar));
            command.Parameters["@f_username"].Value = s;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Urname = String.Format("{0}", reader[0]);
            }
            Close_connection();
            return Urname; 
        }
        public string select_Password_db(string s)
        {
            string password = "";
            Open_connection();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandType = CommandType.Text;
            command.CommandText = "select f_Password from users where f_Username = @f_username";
            command.Parameters.Add(new SqlParameter("@f_username", SqlDbType.NVarChar));
            command.Parameters["@f_username"].Value = s;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                password = String.Format("{0}", reader[0]);
            }
            Close_connection();
            return password;
        }
        public DataTable Select_User()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from users";
            Open_connection();
            da.SelectCommand = cmd;
            da.Fill(dt);
            Close_connection();
            return dt;
        }
        public void Delete_user(int id)
        {
            Open_connection();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandType = CommandType.Text;
            command.CommandText = "delete from users where f_ID = " + id;
            command.ExecuteNonQuery();
            Close_connection();
        }
        public void Update_Password(string password, string name)
        {
            Open_connection();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandType = CommandType.Text;
            command.CommandText = "update users set f_Password = '" + password + "' where f_Username = '" + name + "'";
            command.ExecuteNonQuery();
            Close_connection();
        }
    }
}
