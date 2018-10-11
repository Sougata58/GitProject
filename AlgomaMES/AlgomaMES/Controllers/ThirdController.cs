using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlgomaMES.Controllers
{
    public class ThirdController : Controller
    {
        // GET: Third
        public ActionResult Index()
        {
            string s = "sougata changd this";
            return View();
        }
    }
}