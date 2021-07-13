using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aspnet_mvc.Controllers
{
    public class homrController : Controller
    {
        // GET: homr
        public ActionResult Index()
        {
            return View();
        }
    }
}