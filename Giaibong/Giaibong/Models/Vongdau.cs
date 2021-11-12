using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Giaibong.Models
{
    public class Vongdau
    {
        public int ID { get; set; }
        public string Tenvongdau { get; set; }
        public int GiaidauID { get; set; }

        public Vongdau()
        {
        }

        public Vongdau(int iD, string tenvongdau, int giaidauID)
        {
            ID = iD;
            Tenvongdau = tenvongdau;
            GiaidauID = giaidauID;
        }
    }
}