using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalExam410716152.Controllers
{
    public class WeekController : Controller
    {
        // GET: Week
        public ActionResult Index(int? math)
        {
            var ss = "";
            if(math .HasValue && math == 1)
            {
                ss = ("星期一");
            }
            if (math.HasValue && math == 2)
            {
                ss = ("星期二");
            }
            if (math.HasValue && math == 3)
            {
                ss = ("星期三");
            }
            if (math.HasValue && math == 4)
            {
                ss = ("星期四");
            }
            if (math.HasValue && math == 5)
            {
                ss = ("星期五");
            }
            if (math.HasValue && math == 6)
            {
                ss = ("星期六");
            }
            if (math.HasValue && math == 7)
            {
                ss = ("星期日");
            }
            if (math.HasValue && math > 7)
            {
                ss = ("請輸入正確數字");
            }
            if (math.HasValue && math < 1)
            {
                ss = ("請輸入正確數字");
            }
            ViewBag.ss = ss;
            return View();
        }
    }
}