using ControllerToView_April071024.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace ControllerToView_April071024.Controllers
{
    public class GTHController : Controller
    {
        // GET: GTH
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Method1()
        {
            ViewBag.warje = "GTH pune";
            List<string> list = new List<string>() { "pune","mumbai","nashik","dhule"};
            ViewBag.cityList = list;
            List<student> studs = new List<student>()
            {
                new student(){roll=1,name="rajesh"},
                new student(){roll=2,name="dinesh"},
                new student(){roll=3,name="pawan"},
                new student(){roll=4,name="mahesh"},
            };
            ViewBag.mystudents = studs;
            return View();
        }
        public ActionResult ViewDataMethod()
        {
            ViewData["no"] = 12345;
            int[] nums = new int[] { 111, 222, 333, 444, 555 };
            ViewData["NumArray"] = nums;

            student s1 = new student() { roll = 11, name = "dinesh" };
            student s2 = new student() { roll = 22, name = "pawan" };

            List<student> stds = new List<student>();
            stds.Add(s1);
            stds.Add(s2);

            ViewData["MyStudList"]= stds;
            return View();
        }
    }
}