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

    public partial class Customers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customers()
        {
            this.Orders = new HashSet<Orders>();
        }
    
        [Required]
        [Display(Name ="M��teri Numaras�")]
        public string CustomerID { get; set; }

        [Required]
        [Display(Name = "�irket Ad�")]
        public string CompanyName { get; set; }

        [Required]
        [Display(Name = "M��teri Ad�")]
        public string ContactName { get; set; }

        [Required]
        [Display(Name = "M��teri A��klamas�")]
        public string ContactTitle { get; set; }

        [Required]
        [Display(Name = "M��teri Numaras�")]
        public string Address { get; set; }

        [Required]
        [Display(Name = "Adres")]
        public string City { get; set; }

        [Required]
        [Display(Name = "�ehir")]
        public string Region { get; set; }

        [Required]
        [Display(Name = "B�lge")]
        public string PostalCode { get; set; }

        [Required]
        [Display(Name = "Posta Kodu")]
        public string Country { get; set; }

        [Required]
        [Display(Name = "�lke")]
        public string Phone { get; set; }

        [Required]
        [Display(Name = "Telefon")]
        public string Fax { get; set; }

        [Required]
        [Display(Name = "Kullan�c� Ad�")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "�ifre")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Kullan�c� Tipi")]
        public string UserType { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orders> Orders { get; set; }
    }
    
}
