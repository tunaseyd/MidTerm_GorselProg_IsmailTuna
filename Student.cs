using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselHW1_IsmailTunaSeydisehirli
{
    public partial class Student : Form
    {
        public static StudentDB StudentEntity { get; set; }

        public Student()
        {
            InitializeComponent();
        }

        
        private void SearchButton_Click(object sender, EventArgs e)
        {
            var ctx = new SDBEntities();
            var stdnt = ctx.StudentDBs.ToList().Where(x => x.Student_ID == SearchBox.Text || x.Student_Name  == SearchBox.Text).ToList();
            StudentEntity = stdnt.FirstOrDefault();



            var bindingList = new BindingList<StudentDB>(stdnt);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }

        private void Resetbttn_Click(object sender, EventArgs e)
        {
            var ctx = new SDBEntities();
            var stdnt = ctx.StudentDBs.ToList();
            var bindingList = new BindingList<StudentDB>(stdnt);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }

        private void Form_Load(object sender, EventArgs e)
        
        {
            var ctx = new SDBEntities();
            var stdnt = ctx.StudentDBs.ToList();

            

            var bindingList = new BindingList<StudentDB>(stdnt);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }

        private void DellButton_Click(object sender, EventArgs e)
        {
            if (StudentEntity != null)
            {
                var ctx = new SDBEntities();
                ctx.StudentDBs.ToList().Remove(StudentEntity);
                ctx.SaveChanges();
                
                var stdnt = ctx.StudentDBs.ToList();
                
                var bindingList = new BindingList<StudentDB>(stdnt);
                var source = new BindingSource(bindingList, null);
                dataGridView1.DataSource = source;



            }
            
        }

        private void RegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentChild f = new StudentChild();
            f.ShowDialog();
            f = null;
            this.Show();
        }

        private void UpdateToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            StudentUChild f = new StudentUChild();
            f.ShowDialog();
            f = null;
            this.Show();
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SearchBox.Text = dataGridView1.CurrentCell.Value.ToString();
        }
    }
}
