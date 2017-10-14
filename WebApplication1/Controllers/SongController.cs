using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class SongController : Controller
    {
        public ActionResult GrabData(Song song)
        {
            return RedirectToAction("Create");
        }

        public ActionResult Create()
        {
            return View();
        }
    }
}