using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Giaibong.Models
{
    public class CauthuTrandau
    {
        public int ID { get; set; }
        public int Id_Trandau { get; set; }
        public int Id_Cauthu { get; set; }
        public string TenCauthu { get; set; }
        public string VT { get; set; }
        public int Id_Doibong { get; set; }

        public CauthuTrandau()
        {
        }

        public CauthuTrandau(int id_Cauthu)
        {
            Id_Cauthu = id_Cauthu;
        }

        public CauthuTrandau(int iD, int id_Trandau, int id_Cauthu, string tenCauthu, string vT, int id_Doibong)
        {
            ID = iD;
            Id_Trandau = id_Trandau;
            Id_Cauthu = id_Cauthu;
            TenCauthu = tenCauthu;
            VT = vT;
            Id_Doibong = id_Doibong;
        }
    }
}