using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_managemen_tsystem
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newForm = new FrmTeacher();
            newForm.Show();
            
        }

        private void BtnStudent_Click(object sender, EventArgs e)
        {
            var newForm = new FrmStudents();
            newForm.Show();
        }

        private void BtnFaculty_Click(object sender, EventArgs e)
        {
            var newForm = new FrmFaculty();
            newForm.Show();
        }

        private void BtnSubject_Click(object sender, EventArgs e)
        {
            var newForm = new FrmSubjects();
            newForm.Show();
        }

        private void BtnTeacherDispatch_Click(object sender, EventArgs e)
        {
            var newForm = new teacherdispatch();
            newForm.Show();
        }

        private void Btnssignment_Click(object sender, EventArgs e)
        {
            var newForm = new FrmAssignments();
            newForm.Show();
        }
    }
}
