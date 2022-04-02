namespace ExaminationSystem
{
    partial class Department_form
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
            this.txt_dept_Name = new System.Windows.Forms.TextBox();
            this.txt_dept_locatoin = new System.Windows.Forms.TextBox();
            this.txt_dept_Description = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Dept_Save = new System.Windows.Forms.Button();
            this.btn_Dept_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_dept_Name
            // 
            this.txt_dept_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_dept_Name.Location = new System.Drawing.Point(418, 115);
            this.txt_dept_Name.Name = "txt_dept_Name";
            this.txt_dept_Name.Size = new System.Drawing.Size(244, 20);
            this.txt_dept_Name.TabIndex = 0;
            // 
            // txt_dept_locatoin
            // 
            this.txt_dept_locatoin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_dept_locatoin.Location = new System.Drawing.Point(418, 156);
            this.txt_dept_locatoin.Name = "txt_dept_locatoin";
            this.txt_dept_locatoin.Size = new System.Drawing.Size(244, 20);
            this.txt_dept_locatoin.TabIndex = 1;
            // 
            // txt_dept_Description
            // 
            this.txt_dept_Description.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_dept_Description.Location = new System.Drawing.Point(418, 200);
            this.txt_dept_Description.Name = "txt_dept_Description";
            this.txt_dept_Description.Size = new System.Drawing.Size(244, 20);
            this.txt_dept_Description.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Department Name";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(233, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Loacrion";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(233, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Description";
            // 
            // btn_Dept_Save
            // 
            this.btn_Dept_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Dept_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Dept_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Dept_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dept_Save.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Dept_Save.Location = new System.Drawing.Point(418, 295);
            this.btn_Dept_Save.Name = "btn_Dept_Save";
            this.btn_Dept_Save.Size = new System.Drawing.Size(91, 30);
            this.btn_Dept_Save.TabIndex = 6;
            this.btn_Dept_Save.Text = "Save";
            this.btn_Dept_Save.UseVisualStyleBackColor = false;
            // 
            // btn_Dept_Cancel
            // 
            this.btn_Dept_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Dept_Cancel.BackColor = System.Drawing.Color.Red;
            this.btn_Dept_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Dept_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dept_Cancel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Dept_Cancel.Location = new System.Drawing.Point(569, 295);
            this.btn_Dept_Cancel.Name = "btn_Dept_Cancel";
            this.btn_Dept_Cancel.Size = new System.Drawing.Size(93, 30);
            this.btn_Dept_Cancel.TabIndex = 7;
            this.btn_Dept_Cancel.Text = "Cancle";
            this.btn_Dept_Cancel.UseVisualStyleBackColor = false;
            // 
            // Department_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Dept_Cancel);
            this.Controls.Add(this.btn_Dept_Save);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_dept_Description);
            this.Controls.Add(this.txt_dept_locatoin);
            this.Controls.Add(this.txt_dept_Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Department_form";
            this.Text = "Department_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_dept_Name;
        private System.Windows.Forms.TextBox txt_dept_locatoin;
        private System.Windows.Forms.TextBox txt_dept_Description;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Dept_Save;
        private System.Windows.Forms.Button btn_Dept_Cancel;
    }
}