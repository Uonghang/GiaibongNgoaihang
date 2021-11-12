using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Giaibong.Models
{
    public class Cauthu
    {
        public int ID { get; set; }

        public string Ten { get; set; }
        public string Ngaysinh { get; set; }
        public string VT { get; set; }
        public int DoibongID { get; set; }
        public string Chanthuan { get; set; }
        public string Chieucao { get; set; }
        public string Cannang { get; set; }
        public string Dacdiem { get; set; }
        public int Status { get; set; }

        public Cauthu()
        {
        }

        public Cauthu(int iD, string ten, string ngaysinh, string vT, int doibongID, string chanthuan, string chieucao, string cannang, string dacdiem, int status)
        {
            ID = iD;
            Ten = ten;
            Ngaysinh = ngaysinh;
            VT = vT;
            DoibongID = doibongID;
            Chanthuan = chanthuan;
            Chieucao = chieucao;
            Cannang = cannang;
            Dacdiem = dacdiem;
            Status = status;
        }
    }
}