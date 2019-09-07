using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GradeInvestment.Controllers
{
    public class GradesController : Controller
    {
        [HttpGet]
        public ActionResult GradeCal()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GradeCal(FormCollection grades)
        {

            int t1 = Int32.Parse(Request.Form["test1"]);
            int t2 = Int32.Parse(Request.Form["test2"]);
            int t3 = Int32.Parse(Request.Form["test3"]);

            string message;
            if (t1 < 0 || t2 < 0 || t3 < 0)
            {
                message = "Please input numbers greater than 0";
                ViewBag.message = message;
            }
            else
            {

                int avg = (t1 + t2 + t3) / 3;
                char letter_grade;

                if (avg >= 90)
                {
                    letter_grade = 'A';
                }
                else if (avg >= 80)
                {
                    letter_grade = 'B';
                }
                else if (avg >= 70)
                {
                    letter_grade = 'C';
                }
                else if (avg >= 60)
                {
                    letter_grade = 'D';
                }
                else if (avg >= 0)
                {
                    letter_grade = 'F';
                }
                else
                {
                    letter_grade = 'Z';
                }

                ViewBag.letter = letter_grade;
                ViewBag.avg = avg;
            }

            return View();
        }
    }
}