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
    public partial class FrmSubjects : Form
    {
        private bool IsEditMode = false;
        public FrmSubjects()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-2ILOCVB\SQLEXPRESS;Initial Catalog=AssignmentDB;Integrated Security=True"); 
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                    TxtSubjectId.Clear();
                    TxtSubjectName.Clear();
                    TxtRemarks.Clear();
                    TxtSubjectId.ReadOnly = true;
                    TxtSubjectName.ReadOnly = true;
                    TxtRemarks.ReadOnly = true;
                    break;
                case "New"://setting when new is clicked
                    BtnNew.Enabled = false;
                    BtnDel.Enabled = false;
                    BtnEdit.Enabled = false;
                    BtnInsert.Enabled = true;
                    TxtSubjectId.Clear();
                    TxtSubjectName.Clear();
                    TxtRemarks.Clear();
                    TxtSubjectId.ReadOnly = true;
                    TxtSubjectName.ReadOnly = true;
                    TxtRemarks.ReadOnly = true;
                    break;
            }
        }
        private void BtnInsert_Click(object sender, EventArgs e)
        {
            if (ValidateData() != true)
                return;
            if (IsEditMode == false)
            {
                //query for insert
                string sql = "insert into Subjects (SubjectID,SubjectName,Remarks)values('" + TxtSubjectId.Text + "','" + TxtSubjectName.Text + "','" + TxtRemarks.Text + "')";
                DBconnection.ExecuteNonQuery(sql);
                MessageBox.Show("inserted succcessfully");
            }
            else
            {
                string sqlUpdate = "update Subjects set SubjectName = '" + TxtSubjectName.Text + "', Remarks = '" + TxtRemarks.Text + "' where SubjectId=" + TxtSubjectId.Text; ;
                MessageBox.Show("updated");
                DBconnection.ExecuteNonQuery(sqlUpdate);

                //query for update
            }
            LoadData();

        }
        private void LoadData()
        {
            string sql = "Select SubjectId,SubjectName,Remarks " + " from Subjects";
            Dtable.DataSource = DBconnection.GetTableQuery(sql);
        }
        private int GetSubjectId()
        {
            try
            {
                string SQL = "select max(SubjectId)+1 from Subjects";
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
            IsEditMode = false;
            //enabledisable control("new");
            TxtSubjectId.Text = GetSubjectId().ToString();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            IsEditMode = true;
            BtnInsert.Enabled = true;
        }

        private void FrmSubjects_Load(object sender, EventArgs e)
        {
            LoadData();
            
        }
        private bool ValidateData()
        {
            if (TxtSubjectId.Text == "")
            {
                MessageBox.Show("please enter the name");
                TxtSubjectId.Focus();
                return false;
            }
            if (TxtSubjectName.Text == "")
            {
                MessageBox.Show("please enter the name");
                TxtSubjectName.Focus();
                return false;
            }
            if (TxtRemarks.Text == "")
            {
                MessageBox.Show("please enter the Mob.No");
                TxtRemarks.Focus();
                return false;
            }
           
            return true;
        }
        private void Dtable_DoubleClick(object sender, EventArgs e)
        {

            TxtSubjectId.Text = Dtable.CurrentRow.Cells["SubjectId"].Value.ToString();
            TxtSubjectName.Text = Dtable.CurrentRow.Cells["SubjectName"].Value.ToString();
            TxtRemarks.Text = Dtable.CurrentRow.Cells["Remarks"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult a;
            a = MessageBox.Show("are you sure to delete data", "delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.No)
            {
                return;
            }
            string sql = "delete from Subjects where SubjectId=" + TxtSubjectId.Text;
            DBconnection.ExecuteNonQuery(sql);
            LoadData();
        }


    }

}
