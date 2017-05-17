using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReviewHomework.Controllers
{
    public class OverTodayController : Controller
    {
        // GET: OverToday
        public ActionResult Index(DateTime? Dateee)
        {
            var isValidate = true;
            if (Dateee.HasValue)
            {
                isValidate = DateTime.Now.Date > Dateee;
            }
            return Json(isValidate, JsonRequestBehavior.AllowGet);
        }
    }
}