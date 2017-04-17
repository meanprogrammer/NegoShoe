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

        public ActionResult Execute(string query)
        {
            sqlData.Execute(query);
            return View();
        }
    }
}