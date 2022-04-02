namespace ExaminationSystem.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Instructor")]
    public partial class Instructor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Instructor()
        {
            Courses = new HashSet<Course>();
        }

        [Key]
     
        public int Ins_Id { get; set; }

        [StringLength(100)]
        public string Ins_Name { get; set; }

        [Column(TypeName = "money")]
        public decimal Ins_Salary { get; set; }

        [StringLength(100)]
        public string Ins_Degree { get; set; }

        [StringLength(100)]
        public string mail { get; set; }

        [StringLength(100)]
        public string password { get; set; }


        public int Dept_Id { get; set; }

        public virtual Department Department { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Course> Courses { get; set; }
    }
}
