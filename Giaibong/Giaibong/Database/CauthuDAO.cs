using Giaibong.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Giaibong.Database
{
    public class CauthuDAO
    {
        private SqlConnection connect;
        private SqlCommand cmd;
        private SqlDataReader dt;

        public List<Cauthu> GetCauthuByID(string sql)
        {
            List<Cauthu> list = new List<Cauthu>();
            Cauthu m = new Cauthu();
            DAO dao = new DAO();
            using (this.connect = new SqlConnection(dao.constring))
            {
                this.connect.Open();
                cmd = new SqlCommand(sql, this.connect);
                dt = cmd.ExecuteReader();
                while (dt.HasRows != null && dt.Read())
                {
                    int id = (int)dt[0];
                    string TenCauthu = ((string)dt[1]).Trim();
                    DateTime Ngaysinh = ((DateTime)dt[2]).Date;
                    string ngay = Ngaysinh.ToString("dd-MM-yyy");
                    string VT = ((string)dt[3]).Trim();
                    int ID_doibong = (int)dt[4];
                    string Chanthuan = ((string)dt[5]).Trim();
                    string Chieucao = ((string)dt[6]).Trim();
                    string Cannang = ((string)dt[7]).Trim();
                    string Dacdiem = ((string)dt[8]).Trim();
                    int Status = (int)dt[9];

                    m = new Cauthu(id, TenCauthu, ngay, VT, ID_doibong, Chanthuan, Chieucao, Cannang, Dacdiem, Status);
                    list.Add(m);
                }
                this.connect.Close();
                return list;
            }


        }
        public Cauthu GetCauthu(string sql)
        {

            Cauthu m = new Cauthu();
            DAO dao = new DAO();
            using (this.connect = new SqlConnection(dao.constring))
            {
                this.connect.Open();
                cmd = new SqlCommand(sql, this.connect);
                dt = cmd.ExecuteReader();
                if (dt.HasRows)
                {
                    if (dt.Read())
                    {
                        int id = (int)dt[0];
                        string TenCauthu = ((string)dt[1]).Trim();
                        DateTime Ngaysinh = ((DateTime)dt[2]).Date;
                        string ngay = Ngaysinh.ToString("dd-MM-yyy");
                        string VT = ((string)dt[3]).Trim();
                        int ID_doibong = (int)dt[4];
                        string Chanthuan = ((string)dt[5]).Trim();
                        string Chieucao = ((string)dt[6]).Trim();
                        string Cannang = ((string)dt[7]).Trim();
                        string Dacdiem = ((string)dt[8]).Trim();
                        int Status = (int)dt[9];

                        m = new Cauthu(id, TenCauthu, ngay, VT, ID_doibong, Chanthuan, Chieucao, Cannang, Dacdiem, Status);
                    }


                }
                return m;


            }

        }
    }
}