using Giaibong.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace Giaibong.Database
{
    public class NhanvienDAO
    {
        private SqlConnection connect;
        private SqlCommand cmd;
        private SqlDataReader dt;
        public LoginModel LoginNhanvien(string sql, Object[] parames = null)
        {
            LoginModel m = new LoginModel();
            DAO dao = new DAO();
            using (this.connect = new SqlConnection(dao.constring))
            {
                this.connect.Open();
                cmd = new SqlCommand(sql, this.connect);
                if (parames[0] != null && parames[1] != null)
                {
                    List<string> list = new List<string>();
                    string[] tam = sql.Split(' ');
                    foreach (var item in tam)
                    {
                        if (item[0] == '@')
                        {
                            list.Add(item);
                        }
                    }
                    for (int i = 0; i < list.Count; i++)
                    {
                        cmd.Parameters.AddWithValue(list[i], parames[i]);
                    }
                    dt = cmd.ExecuteReader();
                    if (dt.HasRows)
                    {
                        if (dt.Read())
                        {
                            int ID = (int)dt[0];
                            string Ten = (string)dt[1];
                            string Diachi = (string)dt[2];
                            string Sdt = (string)dt[3];
                            string Vitri = (string)dt[4];
                            string Username = (string)dt[5];
                            string Password = (string)dt[6];
                            m = new LoginModel(ID, Ten, Diachi, Sdt, Vitri, Username, Password);
                        }
                    }
                    else
                    {
                        return null;
                    }
                }

                this.connect.Close();
                return m;
            }
        }
    }
}