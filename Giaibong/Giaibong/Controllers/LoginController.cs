using Giaibong.Code;
using Giaibong.Database;
using Giaibong.Models;
using System.Web.Mvc;

namespace Giaibong.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(LoginModel model)
        {
            NhanvienDAO dao = new NhanvienDAO();
            string sql = "Select*from Nhanvien where Username= @username and Password= @password";
            object[] parameter = new object[]{
                model.Username,model.Password,
            };
            LoginModel m = dao.LoginNhanvien(sql, parameter);
            if (m.Username != null && ModelState.IsValid)
            {
                Session["Nhanvien"] = m;
                SessionHttp.Username = m.Ten;
                return RedirectToAction("GDHome", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Thông tin đăng nhập sai");

            }
            return View(m);
        }
    }
}