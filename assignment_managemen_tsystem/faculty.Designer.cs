namespace assignment_managemen_tsystem
{
    partial class FrmFaculty
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnDel = new System.Windows.Forms.Button();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtFacultyName = new System.Windows.Forms.TextBox();
            this.Txtdes = new System.Windows.Forms.TextBox();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.Dtable = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dtable)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(872, 100);
            this.panel1.TabIndex = 1;
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(374, 34);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(75, 30);
            this.BtnNew.TabIndex = 4;
            this.BtnNew.Text = "new";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(152, 34);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(75, 30);
            this.BtnEdit.TabIndex = 2;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(259, 34);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(75, 30);
            this.BtnReset.TabIndex = 1;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnView
            // 
            this.BtnView.Location = new System.Drawing.Point(34, 34);
            this.BtnView.Name = "BtnView";
            this.BtnView.Size = new System.Drawing.Size(75, 30);
            this.BtnView.TabIndex = 0;
            this.BtnView.Text = "View";
            this.BtnView.UseVisualStyleBackColor = true;
            this.BtnView.Click += new System.EventHandler(this.BtnView_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BtnDel);
            this.panel3.Controls.Add(this.BtnInsert);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.TxtFacultyName);
            this.panel3.Controls.Add(this.Txtdes);
            this.panel3.Controls.Add(this.TxtId);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(477, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(395, 403);
            this.panel3.TabIndex = 2;
            // 
            // BtnDel
            // 
            this.BtnDel.Location = new System.Drawing.Point(120, 301);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(75, 34);
            this.BtnDel.TabIndex = 19;
            this.BtnDel.Text = "delete";
            this.BtnDel.UseVisualStyleBackColor = true;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // BtnInsert
            // 
            this.BtnInsert.Location = new System.Drawing.Point(223, 301);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(75, 34);
            this.BtnInsert.TabIndex = 18;
            this.BtnInsert.Text = "Insert";
            this.BtnInsert.UseVisualStyleBackColor = true;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Faculty Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "faculty Id";
            // 
            // TxtFacultyName
            // 
            this.TxtFacultyName.Location = new System.Drawing.Point(246, 162);
            this.TxtFacultyName.Name = "TxtFacultyName";
            this.TxtFacultyName.Size = new System.Drawing.Size(100, 22);
            this.TxtFacultyName.TabIndex = 14;
            // 
            // Txtdes
            // 
            this.Txtdes.Location = new System.Drawing.Point(246, 223);
            this.Txtdes.Name = "Txtdes";
            this.Txtdes.Size = new System.Drawing.Size(100, 22);
            this.Txtdes.TabIndex = 13;
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(246, 100);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(100, 22);
            this.TxtId.TabIndex = 10;
            // 
            // Dtable
            // 
            this.Dtable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dtable.Location = new System.Drawing.Point(0, 100);
            this.Dtable.Name = "Dtable";
            this.Dtable.RowTemplate.Height = 24;
            this.Dtable.Size = new System.Drawing.Size(477, 403);
            this.Dtable.TabIndex = 3;
            this.Dtable.DoubleClick += new System.EventHandler(this.Dtable_DoubleClick);
            // 
            // FrmFaculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 503);
            this.Controls.Add(this.Dtable);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "FrmFaculty";
            this.Text = "Faculty";
            this.Load += new System.EventHandler(this.FrmFaculty_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dtable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnView;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtFacultyName;
        private System.Windows.Forms.TextBox Txtdes;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.DataGridView Dtable;
        private System.Windows.Forms.Button BtnDel;
        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.Button BtnNew;
    }
}