namespace ExaminationSystem
{
    partial class Course_form
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
            this.btn_course_Save = new System.Windows.Forms.Button();
            this.btn_Course_Cancle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_crs_name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numeric_course_Duration = new System.Windows.Forms.NumericUpDown();
            this.txt_CourseName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_course_Duration)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_course_Save
            // 
            this.btn_course_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_course_Save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_course_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(9)))), ((int)(((byte)(31)))));
            this.btn_course_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_course_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_course_Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(218)))), ((int)(((byte)(197)))));
            this.btn_course_Save.Image = global::ExaminationSystem.Properties.Resources.Treetog_I_Floppy_Small;
            this.btn_course_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_course_Save.Location = new System.Drawing.Point(701, 486);
            this.btn_course_Save.Name = "btn_course_Save";
            this.btn_course_Save.Size = new System.Drawing.Size(127, 47);
            this.btn_course_Save.TabIndex = 6;
            this.btn_course_Save.Text = "     Save";
            this.btn_course_Save.UseVisualStyleBackColor = false;
            this.btn_course_Save.Click += new System.EventHandler(this.btn_course_Save_Click);
            // 
            // btn_Course_Cancle
            // 
            this.btn_Course_Cancle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Course_Cancle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(10)))), ((int)(((byte)(36)))));
            this.btn_Course_Cancle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Course_Cancle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Course_Cancle.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Course_Cancle.Image = global::ExaminationSystem.Properties.Resources.delete;
            this.btn_Course_Cancle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Course_Cancle.Location = new System.Drawing.Point(856, 486);
            this.btn_Course_Cancle.Name = "btn_Course_Cancle";
            this.btn_Course_Cancle.Size = new System.Drawing.Size(128, 47);
            this.btn_Course_Cancle.TabIndex = 7;
            this.btn_Course_Cancle.Text = "      Cancel";
            this.btn_Course_Cancle.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbl_crs_name);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numeric_course_Duration);
            this.groupBox1.Controls.Add(this.txt_CourseName);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(42, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(942, 333);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(218)))), ((int)(((byte)(197)))));
            this.label3.Location = new System.Drawing.Point(6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 28);
            this.label3.TabIndex = 14;
            this.label3.Text = "Create Course";
            // 
            // lbl_crs_name
            // 
            this.lbl_crs_name.AutoSize = true;
            this.lbl_crs_name.Location = new System.Drawing.Point(309, 147);
            this.lbl_crs_name.Name = "lbl_crs_name";
            this.lbl_crs_name.Size = new System.Drawing.Size(0, 13);
            this.lbl_crs_name.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(87, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Course Duration:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(87, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Course Name:";
            // 
            // numeric_course_Duration
            // 
            this.numeric_course_Duration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numeric_course_Duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeric_course_Duration.Location = new System.Drawing.Point(312, 189);
            this.numeric_course_Duration.Name = "numeric_course_Duration";
            this.numeric_course_Duration.Size = new System.Drawing.Size(543, 30);
            this.numeric_course_Duration.TabIndex = 10;
            // 
            // txt_CourseName
            // 
            this.txt_CourseName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_CourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CourseName.Location = new System.Drawing.Point(312, 107);
            this.txt_CourseName.Name = "txt_CourseName";
            this.txt_CourseName.Size = new System.Drawing.Size(543, 30);
            this.txt_CourseName.TabIndex = 9;
            // 
            // Course_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(9)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1035, 568);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Course_Cancle);
            this.Controls.Add(this.btn_course_Save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Course_form";
            this.Text = "Course_form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_course_Duration)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_course_Save;
        private System.Windows.Forms.Button btn_Course_Cancle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_crs_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numeric_course_Duration;
        private System.Windows.Forms.TextBox txt_CourseName;
        private System.Windows.Forms.Label label3;
    }
}