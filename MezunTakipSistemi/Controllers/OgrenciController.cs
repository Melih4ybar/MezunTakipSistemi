using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MezunTakipSistemi.Controllers
{
    public class OgrenciController : Controller
    {
        // GET: Ogrenci
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Giris()
        {
            return View();
        }
        public ActionResult Kayit()
        {
            return View();
        }
    }
}