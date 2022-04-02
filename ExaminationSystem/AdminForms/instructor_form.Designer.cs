namespace ExaminationSystem
{
    partial class instructor_form
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
            this.txt_inst_name = new System.Windows.Forms.TextBox();
            this.txt_inst_salary = new System.Windows.Forms.TextBox();
            this.txt_inst_degree = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_inst_save = new System.Windows.Forms.Button();
            this.btn_inst_cancle = new System.Windows.Forms.Button();
            this.cb_inst_department = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_inst_name
            // 
            this.txt_inst_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_inst_name.Location = new System.Drawing.Point(425, 121);
            this.txt_inst_name.Name = "txt_inst_name";
            this.txt_inst_name.Size = new System.Drawing.Size(235, 20);
            this.txt_inst_name.TabIndex = 1;
            // 
            // txt_inst_salary
            // 
            this.txt_inst_salary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_inst_salary.Location = new System.Drawing.Point(425, 170);
            this.txt_inst_salary.Name = "txt_inst_salary";
            this.txt_inst_salary.Size = new System.Drawing.Size(235, 20);
            this.txt_inst_salary.TabIndex = 2;
            // 
            // txt_inst_degree
            // 
            this.txt_inst_degree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_inst_degree.Location = new System.Drawing.Point(425, 214);
            this.txt_inst_degree.Name = "txt_inst_degree";
            this.txt_inst_degree.Size = new System.Drawing.Size(235, 20);
            this.txt_inst_degree.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(284, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(275, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = " Salary";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(279, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Degree";
            // 
            // btn_inst_save
            // 
            this.btn_inst_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_inst_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_inst_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inst_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inst_save.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_inst_save.Location = new System.Drawing.Point(425, 323);
            this.btn_inst_save.Name = "btn_inst_save";
            this.btn_inst_save.Size = new System.Drawing.Size(99, 32);
            this.btn_inst_save.TabIndex = 8;
            this.btn_inst_save.Text = "Save";
            this.btn_inst_save.UseVisualStyleBackColor = false;
            // 
            // btn_inst_cancle
            // 
            this.btn_inst_cancle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_inst_cancle.BackColor = System.Drawing.Color.Red;
            this.btn_inst_cancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inst_cancle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inst_cancle.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_inst_cancle.Location = new System.Drawing.Point(588, 323);
            this.btn_inst_cancle.Name = "btn_inst_cancle";
            this.btn_inst_cancle.Size = new System.Drawing.Size(86, 32);
            this.btn_inst_cancle.TabIndex = 9;
            this.btn_inst_cancle.Text = "Cancle";
            this.btn_inst_cancle.UseVisualStyleBackColor = false;
            // 
            // cb_inst_department
            // 
            this.cb_inst_department.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_inst_department.FormattingEnabled = true;
            this.cb_inst_department.Location = new System.Drawing.Point(425, 255);
            this.cb_inst_department.Name = "cb_inst_department";
            this.cb_inst_department.Size = new System.Drawing.Size(235, 21);
            this.cb_inst_department.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Department ";
            // 
            // instructor_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_inst_department);
            this.Controls.Add(this.btn_inst_cancle);
            this.Controls.Add(this.btn_inst_save);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_inst_degree);
            this.Controls.Add(this.txt_inst_salary);
            this.Controls.Add(this.txt_inst_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "instructor_form";
            this.Text = "instructor_form";
            this.Load += new System.EventHandler(this.instructor_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_inst_name;
        private System.Windows.Forms.TextBox txt_inst_salary;
        private System.Windows.Forms.TextBox txt_inst_degree;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_inst_save;
        private System.Windows.Forms.Button btn_inst_cancle;
        private System.Windows.Forms.ComboBox cb_inst_department;
        private System.Windows.Forms.Label label1;
    }
}