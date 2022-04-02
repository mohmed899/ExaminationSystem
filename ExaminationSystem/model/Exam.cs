namespace ExaminationSystem.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Exam")]
    public partial class Exam
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Exam()
        {
            Student_Exam_Question = new HashSet<Student_Exam_Question>();
        }

        [Key]
        public int Exam_Id { get; set; }

        public int N_TF { get; set; }

        public int N_Mcq { get; set; }

        public int mark { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student_Exam_Question> Student_Exam_Question { get; set; }
    }
}
