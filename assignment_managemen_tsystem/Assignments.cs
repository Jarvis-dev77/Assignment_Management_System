using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace assignment_managemen_tsystem
{
    public partial class FrmAssignments : Form
    {
        private bool IsEditMode = false;
        public FrmAssignments()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-2ILOCVB\SQLEXPRESS;Initial Catalog=AssignmentDB;Integrated Security=True");
        private void EnableDisableControl(string mode)
        {
            switch (mode)
            {
                case "Reset"://to reset form
                    BtnNew.Enabled = true;
                    BtnDel.Enabled = false;
                    BtnEdit.Enabled = true;
                    BtnInsert.Enabled = false;
                    TxtAssignmentId.Clear();
                   TxtDate.Clear();
                    TxtComment.Clear();
                    TxtStatus.Clear();
                   
                    break;
                case "New"://setting when new is clicked
                    BtnNew.Enabled = false;
                    BtnDel.Enabled = false;
                    BtnEdit.Enabled = false;
                    BtnInsert.Enabled = true;
                    TxtAssignmentId.Clear();
                    TxtDate.Clear();
                    TxtComment.Clear();
                    TxtStatus.Clear();
                    break;
            }
        }
        private void FrmAssignments_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadFacultyCombo();
            LoadStudentCombo();
            LoadTeacherCombo();
        }
        private bool ValidateData()
        {
            if (CmbSubjectId.Text == "")
            {
                MessageBox.Show("please enter the subject id");
                CmbSubjectId.Focus();
                return false;
            }
            if (CmbStudentId.Text == "")
            {
                MessageBox.Show("please enter the student id");
                CmbStudentId.Focus();
                return false;
            }
            if (CmbTeacherId.Text == "")
            {
                MessageBox.Show("please enter the teacher id");
                CmbTeacherId.Focus();
                return false;
            }
            if (TxtDate.Text == "")
            {
                MessageBox.Show("please enter the Date of submission");
                TxtDate.Focus();
                return false;
            }
            if (TxtStatus.Text == "")
            {
                MessageBox.Show("please enter the status");
                TxtStatus.Focus();
                return false;
            }
            if (TxtComment.Text == "")
            {
                MessageBox.Show("please enter the Comment");
                TxtComment.Focus();
                return false;
            }
            //validate duplicate assignment
            string sql = "select * from Assignments where StudentId=" + CmbStudentId.SelectedValue + " and TeacherID=" + CmbTeacherId.SelectedValue + " and SubjectId=" + CmbSubjectId.SelectedValue;
            DataTable Dtable = new DataTable();
            Dtable = DBconnection.GetTableQuery(sql);
            if(Dtable.Rows.Count>1)
            {
                MessageBox.Show("This Assignemnt Already submitted");
                return false;
            }  
            return true;
        }
        private int GetAssignmentID()
        {
            try
            {
                string SQL = "select max(AssignmentId)+1 from Assignments";
                var data = DBconnection.GetTableQuery(SQL);
                return Convert.ToInt32(data.Rows[0][0]);
            }
            catch (Exception)
            {
                return 1;
            }
        }//end of get teacher


        private void BtnView_Click(object sender, EventArgs e)
        {
            string sqldisplay = "Select AssignmentId,StudentId,SubjectId,TeacherId,DateOfSubmision,Status,Comment" + "from Assignments";
            DBconnection.ExecuteNonQuery(sqldisplay);
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            if (ValidateData() != true)
                return;
            if (IsEditMode == false)
            {
                //query for insert
                string sql = "insert into Assignments (AssignmentId,StudentId,SubjectId,TeacherID,DateOfSubmision,Status,Comment)values('" + TxtAssignmentId.Text + "','" + CmbStudentId.SelectedValue + "','" +CmbSubjectId.SelectedValue + "','" + CmbTeacherId.SelectedValue + "','" + TxtDate.Text + "','" + TxtStatus.Text + "','" + TxtComment.Text + "')";
                DBconnection.ExecuteNonQuery(sql);
                MessageBox.Show("inserted succcessfully");
            }
            else
            {
                string sqlUpdate = "update Assignments set  DateOfSubmision='" + TxtDate.Text + "',Status='" + TxtStatus.Text + "',Comment='" + TxtComment.Text + "' where AssignmentId=" + TxtAssignmentId.Text;
                DBconnection.ExecuteNonQuery(sqlUpdate);

                //query for update
            }
            LoadData();

        }
        private void LoadData()
        {
            string sql = "Select AssignmentId,SubjectId,StudentId,TeacherID,DateOfSubmision,Status,Comment " + "from Assignments";
            Dtable.DataSource = DBconnection.GetTableQuery(sql);
        }
        private void BtnDel_Click(object sender, EventArgs e)
        {

            DialogResult a;
            a = MessageBox.Show("are you sure to delete data", "delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.No)
            {
                return;
            }
            string sql = "delete from Assignments where AssignmentId=" + TxtAssignmentId.Text;
            DBconnection.ExecuteNonQuery(sql);
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IsEditMode = false;
            EnableDisableControl("New");
            TxtAssignmentId.Text = GetAssignmentID().ToString();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {

            IsEditMode = true;
            
        }
        private void LoadFacultyCombo()
        {
            string sql = "select SubjectId" + " from Subjects";      
            var data = DBconnection.GetTableQuery(sql);
            CmbSubjectId.DataSource = data;
            CmbSubjectId.DisplayMember = "SubjectId";
            CmbSubjectId.ValueMember = "SubjectId";

        }
        private void LoadStudentCombo()
        {
            string sql2 = "select StudentId" + " from Students";
            var data2 = DBconnection.GetTableQuery(sql2);
            CmbStudentId.DataSource = data2;
            CmbStudentId.DisplayMember = "StudentId";
            CmbStudentId.ValueMember = "StudentId";
        }
        private void LoadTeacherCombo()
        {
            string sql3 = "select TeacherID" + " from Teacher";
            var data3 = DBconnection.GetTableQuery(sql3);
            CmbTeacherId.DataSource = data3;
            CmbTeacherId.DisplayMember = "TeacherID";
            CmbTeacherId.ValueMember = "TeacherID";
        }

        private void Dtable_DoubleClick(object sender, EventArgs e)
        {

            TxtAssignmentId.Text = Dtable.CurrentRow.Cells["AssignmentId"].Value.ToString();
            CmbSubjectId.SelectedValue = Dtable.CurrentRow.Cells["SubjectId"].Value.ToString();
            CmbStudentId.SelectedValue = Dtable.CurrentRow.Cells["StudentId"].Value.ToString();
            CmbTeacherId.SelectedValue = Dtable.CurrentRow.Cells["TeacherID"].Value.ToString();
            TxtDate.Text = Dtable.CurrentRow.Cells["DateOfSubmision"].Value.ToString();
            TxtStatus.Text = Dtable.CurrentRow.Cells["Status"].Value.ToString();
            TxtComment.Text = Dtable.CurrentRow.Cells["Comment"].Value.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            EnableDisableControl("Reset");

        }
    }
}
