namespace ExaminationSystem
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Topic")]
    public partial class Topic
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Top_Id { get; set; }

        [StringLength(100)]
        public string Top_Name { get; set; }

        public int course_Id { get; set; }

        public virtual Course Course { get; set; }
    }
}
