using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Giaibong.Models
{
    public class Trandau
    {
        public int ID { get; set; }
        public int DoibongID { get; set; }
        public string Ten { get; set; }
        public string TenDoibong { get; set; }
        public DateTime Ngaythidau { get; set; }
        public int VongdauID { get; set; }
        public long Giaban { get; set; }
        public string Diachi { get; set; }
        public string Trangphuc { get; set; }

        public Trandau()
        {
        }

        public Trandau(int iD, int doibongId, string ten, string tenDoibong, DateTime ngaythidau, string diachi, string trangphuc)
        {
            ID = iD;
            DoibongID = doibongId;
            Ten = ten;
            TenDoibong = tenDoibong;
            Ngaythidau = ngaythidau;
            Diachi = diachi;
            Trangphuc = trangphuc;
        }
    }
}