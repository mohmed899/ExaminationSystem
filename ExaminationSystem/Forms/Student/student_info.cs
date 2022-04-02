using System;
using System.Data;
using ExaminationSystem.model;
using System.Linq;
using System.Windows.Forms;

namespace ExaminationSystem.Forms.Student
{
    public partial class student_info : Form
    {
        int exam_id, studen_id;

        public student_info(int st_id)
        {
            InitializeComponent();
            studen_id = st_id;

        }
        void assignNameAndDepartment()
        {
            ExaminationSystem.model.Student student;
            using (var db = new context())
            {
                student = db.Students.Where(s => s.ST_Id == studen_id).FirstOrDefault();
                lbl_name.Text = student.St_Fname + " " + student.St_Lname;
                lbl_department.Text = student.Department.Dept_Name;
            }

        }
        void fillCourses()
        {
            context db = new context();
            var courses = db.Stu_course.
                  Where(sc => sc.St_Id == studen_id)
                  .Select(sc => new { id = sc.Course.Crs_Id, name = sc.Course.course_Name })
                    .ToList();
            courses.Insert(0, new { id = 0, name = "select course " });
            cb_course.DataSource = courses;
            cb_course.DisplayMember = "name";
            cb_course.ValueMember = "id";
        }

        void getExamId()
        {
            context db = new context();

            int course = (int)cb_course.SelectedValue;
            var query = (
                     from e in db.Exams
                     join seq in db.Student_Exam_Question on e.Exam_Id equals seq.Exam_Id
                     join q in db.Questions on seq.Q_Id equals q.Q_Id
                     where q.Crs_Id == course && seq.Stud_Ans == null
                     select new { e.Exam_Id }
                   ).FirstOrDefault();
            if (query != null)
                exam_id = query.Exam_Id;
            else
            {
                exam_id = 0;
                MessageBox.Show("no Exam for this course ");
                button1.Enabled = false;
            }
        }

        private void student_info_Load(object sender, EventArgs e)
        {
            fillCourses();
            assignNameAndDepartment();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((int)cb_course.SelectedValue != 0)
            {

                var confirmResult = MessageBox.Show(
                                    "Are you sure you want to start exam ??",
                                    "Confirm Exam start!!??",
                                    MessageBoxButtons.YesNo
                                    );
                if (confirmResult == DialogResult.Yes)
                {

                    MessageBox.Show(exam_id.ToString() + " " + studen_id.ToString());
                    Exam ex = new Exam(exam_id, studen_id);
                    this.Hide();
                    ex.Show();
                }
                else
                {
                    MessageBox.Show("when cancel");
                }
            }
            else
            {
                MessageBox.Show("select course first ");
            }

        }


        private void cb_course_SelectionChangeCommitted(object sender, EventArgs e)
        {
            button1.Enabled = true;
            getExamId();
        }
    }
}
