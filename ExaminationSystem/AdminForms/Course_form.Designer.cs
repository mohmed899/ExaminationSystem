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
            this.cb_topic = new System.Windows.Forms.ComboBox();
            this.txt_CourseName = new System.Windows.Forms.TextBox();
            this.numeric_course_Duration = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_course_Save = new System.Windows.Forms.Button();
            this.btn_Course_Cancle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_course_Duration)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_topic
            // 
            this.cb_topic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_topic.FormattingEnabled = true;
            this.cb_topic.Location = new System.Drawing.Point(388, 220);
            this.cb_topic.Name = "cb_topic";
            this.cb_topic.Size = new System.Drawing.Size(272, 21);
            this.cb_topic.TabIndex = 0;
            // 
            // txt_CourseName
            // 
            this.txt_CourseName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_CourseName.Location = new System.Drawing.Point(388, 131);
            this.txt_CourseName.Name = "txt_CourseName";
            this.txt_CourseName.Size = new System.Drawing.Size(272, 20);
            this.txt_CourseName.TabIndex = 1;
            // 
            // numeric_course_Duration
            // 
            this.numeric_course_Duration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numeric_course_Duration.Location = new System.Drawing.Point(388, 175);
            this.numeric_course_Duration.Name = "numeric_course_Duration";
            this.numeric_course_Duration.Size = new System.Drawing.Size(272, 20);
            this.numeric_course_Duration.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Course Name:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(222, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Course Duration:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(222, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Topic";
            // 
            // btn_course_Save
            // 
            this.btn_course_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_course_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_course_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_course_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_course_Save.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_course_Save.Location = new System.Drawing.Point(388, 296);
            this.btn_course_Save.Name = "btn_course_Save";
            this.btn_course_Save.Size = new System.Drawing.Size(113, 31);
            this.btn_course_Save.TabIndex = 6;
            this.btn_course_Save.Text = "Save";
            this.btn_course_Save.UseVisualStyleBackColor = false;
            this.btn_course_Save.Click += new System.EventHandler(this.btn_course_Save_Click);
            // 
            // btn_Course_Cancle
            // 
            this.btn_Course_Cancle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Course_Cancle.BackColor = System.Drawing.Color.Red;
            this.btn_Course_Cancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Course_Cancle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Course_Cancle.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Course_Cancle.Location = new System.Drawing.Point(552, 296);
            this.btn_Course_Cancle.Name = "btn_Course_Cancle";
            this.btn_Course_Cancle.Size = new System.Drawing.Size(108, 31);
            this.btn_Course_Cancle.TabIndex = 7;
            this.btn_Course_Cancle.Text = "Cancle";
            this.btn_Course_Cancle.UseVisualStyleBackColor = false;
            // 
            // Course_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Course_Cancle);
            this.Controls.Add(this.btn_course_Save);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numeric_course_Duration);
            this.Controls.Add(this.txt_CourseName);
            this.Controls.Add(this.cb_topic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Course_form";
            this.Text = "Course_form";
            ((System.ComponentModel.ISupportInitialize)(this.numeric_course_Duration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_topic;
        private System.Windows.Forms.TextBox txt_CourseName;
        private System.Windows.Forms.NumericUpDown numeric_course_Duration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_course_Save;
        private System.Windows.Forms.Button btn_Course_Cancle;
    }
}