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
        /// <summary>
        /// Test Cauthu có dữ liệ
        /// </summary>
        [TestMethod]
        public void TestCauthuNotNull()
        {
            CauthuDAO dao = new CauthuDAO();
            List<Cauthu> list = dao.GetCauthuByID(1);
            Assert.AreNotEqual(list.Count, 0);
        }
        /// <summary>
        /// Test Cauthu không co du liêu
        /// </summary>
        [TestMethod]
        public void TestCauthuNull()
        {
            CauthuDAO dao = new CauthuDAO();
            List<Cauthu> list = dao.GetCauthuByID(8);
            Assert.AreEqual(list.Count, 0);
        }
    }
}
