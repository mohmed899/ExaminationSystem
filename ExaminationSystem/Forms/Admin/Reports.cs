using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationSystem.Forms.Admin
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {

    
            this.reportViewer1.RefreshReport();
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if (b != null)
                reportViewer1.ServerReport.ReportPath = "/Report Project2/"+b.Name;
            reportViewer1.Refresh();
            reportViewer1.RefreshReport();
        }

       
    }
}
