using Giaibong.Code;
using Giaibong.Database;
using Giaibong.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Giaibong.Controllers
{
    public class TrandauController : Controller
    {
        // GET: Trandau
        public ActionResult GDTrandau()
        {
            TrandauDAO dao = new TrandauDAO();
            int id = SessionHttp.Id_Vongdau;
            List<Trandau> model = dao.GetTrandauByID(id);
            return View(model);
        }
    }
}