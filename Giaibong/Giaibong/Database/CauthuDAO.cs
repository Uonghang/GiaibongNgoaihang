using Giaibong.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Giaibong.Database
{
    public class CauthuDAO:DAO
    {
        private SqlConnection connect;
        private SqlCommand cmd;
        private SqlDataReader dt;

        public List<Cauthu> GetCauthuByID(int DoibongID)
        {
            string sql = "select*from Cauthu where DoibongID='" + DoibongID + "'";
            List<Cauthu> list = new List<Cauthu>();
            Cauthu m = new Cauthu();
            using (this.connect = new SqlConnection(constring))
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
        public Cauthu GetCauthu(int Id)
        {
            string sql = "Select*from Cauthu where ID='" + Id + "'";
            Cauthu m = new Cauthu();
            DAO dao = new DAO();
            using (this.connect = new SqlConnection(constring))
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
                this.connect.Close();
                return m;


            }

        }
        public List<Cauthu> GetCauthuDangky()
        {

            string sql = "Select*from Cauthu where Status=1";
            List<Cauthu> list = new List<Cauthu>();
            Cauthu m = new Cauthu();
            using (this.connect = new SqlConnection(constring))
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
        public bool UpdateCauthu(int DoibongID,int Id_Cauthu)
        {
            string sql = "Update Cauthu set Status=1 where DoibongID='" + DoibongID + "' and ID='" + Id_Cauthu + "'";
            return Commom(sql);
        }
        public void ResetStatus()
        {
            string sql = "Update Cauthu set Status=0";
            Commom(sql);
        }
        public void UpdateStatus(int status,int Id)
        {
            string sql = "Update Cauthu set Status='"+ status + "' where ID='" + Id + "'";
            Commom(sql);
        }
        public bool Commom(string sql)
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