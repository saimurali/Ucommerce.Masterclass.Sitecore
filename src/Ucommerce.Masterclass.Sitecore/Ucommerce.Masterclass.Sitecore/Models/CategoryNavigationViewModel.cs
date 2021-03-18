using System;
using System.Collections.Generic;

namespace Ucommerce.Masterclass.Models
{
    public class CategoryNavigationViewModel
    {
        public CategoryNavigationViewModel()
        {
            Categories = new List<CategoryViewModel>();
        }
        public IList<CategoryViewModel> Categories { get; set; } 
        
        public Guid CurrentCategoryGuid { get; set; }
    }
}