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
        /// <summary>
        /// Test Vongdau Not Null
        /// </summary>
        [TestMethod]
        public void VongdauNotNull()
        {
            VongdauDAO dao = new VongdauDAO();
            List<Vongdau> list = dao.GetVongdau();
            Assert.AreNotEqual(list.Count, 0);
        }
    }
}
