using ReviewHomework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReviewHomework.Controllers
{
    public class HomeController : Controller
    {
        Show db = new Show();
        public ActionResult Sample()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ChildAction()
        {
            var model = new List<MyClass>();
            var data = db.AccountBook.ToList();
            foreach (var item in data)
            {
                MyClass x = new MyClass()
                {
                    Money = item.Amounttt,
                    Date = item.Dateee
                };
                if (item.Categoryyy == 0)
                {
                    x.Category = "收入";
                }
                else
                {
                    x.Category = "支出";
                }
                model.Add(x);
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(AccountBook data)
        {
            if (ModelState.IsValid)
            {
                data.Id = Guid.NewGuid();
                db.AccountBook.Add(data);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(data);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}