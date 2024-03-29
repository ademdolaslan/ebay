//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ebay.Models.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Orders
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Orders()
        {
            this.Order_Details = new HashSet<Order_Details>();
        }
    
        [Display(Name ="Sipari� Numaras�")]
        public int OrderID { get; set; }
        [Display(Name = "M��teri Numaras�")]
        public string CustomerID { get; set; }
        [Display(Name = "Personel Numaras�")]
        public Nullable<int> EmployeeID { get; set; }
        [Display(Name = "Sipari� Tarihi")]
        public Nullable<System.DateTime> OrderDate { get; set; }
        [Display(Name = "�stenen Tarih")]
        public Nullable<System.DateTime> RequiredDate { get; set; }
        [Display(Name = "Sevk Tarihi")]
        public Nullable<System.DateTime> ShippedDate { get; set; }
        [Display(Name = "Kargo")]
        public Nullable<int> ShipVia { get; set; }
        [Display(Name = "A��rl�k")]
        public Nullable<decimal> Freight { get; set; }
        [Display(Name = "Kargo Ad�")]
        public string ShipName { get; set; }
        [Display(Name = "Kargo Adresi")]
        public string ShipAddress { get; set; }
        [Display(Name = "Kargo �ehri")]
        public string ShipCity { get; set; }
        [Display(Name = "Kargo B�lgesi")]
        public string ShipRegion { get; set; }
        [Display(Name = "Kargo Posta Kodu")]
        public string ShipPostalCode { get; set; }
        [Display(Name = "Kargo �lkesi")]
        public string ShipCountry { get; set; }

    
        public virtual Customers Customers { get; set; }
        public virtual Employees Employees { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order_Details> Order_Details { get; set; }
        public virtual Shippers Shippers { get; set; }
    }
}
