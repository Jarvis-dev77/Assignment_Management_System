namespace assignment_managemen_tsystem
{
    partial class FrmAssignments
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnView = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Dtable = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CmbStudentId = new System.Windows.Forms.ComboBox();
            this.CmbTeacherId = new System.Windows.Forms.ComboBox();
            this.CmbSubjectId = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtComment = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnDel = new System.Windows.Forms.Button();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDate = new System.Windows.Forms.TextBox();
            this.TxtStatus = new System.Windows.Forms.TextBox();
            this.TxtAssignmentId = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dtable)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnNew);
            this.panel1.Controls.Add(this.BtnEdit);
            this.panel1.Controls.Add(this.BtnReset);
            this.panel1.Controls.Add(this.BtnView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(849, 94);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(523, 39);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(75, 23);
            this.BtnNew.TabIndex = 7;
            this.BtnNew.Text = "new";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(320, 39);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(75, 23);
            this.BtnEdit.TabIndex = 6;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(427, 39);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(75, 23);
            this.BtnReset.TabIndex = 5;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnView
            // 
            this.BtnView.Location = new System.Drawing.Point(202, 39);
            this.BtnView.Name = "BtnView";
            this.BtnView.Size = new System.Drawing.Size(75, 23);
            this.BtnView.TabIndex = 4;
            this.BtnView.Text = "View";
            this.BtnView.UseVisualStyleBackColor = true;
            this.BtnView.Click += new System.EventHandler(this.BtnView_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(849, 478);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Dtable);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(417, 478);
            this.panel4.TabIndex = 1;
            // 
            // Dtable
            // 
            this.Dtable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dtable.Location = new System.Drawing.Point(0, 0);
            this.Dtable.Name = "Dtable";
            this.Dtable.RowTemplate.Height = 24;
            this.Dtable.Size = new System.Drawing.Size(417, 478);
            this.Dtable.TabIndex = 1;
            this.Dtable.DoubleClick += new System.EventHandler(this.Dtable_DoubleClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.CmbStudentId);
            this.panel3.Controls.Add(this.CmbTeacherId);
            this.panel3.Controls.Add(this.CmbSubjectId);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.TxtComment);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.BtnDel);
            this.panel3.Controls.Add(this.BtnInsert);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.TxtDate);
            this.panel3.Controls.Add(this.TxtStatus);
            this.panel3.Controls.Add(this.TxtAssignmentId);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(415, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(434, 478);
            this.panel3.TabIndex = 0;
            // 
            // CmbStudentId
            // 
            this.CmbStudentId.FormattingEnabled = true;
            this.CmbStudentId.Location = new System.Drawing.Point(242, 134);
            this.CmbStudentId.Name = "CmbStudentId";
            this.CmbStudentId.Size = new System.Drawing.Size(100, 24);
            this.CmbStudentId.TabIndex = 28;
            // 
            // CmbTeacherId
            // 
            this.CmbTeacherId.FormattingEnabled = true;
            this.CmbTeacherId.Location = new System.Drawing.Point(242, 197);
            this.CmbTeacherId.Name = "CmbTeacherId";
            this.CmbTeacherId.Size = new System.Drawing.Size(100, 24);
            this.CmbTeacherId.TabIndex = 27;
            // 
            // CmbSubjectId
            // 
            this.CmbSubjectId.FormattingEnabled = true;
            this.CmbSubjectId.Location = new System.Drawing.Point(242, 78);
            this.CmbSubjectId.Name = "CmbSubjectId";
            this.CmbSubjectId.Size = new System.Drawing.Size(100, 24);
            this.CmbSubjectId.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "comment";
            // 
            // TxtComment
            // 
            this.TxtComment.Location = new System.Drawing.Point(242, 373);
            this.TxtComment.Name = "TxtComment";
            this.TxtComment.Size = new System.Drawing.Size(100, 22);
            this.TxtComment.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Student Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Subject Id";
            // 
            // BtnDel
            // 
            this.BtnDel.Location = new System.Drawing.Point(123, 432);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(75, 34);
            this.BtnDel.TabIndex = 21;
            this.BtnDel.Text = "delete";
            this.BtnDel.UseVisualStyleBackColor = true;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // BtnInsert
            // 
            this.BtnInsert.Location = new System.Drawing.Point(226, 432);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(75, 34);
            this.BtnInsert.TabIndex = 20;
            this.BtnInsert.Text = "Insert";
            this.BtnInsert.UseVisualStyleBackColor = true;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Date of Submission";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Teacher Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Assignment Id";
            // 
            // TxtDate
            // 
            this.TxtDate.Location = new System.Drawing.Point(242, 263);
            this.TxtDate.Name = "TxtDate";
            this.TxtDate.Size = new System.Drawing.Size(100, 22);
            this.TxtDate.TabIndex = 14;
            // 
            // TxtStatus
            // 
            this.TxtStatus.Location = new System.Drawing.Point(242, 325);
            this.TxtStatus.Name = "TxtStatus";
            this.TxtStatus.Size = new System.Drawing.Size(100, 22);
            this.TxtStatus.TabIndex = 13;
            // 
            // TxtAssignmentId
            // 
            this.TxtAssignmentId.BackColor = System.Drawing.SystemColors.Info;
            this.TxtAssignmentId.Location = new System.Drawing.Point(242, 15);
            this.TxtAssignmentId.Name = "TxtAssignmentId";
            this.TxtAssignmentId.Size = new System.Drawing.Size(100, 22);
            this.TxtAssignmentId.TabIndex = 12;
            // 
            // FrmAssignments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 572);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmAssignments";
            this.Text = "Assignments";
            this.Load += new System.EventHandler(this.FrmAssignments_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dtable)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnView;
        private System.Windows.Forms.DataGridView Dtable;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox CmbStudentId;
        private System.Windows.Forms.ComboBox CmbTeacherId;
        private System.Windows.Forms.ComboBox CmbSubjectId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtComment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnDel;
        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtDate;
        private System.Windows.Forms.TextBox TxtStatus;
        private System.Windows.Forms.TextBox TxtAssignmentId;
    }
}