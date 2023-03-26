namespace assignment_managemen_tsystem
{
    partial class FrmSubjects
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
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSubjectName = new System.Windows.Forms.TextBox();
            this.TxtRemarks = new System.Windows.Forms.TextBox();
            this.TxtSubjectId = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Dtable = new System.Windows.Forms.DataGridView();
            this.BtnDel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dtable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnEdit);
            this.panel1.Controls.Add(this.BtnReset);
            this.panel1.Controls.Add(this.BtnNew);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 100);
            this.panel1.TabIndex = 0;
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(430, 39);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(75, 23);
            this.BtnEdit.TabIndex = 5;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(537, 39);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(75, 23);
            this.BtnReset.TabIndex = 4;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(312, 39);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(75, 23);
            this.BtnNew.TabIndex = 3;
            this.BtnNew.Text = "New";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnView_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(964, 467);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.BtnDel);
            this.panel4.Controls.Add(this.BtnInsert);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.TxtSubjectName);
            this.panel4.Controls.Add(this.TxtRemarks);
            this.panel4.Controls.Add(this.TxtSubjectId);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(472, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(492, 467);
            this.panel4.TabIndex = 1;
            // 
            // BtnInsert
            // 
            this.BtnInsert.Location = new System.Drawing.Point(193, 325);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(75, 37);
            this.BtnInsert.TabIndex = 18;
            this.BtnInsert.Text = "insert";
            this.BtnInsert.UseVisualStyleBackColor = true;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Remarks";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Subject Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Subject Id";
            // 
            // TxtSubjectName
            // 
            this.TxtSubjectName.Location = new System.Drawing.Point(275, 160);
            this.TxtSubjectName.Name = "TxtSubjectName";
            this.TxtSubjectName.Size = new System.Drawing.Size(100, 22);
            this.TxtSubjectName.TabIndex = 14;
            // 
            // TxtRemarks
            // 
            this.TxtRemarks.Location = new System.Drawing.Point(275, 221);
            this.TxtRemarks.Name = "TxtRemarks";
            this.TxtRemarks.Size = new System.Drawing.Size(100, 22);
            this.TxtRemarks.TabIndex = 13;
            // 
            // TxtSubjectId
            // 
            this.TxtSubjectId.Location = new System.Drawing.Point(275, 98);
            this.TxtSubjectId.Name = "TxtSubjectId";
            this.TxtSubjectId.Size = new System.Drawing.Size(100, 22);
            this.TxtSubjectId.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Dtable);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(472, 467);
            this.panel3.TabIndex = 0;
            // 
            // Dtable
            // 
            this.Dtable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dtable.Location = new System.Drawing.Point(0, 0);
            this.Dtable.Name = "Dtable";
            this.Dtable.RowTemplate.Height = 24;
            this.Dtable.Size = new System.Drawing.Size(472, 467);
            this.Dtable.TabIndex = 0;
            this.Dtable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.Dtable.DoubleClick += new System.EventHandler(this.Dtable_DoubleClick);
            // 
            // BtnDel
            // 
            this.BtnDel.Location = new System.Drawing.Point(99, 325);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(75, 37);
            this.BtnDel.TabIndex = 19;
            this.BtnDel.Text = "Delete";
            this.BtnDel.UseVisualStyleBackColor = true;
            this.BtnDel.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmSubjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 567);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmSubjects";
            this.Text = "subjects";
            this.Load += new System.EventHandler(this.FrmSubjects_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dtable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView Dtable;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSubjectName;
        private System.Windows.Forms.TextBox TxtRemarks;
        private System.Windows.Forms.TextBox TxtSubjectId;
        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.Button BtnDel;
    }
}