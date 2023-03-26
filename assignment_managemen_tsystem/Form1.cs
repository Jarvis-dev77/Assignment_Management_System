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
    public partial class FrmTeacher : Form
    {
        private bool IsEditMode = false;
        public FrmTeacher()
        {
            InitializeComponent();
        }
       
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-2ILOCVB\SQLEXPRESS;Initial Catalog=AssignmentDB;Integrated Security=True");

        private void button3_Click(object sender, EventArgs e)
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
                    TxtName.Clear();
                    TxtEmail.Clear();
                    TxtMobNo.Clear();
                    TxtName.ReadOnly=true;
                    TxtEmail.ReadOnly = true;
                    TxtMobNo.ReadOnly = true;
                    break;
                case "new"://setting when new is clicked
                    BtnNew.Enabled = false;
                    BtnDel.Enabled = false;
                    BtnEdit.Enabled = false;
                    BtnInsert.Enabled = true;
                    TxtId.ReadOnly = true;
                    TxtName.ReadOnly = true;
                    TxtEmail.ReadOnly = true;
                    TxtMobNo.ReadOnly = true;
                    break;
                case "Edit":
                    BtnNew.Enabled = false;
                    BtnDel.Enabled = true;
                    BtnEdit.Enabled = false;
                    BtnInsert.Enabled = true;
                    break;
            }
        }
        private void BtnView_Click(object sender, EventArgs e)
        {
            string sqldisplay = "Select TeacherID,TeacherName,emailaddress,mobileno " + " from Teacher";
            DBconnection.ExecuteNonQuery(sqldisplay);
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            if (ValidateData() != true)
                return;
            if (IsEditMode==false)
            {
                //query for insert
                string sql = "insert into Teacher (TeacherID,TeacherName,emailaddress,mobileno)values('" + TxtId.Text + "','" + TxtName.Text + "','" + TxtEmail.Text + "','" + TxtMobNo.Text + "')";
                DBconnection.ExecuteNonQuery(sql);
                MessageBox.Show("inserted succcessfully");
            }
            else
            {
                string sqlUpdate = "update Teacher set TeacherName = '" + TxtName.Text + "', emailaddress = '" + TxtEmail.Text + "', mobileno = '" + TxtMobNo.Text + "' where TeacherId = " + TxtId.Text; ;
                MessageBox.Show("updated");
                DBconnection.ExecuteNonQuery(sqlUpdate);

                //query for update
            }
            LoadData();

        }
       private void LoadData()
        {
           string sql = "Select TeacherID,TeacherName,emailaddress,mobileno " + " from Teacher";
           Dtable.DataSource = DBconnection.GetTableQuery(sql);
        }
        
        private void BtnDel_Click(object sender, EventArgs e)
        {
            DialogResult a;
            a = MessageBox.Show("are you sure to delete data", "delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(a==DialogResult.No)
            {
                return;
            }
            string sql = "delete from teacher where TeacherId=" +TxtId.Text;
            DBconnection.ExecuteNonQuery(sql);
            LoadData();
        }

        private void FrmTeacher_Load(object sender, EventArgs e)
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
            if (TxtName.Text== "")
            {
                MessageBox.Show("please enter the name");
                TxtName.Focus();
                return false;
            }
            if(TxtMobNo.Text== "")
            {
                MessageBox.Show("please enter the Mob.No");
                TxtMobNo.Focus();
                return false;
            }
            if (TxtEmail.Text == "")
            {
                MessageBox.Show("please enter the Email");
                TxtEmail.Focus();
                return false;
            }
            
            return true;
        }
        private int GetTeacherID()
        {
            try
            {
                string SQL = "select max(teacherID)+1 from teacher";
                var data = DBconnection.GetTableQuery(SQL);
                return Convert.ToInt32(data.Rows[0][0]);
            }
            catch(Exception)
            {
                return 1;
            }
        }//end of get teacher

        private void button1_Click(object sender, EventArgs e)
        {
            IsEditMode = false;
            //enabledisable control("new");
            TxtId.Text = GetTeacherID().ToString();
        }

        private void Dtable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Dtable_DoubleClick(object sender, EventArgs e)
        {
            TxtId.Text = Dtable.CurrentRow.Cells["TeacherID"].Value.ToString();
            TxtName.Text = Dtable.CurrentRow.Cells["TeacherName"].Value.ToString();
            TxtEmail.Text = Dtable.CurrentRow.Cells["emailaddress"].Value.ToString();
            TxtMobNo.Text = Dtable.CurrentRow.Cells["mobileno"].Value.ToString();
        }

        private void Dtable_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Dtable_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
