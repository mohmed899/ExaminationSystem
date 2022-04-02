namespace ExaminationSystem
{
    partial class main_form
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
            this.Control_Panel = new System.Windows.Forms.Panel();
            this.btn_instrucror = new System.Windows.Forms.Button();
            this.btn_Topic = new System.Windows.Forms.Button();
            this.btn_Department = new System.Windows.Forms.Button();
            this.btn_Course = new System.Windows.Forms.Button();
            this.btn_Student = new System.Windows.Forms.Button();
            this.main_panel = new System.Windows.Forms.Panel();
            this.Control_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Control_Panel
            // 
            this.Control_Panel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Control_Panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Control_Panel.Controls.Add(this.btn_instrucror);
            this.Control_Panel.Controls.Add(this.btn_Topic);
            this.Control_Panel.Controls.Add(this.btn_Department);
            this.Control_Panel.Controls.Add(this.btn_Course);
            this.Control_Panel.Controls.Add(this.btn_Student);
            this.Control_Panel.Location = new System.Drawing.Point(-3, 1);
            this.Control_Panel.Name = "Control_Panel";
            this.Control_Panel.Size = new System.Drawing.Size(206, 446);
            this.Control_Panel.TabIndex = 1;
            // 
            // btn_instrucror
            // 
            this.btn_instrucror.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_instrucror.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_instrucror.FlatAppearance.BorderSize = 0;
            this.btn_instrucror.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_instrucror.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_instrucror.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_instrucror.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_instrucror.Location = new System.Drawing.Point(3, 295);
            this.btn_instrucror.Name = "btn_instrucror";
            this.btn_instrucror.Size = new System.Drawing.Size(196, 29);
            this.btn_instrucror.TabIndex = 4;
            this.btn_instrucror.Text = "Instructor";
            this.btn_instrucror.UseVisualStyleBackColor = false;
            this.btn_instrucror.Click += new System.EventHandler(this.btn_instrucror_Click);
            // 
            // btn_Topic
            // 
            this.btn_Topic.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Topic.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Topic.FlatAppearance.BorderSize = 0;
            this.btn_Topic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Topic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Topic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Topic.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_Topic.Location = new System.Drawing.Point(3, 233);
            this.btn_Topic.Name = "btn_Topic";
            this.btn_Topic.Size = new System.Drawing.Size(196, 29);
            this.btn_Topic.TabIndex = 3;
            this.btn_Topic.Text = "Topic";
            this.btn_Topic.UseVisualStyleBackColor = false;
            this.btn_Topic.Click += new System.EventHandler(this.btn_Topic_Click);
            // 
            // btn_Department
            // 
            this.btn_Department.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Department.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Department.FlatAppearance.BorderSize = 0;
            this.btn_Department.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Department.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Department.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Department.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_Department.Location = new System.Drawing.Point(3, 164);
            this.btn_Department.Name = "btn_Department";
            this.btn_Department.Size = new System.Drawing.Size(196, 29);
            this.btn_Department.TabIndex = 2;
            this.btn_Department.Text = "Department";
            this.btn_Department.UseVisualStyleBackColor = false;
            this.btn_Department.Click += new System.EventHandler(this.btn_Department_Click);
            // 
            // btn_Course
            // 
            this.btn_Course.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Course.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Course.FlatAppearance.BorderSize = 0;
            this.btn_Course.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Course.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Course.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Course.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_Course.Location = new System.Drawing.Point(3, 102);
            this.btn_Course.Name = "btn_Course";
            this.btn_Course.Size = new System.Drawing.Size(196, 29);
            this.btn_Course.TabIndex = 1;
            this.btn_Course.Text = "Course";
            this.btn_Course.UseVisualStyleBackColor = false;
            this.btn_Course.Click += new System.EventHandler(this.btn_Course_Click);
            // 
            // btn_Student
            // 
            this.btn_Student.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Student.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Student.FlatAppearance.BorderSize = 0;
            this.btn_Student.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Student.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Student.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Student.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_Student.Location = new System.Drawing.Point(3, 51);
            this.btn_Student.Name = "btn_Student";
            this.btn_Student.Size = new System.Drawing.Size(196, 29);
            this.btn_Student.TabIndex = 0;
            this.btn_Student.Text = "Student";
            this.btn_Student.UseVisualStyleBackColor = false;
            this.btn_Student.Click += new System.EventHandler(this.btn_Student_Click);
            // 
            // main_panel
            // 
            this.main_panel.AutoSize = true;
            this.main_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.main_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.main_panel.Location = new System.Drawing.Point(209, 1);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(591, 446);
            this.main_panel.TabIndex = 2;
            this.main_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.main_panel_Paint);
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.Control_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "main_form";
            this.Text = "main_form";
            this.Load += new System.EventHandler(this.main_form_Load);
            this.Control_Panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Control_Panel;
        private System.Windows.Forms.Button btn_instrucror;
        private System.Windows.Forms.Button btn_Topic;
        private System.Windows.Forms.Button btn_Department;
        private System.Windows.Forms.Button btn_Course;
        private System.Windows.Forms.Button btn_Student;
        private System.Windows.Forms.Panel main_panel;
    }
}