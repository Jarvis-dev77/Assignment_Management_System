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
    public partial class teacherdispatch : Form
    {
        private bool IsEditMode = false;
        public teacherdispatch()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-2ILOCVB\SQLEXPRESS;Initial Catalog=AssignmentDB;Integrated Security=True");

        private void BtnEdit_Click(object sender, EventArgs e)
        {

            IsEditMode = true;
            
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
                    //TxtDispatch.Clear();
                    TxtReturn.Clear();         
                    TxtRemarks.ReadOnly = true;
                    break;
                case "New"://setting when new is clicked
                    BtnNew.Enabled = false;
                    BtnDel.Enabled = false;
                    BtnEdit.Enabled = false;
                    BtnInsert.Enabled = true;
                    TxtId.Clear();
                    //TxtDispatch.Clear();
                    TxtReturn.Clear();
                    TxtRemarks.ReadOnly = true;
                   
                    break;
            }
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            string sqldisplay = "Select TeacherDispatchid,Assignmentid,DateOfDispatch,IsReturn,Remarks" + " from TeacherDispatch";
            DBconnection.ExecuteNonQuery(sqldisplay);
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            if (ValidateData() != true)
                return;
            EnableDisableControl("Insert");
            if (IsEditMode == false)
            {
                //query for insert
                string sql = "insert into TeacherDispatch (TeacherDispatchId,Assignmentid,DateOfDispatch,IsReturn,Remarks)values('" + TxtId.Text + "','" + CmbTecaherDispatch.SelectedValue + "','" + DateOfDispatch.Value + "','" + TxtReturn.Text + "','"+TxtRemarks.Text +"')";
                DBconnection.ExecuteNonQuery(sql);
                MessageBox.Show("inserted succcessfully");
            }
            else
            {
                string sqlUpdate = "update TeacherDispatch set  DateOfDispatch='" + DateOfDispatch.Value + "',IsReturn='" + TxtReturn.Text + "',Remarks='" + TxtRemarks.Text + "' where TeacherDispatchId=" + TxtId.Text;
                DBconnection.ExecuteNonQuery(sqlUpdate);

                //query for update
            }
            LoadData();

        }
        private void LoadData()
        {
            string sql = "Select TeacherDispatchID,Assignmentid,DateOfDispatch,IsReturn,Remarks" + " from TeacherDispatch";
            Dtable.DataSource = DBconnection.GetTableQuery(sql);
        }
        private bool ValidateData()
        {
            if (TxtId.Text == "")
            {
                MessageBox.Show("please enter the assignment id");
                TxtId.Focus();
                return false;
            }
            if (CmbTecaherDispatch.Text =="")
            {
                MessageBox.Show("please enter the assignment id");
                CmbTecaherDispatch.Focus();
                return false;
            }
            if (DateOfDispatch.Text == "")
            {
                MessageBox.Show("please enter the date of dispatch");
                DateOfDispatch.Focus();
                return false;
            }
            if (TxtReturn.Text == "")
            {
                MessageBox.Show("please enter the is returned");
                TxtReturn.Focus();
                return false;
            }
            if (TxtRemarks.Text == "")
            {
                MessageBox.Show("please enter the remarks");
                TxtRemarks.Focus();
                return false;
            }
            //validate duplicate assignment
            string sql = "select * from TeacherDispatch where TeacherDispatchId=" + TxtId.Text + " and AssignmentId=" +CmbTecaherDispatch.SelectedValue + " and DateOfDispatch=" + DateOfDispatch.Value + " and IsReturn=" + TxtReturn.Text + " and Remarks=" + TxtRemarks.Text ;
            DataTable Dtable = new DataTable();
            Dtable = DBconnection.GetTableQuery(sql);
            if (Dtable.Rows.Count > 1)
            {
                MessageBox.Show("This Assignemnt Already submitted");
                return false;
            }
            return true;
        }
        private void BtnDel_Click(object sender, EventArgs e)
        {
            DialogResult a;
            a = MessageBox.Show("are you sure to delete data", "delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.No)
            {
                return;
            }
            string sql = "delete from TeacherDispatch where TeacherDispatchId=" + TxtId.Text;
            DBconnection.ExecuteNonQuery(sql);
            LoadData();
        }


        private void teacherdispatch_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadFacultyCombo();
        }

        private int GetTeacherDispatchId()
        {
            try
            {
                string SQL = "select max(TeacherDispatchId)+1 from TeacherDispatch";
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
            TxtId.Text = GetTeacherDispatchId().ToString();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            TxtId.Text = Dtable.CurrentRow.Cells["TeacherDispatchId"].Value.ToString();
            CmbTecaherDispatch.SelectedValue = Dtable.CurrentRow.Cells["AssignmentId"].Value.ToString();
            DateOfDispatch.Text = Dtable.CurrentRow.Cells["DateOfDispatch"].Value.ToString();
            TxtReturn.Text = Dtable.CurrentRow.Cells["IsReturn"].Value.ToString();
            TxtRemarks.Text = Dtable.CurrentRow.Cells["Remarks"].Value.ToString();
        }
        private void LoadFacultyCombo()
        {
            string sql = "select AssignmentId" + " from Assignments";
            var data = DBconnection.GetTableQuery(sql);
            CmbTecaherDispatch.DataSource = data;
            CmbTecaherDispatch.DisplayMember = "AssignmentId";
            CmbTecaherDispatch.ValueMember = "AssignmentId";
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            EnableDisableControl("Reset");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
