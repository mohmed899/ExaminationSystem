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

namespace ExaminationSystem
{
    public partial class Department_form : Form
    {
        public Department_form()
        {
            InitializeComponent();
        }

        private void Department_form_Load(object sender, EventArgs e)
        {

        }


        bool valideatFildNotEmpety(TextBox text, string errorMessage)
        {
            if (text.Text == "")
            {
                error.SetError(text, errorMessage);
                return false;
            }
            return true;
        }

        private void btn_Dept_Save_Click(object sender, EventArgs e)
        {
            if(
                valideatFildNotEmpety(txt_dept_Name,"cant be empety")
                &&
                valideatFildNotEmpety(txt_dept_locatoin, "cant be empety")
                &&
                valideatFildNotEmpety(txt_dept_Description, "cant be empety")
                )
            {
                SqlParameter p1 = new SqlParameter
                {
                    ParameterName = "@deptName",
                    SqlDbType = SqlDbType.NVarChar,
                    Value = txt_dept_Name.Text,

                };

                SqlParameter p2 = new SqlParameter
                {
                    ParameterName = "@deptlocation",
                    SqlDbType = SqlDbType.NVarChar,
                    Value = txt_dept_locatoin.Text,

                };
                SqlParameter p3 = new SqlParameter
                {
                    ParameterName = "@deptdes",
                    SqlDbType = SqlDbType.NVarChar,
                    Value = txt_dept_Description.Text,

                };

                using ( var db = new context() )
                {
                    db.Database.ExecuteSqlCommand("exec instdept @deptName,@deptdes,@deptlocation", p1, p3, p2);
                }
                MessageBox.Show("Done");
            }
        }
    }
}
