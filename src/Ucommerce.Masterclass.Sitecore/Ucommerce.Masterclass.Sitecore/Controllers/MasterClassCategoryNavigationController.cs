using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Mvc;
using Ucommerce.Api;
using Ucommerce.Infrastructure;
using Ucommerce.Masterclass.Models;
using Ucommerce.Search;
using Ucommerce.Search.Models;
using Ucommerce.Search.Slugs;


namespace Ucommerce.Masterclass.Models
{
    public class MasterClassCategoryNavigationController : Controller
    {
        public ActionResult CategoryNavigation()
        {
            var model = new CategoryNavigationViewModel();

            return View("/views/CategoryNavigation/index.cshtml", model);
        }

        private IList<CategoryViewModel> MapCategories(IList<Category> categories)
        {
            return new List<CategoryViewModel>();
        }
    }
}