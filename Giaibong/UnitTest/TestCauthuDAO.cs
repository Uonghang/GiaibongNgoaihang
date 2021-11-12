using Giaibong.Database;
using Giaibong.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class TestCauthuDAO
    {
        [TestMethod]
        public void TestCauthuNotNull()
        {
            CauthuDAO dao = new CauthuDAO();
            string sql = "select*from Cauthu where DoibongID=1";
            List<Cauthu> list = dao.GetCauthuByID(sql);
            Assert.AreNotEqual(list.Count, 0);
        }
    }
}
