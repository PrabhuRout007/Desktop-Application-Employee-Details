
namespace LINQToSQL_NareshIT_
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(193, 265);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 47);
            this.close.TabIndex = 27;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(112, 265);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 47);
            this.clear.TabIndex = 26;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // insertbutton
            // 
            this.insertbutton.Location = new System.Drawing.Point(31, 265);
            this.insertbutton.Name = "insertbutton";
            this.insertbutton.Size = new System.Drawing.Size(75, 47);
            this.insertbutton.TabIndex = 25;
            this.insertbutton.Text = "Insert";
            this.insertbutton.UseVisualStyleBackColor = true;
            this.insertbutton.Click += new System.EventHandler(this.insertbutton_Click);
            // 
            // textBox_dname
            // 
            this.textBox_dname.Location = new System.Drawing.Point(88, 230);
            this.textBox_dname.Name = "textBox_dname";
            this.textBox_dname.Size = new System.Drawing.Size(153, 20);
            this.textBox_dname.TabIndex = 24;
            // 
            // textBox_salary
            // 
            this.textBox_salary.Location = new System.Drawing.Point(88, 193);
            this.textBox_salary.Name = "textBox_salary";
            this.textBox_salary.Size = new System.Drawing.Size(153, 20);
            this.textBox_salary.TabIndex = 23;
            // 
            // textBox_job
            // 
            this.textBox_job.Location = new System.Drawing.Point(88, 151);
            this.textBox_job.Name = "textBox_job";
            this.textBox_job.Size = new System.Drawing.Size(153, 20);
            this.textBox_job.TabIndex = 22;
            // 
            // textBox_ename
            // 
            this.textBox_ename.Location = new System.Drawing.Point(88, 111);
            this.textBox_ename.Name = "textBox_ename";
            this.textBox_ename.Size = new System.Drawing.Size(153, 20);
            this.textBox_ename.TabIndex = 21;
            // 
            // textBox_eno
            // 
            this.textBox_eno.Location = new System.Drawing.Point(88, 69);
            this.textBox_eno.Name = "textBox_eno";
            this.textBox_eno.ReadOnly = true;
            this.textBox_eno.Size = new System.Drawing.Size(153, 20);
            this.textBox_eno.TabIndex = 20;
            // 
            // dname
            // 
            this.dname.AutoSize = true;
            this.dname.Location = new System.Drawing.Point(17, 237);
            this.dname.Name = "dname";
            this.dname.Size = new System.Drawing.Size(43, 13);
            this.dname.TabIndex = 19;
            this.dname.Text = "DName";
            // 
            // salary
            // 
            this.salary.AutoSize = true;
            this.salary.Location = new System.Drawing.Point(17, 193);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(36, 13);
            this.salary.TabIndex = 18;
            this.salary.Text = "Salary";
            // 
            // job
            // 
            this.job.AutoSize = true;
            this.job.Location = new System.Drawing.Point(17, 154);
            this.job.Name = "job";
            this.job.Size = new System.Drawing.Size(24, 13);
            this.job.TabIndex = 17;
            this.job.Text = "Job";
            // 
            // ename
            // 
            this.ename.AutoSize = true;
            this.ename.Location = new System.Drawing.Point(17, 114);
            this.ename.Name = "ename";
            this.ename.Size = new System.Drawing.Size(40, 13);
            this.ename.TabIndex = 16;
            this.ename.Text = "Ename";
            // 
            // eno
            // 
            this.eno.AutoSize = true;
            this.eno.Location = new System.Drawing.Point(17, 77);
            this.eno.Name = "eno";
            this.eno.Size = new System.Drawing.Size(26, 13);
            this.eno.TabIndex = 15;
            this.eno.Text = "Eno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Employee Details";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 313);
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
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
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
        private System.Windows.Forms.Label label1;
    }
}