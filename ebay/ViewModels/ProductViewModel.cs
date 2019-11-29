using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ebay.Models.EntityFramework;

namespace ebay.ViewModels
{
    public class ProductViewModel
    {
        public Products products { get; set; }
        public IEnumerable<Suppliers> suppliers { get; set; }
        public IEnumerable<Categories> categories { get; set; }

    }
}