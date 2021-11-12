using Giaibong.Code;
using Giaibong.Database;
using Giaibong.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Giaibong.Controllers
{
    public class VongdauController : Controller
    {
        // GET: Vongdau
        public ActionResult GDVongdau()
        {
            string sql = "select*from Vongdau";
            VongdauDAO dao = new VongdauDAO();
            List<Vongdau> list = dao.GetVongdauByID(sql);

            return View(list);
        }
        public ActionResult GetID(int Id)
        {
            SessionHttp.Id_Vongdau = Id;
            return RedirectToAction("GDTrandau", "Trandau");
        }
    }
}