using Giaibong.Database;
using Giaibong.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Transactions;

namespace TestDSCauthuTrandauDAO
{
    [TestClass]
    public class TestDSCauthuTrandauDAO
    {
        private DAO d = new DAO();
        private DSCauthuTrandauDAO dao = new DSCauthuTrandauDAO();
        [TestMethod]
        public void TestDangkyThatbai1()
        {
            using (TransactionScope transaction = new TransactionScope())
            {
               
                CauthuDAO cauthuDAO = new CauthuDAO();
                cauthuDAO.UpdateCauthu(1, 2);
                cauthuDAO.UpdateCauthu(1, 3);
                cauthuDAO.UpdateCauthu(1, 4);
                List<Cauthu> list = cauthuDAO.GetCauthuDangky();
                Assert.AreNotEqual(list.Count,16);
            }
        }
        [TestMethod]
        public void TestDangkyThatbai2()
        {
          
            using (TransactionScope transaction = new TransactionScope())
            {
                
                CauthuDAO cauthuDAO = new CauthuDAO();
                cauthuDAO.UpdateCauthu(1, 2);
                cauthuDAO.UpdateCauthu(1, 3);
                cauthuDAO.UpdateCauthu(1, 4); cauthuDAO.UpdateCauthu(1, 2);
                cauthuDAO.UpdateCauthu(1, 3);
                cauthuDAO.UpdateCauthu(1, 4);
                cauthuDAO.UpdateCauthu(1, 5);
                cauthuDAO.UpdateCauthu(1, 6);
                cauthuDAO.UpdateCauthu(1, 7);
                cauthuDAO.UpdateCauthu(1, 8);
                cauthuDAO.UpdateCauthu(1, 9);
                cauthuDAO.UpdateCauthu(1, 10);
                cauthuDAO.UpdateCauthu(1, 11);
                cauthuDAO.UpdateCauthu(1, 12);
                cauthuDAO.UpdateCauthu(1, 13);
                cauthuDAO.UpdateCauthu(1, 14);
                cauthuDAO.UpdateCauthu(1, 15);
                cauthuDAO.UpdateCauthu(1, 18);
                cauthuDAO.UpdateCauthu(1, 17);
                cauthuDAO.UpdateCauthu(1, 19);
                List<Cauthu> list = cauthuDAO.GetCauthuDangky();
                Assert.AreNotEqual(list.Count, 16);
            }
        }
        [TestMethod]
        public void TestDangkyThanhcong()
        {
            
            using (TransactionScope transaction = new TransactionScope())
            {
                
                CauthuDAO cauthuDAO = new CauthuDAO();
                cauthuDAO.UpdateCauthu(1,2);
                cauthuDAO.UpdateCauthu(1, 3);
                cauthuDAO.UpdateCauthu(1, 4);
                cauthuDAO.UpdateCauthu(1, 5);
                cauthuDAO.UpdateCauthu(1, 6);
                cauthuDAO.UpdateCauthu(1, 7);
                cauthuDAO.UpdateCauthu(1, 8);
                cauthuDAO.UpdateCauthu(1, 9);
                cauthuDAO.UpdateCauthu(1, 10);
                cauthuDAO.UpdateCauthu(1, 11);
                cauthuDAO.UpdateCauthu(1, 12);
                cauthuDAO.UpdateCauthu(1, 13);
                cauthuDAO.UpdateCauthu(1, 14);
                cauthuDAO.UpdateCauthu(1, 15);
                cauthuDAO.UpdateCauthu(1, 18);
                cauthuDAO.UpdateCauthu(1, 17);
                List<Cauthu> list= cauthuDAO.GetCauthuDangky();
                Assert.AreEqual(list.Count, 16);
                foreach(var item in list)
                {
                    var res=dao.DangkyCauthu(5, item);
                    Assert.AreEqual(res, true);
                }
                
            }
            
           
        }

        [TestMethod]
        public void TestDangkyUpdate()
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                
                CauthuDAO cauthuDAO = new CauthuDAO();
                cauthuDAO.UpdateCauthu(1, 2);
                cauthuDAO.UpdateCauthu(1, 3);
                cauthuDAO.UpdateCauthu(1, 4);
                cauthuDAO.UpdateCauthu(1, 5);
                cauthuDAO.UpdateCauthu(1, 6);
                cauthuDAO.UpdateCauthu(1, 7);
                cauthuDAO.UpdateCauthu(1, 8);
                cauthuDAO.UpdateCauthu(1, 9);
                cauthuDAO.UpdateCauthu(1, 10);
                cauthuDAO.UpdateCauthu(1, 11);
                cauthuDAO.UpdateCauthu(1, 12);
                cauthuDAO.UpdateCauthu(1, 13);
                cauthuDAO.UpdateCauthu(1, 14);
                cauthuDAO.UpdateCauthu(1, 15);
                cauthuDAO.UpdateCauthu(1, 18);
                cauthuDAO.UpdateCauthu(1, 19);
                /// test chuc nang delete
                dao.DeleteCauthu(1, 3);
                List<Cauthu> list = cauthuDAO.GetCauthuDangky();
                Assert.AreEqual(list.Count, 16);
                foreach (var item in list)
                {
                    var res = dao.DangkyCauthu(3, item);
                    Assert.AreEqual(res, true);
                }

            }
            
        }
        [TestMethod]
        public void DeleteCauthuDangky()
        {

            using (TransactionScope transaction = new TransactionScope())
            {
                var res=dao.DeleteCauthu(1, 3);
                Assert.AreEqual(res, true);
            }
        }
        [TestMethod]
        public void GetCauThuTrandauByID()
        {
            
            using (TransactionScope transaction = new TransactionScope())
            {
                List<CauthuTrandau> _cauthus = dao.GetCauThuTrandauByID(1, 3);
                Assert.AreEqual(_cauthus.Count, 16);
            }
        }
        [TestMethod]
        public void GetCauThuTrandauByIDExits()
        {

            using (TransactionScope transaction = new TransactionScope())
            {
                List<CauthuTrandau> _cauthus = dao.GetCauThuTrandauByID(1, 4);
                Assert.AreNotEqual(_cauthus.Count, 16);
            }
        }
    }
   
}
