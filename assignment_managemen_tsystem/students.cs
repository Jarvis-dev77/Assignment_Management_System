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
    public partial class FrmStudents : Form
    {
        private bool IsEditMode = false;
        public FrmStudents()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-2ILOCVB\SQLEXPRESS;Initial Catalog=AssignmentDB;Integrated Security=True");

        private void BtnView_Click(object sender, EventArgs e)
        {
            string sqldisplay = "Select StudentId,FirstName,LastName,Section,EmailAddres,ContactNo,Remarks,FacultyId" + " from Students";
            DBconnection.ExecuteNonQuery(sqldisplay);
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            IsEditMode = true;
            BtnInsert.Enabled = true;
        }
        private void EnableDisableControl(string mode)
        {
            switch (mode)
            {
                case "Reset"://to reset form
                    BtnNew.Enabled = true;
                    BtnDel.Enabled = false;
                    BtnEdit.Enabled = true;
                    BtnInsert.Enabled = false;
                    TxtId.Clear();
                    TxtFirstName.Clear();
                    TxtSecondName.Clear();
                    TxtEmail.Clear();
                    TxtMobNo.ReadOnly = true;
                    TxtSection.ReadOnly = true;
                    TxtRemarks.ReadOnly = true;
                    break;
                case "New"://setting when new is clicked
                    BtnNew.Enabled = false;
                    BtnDel.Enabled = false;
                    BtnEdit.Enabled = false;
                    BtnInsert.Enabled = true;
                    TxtId.Clear();
                    TxtFirstName.Clear();
                    TxtSecondName.Clear();
                    TxtEmail.Clear();
                    TxtMobNo.ReadOnly = true;
                    TxtSection.ReadOnly = true;
                    TxtRemarks.ReadOnly = true;
                    break;
            }
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            if (ValidateData() != true)
                return;
            EnableDisableControl("Insert");
            if (IsEditMode == false)
            {
                //query for insert
                string sql = "insert into Students (StudentId,FirstName,LastName,Section,EmailAddres,ContactNo,Remarks,FacultyId)values('" + TxtId.Text + "','" + TxtFirstName.Text + "','" + TxtSecondName.Text + "','" + TxtSection.Text + "','" + TxtEmail.Text + "','" + TxtMobNo.Text + "','" + TxtRemarks.Text + "','" + CmbFaculty.SelectedValue + "')";
                DBconnection.ExecuteNonQuery(sql);
                MessageBox.Show("inserted succcessfully");
            }
            else
            {
                string sqlUpdate = "update Students set FirstName = '" + TxtFirstName.Text + "', LastName='" + TxtSecondName.Text + "', EmailAddres = '" + TxtEmail.Text + "', Section= '" + TxtSection.Text + "', ContactNo = '" + TxtMobNo.Text + "', Remarks='" + TxtRemarks.Text + "', FacultyId='" + CmbFaculty.SelectedValue + "' where StudentId = " + TxtId.Text; ;
                MessageBox.Show("updated");
                DBconnection.ExecuteNonQuery(sqlUpdate);

                //query for update
            }
            LoadData();

        }
        private void LoadData()
        {
            string sql = "Select StudentId,FirstName,LastName,Section,EmailAddres,ContactNo,Remarks,FacultyId " + " from Students";
            DTable.DataSource = DBconnection.GetTableQuery(sql);
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            DialogResult a;
            a = MessageBox.Show("are you sure to delete data", "delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.No)
            {
                return;
            }
            string sql = "delete from teacher where TeacherId=" + TxtId.Text;
            DBconnection.ExecuteNonQuery(sql);
            LoadData();
        }

        private void FrmStudents_Load(object sender, EventArgs e)
        {
            LoadFacultyCombo();
            LoadData();
        }
        private bool ValidateData()
        {
            if (TxtId.Text == "")
            {
                MessageBox.Show("please enter the id");
                TxtId.Focus();
                return false;
            }
            if (TxtFirstName.Text == "")
            {
                MessageBox.Show("please enter the first name");
                TxtFirstName.Focus();
                return false;
            }
            if (TxtSecondName.Text == "")
            {
                MessageBox.Show("please enter the second name");
                TxtSecondName.Focus();
                return false;
            }
            if (TxtMobNo.Text == "")
            {
                MessageBox.Show("please enter the Mob.No");
                TxtMobNo.Focus();
                return false;
            }
            if (TxtEmail.Text == "")
            {
                MessageBox.Show("please enter the email");
                TxtEmail.Focus();
                return false;
            }
            if (TxtSection.Text == "")
            {
                MessageBox.Show("please enter the section");
                TxtSection.Focus();
                return false;
            }
            if (TxtRemarks.Text == "")
            {
                MessageBox.Show("please enter the remarks");
                TxtRemarks.Focus();
                return false;
            }
            if (CmbFaculty.Text == "")
            {
                MessageBox.Show("please enter the faculty id");
                CmbFaculty.Focus();
                return false;
            }
            return true;
        }
        private int GetStudentId()
        {
            try
            {
                string SQL = "select max(StudentId)+1 from Students";
                var data = DBconnection.GetTableQuery(SQL);
                return Convert.ToInt32(data.Rows[0][0]);
            }
            catch (Exception)
            {
                return 1;
            }
        }//end of get teacher

        private void BtnNew_Click(object sender, EventArgs e)
        {
            IsEditMode = false;
            EnableDisableControl("new");
            TxtId.Text = GetStudentId().ToString();
        }

        private void DTable_DoubleClick(object sender, EventArgs e)
        {
            TxtId.Text = DTable.CurrentRow.Cells["StudentId"].Value.ToString();
            TxtFirstName.Text = DTable.CurrentRow.Cells["FirstName"].Value.ToString();
            TxtSecondName.Text = DTable.CurrentRow.Cells["LastName"].Value.ToString();
            TxtSection.Text = DTable.CurrentRow.Cells["Section"].Value.ToString();
            TxtEmail.Text = DTable.CurrentRow.Cells["EmailAddres"].Value.ToString();
            TxtMobNo.Text = DTable.CurrentRow.Cells["ContactNo"].Value.ToString();
            TxtRemarks.Text = DTable.CurrentRow.Cells["Remarks"].Value.ToString();
            CmbFaculty.Text = DTable.CurrentRow.Cells["FacultyId"].Value.ToString();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void LoadFacultyCombo()
        {
            string sql = "select FacultyId" + " from Faculty";
            var data = DBconnection.GetTableQuery(sql);
            CmbFaculty.DataSource = data;
            CmbFaculty.DisplayMember = "FacultyId";
            CmbFaculty.ValueMember = "FacultyId";
        }

        private void CmbFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnReset_Click(object sender, EventArgs e)
        {

        }
    }
}

