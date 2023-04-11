using GoogleChart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoogleChart.Controllers
{
    public class VisualizeController : Controller
    {
        // GET: Visualize
        public ActionResult ColumnChart()
        {
            return View();
        }
        public ActionResult VisualizeStudentResult()
        {
            return Json(Result(),JsonRequestBehavior.AllowGet);
        }
        public List<StudentResult> Result()
        {
            List<StudentResult>studentResults= new List<StudentResult>();
            studentResults.Add(new StudentResult()
            {
                studentName = "Atar",
                markObtained = 88
            });
            studentResults.Add(new StudentResult()
            {
                studentName = "Qasim",
                markObtained = 66
            });
            studentResults.Add(new StudentResult()
            {
                studentName = "Abdul Hanan",
                markObtained = 77
            });
            studentResults.Add(new StudentResult()
            {
                studentName = "Haaanain Ahmad",
                markObtained = 95
            });
            studentResults.Add(new StudentResult()
            {
                studentName = "Hazma",
                markObtained = 90
            });
            return studentResults;
        }
    }
}