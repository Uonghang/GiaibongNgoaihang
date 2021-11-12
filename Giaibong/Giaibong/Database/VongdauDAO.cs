using Giaibong.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Giaibong.Database
{
    public class VongdauDAO
    {
        private SqlConnection connect;
        private SqlCommand cmd;
        private SqlDataReader dt;

        public List<Vongdau> GetVongdauByID(string sql)
        {
            List<Vongdau> list = new List<Vongdau>();
            Vongdau m = new Vongdau();
            DAO dao = new DAO();
            using ( this.connect= new SqlConnection(dao.constring))
            {
                this.connect.Open();
                cmd = new SqlCommand(sql, this.connect);
                dt = cmd.ExecuteReader();
                while (dt.HasRows != null && dt.Read())
                {
                    int id = (int)dt[0];
                    String Tenvongdau = ((string)dt[1]).Trim();
                    int GiaidauID = (int)dt[2];
                    m = new Vongdau(id, Tenvongdau, GiaidauID);
                    list.Add(m);
                }
                this.connect.Close();
                return list;
            }

        }
    }
}