using Giaibong.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Giaibong.Database
{
    public class TrandauDAO
    {
        private SqlConnection connect;
        private SqlCommand cmd;
        private SqlDataReader dt;
        public List<Trandau> GetTrandauByID(string sql)
        {
            List<Trandau> list = new List<Trandau>();
            Trandau m = new Trandau();
            DAO dao = new DAO();
            using (this.connect = new SqlConnection(dao.constring))
            {
                this.connect.Open();
                cmd = new SqlCommand(sql, this.connect);
                dt = cmd.ExecuteReader();
                while (dt.HasRows != null && dt.Read())
                {
                    int id_doibong = (int)dt[0];
                    int id_trandau = (int)dt[1];
                    string ten = ((string)dt[2]).Trim();
                    string Tendoibong = ((string)dt[3]).Trim();
                    DateTime Ngay = ((DateTime)dt[4]);
                    string Diachi = ((string)dt[5]).Trim();
                    string Trangphuc = ((string)dt[6]).Trim();

                    m = new Trandau(id_trandau, id_doibong, ten, Tendoibong, Ngay, Diachi, Trangphuc);
                    list.Add(m);
                }
                this.connect.Close();
                return list;
            }

        }
    }
}