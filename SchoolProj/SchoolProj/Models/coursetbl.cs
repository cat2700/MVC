//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchoolProj.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class coursetbl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public coursetbl()
        {
            this.enrolltbls = new HashSet<enrolltbl>();
        }
    
        public int id { get; set; }
        public string title { get; set; }
        public string credit { get; set; }
        public string description { get; set; }
        public Nullable<int> price { get; set; }
        public Nullable<CourseLevels> level { get; set; }
        public bool isactive { get; set; }
        public Nullable<RatingLevels> rating { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<enrolltbl> enrolltbls { get; set; }
    }
}
