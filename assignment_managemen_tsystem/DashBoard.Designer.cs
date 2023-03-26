namespace assignment_managemen_tsystem
{
    partial class DashBoard
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
            this.BtnTeacer = new System.Windows.Forms.Button();
            this.BtnTeacherDispatch = new System.Windows.Forms.Button();
            this.BtnSubject = new System.Windows.Forms.Button();
            this.BtnFaculty = new System.Windows.Forms.Button();
            this.BtnStudent = new System.Windows.Forms.Button();
            this.Btnssignment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnTeacer
            // 
            this.BtnTeacer.Location = new System.Drawing.Point(12, 31);
            this.BtnTeacer.Name = "BtnTeacer";
            this.BtnTeacer.Size = new System.Drawing.Size(151, 63);
            this.BtnTeacer.TabIndex = 0;
            this.BtnTeacer.Text = "Teacher";
            this.BtnTeacer.UseVisualStyleBackColor = true;
            this.BtnTeacer.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnTeacherDispatch
            // 
            this.BtnTeacherDispatch.Location = new System.Drawing.Point(711, 31);
            this.BtnTeacherDispatch.Name = "BtnTeacherDispatch";
            this.BtnTeacherDispatch.Size = new System.Drawing.Size(151, 63);
            this.BtnTeacherDispatch.TabIndex = 1;
            this.BtnTeacherDispatch.Text = "TeacherDispatch";
            this.BtnTeacherDispatch.UseVisualStyleBackColor = true;
            this.BtnTeacherDispatch.Click += new System.EventHandler(this.BtnTeacherDispatch_Click);
            // 
            // BtnSubject
            // 
            this.BtnSubject.Location = new System.Drawing.Point(581, 161);
            this.BtnSubject.Name = "BtnSubject";
            this.BtnSubject.Size = new System.Drawing.Size(151, 63);
            this.BtnSubject.TabIndex = 2;
            this.BtnSubject.Text = "Subjects";
            this.BtnSubject.UseVisualStyleBackColor = true;
            this.BtnSubject.Click += new System.EventHandler(this.BtnSubject_Click);
            // 
            // BtnFaculty
            // 
            this.BtnFaculty.Location = new System.Drawing.Point(365, 161);
            this.BtnFaculty.Name = "BtnFaculty";
            this.BtnFaculty.Size = new System.Drawing.Size(151, 63);
            this.BtnFaculty.TabIndex = 3;
            this.BtnFaculty.Text = "Faculty";
            this.BtnFaculty.UseVisualStyleBackColor = true;
            this.BtnFaculty.Click += new System.EventHandler(this.BtnFaculty_Click);
            // 
            // BtnStudent
            // 
            this.BtnStudent.Location = new System.Drawing.Point(115, 161);
            this.BtnStudent.Name = "BtnStudent";
            this.BtnStudent.Size = new System.Drawing.Size(151, 63);
            this.BtnStudent.TabIndex = 4;
            this.BtnStudent.Text = "Students";
            this.BtnStudent.UseVisualStyleBackColor = true;
            this.BtnStudent.Click += new System.EventHandler(this.BtnStudent_Click);
            // 
            // Btnssignment
            // 
            this.Btnssignment.Location = new System.Drawing.Point(365, 40);
            this.Btnssignment.Name = "Btnssignment";
            this.Btnssignment.Size = new System.Drawing.Size(151, 63);
            this.Btnssignment.TabIndex = 5;
            this.Btnssignment.Text = "Assignmnets";
            this.Btnssignment.UseVisualStyleBackColor = true;
            this.Btnssignment.Click += new System.EventHandler(this.Btnssignment_Click);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(889, 553);
            this.Controls.Add(this.Btnssignment);
            this.Controls.Add(this.BtnStudent);
            this.Controls.Add(this.BtnFaculty);
            this.Controls.Add(this.BtnSubject);
            this.Controls.Add(this.BtnTeacherDispatch);
            this.Controls.Add(this.BtnTeacer);
            this.Name = "DashBoard";
            this.Text = "DashBoard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnTeacer;
        private System.Windows.Forms.Button BtnTeacherDispatch;
        private System.Windows.Forms.Button BtnSubject;
        private System.Windows.Forms.Button BtnFaculty;
        private System.Windows.Forms.Button BtnStudent;
        private System.Windows.Forms.Button Btnssignment;
    }
}