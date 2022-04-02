using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationSystem
{
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
        }
         void loadform(Form f)
        {
            if (this.main_panel.Controls.Count > 0)
                this.main_panel.Controls.RemoveAt(0);
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

        private void main_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
