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
    public partial class FrmFaculty : Form
    {
        private bool IsEditMode = false;
        public FrmFaculty()
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
                    TxtId.Clear();
                    TxtFacultyName.Clear();
                    break;
                case "New"://setting when new is clicked
                    BtnNew.Enabled = false;
                    BtnDel.Enabled = false;
                    BtnEdit.Enabled = false;
                    BtnInsert.Enabled = true;
                    TxtId.Clear();
                    TxtFacultyName.Clear();
                   
                    break;
            }
        }

        private void FrmFaculty_Load(object sender, EventArgs e)
        {
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
            if (TxtFacultyName.Text == "")
            {
                MessageBox.Show("please enter the faculty name");
                TxtFacultyName.Focus();
                return false;
            }
            if (Txtdes.Text == "")
            {
                MessageBox.Show("please enter the description");
                Txtdes.Focus();
                return false;
            }
            return true;
        }
        private int GetFacultyId()
        {
            try
            {
                string SQL = "select max(FacultyId)+1 from Faculty";
                var data = DBconnection.GetTableQuery(SQL);
                return Convert.ToInt32(data.Rows[0][0]);
            }
            catch (Exception)
            {
                return 1;
            }
        }//end of get faculty

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            IsEditMode = true;
            BtnInsert.Enabled = true;
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            string sqldisplay = "Select FacultyId,FacultyName,Description" + " from Faculty";
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
                string sql = "insert into Faculty (FacultyId,FacultyName,Description)values('" + TxtId.Text + "','" + TxtFacultyName.Text + "','" + Txtdes.Text + "')";
                DBconnection.ExecuteNonQuery(sql);
                MessageBox.Show("inserted succcessfully");
            }
            else
            {
                string sqlUpdate = "update Faculty set  FacultyName='" + TxtFacultyName.Text + "',Description='" + Txtdes.Text + "'where FacultyId=" + TxtId.Text;
                DBconnection.ExecuteNonQuery(sqlUpdate);

                //query for update
            }
            LoadData();

        }
        private void LoadData()
        {
            string sql = "Select FacultyId,FacultyName,Description" + " from Faculty";
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
            string sql = "delete from Faculty where FacultyId=" + TxtId.Text;
            DBconnection.ExecuteNonQuery(sql);
            LoadData();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            IsEditMode = false;
            EnableDisableControl("New");
            TxtId.Text = GetFacultyId().ToString();
        }

        private void Dtable_DoubleClick(object sender, EventArgs e)
        {

            TxtId.Text = Dtable.CurrentRow.Cells["FacultyId"].Value.ToString();
            TxtFacultyName.Text = Dtable.CurrentRow.Cells["FacultyName"].Value.ToString();
            Txtdes.Text = Dtable.CurrentRow.Cells["Description"].Value.ToString();
            
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {

        }
    }


}

