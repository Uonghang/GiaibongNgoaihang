using Giaibong.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace Giaibong.Database
{
    public class DSCauthuTrandauDAO
    {
        private SqlConnection connect;
        private SqlCommand cmd;
        private SqlDataReader dt;
        public bool DangkyCauthu(string sql)
        {
            int res = 0;
            DAO dao = new DAO();
            using (this.connect = new SqlConnection(dao.constring))
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
        public List<CauthuTrandau> GetCauThuTrandauByID(string sql)
        {
            DAO dao = new DAO();
            List<CauthuTrandau> list = new List<CauthuTrandau>();
            CauthuTrandau m = new CauthuTrandau();
            using (this.connect = new SqlConnection(dao.constring))
            {
                this.connect.Open();
                cmd = new SqlCommand(sql, this.connect);
                dt = cmd.ExecuteReader();
                while (dt.HasRows != null && dt.Read())
                {

                    int id = (int)dt[0];
                    m = new CauthuTrandau(id);
                    list.Add(m);
                }
                return list;
            }

        }
        
    }
}