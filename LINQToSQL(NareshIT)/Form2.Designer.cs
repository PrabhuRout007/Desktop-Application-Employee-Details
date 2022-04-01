
namespace LINQToSQL_NareshIT_
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.eno = new System.Windows.Forms.Label();
            this.ename = new System.Windows.Forms.Label();
            this.job = new System.Windows.Forms.Label();
            this.salary = new System.Windows.Forms.Label();
            this.dname = new System.Windows.Forms.Label();
            this.textBox_eno = new System.Windows.Forms.TextBox();
            this.textBox_ename = new System.Windows.Forms.TextBox();
            this.textBox_job = new System.Windows.Forms.TextBox();
            this.textBox_salary = new System.Windows.Forms.TextBox();
            this.textBox_dname = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Details";
            // 
            // eno
            // 
            this.eno.AutoSize = true;
            this.eno.Location = new System.Drawing.Point(12, 86);
            this.eno.Name = "eno";
            this.eno.Size = new System.Drawing.Size(26, 13);
            this.eno.TabIndex = 1;
            this.eno.Text = "Eno";
            // 
            // ename
            // 
            this.ename.AutoSize = true;
            this.ename.Location = new System.Drawing.Point(12, 123);
            this.ename.Name = "ename";
            this.ename.Size = new System.Drawing.Size(40, 13);
            this.ename.TabIndex = 2;
            this.ename.Text = "Ename";
            // 
            // job
            // 
            this.job.AutoSize = true;
            this.job.Location = new System.Drawing.Point(12, 163);
            this.job.Name = "job";
            this.job.Size = new System.Drawing.Size(24, 13);
            this.job.TabIndex = 3;
            this.job.Text = "Job";
            // 
            // salary
            // 
            this.salary.AutoSize = true;
            this.salary.Location = new System.Drawing.Point(12, 202);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(36, 13);
            this.salary.TabIndex = 4;
            this.salary.Text = "Salary";
            // 
            // dname
            // 
            this.dname.AutoSize = true;
            this.dname.Location = new System.Drawing.Point(12, 246);
            this.dname.Name = "dname";
            this.dname.Size = new System.Drawing.Size(43, 13);
            this.dname.TabIndex = 5;
            this.dname.Text = "DName";
            // 
            // textBox_eno
            // 
            this.textBox_eno.Location = new System.Drawing.Point(83, 78);
            this.textBox_eno.Name = "textBox_eno";
            this.textBox_eno.Size = new System.Drawing.Size(153, 20);
            this.textBox_eno.TabIndex = 6;
            // 
            // textBox_ename
            // 
            this.textBox_ename.Location = new System.Drawing.Point(83, 120);
            this.textBox_ename.Name = "textBox_ename";
            this.textBox_ename.Size = new System.Drawing.Size(153, 20);
            this.textBox_ename.TabIndex = 7;
            // 
            // textBox_job
            // 
            this.textBox_job.Location = new System.Drawing.Point(83, 160);
            this.textBox_job.Name = "textBox_job";
            this.textBox_job.Size = new System.Drawing.Size(153, 20);
            this.textBox_job.TabIndex = 8;
            // 
            // textBox_salary
            // 
            this.textBox_salary.Location = new System.Drawing.Point(83, 202);
            this.textBox_salary.Name = "textBox_salary";
            this.textBox_salary.Size = new System.Drawing.Size(153, 20);
            this.textBox_salary.TabIndex = 9;
            // 
            // textBox_dname
            // 
            this.textBox_dname.Location = new System.Drawing.Point(83, 239);
            this.textBox_dname.Name = "textBox_dname";
            this.textBox_dname.Size = new System.Drawing.Size(153, 20);
            this.textBox_dname.TabIndex = 10;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(26, 274);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 47);
            this.save.TabIndex = 11;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(107, 274);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 47);
            this.clear.TabIndex = 12;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(188, 274);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 47);
            this.close.TabIndex = 13;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 351);
            this.Controls.Add(this.close);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.save);
            this.Controls.Add(this.textBox_dname);
            this.Controls.Add(this.textBox_salary);
            this.Controls.Add(this.textBox_job);
            this.Controls.Add(this.textBox_ename);
            this.Controls.Add(this.textBox_eno);
            this.Controls.Add(this.dname);
            this.Controls.Add(this.salary);
            this.Controls.Add(this.job);
            this.Controls.Add(this.ename);
            this.Controls.Add(this.eno);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label eno;
        private System.Windows.Forms.Label ename;
        private System.Windows.Forms.Label job;
        private System.Windows.Forms.Label salary;
        private System.Windows.Forms.Label dname;
        internal System.Windows.Forms.TextBox textBox_eno;
        internal System.Windows.Forms.TextBox textBox_ename;
        internal System.Windows.Forms.TextBox textBox_job;
        internal System.Windows.Forms.TextBox textBox_salary;
        internal System.Windows.Forms.TextBox textBox_dname;
        internal System.Windows.Forms.Button save;
        internal System.Windows.Forms.Button clear;
        internal System.Windows.Forms.Button close;
    }
}