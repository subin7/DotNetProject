//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinalKist.Models.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Book
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Book()
        {
            this.issues = new HashSet<issue>();
        }
    
        public string Id { get; set; }
        public string title { get; set; }
        public string PublicationId { get; set; }
        public string AuthorId { get; set; }
        public Nullable<decimal> Price { get; set; }
        public string Edition { get; set; }
        public Nullable<System.DateTime> PublishDate { get; set; }
        public string Genre { get; set; }
    
        public virtual Author Author { get; set; }
        public virtual publication publication { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<issue> issues { get; set; }
    }
}
