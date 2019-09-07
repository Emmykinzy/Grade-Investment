using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GradeInvestment.Controllers
{
    public class LoanController : Controller
    {
        [HttpGet]
        public ActionResult LoanCal()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoanCal(int inv, double rate, int year)
        {

            double total = inv;
            double r = (rate/100);
            for(int x=0;x < year; x++)
            {
                total += total * r;
            }

            ViewBag.total = total;

            return View();
        }
    }
}