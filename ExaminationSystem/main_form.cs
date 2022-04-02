using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExaminationSystem.Forms.Instractor;
using ExaminationSystem.Forms.Admin;
namespace ExaminationSystem
{
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
        }
        public void loadform(object Form)
        {
            if (this.main_panel.Controls.Count > 0)
                this.main_panel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.main_panel.Controls.Add(f);
            this.main_panel.Tag = f;
            f.Show();
        }

        private void main_form_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Student_Click(object sender, EventArgs e)
        {
            loadform(new txt_Fname());
        }

        private void btn_Course_Click(object sender, EventArgs e)
        {
            loadform(new Course_form());
        }

        private void btn_Department_Click(object sender, EventArgs e)
        {
            loadform(new Department_form());
        }

        private void btn_Topic_Click(object sender, EventArgs e)
        {
            loadform(new Topic_form());
        }

        private void btn_instrucror_Click(object sender, EventArgs e)
        {
            loadform(new instructor_form());
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // loadform(new GenerateExam());
        }

        private void main_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            loadform(new Reports() );
        }
    }
}
