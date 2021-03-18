using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Ucommerce.Masterclass.Models
{
    public class MasterClassHomeController : Controller
    { 
        public ActionResult Index()
        {
            return View();
        }
    }
}