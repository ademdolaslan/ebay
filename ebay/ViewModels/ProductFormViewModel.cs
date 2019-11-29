using ebay.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ebay.ViewModels
{
    public class ProductFormViewModel
    {
        public IEnumerable<Suppliers> _Suppliers { get; set; }
        public IEnumerable<Categories> _Categories { get; set; }
        public Products _Products { get; set; }
    }
}