using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Giaibong.Models
{
    public class LoginModel
    {
        public int ID { get; set; }
        public string Ten { get; set; }
        public string Diachi { get;set;}
        public string Sdt { get; set; }
        public string Vitri { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }

        public LoginModel()
        {
        }

        public LoginModel(int iD, string ten, string diachi, string sdt, string vitri, string username, string password)
        {
            ID = iD;
            Ten = ten;
            Diachi = diachi;
            Sdt = sdt;
            Vitri = vitri;
            Username = username;
            Password = password;
        }
    }
}