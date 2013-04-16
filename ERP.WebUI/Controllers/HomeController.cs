using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
// add new references
using ERP.WebUI.Models;

namespace ERP.WebUI.Controllers
{
    public class HomeController : Controller
    {        
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CreateEvent() 
        { 
            return View(); 
        }
    }
}
