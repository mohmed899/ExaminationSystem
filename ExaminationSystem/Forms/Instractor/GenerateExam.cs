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

namespace ExaminationSystem.Forms.Instractor
{
    public partial class GenerateExam : Form
    {
        context db;
        int instructor_id;
        public GenerateExam(int isn_id)
        {
            InitializeComponent();
            db =new context();
            instructor_id = isn_id;
        }

        private void GenerateExam_Load(object sender, EventArgs e)
        {
            loadCourses();
          
        }
        void loadCourses()
        {
            var course = db.Instructors.Where(i => i.Ins_Id == instructor_id).SingleOrDefault().Courses.ToList();
            cb_coursegenerate.DataSource = course;
            cb_coursegenerate.ValueMember = "Crs_Id";
            cb_coursegenerate.DisplayMember = "course_Name";
        }
     

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            var qmcq = (decimal)tfvalue.Value;
            if (qmcq <= 10)
            {
                mcqvalue.Value = 10 - qmcq;
            }
            else
            {
                MessageBox.Show("requirred number between 0 to 10");
                tfvalue.Value = 0;
            }
           
        }

        private void mcqvalue_ValueChanged(object sender, EventArgs e)
        {

            var qtf= (decimal)mcqvalue.Value;
            if (qtf <= 10)
            {
                tfvalue.Value = 10 - qtf;
            }
            else
            {
                MessageBox.Show("requirred number between 0 to 10");
                mcqvalue.Value = 0;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
           
        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            
            SqlParameter parameter1 = new SqlParameter
            {
                ParameterName = "@Crs_number",
                SqlDbType = SqlDbType.Int,
                Value = (int)cb_coursegenerate.SelectedValue
            };
            SqlParameter parameter2 = new SqlParameter()
            {
                ParameterName = "@TF_number",
                SqlDbType = SqlDbType.Int,
                Value = tfvalue.Value
            };
            SqlParameter parameter3 = new SqlParameter()
            {
                ParameterName = "@MCQ_number",
                SqlDbType = SqlDbType.Int,
                Value = mcqvalue.Value
            };
            db.Database.ExecuteSqlCommand("execute genExam @TF_number,@MCQ_number, @Crs_number", parameter2, parameter3, parameter1);

            tfvalue.Value = 0;
            mcqvalue.Value= 0;

            MessageBox.Show("done");
        }
    }
}
