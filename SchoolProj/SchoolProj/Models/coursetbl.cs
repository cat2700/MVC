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
    using System.ComponentModel.DataAnnotations;

    public partial class coursetbl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public coursetbl()
        {
            this.enrolltbls = new HashSet<enrolltbl>();
        }
    
        public int id { get; set; }
        [Required (ErrorMessage ="���� �� ���� �������")]
        public string title { get; set; }
        [Required(ErrorMessage = "�� ����� ��� �������")]
        [Range(2,6,ErrorMessage ="Should Between 2 And 6")]
        public string credit { get; set; }
        [Display(Name ="�����")]
        public string description { get; set; }
        public Nullable<int> price { get; set; }
        [Required(ErrorMessage ="Select From List")]
        [EnumDataType(typeof(CourseLevels),ErrorMessage ="���� �� ����")]
        public Nullable<CourseLevels> level { get; set; }
        public bool isactive { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<enrolltbl> enrolltbls { get; set; }
    }
}
