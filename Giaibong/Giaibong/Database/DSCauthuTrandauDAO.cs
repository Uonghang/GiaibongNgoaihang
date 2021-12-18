using Giaibong.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace Giaibong.Database
{
    public class DSCauthuTrandauDAO:DAO
    {
        private SqlConnection connect;
        private SqlCommand cmd;
        private SqlDataReader dt;
        public bool DangkyCauthu(int TrandauID,Cauthu item)
        {
            int res = 0;
            string sql = "Insert into DSCauthuTrandau(TrandauID,CauthuID,Ten,VT) " +
                        "values('" + TrandauID + "','" + item.ID + "','" + item.Ten + "','" + item.VT + "')";
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
        public List<CauthuTrandau> GetCauThuTrandauByID(int DoibongID,int TrandauID)
        {
            string sql = "select CauthuID from DSCauthuTrandau ds inner join Doibong_Trandau td " +
                "on td.TrandauID = ds.TrandauID where td.DoibongID='" + DoibongID + "' and td.TrandauID='" + TrandauID + "'";
           
            List<CauthuTrandau> list = new List<CauthuTrandau>();
            CauthuTrandau m = new CauthuTrandau();
            using (this.connect = new SqlConnection(constring))
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
        public bool DeleteCauthu(int DoibongID, int TrandauID)
        {
            string status = "select CauthuID from DSCauthuTrandau ds inner join Doibong_Trandau td " +
               "on td.TrandauID = ds.TrandauID where td.DoibongID='" + DoibongID + "' and td.TrandauID='" + TrandauID + "'";
            string sql = "delete DSCauthuTrandau where TrandauID='" + TrandauID + "'" +
                        "and CauthuID IN ("+status+ ")";
            int res = 0;
            using (this.connect = new SqlConnection(constring))
            {
                this.connect.Open();
                SqlCommand comand = new SqlCommand(sql, this.connect);
                res = comand.ExecuteNonQuery();
               
                if (res > 0)
                {
                    return true;
                }
                this.connect.Close();
            }
            return false;
        }
        
    }
}