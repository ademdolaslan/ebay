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

    public partial class Employees
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employees()
        {
            this.Employees1 = new HashSet<Employees>();
            this.Orders = new HashSet<Orders>();
            this.Territories = new HashSet<Territories>();
        }

        [Display(Name = "Personel Numaras�")]
        public int EmployeeID { get; set; }
        [Display(Name = "Personel Soyad�")]
        public string LastName { get; set; }
        [Display(Name = "Personel Ad�")]
        public string FirstName { get; set; }
        [Display(Name = "Personel Bran�")]
        public string Title { get; set; }
        [Display(Name = "Personel �nvan")]
        public string TitleOfCourtesy { get; set; }
        [Display(Name = "Do�um Tarihi")]
        public Nullable<System.DateTime> BirthDate { get; set; }
        [Display(Name = "��kar�lma Tarihi")]
        public Nullable<System.DateTime> HireDate { get; set; }
        [Display(Name = "Adres")]
        public string Address { get; set; }
        [Display(Name = "�ehir")]
        public string City { get; set; }
        [Display(Name = "B�lge")]
        public string Region { get; set; }
        [Display(Name = "Posta Kodu")]
        public string PostalCode { get; set; }
        [Display(Name = "�lke")]
        public string Country { get; set; }
        [Display(Name = "Ev Telefonu")]
        public string HomePhone { get; set; }
        [Display(Name = "Ek A��klama")]
        public string Extension { get; set; }
        [Display(Name = "Foto�raf")]
        public byte[] Photo { get; set; }
        [Display(Name = "Notlar")]
        public string Notes { get; set; }
        [Display(Name = "Rapor")]
        public Nullable<int> ReportsTo { get; set; }
        
        public string PhotoPath { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employees> Employees1 { get; set; }
        public virtual Employees Employees2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orders> Orders { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Territories> Territories { get; set; }
    }
}