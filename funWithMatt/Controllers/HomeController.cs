using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace funWithMatt.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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
        public ActionResult CustomLogin()
        {
            FunClassFun.DatabaseExamples.InsertUsingSqlString();

            

                return View();
        }
        public ActionResult CallStoredProcedure()
        {
            FunClassFun.DatabaseExamples.InsertUsingStoredProcedure();

            return View();

        }

        public ActionResult Read()
        {

           var users =  FunClassFun.DatabaseExamples.ReadAllUsers();

            return View(users);
        }

       
    }
}