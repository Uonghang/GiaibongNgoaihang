using Giaibong.Database;
using Giaibong.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class TestVongdauDAO
    {
        [TestMethod]
        public void VongdauNotNull()
        {
            VongdauDAO dao = new VongdauDAO();
            string sql = "select*from Vongdau";
            List<Vongdau> list = dao.GetVongdauByID(sql);
            Assert.AreNotEqual(list.Count, 0);
        }
    }
}
