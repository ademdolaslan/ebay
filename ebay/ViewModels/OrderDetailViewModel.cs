using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ebay.Models.EntityFramework;

namespace ebay.ViewModels
{
    public class OrderDetailViewModel
    {
        public Order_Details order_Details { get; set; }
        public IEnumerable<Orders> orders { get; set; }
        public IEnumerable<Products> MyProperty { get; set; }
    }
}