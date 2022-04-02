using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Windows.Forms;

namespace ExaminationSystem
{

    public partial class Course_form : Form
    {
        SqlCommand sqlComman = new SqlCommand();
        public Course_form()
        {
            InitializeComponent();
        }

        private void btn_course_Save_Click(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            Course course = new Course();
            course.course_Name = "Pssshp";
            course.Duration = 3;
            //db.Courses.Add(course);
            //  db.SaveChanges();
            int  x =0;
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@TF",3),
                new SqlParameter("@mcq",7),
                new SqlParameter("@Crs",100),
                new SqlParameter("@E_id", x), 
                 };
            var rest =   db.Database.ExecuteSqlCommand( "execute uu ");
            Console.WriteLine(rest.ToString());
        }
    }
}
