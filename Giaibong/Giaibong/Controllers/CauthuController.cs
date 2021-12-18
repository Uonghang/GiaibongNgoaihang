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
            cauthuDAO.ResetStatus();
            List<Cauthu> model = cauthuDAO.GetCauthuByID(DoibongID);
            SessionHttp.Id_Trandau = TrandauID;
            SessionHttp.Id_Doibong = DoibongID;
            
            List<CauthuTrandau> list = dao.GetCauThuTrandauByID(DoibongID, TrandauID);
            if (list.Count > 0)
            {
                foreach (var item in list)
                {
                    
                   cauthuDAO.UpdateCauthu(DoibongID,item.Id_Cauthu);
                }

            }
            mymodel.model = model;
            mymodel.list = list;
            return View(mymodel);
        }
        public void Status(int Id)
        {
            
            Cauthu model = cauthuDAO.GetCauthu(Id);
            if (model.Status == 0)
            {
                cauthuDAO.UpdateStatus(1, Id);
            }
            else
            {
                cauthuDAO.UpdateStatus(0, Id);
            }
        }
        public JsonResult DangkyCauthu()
        {

            //Check xem đã chọn đủ 16 Cầu thủ chưa
            
            List<Cauthu> model = cauthuDAO.GetCauthuDangky();

            //Nếu thỏa mãn
            if (model.Count == 16)
            {
                //lay ra Danh sach Cau thu Doi bong neu da duoc Dang ky
                List<CauthuTrandau> list =dao.GetCauThuTrandauByID(SessionHttp.Id_Doibong, SessionHttp.Id_Trandau);
                //Nếu đã đăng ký
                if (list.Count > 0)
                {
                    dao.DeleteCauthu(SessionHttp.Id_Doibong, SessionHttp.Id_Trandau);
                    foreach (var item in model)
                    {
                        dao.DangkyCauthu(SessionHttp.Id_Trandau, item);

                    }
                }

                //Nếu chưa đăng ký
                else
                {
                    foreach (var item in model)
                    {
                        dao.DangkyCauthu(SessionHttp.Id_Trandau,item);
                    }
                }

                return Json(true, JsonRequestBehavior.AllowGet);

            }
            return Json(false, JsonRequestBehavior.AllowGet);

        }
    }
}