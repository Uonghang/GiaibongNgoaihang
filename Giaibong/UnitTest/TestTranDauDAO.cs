using Giaibong.Database;
using Giaibong.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class TestTranDauDAO
    {
        /// <summary>
        /// Test Trandau Null
        /// </summary>
        [TestMethod]
        public void TestTrandauISNull()
        {
            TrandauDAO dao = new TrandauDAO();
            List<Trandau> list =dao.GetTrandauByID(2);
            Assert.AreEqual(list.Count,0);
        }
        /// <summary>
        /// Test TrandauNotNull
        /// </summary>
        [TestMethod]
        public void TestTrandauNotNull()
        {
            TrandauDAO dao = new TrandauDAO();
            List<Trandau> list = dao.GetTrandauByID(1);
            Assert.AreNotEqual(list.Count,0);
        }
        /// <summary>
        /// Test Trandau không Tồn Tại
        /// </summary>
        [TestMethod]
        public void TestTrandauExits()
        {
            TrandauDAO dao = new TrandauDAO();
            List<Trandau> list = dao.GetTrandauByID(4);
            Assert.AreEqual(list.Count, 0);
        }


    }
}
