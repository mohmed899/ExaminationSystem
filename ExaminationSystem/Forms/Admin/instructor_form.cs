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
    public partial class instructor_form : Form
    {

        context db;
        public instructor_form()
        {
            InitializeComponent();
            db = new context();
        }

        private void instructor_form_Load(object sender, EventArgs e)
        {
            cb_inst_department.DisplayMember = "Dept_Name";
            cb_inst_department.ValueMember = "Dept_id";
            cb_inst_department.DataSource = db.Departments.ToList();


        }

        private void btn_inst_save_Click(object sender, EventArgs e)
        {
            if (
                valideatFildNotEmpety(txt_inst_name, "cant be empety ")
                &&
                 valideatFildNotEmpety(txt_inst_salary, "cant be empety ")
                 &&
                  valideatFildNotEmpety(txt_email, "cant be empety ")
                  &&
                   valideatFildNotEmpety(txt_inst_degree, "cant be empety ")
                   &&
                    valideatFildNotEmpety(txt_password, "cant be empety ")
                    &&
                     validetMail()
                )
            {
                Instructor ins = new Instructor();
                ins.Ins_Name = txt_inst_name.Text;
                ins.Ins_Salary = decimal.Parse(txt_inst_salary.Text);
                ins.Ins_Degree = txt_inst_degree.Text;
                ins.Dept_Id = (int)cb_inst_department.SelectedValue;
                ins.mail= txt_email.Text;
                ins.password= txt_password.Text;    
                db.Instructors.Add(ins);
                db.SaveChanges();
                txt_inst_name.Text = txt_inst_salary.Text = txt_inst_degree.Text  = txt_email.Text= txt_password.Text= "";
                MessageBox.Show("done");
            }

        }

        bool valideatFildNotEmpety(TextBox textbox, string errorMessage)
        {
            if (textbox.Text == "")
            {
                error.SetError(textbox, errorMessage);
                return false;
            }
            return true;
        }

        bool validetMail()
        {
            var student = db.Instructors.Where(s => s.mail == txt_email.Text).SingleOrDefault();
            if (student == null)
                return true;
            else
            {
                error.SetError(txt_email, "email exist ");
                return false;
            }
        }

    }
}
