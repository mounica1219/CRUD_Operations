namespace SQL_CRUD_Operations
{
    partial class Tables_Page
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
            this.employee_btn = new System.Windows.Forms.Button();
            this.payroll_btn = new System.Windows.Forms.Button();
            this.department_btn = new System.Windows.Forms.Button();
            this.salary_btn = new System.Windows.Forms.Button();
            this.leave_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select the Table on which you are going to apply CRUD Operations";
            // 
            // employee_btn
            // 
            this.employee_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.employee_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_btn.Location = new System.Drawing.Point(185, 181);
            this.employee_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.employee_btn.Name = "employee_btn";
            this.employee_btn.Size = new System.Drawing.Size(121, 43);
            this.employee_btn.TabIndex = 1;
            this.employee_btn.Text = "Employee";
            this.employee_btn.UseVisualStyleBackColor = false;
            this.employee_btn.Click += new System.EventHandler(this.employee_btn_Click);
            // 
            // payroll_btn
            // 
            this.payroll_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.payroll_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payroll_btn.Location = new System.Drawing.Point(392, 181);
            this.payroll_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.payroll_btn.Name = "payroll_btn";
            this.payroll_btn.Size = new System.Drawing.Size(114, 43);
            this.payroll_btn.TabIndex = 2;
            this.payroll_btn.Text = "Payroll";
            this.payroll_btn.UseVisualStyleBackColor = false;
            this.payroll_btn.Click += new System.EventHandler(this.payroll_btn_Click);
            // 
            // department_btn
            // 
            this.department_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.department_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.department_btn.Location = new System.Drawing.Point(592, 181);
            this.department_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.department_btn.Name = "department_btn";
            this.department_btn.Size = new System.Drawing.Size(117, 43);
            this.department_btn.TabIndex = 3;
            this.department_btn.Text = "Department";
            this.department_btn.UseVisualStyleBackColor = false;
            this.department_btn.Click += new System.EventHandler(this.department_btn_Click);
            // 
            // salary_btn
            // 
            this.salary_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.salary_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary_btn.Location = new System.Drawing.Point(294, 297);
            this.salary_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.salary_btn.Name = "salary_btn";
            this.salary_btn.Size = new System.Drawing.Size(104, 42);
            this.salary_btn.TabIndex = 4;
            this.salary_btn.Text = "Salary";
            this.salary_btn.UseVisualStyleBackColor = false;
            this.salary_btn.Click += new System.EventHandler(this.salary_btn_Click);
            // 
            // leave_btn
            // 
            this.leave_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.leave_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leave_btn.Location = new System.Drawing.Point(497, 297);
            this.leave_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.leave_btn.Name = "leave_btn";
            this.leave_btn.Size = new System.Drawing.Size(102, 42);
            this.leave_btn.TabIndex = 5;
            this.leave_btn.Text = "Leave";
            this.leave_btn.UseVisualStyleBackColor = false;
            this.leave_btn.Click += new System.EventHandler(this.leave_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.back_btn.Location = new System.Drawing.Point(830, 12);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 23);
            this.back_btn.TabIndex = 6;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // Tables_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.leave_btn);
            this.Controls.Add(this.salary_btn);
            this.Controls.Add(this.department_btn);
            this.Controls.Add(this.payroll_btn);
            this.Controls.Add(this.employee_btn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Tables_Page";
            this.Text = "Tables_Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button employee_btn;
        private System.Windows.Forms.Button payroll_btn;
        private System.Windows.Forms.Button department_btn;
        private System.Windows.Forms.Button salary_btn;
        private System.Windows.Forms.Button leave_btn;
        private System.Windows.Forms.Button back_btn;
    }
}