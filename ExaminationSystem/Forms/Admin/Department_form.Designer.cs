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
            this.components = new System.ComponentModel.Container();
            this.btn_Dept_Save = new System.Windows.Forms.Button();
            this.btn_Dept_Cancel = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_dept_Description = new System.Windows.Forms.TextBox();
            this.txt_dept_locatoin = new System.Windows.Forms.TextBox();
            this.txt_dept_Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Dept_Save
            // 
            this.btn_Dept_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Dept_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(9)))), ((int)(((byte)(31)))));
            this.btn_Dept_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Dept_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dept_Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(218)))), ((int)(((byte)(197)))));
            this.btn_Dept_Save.Image = global::ExaminationSystem.Properties.Resources.Treetog_I_Floppy_Small;
            this.btn_Dept_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Dept_Save.Location = new System.Drawing.Point(701, 486);
            this.btn_Dept_Save.Name = "btn_Dept_Save";
            this.btn_Dept_Save.Size = new System.Drawing.Size(127, 47);
            this.btn_Dept_Save.TabIndex = 6;
            this.btn_Dept_Save.Text = "    Save";
            this.btn_Dept_Save.UseVisualStyleBackColor = false;
            this.btn_Dept_Save.Click += new System.EventHandler(this.btn_Dept_Save_Click);
            // 
            // btn_Dept_Cancel
            // 
            this.btn_Dept_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Dept_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(10)))), ((int)(((byte)(36)))));
            this.btn_Dept_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Dept_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dept_Cancel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Dept_Cancel.Image = global::ExaminationSystem.Properties.Resources.delete;
            this.btn_Dept_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Dept_Cancel.Location = new System.Drawing.Point(856, 486);
            this.btn_Dept_Cancel.Name = "btn_Dept_Cancel";
            this.btn_Dept_Cancel.Size = new System.Drawing.Size(127, 47);
            this.btn_Dept_Cancel.TabIndex = 7;
            this.btn_Dept_Cancel.Text = "   Cancel";
            this.btn_Dept_Cancel.UseVisualStyleBackColor = false;
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_dept_Description);
            this.groupBox1.Controls.Add(this.txt_dept_locatoin);
            this.groupBox1.Controls.Add(this.txt_dept_Name);
            this.groupBox1.Location = new System.Drawing.Point(30, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(930, 302);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(64, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(76, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Loacrion";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(55, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Department Name";
            // 
            // txt_dept_Description
            // 
            this.txt_dept_Description.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_dept_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dept_Description.Location = new System.Drawing.Point(270, 179);
            this.txt_dept_Description.Name = "txt_dept_Description";
            this.txt_dept_Description.Size = new System.Drawing.Size(605, 30);
            this.txt_dept_Description.TabIndex = 8;
            // 
            // txt_dept_locatoin
            // 
            this.txt_dept_locatoin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_dept_locatoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dept_locatoin.Location = new System.Drawing.Point(270, 135);
            this.txt_dept_locatoin.Name = "txt_dept_locatoin";
            this.txt_dept_locatoin.Size = new System.Drawing.Size(605, 30);
            this.txt_dept_locatoin.TabIndex = 7;
            // 
            // txt_dept_Name
            // 
            this.txt_dept_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_dept_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dept_Name.Location = new System.Drawing.Point(270, 94);
            this.txt_dept_Name.Name = "txt_dept_Name";
            this.txt_dept_Name.Size = new System.Drawing.Size(605, 30);
            this.txt_dept_Name.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(218)))), ((int)(((byte)(197)))));
            this.label4.Location = new System.Drawing.Point(6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 28);
            this.label4.TabIndex = 15;
            this.label4.Text = "Create Department";
            // 
            // Department_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(9)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(995, 548);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Dept_Cancel);
            this.Controls.Add(this.btn_Dept_Save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Department_form";
            this.Text = "Department_form";
            this.Load += new System.EventHandler(this.Department_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Dept_Save;
        private System.Windows.Forms.Button btn_Dept_Cancel;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_dept_Description;
        private System.Windows.Forms.TextBox txt_dept_locatoin;
        private System.Windows.Forms.TextBox txt_dept_Name;
        private System.Windows.Forms.Label label4;
    }
}