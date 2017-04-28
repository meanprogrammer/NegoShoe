using NegoShoePH.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NegoshoePH.Web.Controllers
{
    public class SQLExecutorController : Controller
    {
        SQLData sqlData;

        public SQLExecutorController()
        {
            sqlData = new SQLData();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Reset()
        {
            sqlData.ResetDatabase();
            return View();
        }

        public ActionResult Execute(string query)
        {
            var ar = sqlData.Execute(query);
            ViewBag.AffectedRows = ar;
            return View();
        }
    }
}