using Calander_test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Calander_test.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetCalanderData(string month) 
        {
            List<DataModel> listModels = new List<DataModel>();

            listModels.Add(new DataModel(){start = "2014-03-01", end = "2014-03-02", title = "kumara"});
            listModels.Add(new DataModel() { start = "2014-03-05", title = "<p><b>This text is bold</b></p>" });

            return Json(listModels.ToArray(), JsonRequestBehavior.AllowGet);
        }

    }
}
