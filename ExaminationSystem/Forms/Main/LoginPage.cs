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
using ExaminationSystem.Forms.Student;
using ExaminationSystem.Forms.Instractor;
using System.Data.Entity;

namespace ExaminationSystem.Forms.Main
{
    public partial class LoginPage : Form
    {
        
        
        public LoginPage()
        {
            InitializeComponent();
            //some init
          
            Txt_pass.PasswordChar= '*';
            
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rButton1_Click(object sender, EventArgs e)
        {
            error.Clear();

            if (rb_amin.Checked)
            {
                if (txt_Mail.Text != "admin")
                {
                    error.SetError(txt_Mail, "invalid user");
                    return;
                }
                if(Txt_pass.Text != "admin")
                {
                    error.SetError(Txt_pass, "invalid password");
                    return;
                }
                this.Hide();
                new main_form().Show();
            }
            else if (rb_instructor.Checked)
            {
                Instructor ins =null;
                using (var db = new context())
                {
                    ins= db.Instructors.Where(i=>i.mail==txt_Mail.Text).SingleOrDefault();
                    if (ins==null)
                    {
                        error.SetError(txt_Mail, "invalid user");
                        return;
                    }
                    else if(ins.password!=Txt_pass.Text)
                    {
                        error.SetError(Txt_pass, "invalid password");
                        return;
                    }

                }
                    this.Hide();
                    new GenerateExam(ins.Ins_Id).Show();
            }
            else if (rb_student.Checked)
            {
                ExaminationSystem.model.Student stu = null;
                using (var db = new context())
                {
                    stu = db.Students.Where(i => i.Mail == txt_Mail.Text).SingleOrDefault();
                    if (stu == null)
                    {
                        error.SetError(txt_Mail, "invalid user");
                        return;
                    }
                    else if (stu.password != Txt_pass.Text)
                    {
                        MessageBox.Show(stu.password);
                        error.SetError(Txt_pass, "invalid password");
                        return;
                    }

                }
                this.Hide();
                new student_info(stu.ST_Id).Show();
            }
            else
            {
                error.SetError(gb, "u must select role");
            }

        }
       
    }
}
