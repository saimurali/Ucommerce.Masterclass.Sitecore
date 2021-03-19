using System.Web.Mvc;


namespace Ucommerce.Masterclass.Models
{
    public class MasterClassProductSearchController : Controller
    {
        public ActionResult ProductSearch()
        {
            return View("/views/MasterClassProductSearch/index.cshtml");
        }
    }
}