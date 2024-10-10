using ControllerToView_April071024.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllerToView_April071024.Controllers
{
    public class HTMLhelperDemoController : Controller
    {
        public ActionResult dd1()
        {
            student s1 = new student() { roll = 1, name = "rajesh" };
            return View();
        }
        public ActionResult demo()
        {// ADO.net code
            SqlConnection con = new SqlConnection("Data Source=Desktop-ABKHEEV;Initial Catalog=tempdb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            SqlDataAdapter adp = new SqlDataAdapter("select * from tblStudent", con);
            SqlCommandBuilder cmdb = new SqlCommandBuilder(adp);
            DataSet ds = new DataSet();
            adp.Fill(ds, "tblStudent");

            student s1 = new student();

            s1.roll = (int)ds.Tables["tblStudent"].Rows[0][0];
            s1.name = (string)ds.Tables["tblStudent"].Rows[0][1];
            return View(s1);



            /*student s1 = new student();
            s1.roll = 1;
            s1.name = "rajesh";
            
            return View(s1);
        */
            }
        // GET: HTMLhelperDemo
        [HttpGet]
        public ActionResult EmpReg()
        {
            return View();
        }
        [HttpPost]
        public ActionResult EmpReg(string empid,string empname)
        {
            return View();
        }
        public ActionResult StudReg()
        {
            return View();
        }
        [HttpPost]
        public ActionResult StudReg(student s1,string isNewAddmission)
        {
            return View();
        }
    }
}