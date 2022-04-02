namespace ExaminationSystem.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Question")]
    public partial class Question
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Question()
        {
            QestionAnswers = new HashSet<QestionAnswer>();
            Student_Exam_Question = new HashSet<Student_Exam_Question>();
        }

        [Key]
        public int Q_Id { get; set; }

        [Required]
        [StringLength(1000)]
        public string Q_body { get; set; }

        [StringLength(10)]
        public string Q_Type { get; set; }

        public int? mark { get; set; }

        [Required]
        [StringLength(50)]
        public string Right_Ans { get; set; }

        public int? Crs_Id { get; set; }

        public virtual Course Course { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QestionAnswer> QestionAnswers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student_Exam_Question> Student_Exam_Question { get; set; }
    }
}
