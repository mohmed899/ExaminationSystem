namespace ExaminationSystem
{
    partial class Topic_form
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
            this.txt_Topic_Name = new System.Windows.Forms.TextBox();
            this.cb_Courses = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_topic_save = new System.Windows.Forms.Button();
            this.btn_topic_cancle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Topic_Name
            // 
            this.txt_Topic_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Topic_Name.Location = new System.Drawing.Point(255, 111);
            this.txt_Topic_Name.Name = "txt_Topic_Name";
            this.txt_Topic_Name.Size = new System.Drawing.Size(288, 20);
            this.txt_Topic_Name.TabIndex = 0;
            // 
            // cb_Courses
            // 
            this.cb_Courses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_Courses.FormattingEnabled = true;
            this.cb_Courses.Location = new System.Drawing.Point(255, 181);
            this.cb_Courses.Name = "cb_Courses";
            this.cb_Courses.Size = new System.Drawing.Size(288, 21);
            this.cb_Courses.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Topic Name";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Courses";
            // 
            // btn_topic_save
            // 
            this.btn_topic_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_topic_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_topic_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_topic_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_topic_save.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_topic_save.Location = new System.Drawing.Point(255, 269);
            this.btn_topic_save.Name = "btn_topic_save";
            this.btn_topic_save.Size = new System.Drawing.Size(105, 30);
            this.btn_topic_save.TabIndex = 4;
            this.btn_topic_save.Text = "Save";
            this.btn_topic_save.UseVisualStyleBackColor = false;
            // 
            // btn_topic_cancle
            // 
            this.btn_topic_cancle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_topic_cancle.BackColor = System.Drawing.Color.Red;
            this.btn_topic_cancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_topic_cancle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_topic_cancle.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_topic_cancle.Location = new System.Drawing.Point(448, 269);
            this.btn_topic_cancle.Name = "btn_topic_cancle";
            this.btn_topic_cancle.Size = new System.Drawing.Size(95, 30);
            this.btn_topic_cancle.TabIndex = 5;
            this.btn_topic_cancle.Text = "Cancle";
            this.btn_topic_cancle.UseVisualStyleBackColor = false;
            // 
            // Topic_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(678, 444);
            this.Controls.Add(this.btn_topic_cancle);
            this.Controls.Add(this.btn_topic_save);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_Courses);
            this.Controls.Add(this.txt_Topic_Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Topic_form";
            this.Text = "Topic_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Topic_Name;
        private System.Windows.Forms.ComboBox cb_Courses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_topic_save;
        private System.Windows.Forms.Button btn_topic_cancle;
    }
}