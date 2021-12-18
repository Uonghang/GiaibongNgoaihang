using Giaibong.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Giaibong.Database
{
    public class TrandauDAO:DAO
    {
        private SqlConnection connect;
        private SqlCommand cmd;
        private SqlDataReader dt;
        /// <summary>
        /// Get Vong dau
        /// </summary>
        /// <param name="VongdauID"></param>
        /// <returns>List Trandau</returns>
        public List<Trandau> GetTrandauByID(int VongdauID)
        {
            string sql = "select db.DoibongID,td.ID,td.Ten [Tên trận đấu],d.Ten as [Tên đội bóng],td.Ngaythidau [Ngày thi đấu],d.Diachi[Địa chỉ],d.Trangphuc [Trang phục]from Doibong_Trandau db " +
                "inner join  Trandau td on td.ID=db.TrandauID inner join Doibong d on d.ID = db.DoibongID where td.VongdauID =" + VongdauID + "";
            List<Trandau> list = new List<Trandau>();
            Trandau m = new Trandau();
            using (this.connect = new SqlConnection(constring))
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