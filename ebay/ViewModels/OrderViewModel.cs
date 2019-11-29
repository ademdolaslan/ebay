using ebay.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ebay.ViewModels
{
    public class OrderViewModel
    {
        public Orders orders { get; set; }
        public IEnumerable<Employees> employees { get; set; }
        public IEnumerable<Customers> customers { get; set; }
        public IEnumerable<Shippers> shippers { get; set; }
    }
}