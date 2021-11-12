using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Giaibong.Models
{
    public class Doibong
    {
        public int ID { get; set; }
        public string Ten { get; set; }
        public string Diachi { get; set; }
        public string Trangphuc { get; set; }
        public string Mota { get; set; }

        public Doibong()
        {
        }

        public Doibong(int iD, string tendoibong, string diachi, string trangphuc, string mota)
        {
            ID = iD;
            Ten = tendoibong;
            Diachi = diachi;
            Trangphuc = trangphuc;
            Mota = mota;
        }
    }
}