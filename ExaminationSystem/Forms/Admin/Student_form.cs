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
namespace ExaminationSystem
{
    public partial class txt_Fname : Form
    {
        context db;
        public txt_Fname()
        {
            InitializeComponent();
            db = new context();

        }

        private void txt_Fname_Load(object sender, EventArgs e)
        {
            cb_student_course.DisplayMember = "course_Name";
            cb_student_course.ValueMember = "Crs_id";
            cb_student_course.DataSource = db.Courses.ToList();


            cb_department.DisplayMember = "Dept_Name";
            cb_department.ValueMember = "Dept_id";
            cb_department.DataSource = db.Departments.ToList();

        }

        private void btn_student_Save_Click(object sender, EventArgs e)
        {
            error.Clear();

            if( 
                valideatFildNotEmpety(txt_Fame,"f name cant be empety ")
                &&
                valideatFildNotEmpety(txt_Lname, "last name cant be empety ")
                &&
                valideatFildNotEmpety(txt_Address, " Adress cant be empety ")
                &&
                valideatFildNotEmpety(txt_age, "age cant be empety ")
                &&
                valideatFildNotEmpety(txt_username, "mail  name cant be empety ")
                &&
                valideatFildNotEmpety(txt_password, "password name cant be empety ")
                &&
                validetMail()
                )
            {
                Student s = new Student();
                s.St_Fname = txt_Fame.Text;
                s.St_Lname = txt_Lname.Text;
                s.St_Address = txt_Address.Text;
                s.St_Age = int.Parse(txt_age.Text);
                s.Dept_id = (int)cb_department.SelectedValue;
                s.password = txt_password.Text;
                s.Mail = txt_username.Text;
                db.Students.Add(s);
                db.SaveChanges();
            //clear feilds
                txt_Fame.Text = txt_Lname.Text = txt_age.Text = txt_Address.Text = txt_username.Text = txt_password.Text = "";
                MessageBox.Show("added Student");
            }

          
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        bool validetMail()
        {
            var student = db.Students.Where(s => s.Mail == txt_username.Text).SingleOrDefault();
            if (student == null)
                return true;
            else
            {
                error.SetError(txt_username, "email exist ");
                return false;
            }
        }


        bool valideatFildNotEmpety (TextBox text,string errorMessage)
        {
            if (text.Text == "")
            {
                error.SetError(text, errorMessage);
                return false;
            }
            return true;
        }

    }
}
