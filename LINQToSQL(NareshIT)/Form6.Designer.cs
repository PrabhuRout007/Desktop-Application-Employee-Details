
namespace LINQToSQL_NareshIT_
{
    partial class Form6
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
            this.close = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.insertbutton = new System.Windows.Forms.Button();
            this.textBox_dname = new System.Windows.Forms.TextBox();
            this.textBox_salary = new System.Windows.Forms.TextBox();
            this.textBox_job = new System.Windows.Forms.TextBox();
            this.textBox_ename = new System.Windows.Forms.TextBox();
            this.textBox_eno = new System.Windows.Forms.TextBox();
            this.dname = new System.Windows.Forms.Label();
            this.salary = new System.Windows.Forms.Label();
            this.job = new System.Windows.Forms.Label();
            this.ename = new System.Windows.Forms.Label();
            this.eno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(185, 255);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 47);
            this.close.TabIndex = 40;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(104, 255);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 47);
            this.clear.TabIndex = 39;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // insertbutton
            // 
            this.insertbutton.Location = new System.Drawing.Point(23, 255);
            this.insertbutton.Name = "insertbutton";
            this.insertbutton.Size = new System.Drawing.Size(75, 47);
            this.insertbutton.TabIndex = 38;
            this.insertbutton.Text = "Insert";
            this.insertbutton.UseVisualStyleBackColor = true;
            this.insertbutton.Click += new System.EventHandler(this.insertbutton_Click);
            // 
            // textBox_dname
            // 
            this.textBox_dname.Location = new System.Drawing.Point(104, 211);
            this.textBox_dname.Name = "textBox_dname";
            this.textBox_dname.Size = new System.Drawing.Size(153, 20);
            this.textBox_dname.TabIndex = 37;
            // 
            // textBox_salary
            // 
            this.textBox_salary.Location = new System.Drawing.Point(104, 174);
            this.textBox_salary.Name = "textBox_salary";
            this.textBox_salary.Size = new System.Drawing.Size(153, 20);
            this.textBox_salary.TabIndex = 36;
            // 
            // textBox_job
            // 
            this.textBox_job.Location = new System.Drawing.Point(104, 132);
            this.textBox_job.Name = "textBox_job";
            this.textBox_job.Size = new System.Drawing.Size(153, 20);
            this.textBox_job.TabIndex = 35;
            // 
            // textBox_ename
            // 
            this.textBox_ename.Location = new System.Drawing.Point(104, 92);
            this.textBox_ename.Name = "textBox_ename";
            this.textBox_ename.Size = new System.Drawing.Size(153, 20);
            this.textBox_ename.TabIndex = 34;
            // 
            // textBox_eno
            // 
            this.textBox_eno.Location = new System.Drawing.Point(104, 50);
            this.textBox_eno.Name = "textBox_eno";
            this.textBox_eno.ReadOnly = true;
            this.textBox_eno.Size = new System.Drawing.Size(153, 20);
            this.textBox_eno.TabIndex = 33;
            // 
            // dname
            // 
            this.dname.AutoSize = true;
            this.dname.Location = new System.Drawing.Point(33, 218);
            this.dname.Name = "dname";
            this.dname.Size = new System.Drawing.Size(43, 13);
            this.dname.TabIndex = 32;
            this.dname.Text = "DName";
            // 
            // salary
            // 
            this.salary.AutoSize = true;
            this.salary.Location = new System.Drawing.Point(33, 174);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(36, 13);
            this.salary.TabIndex = 31;
            this.salary.Text = "Salary";
            // 
            // job
            // 
            this.job.AutoSize = true;
            this.job.Location = new System.Drawing.Point(33, 135);
            this.job.Name = "job";
            this.job.Size = new System.Drawing.Size(24, 13);
            this.job.TabIndex = 30;
            this.job.Text = "Job";
            // 
            // ename
            // 
            this.ename.AutoSize = true;
            this.ename.Location = new System.Drawing.Point(33, 95);
            this.ename.Name = "ename";
            this.ename.Size = new System.Drawing.Size(40, 13);
            this.ename.TabIndex = 29;
            this.ename.Text = "Ename";
            // 
            // eno
            // 
            this.eno.AutoSize = true;
            this.eno.Location = new System.Drawing.Point(33, 58);
            this.eno.Name = "eno";
            this.eno.Size = new System.Drawing.Size(26, 13);
            this.eno.TabIndex = 28;
            this.eno.Text = "Eno";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 314);
            this.Controls.Add(this.close);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.insertbutton);
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
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button close;
        internal System.Windows.Forms.Button clear;
        internal System.Windows.Forms.Button insertbutton;
        internal System.Windows.Forms.TextBox textBox_dname;
        internal System.Windows.Forms.TextBox textBox_salary;
        internal System.Windows.Forms.TextBox textBox_job;
        internal System.Windows.Forms.TextBox textBox_ename;
        internal System.Windows.Forms.TextBox textBox_eno;
        private System.Windows.Forms.Label dname;
        private System.Windows.Forms.Label salary;
        private System.Windows.Forms.Label job;
        private System.Windows.Forms.Label ename;
        private System.Windows.Forms.Label eno;
    }
}