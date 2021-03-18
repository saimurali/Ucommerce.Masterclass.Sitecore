using System.Web.Mvc;
using Ucommerce.Api;
using Ucommerce.Infrastructure;

namespace Ucommerce.Masterclass.Models
{
    public class MasterClassShippingController : Controller
    {
        [System.Web.Mvc.HttpGet]
        public ActionResult Index()
        {
            var shippingViewModel = new ShippingViewModel();
            
            return View(shippingViewModel);
        }


        [HttpPost]
        public ActionResult Index(int SelectedShippingMethodId)
        {
            return Redirect("/payment");
        }
    }
}