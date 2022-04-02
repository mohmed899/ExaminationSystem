using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExaminationSystem.model;
using System.Data.SqlClient;

namespace ExaminationSystem
{
    public partial class Course_form : Form
    {
        context db;
        public Course_form()
        {
            InitializeComponent();
            db = new context();
        }

  

        private void btn_course_Save_Click(object sender, EventArgs e)
        {
            var course = db.Courses.Where(c => c.course_Name == txt_CourseName.Text).ToList().SingleOrDefault();
            if (txt_CourseName.Text != "")
            {
                if (course == null)
                {
                    Course c = new Course();

                    SqlParameter parameter2 = new SqlParameter
                    {
                        ParameterName = "@crs_name",
                        SqlDbType = SqlDbType.NVarChar,
                        Value = txt_CourseName.Text
                    };
                    SqlParameter parameter3 = new SqlParameter
                    {
                        ParameterName = "@duration_crs",
                        SqlDbType = SqlDbType.Int,
                        Value = (int)numeric_course_Duration.Value
                    };
                    db.Database.ExecuteSqlCommand("execute  insert_courses @crs_name,@duration_crs", parameter2, parameter3);

                    lbl_crs_name.Text = "Done";
                    lbl_crs_name.ForeColor = Color.Green;
                    txt_CourseName.Text = "";
                    numeric_course_Duration.Text = "0";

                }
                else
                {
                    lbl_crs_name.Text = "course_name has already existed before";
                    lbl_crs_name.ForeColor = Color.Red;
                }

            }
            else
            {
                lbl_crs_name.Text = "course_name Name is Required";
                lbl_crs_name.ForeColor = Color.Red;
            }
        }
    }
}

