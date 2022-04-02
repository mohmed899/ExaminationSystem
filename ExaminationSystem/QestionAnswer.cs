namespace ExaminationSystem
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QestionAnswer")]
    public partial class QestionAnswer
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(100)]
        public string Ans_body { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Q_Id { get; set; }

        public virtual Question Question { get; set; }
    }
}
