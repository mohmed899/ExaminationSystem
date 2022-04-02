using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExaminationSystem.model;
namespace ExaminationSystem
{
    public partial class Topic_form : Form
    {
        context db;
        public Topic_form()
        {
            InitializeComponent();
            db = new context();
        }

        private void Topic_form_Load(object sender, EventArgs e)
        {
            var coursename = db.Courses.ToList();
            cb_Courses.DataSource = coursename;
            cb_Courses.DisplayMember = "course_Name";
            cb_Courses.ValueMember = "Crs_Id";
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_topic_save_Click(object sender, EventArgs e)
        {
            var topic = db.Topics.Where(t => t.Top_Name == txt_Topic_Name.Text).ToList().SingleOrDefault();
            if (txt_Topic_Name.Text != "")
            {
                if (topic == null)
                {
                    Topic topic1 = new Topic();
                    SqlParameter parameter1 = new SqlParameter
                    {
                        ParameterName = "@crs_id",
                        SqlDbType = SqlDbType.Int,
                        Value = (int)cb_Courses.SelectedValue
                    };

                    SqlParameter parameter3 = new SqlParameter
                    {
                        ParameterName = "@topicname",
                        SqlDbType = SqlDbType.NVarChar,
                        Value = txt_Topic_Name.Text
                    };
                    db.Database.ExecuteSqlCommand("execute insert_topic  @crs_id ,@topicname", parameter1, parameter3);
                    lbl_name.Text = "Done";
                    lbl_name.ForeColor = Color.Green;
                    txt_Topic_Name.Text = "";

                }
                else
                {
                    lbl_name.Text = "topic_name has already existed before";
                    lbl_name.ForeColor = Color.Red;
                }

            }
            else
            {
                lbl_name.Text = "topic_name Name is Required";
                lbl_name.ForeColor = Color.Red;
            }


        }

      
    }
}
