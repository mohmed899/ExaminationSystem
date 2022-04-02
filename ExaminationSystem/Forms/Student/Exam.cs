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
using System.Diagnostics;
namespace ExaminationSystem.Forms.Student
{
    public partial class Exam : Form
    {
        int CurrentQuestionIndex = 0;
        List<ExamList> QuestionList;
        int m,s ,Exam_id , Student_id;
       


        public Exam( int ExamId , int st_id )
        {
            InitializeComponent();
            QuestionList = new List<ExamList>();
            m = 15;
            s = 59;
           Exam_id = ExamId;
           Student_id = st_id;
           
        }

        private void Exam_Load(object sender, EventArgs e)
        {
            
            using (var db = new context())
            {
                SqlParameter sqlpram = new SqlParameter()
                {
                    ParameterName = "@Exam_Id",
                    DbType = DbType.Int32,
                    Value = Exam_id
                };

                List<ExamList> examList = db.Database.SqlQuery<ExamList>("execute getQuestionBody @Exam_Id", sqlpram).ToList();
                QuestionList = QuestionFormater(examList);
            }
            displayQuestion();
            //handel navigator Btns
            AssginBtnNavocatorHandler();
            timer1.Start();

        }


        //helper fun

        List<ExamList> QuestionFormater(List<ExamList> list)
        {
            List<ExamList> resList = new List<ExamList>();
            foreach (var q in list)
            {

                foreach (var a in list.FindAll(qq => qq.Q_body == q.Q_body))
                {
                    q.QAnswers.Add(a.Ans_body);

                }
                if (resList.Where(cq => cq.Q_id == q.Q_id).SingleOrDefault() == null)
                    resList.Add(q);

            }
            return resList;
        }

        void displayQuestion()
        {
            lab_Question_body.Text = QuestionList[CurrentQuestionIndex].Q_body+"   (10  Marks)   ";

            //clear Question answers ( the panla)
            flp_answers.Controls.Clear();
            foreach (var ans in QuestionList[CurrentQuestionIndex].QAnswers)
            {
                var r = new RadioButton();
                r.Text = ans;
                r.Width = 1000;
                if(QuestionList[CurrentQuestionIndex].StudentAnswer!= null)
                if(r.Text[0] == QuestionList[CurrentQuestionIndex].StudentAnswer[0])
                    r.Checked = true;   
                r.CheckedChanged += ChoseAnswer;
                flp_answers.Controls.Add(r);
            }


            //next _ previous satates
            btn_prvious.Enabled = CurrentQuestionIndex == 0 ? false : true;
            Btn_next.Enabled = CurrentQuestionIndex == 9 ? false : true;

        }

        void ChoseAnswer( object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;
            if (radio.Checked == true)           
                QuestionList[CurrentQuestionIndex].StudentAnswer = radio.Text.Split(')')[0];
     

            //change Question btn color 

            flp_btnS_NQuestion.Controls[CurrentQuestionIndex].BackColor = Color.FromArgb(3,218,197);
            flp_btnS_NQuestion.Controls[CurrentQuestionIndex].ForeColor = Color.Black;

        }

        private void Btn_next_Click(object sender, EventArgs e)
        {
            if (CurrentQuestionIndex != 10)
                CurrentQuestionIndex = (++CurrentQuestionIndex) % 10;

            displayQuestion();

        }

        private void btn_prvious_Click(object sender, EventArgs e)
        {

               if (CurrentQuestionIndex != 0)
                CurrentQuestionIndex = (--CurrentQuestionIndex) % 10;
            displayQuestion();

        }

        void NavigateQuestion(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            CurrentQuestionIndex = int.Parse(btn.Text) - 1;
            displayQuestion();
        }

        void AssginBtnNavocatorHandler()
        {
            foreach (Button b in flp_btnS_NQuestion.Controls)
            {
                b.Click += NavigateQuestion;
                b.BackColor = Color.FromArgb(1, 9, 31);
            }
        }

        private void btn_finish_Click(object sender, EventArgs e)
        {
            AssignStudentAnswer();
            // display result 

            StudentResult result = new StudentResult(Exam_id, Student_id);
            this.Hide();
            result.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (m == 0 && s == 0) 
                this.Close();
            else
            {
                if (s == 0)
                {
                    m--;
                    s = 59;
                }
                else
                    s--;
            }

            L_Timer.Text = $"min: {m} , second: {s}";
        }

        void AssignStudentAnswer()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("answer", typeof(string));
            dt.Columns.Add("Q_Id", typeof(int));

            //store stusdent ans
            foreach( var q in QuestionList)
            {
                dt.Rows.Add(q.StudentAnswer, q.Q_id);

            }

           

            context db = new context();
            SqlParameter parameter = new SqlParameter
            {
                ParameterName = "@table",
                SqlDbType = SqlDbType.Structured,
                TypeName = "dbo.QuestionAnswer",
                Value = dt
            };
            SqlParameter parameter1 = new SqlParameter
            {
                ParameterName = "@st_id",
                SqlDbType = SqlDbType.Int,
                Value = Student_id
            };
            SqlParameter parameter2 = new SqlParameter
            {
                ParameterName = "@Ex_id",
                SqlDbType = SqlDbType.Int,
                Value = Exam_id
            };

            db.Database.ExecuteSqlCommand("execute  assignAnswer @table, @st_id,@Ex_id ", parameter, parameter1, parameter2);
            
        }


    }
}
