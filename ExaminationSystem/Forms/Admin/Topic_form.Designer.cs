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
            this.btn_topic_save = new System.Windows.Forms.Button();
            this.btn_topic_cancle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Courses = new System.Windows.Forms.ComboBox();
            this.txt_Topic_Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_topic_save
            // 
            this.btn_topic_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_topic_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(9)))), ((int)(((byte)(31)))));
            this.btn_topic_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_topic_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_topic_save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(218)))), ((int)(((byte)(197)))));
            this.btn_topic_save.Image = global::ExaminationSystem.Properties.Resources.Treetog_I_Floppy_Small;
            this.btn_topic_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_topic_save.Location = new System.Drawing.Point(701, 486);
            this.btn_topic_save.Name = "btn_topic_save";
            this.btn_topic_save.Size = new System.Drawing.Size(127, 47);
            this.btn_topic_save.TabIndex = 4;
            this.btn_topic_save.Text = "       Save";
            this.btn_topic_save.UseVisualStyleBackColor = false;
            this.btn_topic_save.Click += new System.EventHandler(this.btn_topic_save_Click);
            // 
            // btn_topic_cancle
            // 
            this.btn_topic_cancle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_topic_cancle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(10)))), ((int)(((byte)(36)))));
            this.btn_topic_cancle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_topic_cancle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_topic_cancle.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_topic_cancle.Image = global::ExaminationSystem.Properties.Resources.delete;
            this.btn_topic_cancle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_topic_cancle.Location = new System.Drawing.Point(856, 486);
            this.btn_topic_cancle.Name = "btn_topic_cancle";
            this.btn_topic_cancle.Size = new System.Drawing.Size(127, 47);
            this.btn_topic_cancle.TabIndex = 5;
            this.btn_topic_cancle.Text = "       Cancel";
            this.btn_topic_cancle.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbl_name);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cb_Courses);
            this.groupBox1.Controls.Add(this.txt_Topic_Name);
            this.groupBox1.Location = new System.Drawing.Point(12, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(972, 345);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(234, 163);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(0, 13);
            this.lbl_name.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(9)))), ((int)(((byte)(31)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(86, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Courses";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(9)))), ((int)(((byte)(31)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(86, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Topic Name";
            // 
            // cb_Courses
            // 
            this.cb_Courses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_Courses.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Courses.FormattingEnabled = true;
            this.cb_Courses.Location = new System.Drawing.Point(224, 191);
            this.cb_Courses.Name = "cb_Courses";
            this.cb_Courses.Size = new System.Drawing.Size(662, 33);
            this.cb_Courses.TabIndex = 8;
            // 
            // txt_Topic_Name
            // 
            this.txt_Topic_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Topic_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Topic_Name.Location = new System.Drawing.Point(224, 121);
            this.txt_Topic_Name.Name = "txt_Topic_Name";
            this.txt_Topic_Name.Size = new System.Drawing.Size(662, 30);
            this.txt_Topic_Name.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(218)))), ((int)(((byte)(197)))));
            this.label4.Location = new System.Drawing.Point(6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 28);
            this.label4.TabIndex = 16;
            this.label4.Text = "Create Topic";
            // 
            // Topic_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(9)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1010, 572);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_topic_cancle);
            this.Controls.Add(this.btn_topic_save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Topic_form";
            this.Text = "Topic_form";
            this.Load += new System.EventHandler(this.Topic_form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_topic_save;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Courses;
        private System.Windows.Forms.TextBox txt_Topic_Name;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button btn_topic_cancle;
    }
}