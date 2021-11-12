using Giaibong.Code;
using Giaibong.Database;
using Giaibong.Models;
using System.Collections.Generic;
using System.Dynamic;
using System.Web.Mvc;

namespace Giaibong.Controllers
{
    public class CauthuController : Controller
    {
        private DSCauthuTrandauDAO dao = new DSCauthuTrandauDAO();
        private CauthuDAO cauthuDAO = new CauthuDAO();
        public ActionResult GDCauthu(int DoibongID, int TrandauID)
        {
            
            dynamic mymodel = new ExpandoObject();
            string resetStatus = "Update Cauthu set Status=0";
            DAO.Singleton.Excute_Modify(resetStatus);
            string getDSCauthu = "select*from Cauthu where DoibongID='" + DoibongID + "'";
            List<Cauthu> model = cauthuDAO.GetCauthuByID(getDSCauthu);
            SessionHttp.Id_Trandau = TrandauID;
            SessionHttp.Id_Doibong = DoibongID;
            string StatusDangky = "select CauthuID from DSCauthuTrandau ds inner join Doibong_Trandau td " +
                "on td.TrandauID = ds.TrandauID where td.DoibongID='" + DoibongID + "' and td.TrandauID='" + TrandauID + "'";
            List<CauthuTrandau> list = dao.GetCauThuTrandauByID(StatusDangky);
            if (list.Count > 0)
            {
                foreach (var item in list)
                {
                    string updateStatus = "Update Cauthu set Status=1 where DoibongID='" + DoibongID + "' and ID='" + item.Id_Cauthu + "'";
                    DAO.Singleton.Excute_Modify(updateStatus);
                }

            }
            mymodel.model = model;
            mymodel.list = list;
            return View(mymodel);
        }
        public void Status(int Id)
        {
            string sql1 = "Select*from Cauthu where ID='" + Id + "'";
            Cauthu model = cauthuDAO.GetCauthu(sql1);
            string sql = "";
            if (model.Status == 0)
            {
                sql = "Update Cauthu set Status=1 where ID='" + Id + "'";
            }
            else
            {
                sql = "Update Cauthu set Status=0 where ID='" + Id + "'";
            }
            DAO.Singleton.Excute_Modify(sql);

        }
        public JsonResult DangkyCauthu()
        {

            //Check xem đã chọn đủ 16 Cầu thủ chưa
            string sql = "Select*from Cauthu where Status=1";
            List<Cauthu> model = cauthuDAO.GetCauthuByID(sql);

            //Nếu thỏa mãn
            if (model.Count == 16)
            {
                //lay ra Danh sach Cau thu Doi bong neu da duoc Dang ky
                string StatusDangky = "select CauthuID from DSCauthuTrandau ds inner join Doibong_Trandau td " +
                "on td.TrandauID = ds.TrandauID where td.DoibongID='" + SessionHttp.Id_Doibong + "' and td.TrandauID='" + SessionHttp.Id_Trandau + "'";
                List<CauthuTrandau> list =dao.GetCauThuTrandauByID(StatusDangky);
                //Nếu đã đăng ký
                if (list.Count > 0)
                {
                    string delete_Table = "delete DSCauthuTrandau where TrandauID='" + SessionHttp.Id_Trandau + "'" +
                        "and CauthuID IN ("+StatusDangky+")";
                    DAO.Singleton.Excute_Modify(delete_Table);
                    foreach (var item in model)
                    {
                        string Insert_Table = "Insert into DSCauthuTrandau(TrandauID,CauthuID,Ten,VT) " +
                    "values('" + SessionHttp.Id_Trandau + "','" + item.ID + "','" + item.Ten + "','" + item.VT + "')";
                        dao.DangkyCauthu(Insert_Table);


                    }
                }

                //Nếu chưa đăng ký
                else
                {
                    foreach (var item in model)
                    {
                        string Insert_Table = "Insert into DSCauthuTrandau(TrandauID,CauthuID,Ten,VT) " +
                        "values('" + SessionHttp.Id_Trandau + "','" + item.ID + "','" + item.Ten + "','" + item.VT + "')";
                        dao.DangkyCauthu(Insert_Table);
                    }
                }

                return Json(true, JsonRequestBehavior.AllowGet);

            }
            return Json(false, JsonRequestBehavior.AllowGet);

        }
    }
}