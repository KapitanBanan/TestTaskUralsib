using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UralsibTask.Models;

namespace UralsibTask.Controllers
{
    public class HomeController : Controller
    {
        // создаем контекст данных
        AutoContext db = new AutoContext();

        public ActionResult Index()
        {
            // получаем из бд все объекты Book
            IEnumerable<Brand> brands = db.Brands;
            // передаем все объекты в динамическое свойство Books в ViewBag
            ViewBag.Brands = brands;
            // возвращаем представление
            return View();
        }
    }
}