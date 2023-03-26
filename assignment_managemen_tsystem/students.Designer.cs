namespace assignment_managemen_tsystem
{
    partial class FrmStudents
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
            this.DTable = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CmbFaculty = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Remarks = new System.Windows.Forms.Label();
            this.Section = new System.Windows.Forms.Label();
            this.TxtSection = new System.Windows.Forms.TextBox();
            this.TxtRemarks = new System.Windows.Forms.TextBox();
            this.BtnDel = new System.Windows.Forms.Button();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.TxtSecondName = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtMobNo = new System.Windows.Forms.TextBox();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTable)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1000, 85);
            this.panel1.TabIndex = 0;
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(591, 39);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(75, 23);
            this.BtnNew.TabIndex = 9;
            this.BtnNew.Text = "new";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(368, 39);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(75, 23);
            this.BtnEdit.TabIndex = 8;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(475, 39);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(75, 23);
            this.BtnReset.TabIndex = 7;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnView
            // 
            this.BtnView.Location = new System.Drawing.Point(250, 39);
            this.BtnView.Name = "BtnView";
            this.BtnView.Size = new System.Drawing.Size(75, 23);
            this.BtnView.TabIndex = 6;
            this.BtnView.Text = "View";
            this.BtnView.UseVisualStyleBackColor = true;
            this.BtnView.Click += new System.EventHandler(this.BtnView_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 477);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.DTable);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(605, 477);
            this.panel4.TabIndex = 1;
            // 
            // DTable
            // 
            this.DTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DTable.Location = new System.Drawing.Point(0, 0);
            this.DTable.Name = "DTable";
            this.DTable.RowTemplate.Height = 24;
            this.DTable.Size = new System.Drawing.Size(605, 477);
            this.DTable.TabIndex = 1;
            this.DTable.DoubleClick += new System.EventHandler(this.DTable_DoubleClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.CmbFaculty);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.Remarks);
            this.panel3.Controls.Add(this.Section);
            this.panel3.Controls.Add(this.TxtSection);
            this.panel3.Controls.Add(this.TxtRemarks);
            this.panel3.Controls.Add(this.BtnDel);
            this.panel3.Controls.Add(this.BtnInsert);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.TxtFirstName);
            this.panel3.Controls.Add(this.TxtSecondName);
            this.panel3.Controls.Add(this.TxtEmail);
            this.panel3.Controls.Add(this.TxtMobNo);
            this.panel3.Controls.Add(this.TxtId);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(605, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(395, 477);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // CmbFaculty
            // 
            this.CmbFaculty.FormattingEnabled = true;
            this.CmbFaculty.Location = new System.Drawing.Point(246, 384);
            this.CmbFaculty.Name = "CmbFaculty";
            this.CmbFaculty.Size = new System.Drawing.Size(121, 24);
            this.CmbFaculty.TabIndex = 28;
            this.CmbFaculty.SelectedIndexChanged += new System.EventHandler(this.CmbFaculty_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "FacultyId";
            // 
            // Remarks
            // 
            this.Remarks.AutoSize = true;
            this.Remarks.Location = new System.Drawing.Point(49, 341);
            this.Remarks.Name = "Remarks";
            this.Remarks.Size = new System.Drawing.Size(64, 17);
            this.Remarks.TabIndex = 25;
            this.Remarks.Text = "Remarks";
            // 
            // Section
            // 
            this.Section.AutoSize = true;
            this.Section.Location = new System.Drawing.Point(49, 297);
            this.Section.Name = "Section";
            this.Section.Size = new System.Drawing.Size(55, 17);
            this.Section.TabIndex = 24;
            this.Section.Text = "Section";
            // 
            // TxtSection
            // 
            this.TxtSection.Location = new System.Drawing.Point(246, 292);
            this.TxtSection.Name = "TxtSection";
            this.TxtSection.Size = new System.Drawing.Size(100, 22);
            this.TxtSection.TabIndex = 23;
            // 
            // TxtRemarks
            // 
            this.TxtRemarks.Location = new System.Drawing.Point(246, 338);
            this.TxtRemarks.Name = "TxtRemarks";
            this.TxtRemarks.Size = new System.Drawing.Size(100, 22);
            this.TxtRemarks.TabIndex = 22;
            // 
            // BtnDel
            // 
            this.BtnDel.Location = new System.Drawing.Point(98, 431);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(75, 34);
            this.BtnDel.TabIndex = 21;
            this.BtnDel.Text = "delete";
            this.BtnDel.UseVisualStyleBackColor = true;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // BtnInsert
            // 
            this.BtnInsert.Location = new System.Drawing.Point(201, 431);
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
            this.label5.Location = new System.Drawing.Point(49, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "MobileNo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Second Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "student Id";
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Location = new System.Drawing.Point(246, 80);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(100, 22);
            this.TxtFirstName.TabIndex = 14;
            // 
            // TxtSecondName
            // 
            this.TxtSecondName.Location = new System.Drawing.Point(246, 141);
            this.TxtSecondName.Name = "TxtSecondName";
            this.TxtSecondName.Size = new System.Drawing.Size(100, 22);
            this.TxtSecondName.TabIndex = 13;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(246, 248);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(100, 22);
            this.TxtEmail.TabIndex = 12;
            // 
            // TxtMobNo
            // 
            this.TxtMobNo.Location = new System.Drawing.Point(246, 200);
            this.TxtMobNo.Name = "TxtMobNo";
            this.TxtMobNo.Size = new System.Drawing.Size(100, 22);
            this.TxtMobNo.TabIndex = 11;
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(246, 18);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(100, 22);
            this.TxtId.TabIndex = 10;
            // 
            // FrmStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmStudents";
            this.Text = "Students";
            this.Load += new System.EventHandler(this.FrmStudents_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DTable)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnView;
        private System.Windows.Forms.DataGridView DTable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtFirstName;
        private System.Windows.Forms.TextBox TxtSecondName;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtMobNo;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Button BtnDel;
        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Label Remarks;
        private System.Windows.Forms.Label Section;
        private System.Windows.Forms.TextBox TxtSection;
        private System.Windows.Forms.TextBox TxtRemarks;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CmbFaculty;
    }
}