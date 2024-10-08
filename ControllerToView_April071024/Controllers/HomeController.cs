using ControllerToView_April071024.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllerToView_April071024.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Method111()
        {
            TempData["no1"] = 12345;
            student s1 = new student() { roll = 6, name = "darshan" };
            TempData["std"] = s1;
            return View();
        }
        public ActionResult Method222()
        {
            //ViewData["no"] = TempData["no1"];
            ////TempData.Keep("no1");
            ///
            //ViewBag.stud = TempData["std"];
            //// TempData.Keep("std");
            ///TempData.Keep();
            //----------use of peek()-------------

            ViewData["no"] = TempData.Peek("no1");
            ViewBag.stud = TempData.Peek("std");
            
            return View();
        }
        public ActionResult Method333()
        {
            ViewBag.number = TempData.Peek("no1");
            ViewBag.stud = TempData.Peek("std");
            return View();
        }
    }
}