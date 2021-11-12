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
        [TestMethod]
        public void TestTrandaudauISNull()
        {
            TrandauDAO dao = new TrandauDAO();
            string sql = "select db.DoibongID,td.ID,td.Ten [Tên trận đấu],d.Ten as [Tên đội bóng],td.Ngaythidau [Ngày thi đấu],d.Diachi[Địa chỉ],d.Trangphuc [Trang phục]from Doibong_Trandau db " +
                "inner join  Trandau td on td.ID=db.TrandauID inner join Doibong d on d.ID = db.DoibongID where td.VongdauID =" + 2 + "";
            List<Trandau> list =dao.GetTrandauByID(sql);
            Assert.AreEqual(list.Count,0);
        }
        [TestMethod]
        public void TestTrandauNotNull()
        {
            TrandauDAO dao = new TrandauDAO();
            string sql = "select db.DoibongID,td.ID,td.Ten [Tên trận đấu],d.Ten as [Tên đội bóng],td.Ngaythidau [Ngày thi đấu],d.Diachi[Địa chỉ],d.Trangphuc [Trang phục]from Doibong_Trandau db " +
                "inner join  Trandau td on td.ID=db.TrandauID inner join Doibong d on d.ID = db.DoibongID where td.VongdauID =" + 1 + "";
            List<Trandau> list = dao.GetTrandauByID(sql);
            Assert.AreNotEqual(list.Count,0);
        }
        
        
    }
}
