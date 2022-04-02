using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ExaminationSystem
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Exam> Exams { get; set; }
        public virtual DbSet<Instructor> Instructors { get; set; }
        public virtual DbSet<QestionAnswer> QestionAnswers { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Stu_course> Stu_course { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Student_Exam_Question> Student_Exam_Question { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Topic> Topics { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>()
                .HasMany(e => e.Stu_course)
                .WithRequired(e => e.Course)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.Topics)
                .WithRequired(e => e.Course)
                .HasForeignKey(e => e.course_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.Instructors)
                .WithMany(e => e.Courses)
                .Map(m => m.ToTable("Ins_Course").MapLeftKey("Crs_Id").MapRightKey("Ins_Id"));

            modelBuilder.Entity<Department>()
                .HasMany(e => e.Instructors)
                .WithRequired(e => e.Department)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Department>()
                .HasMany(e => e.Students)
                .WithRequired(e => e.Department)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Exam>()
                .HasMany(e => e.Student_Exam_Question)
                .WithRequired(e => e.Exam)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Instructor>()
                .Property(e => e.Ins_Salary)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Question>()
                .HasMany(e => e.QestionAnswers)
                .WithRequired(e => e.Question)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Question>()
                .HasMany(e => e.Student_Exam_Question)
                .WithRequired(e => e.Question)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Student>().MapToStoredProcedures()
                .HasMany(e => e.Stu_course)
                .WithRequired(e => e.Student)
                .WillCascadeOnDelete(false);
        }
    }
}
