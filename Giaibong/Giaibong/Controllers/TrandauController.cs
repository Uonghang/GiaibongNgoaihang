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
            string sql = "select db.DoibongID,td.ID,td.Ten [Tên trận đấu],d.Ten as [Tên đội bóng],td.Ngaythidau [Ngày thi đấu],d.Diachi[Địa chỉ],d.Trangphuc [Trang phục]from Doibong_Trandau db " +
                "inner join  Trandau td on td.ID=db.TrandauID inner join Doibong d on d.ID = db.DoibongID where td.VongdauID ="+ SessionHttp.Id_Vongdau+"";
            List<Trandau> model = dao.GetTrandauByID(sql);
            return View(model);
        }
    }
}