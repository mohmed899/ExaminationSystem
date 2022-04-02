namespace ExaminationSystem.Forms.Admin
{
    partial class Reports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.getTopic = new ExaminationSystem.model.RButton();
            this.getStuCrsGrad = new ExaminationSystem.model.RButton();
            this.getAnsewrExam = new ExaminationSystem.model.RButton();
            this.getQuestionBody = new ExaminationSystem.model.RButton();
            this.deptstudent = new ExaminationSystem.model.RButton();
            this.countStudentsINCourse = new ExaminationSystem.model.RButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.getTopic);
            this.panel1.Controls.Add(this.getStuCrsGrad);
            this.panel1.Controls.Add(this.getAnsewrExam);
            this.panel1.Controls.Add(this.getQuestionBody);
            this.panel1.Controls.Add(this.deptstudent);
            this.panel1.Controls.Add(this.countStudentsINCourse);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 68);
            this.panel1.TabIndex = 4;
            // 
            // getTopic
            // 
            this.getTopic.BackColor = System.Drawing.Color.Navy;
            this.getTopic.BackgroundColor = System.Drawing.Color.Navy;
            this.getTopic.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.getTopic.BorderRadius = 20;
            this.getTopic.BorderSize = 0;
            this.getTopic.FlatAppearance.BorderSize = 0;
            this.getTopic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getTopic.ForeColor = System.Drawing.Color.White;
            this.getTopic.Location = new System.Drawing.Point(601, 12);
            this.getTopic.Name = "getTopic";
            this.getTopic.Size = new System.Drawing.Size(99, 40);
            this.getTopic.TabIndex = 14;
            this.getTopic.Text = "topic";
            this.getTopic.TextColor = System.Drawing.Color.White;
            this.getTopic.UseVisualStyleBackColor = false;
            this.getTopic.Click += new System.EventHandler(this.reportBtn_Click);
            // 
            // getStuCrsGrad
            // 
            this.getStuCrsGrad.BackColor = System.Drawing.Color.Navy;
            this.getStuCrsGrad.BackgroundColor = System.Drawing.Color.Navy;
            this.getStuCrsGrad.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.getStuCrsGrad.BorderRadius = 20;
            this.getStuCrsGrad.BorderSize = 0;
            this.getStuCrsGrad.FlatAppearance.BorderSize = 0;
            this.getStuCrsGrad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getStuCrsGrad.ForeColor = System.Drawing.Color.White;
            this.getStuCrsGrad.Location = new System.Drawing.Point(27, 12);
            this.getStuCrsGrad.Name = "getStuCrsGrad";
            this.getStuCrsGrad.Size = new System.Drawing.Size(99, 40);
            this.getStuCrsGrad.TabIndex = 18;
            this.getStuCrsGrad.Text = "Student Grade";
            this.getStuCrsGrad.TextColor = System.Drawing.Color.White;
            this.getStuCrsGrad.UseVisualStyleBackColor = false;
            this.getStuCrsGrad.Click += new System.EventHandler(this.reportBtn_Click);
            // 
            // getAnsewrExam
            // 
            this.getAnsewrExam.BackColor = System.Drawing.Color.Navy;
            this.getAnsewrExam.BackgroundColor = System.Drawing.Color.Navy;
            this.getAnsewrExam.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.getAnsewrExam.BorderRadius = 20;
            this.getAnsewrExam.BorderSize = 0;
            this.getAnsewrExam.FlatAppearance.BorderSize = 0;
            this.getAnsewrExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getAnsewrExam.ForeColor = System.Drawing.Color.White;
            this.getAnsewrExam.Location = new System.Drawing.Point(142, 12);
            this.getAnsewrExam.Name = "getAnsewrExam";
            this.getAnsewrExam.Size = new System.Drawing.Size(99, 40);
            this.getAnsewrExam.TabIndex = 17;
            this.getAnsewrExam.Text = "Answerd Exams";
            this.getAnsewrExam.TextColor = System.Drawing.Color.White;
            this.getAnsewrExam.UseVisualStyleBackColor = false;
            this.getAnsewrExam.Click += new System.EventHandler(this.reportBtn_Click);
            // 
            // getQuestionBody
            // 
            this.getQuestionBody.BackColor = System.Drawing.Color.Navy;
            this.getQuestionBody.BackgroundColor = System.Drawing.Color.Navy;
            this.getQuestionBody.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.getQuestionBody.BorderRadius = 20;
            this.getQuestionBody.BorderSize = 0;
            this.getQuestionBody.FlatAppearance.BorderSize = 0;
            this.getQuestionBody.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getQuestionBody.ForeColor = System.Drawing.Color.White;
            this.getQuestionBody.Location = new System.Drawing.Point(487, 12);
            this.getQuestionBody.Name = "getQuestionBody";
            this.getQuestionBody.Size = new System.Drawing.Size(99, 40);
            this.getQuestionBody.TabIndex = 16;
            this.getQuestionBody.Text = "Exam";
            this.getQuestionBody.TextColor = System.Drawing.Color.White;
            this.getQuestionBody.UseVisualStyleBackColor = false;
            this.getQuestionBody.Click += new System.EventHandler(this.reportBtn_Click);
            // 
            // deptstudent
            // 
            this.deptstudent.BackColor = System.Drawing.Color.Navy;
            this.deptstudent.BackgroundColor = System.Drawing.Color.Navy;
            this.deptstudent.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.deptstudent.BorderRadius = 20;
            this.deptstudent.BorderSize = 0;
            this.deptstudent.FlatAppearance.BorderSize = 0;
            this.deptstudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deptstudent.ForeColor = System.Drawing.Color.White;
            this.deptstudent.Location = new System.Drawing.Point(257, 12);
            this.deptstudent.Name = "deptstudent";
            this.deptstudent.Size = new System.Drawing.Size(99, 40);
            this.deptstudent.TabIndex = 13;
            this.deptstudent.Text = "DepartmentStu";
            this.deptstudent.TextColor = System.Drawing.Color.White;
            this.deptstudent.UseVisualStyleBackColor = false;
            this.deptstudent.Click += new System.EventHandler(this.reportBtn_Click);
            // 
            // countStudentsINCourse
            // 
            this.countStudentsINCourse.BackColor = System.Drawing.Color.Navy;
            this.countStudentsINCourse.BackgroundColor = System.Drawing.Color.Navy;
            this.countStudentsINCourse.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.countStudentsINCourse.BorderRadius = 20;
            this.countStudentsINCourse.BorderSize = 0;
            this.countStudentsINCourse.FlatAppearance.BorderSize = 0;
            this.countStudentsINCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.countStudentsINCourse.ForeColor = System.Drawing.Color.White;
            this.countStudentsINCourse.Location = new System.Drawing.Point(371, 12);
            this.countStudentsINCourse.Name = "countStudentsINCourse";
            this.countStudentsINCourse.Size = new System.Drawing.Size(99, 40);
            this.countStudentsINCourse.TabIndex = 15;
            this.countStudentsINCourse.Text = "Instructorr Course";
            this.countStudentsINCourse.TextColor = System.Drawing.Color.White;
            this.countStudentsINCourse.UseVisualStyleBackColor = false;
            this.countStudentsINCourse.Click += new System.EventHandler(this.reportBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reportViewer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(761, 454);
            this.panel2.TabIndex = 5;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(761, 454);
            this.reportViewer1.TabIndex = 0;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 522);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private model.RButton getTopic;
        private model.RButton getStuCrsGrad;
        private model.RButton getAnsewrExam;
        private model.RButton getQuestionBody;
        private model.RButton deptstudent;
        private model.RButton countStudentsINCourse;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}