﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DB_connect
    {
        public string name = "";
        protected SqlConnection conn = new SqlConnection("Data Source=DESKTOP-E3NRUFR;Initial Catalog=CSDL_QLBH;Integrated Security=True");
        public void Open_connection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public void Close_connection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
