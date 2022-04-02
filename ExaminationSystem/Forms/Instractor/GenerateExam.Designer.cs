namespace ExaminationSystem.Forms.Instractor
{
    partial class GenerateExam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateExam));
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mcqvalue = new System.Windows.Forms.NumericUpDown();
            this.tfvalue = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_coursegenerate = new System.Windows.Forms.ComboBox();
            this.Btn_save = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mcqvalue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfvalue)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cancel
            // 
            resources.ApplyResources(this.btn_cancel, "btn_cancel");
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(10)))), ((int)(((byte)(36)))));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Image = global::ExaminationSystem.Properties.Resources.delete;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Name = "label4";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.mcqvalue);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tfvalue);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cb_coursegenerate);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // mcqvalue
            // 
            resources.ApplyResources(this.mcqvalue, "mcqvalue");
            this.mcqvalue.Name = "mcqvalue";
            this.mcqvalue.ValueChanged += new System.EventHandler(this.mcqvalue_ValueChanged);
            // 
            // tfvalue
            // 
            resources.ApplyResources(this.tfvalue, "tfvalue");
            this.tfvalue.Name = "tfvalue";
            this.tfvalue.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Name = "label1";
            // 
            // cb_coursegenerate
            // 
            resources.ApplyResources(this.cb_coursegenerate, "cb_coursegenerate");
            this.cb_coursegenerate.FormattingEnabled = true;
            this.cb_coursegenerate.Name = "cb_coursegenerate";
            // 
            // Btn_save
            // 
            resources.ApplyResources(this.Btn_save, "Btn_save");
            this.Btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Btn_save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(1)))));
            this.Btn_save.FlatAppearance.BorderSize = 0;
            this.Btn_save.Image = global::ExaminationSystem.Properties.Resources.Treetog_I_Floppy_Small;
            this.Btn_save.Name = "Btn_save";
            this.Btn_save.UseVisualStyleBackColor = false;
            this.Btn_save.Click += new System.EventHandler(this.Btn_save_Click);
            // 
            // GenerateExam
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(9)))), ((int)(((byte)(31)))));
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btn_save);
            this.Controls.Add(this.btn_cancel);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "GenerateExam";
            this.Load += new System.EventHandler(this.GenerateExam_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mcqvalue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfvalue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button Btn_save;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown mcqvalue;
        private System.Windows.Forms.NumericUpDown tfvalue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_coursegenerate;
    }
}