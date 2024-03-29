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

    public partial class Products
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Products()
        {
            this.Order_Details = new HashSet<Order_Details>();
        }
        [Required]
        [Display(Name = "�r�n Numaras�")]
        public int ProductID { get; set; }

        [Required]
        [Display(Name = "�r�n Ad�")]
        public string ProductName { get; set; }

        [Required]
        [Display(Name = "Tedarik�i Numaras�")]
        public Nullable<int> SupplierID { get; set; }

        [Required]
        [Display(Name = "Kategori Numaras�")]
        public Nullable<int> CategoryID { get; set; }

        [Required]
        [Display(Name = "Birim Ba��na Miktar")]
        public string QuantityPerUnit { get; set; }

        [Required]
        [Display(Name = "Birim Fiyat�")]
        public Nullable<decimal> UnitPrice { get; set; }

        [Display(Name = "Stoktaki �r�n Say�s�")]
        public Nullable<short> UnitsInStock { get; set; }

        [Display(Name = "Sipari�teki �r�n Say�s�")]
        public Nullable<short> UnitsOnOrder { get; set; }

        [Display(Name = "�ade D�zeyi")]
        public Nullable<short> ReorderLevel { get; set; }

        [Required]
        [Display(Name = "Durumu")]
        public bool Discontinued { get; set; }
    
        public virtual Categories Categories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order_Details> Order_Details { get; set; }
        public virtual Suppliers Suppliers { get; set; }
    }
}
