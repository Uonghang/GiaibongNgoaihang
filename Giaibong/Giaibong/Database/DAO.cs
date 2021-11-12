using Giaibong.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace Giaibong.Database
{
    public class DAO
    {
        private SqlConnection connect;
        public static DAO singleton = null;
        public string constring;
        public static DAO Singleton
        {
            get
            {
                if (singleton == null)
                {
                    singleton = new DAO();
                }
                return singleton;
            }
        }
        public DAO()
        {
            constring = @"Data Source=DESKTOP-U8OMTB9\SQLEXPRESS;Initial Catalog=Giaibong;Persist Security Info=True;User ID=hang;Password=a0123456";

        }
        //Ham insert/update/delete chung của project
        public bool Excute_Modify(string sql)
        {
            int res = 0;
            using (this.connect = new SqlConnection(constring))
            {
                this.connect.Open();
                SqlCommand comand = new SqlCommand(sql, this.connect);
                res = comand.ExecuteNonQuery();
                this.connect.Close();
            }
            if (res > 0)
            {
                return true;
            }
            return false;

        }
    }
}