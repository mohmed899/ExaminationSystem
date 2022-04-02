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
using ExaminationSystem.model;

namespace ExaminationSystem.Forms.Student
{
    public partial class StudentResult : Form
    {
        int Examid ;
        int StudentId;
        public StudentResult(int Exam_id, int Student_id)
        {
            InitializeComponent();
            this.Examid = Exam_id;
            this.StudentId = Student_id;
        }



        private void StudentResult_Load(object sender, EventArgs e)
        {
            SqlParameter Exam_id = new SqlParameter
            {
                ParameterName = "@ExamID",
                SqlDbType = SqlDbType.Int,              
                Value = Examid
            };
            SqlParameter Student_id = new SqlParameter
            {
                ParameterName = "@StudentID",
                SqlDbType = SqlDbType.Int,
                Value = StudentId
            };

            SqlParameter totalMarkk = new SqlParameter
            {
                ParameterName = "@TotalMark",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Output,
               
            };


            using (var db = new context())
            {
                int totalMark = db.Database.SqlQuery<int>("exec correctExam @ExamID,@StudentID,@TotalMark", Exam_id, Student_id, totalMarkk).First();
                ExaminationSystem.model.Student student = db.Students.Where(st => st.ST_Id == StudentId).SingleOrDefault();

                displayResult(totalMark, student.St_Fname + " " + student.St_Lname);
            }

            void displayResult(int total, string stName)
            {
                lb_studentgrade.Text = total.ToString();
                lb_studnetName.Text = stName;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(
                                    "Are you sure you want to start start new Exam ??",
                                    "Confirm Exam start!!??",
                                    MessageBoxButtons.YesNo
                                    );
            if (confirmResult == DialogResult.Yes)
            {
               this.Hide();
                new student_info(StudentId).Show(); 
            }
            else
            {
                MessageBox.Show("when cancel");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(
                                   "Are you sure you want to close the program ??",
                                   "Confirm close program!!??",
                                   MessageBoxButtons.YesNo
                                   );
            if (confirmResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
