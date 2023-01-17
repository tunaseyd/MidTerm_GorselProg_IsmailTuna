using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselHW1_IsmailTunaSeydisehirli
{
    public partial class Lessons : Form
    {
        private List<SchoolLesson> lessons { get; set; } = new List<SchoolLesson>();
        public Lessons()
        {
            InitializeComponent();
        }

        private void Classes_Load(object sender, EventArgs e)
        {
            var ctx = new SDBEntities();
            var lssn = ctx.LessonDBs.ToList();
            var bindingList = new BindingList<LessonDB>(lssn);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }

        

        

        private void SearchButton_Click(object sender, EventArgs e)
        {
            var ctx = new SDBEntities();
            var lssn = ctx.LessonDBs.ToList().Where(x => x.Lesson_ID == SearchBox.Text || x.Lesson_Name == SearchBox.Text).ToList();


            var bindingList = new BindingList<LessonDB>(lssn);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }

        private void DellButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);

        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClassChild f = new ClassChild();
            f.ShowDialog();
            f = null;
            this.Show();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClassChild f = new ClassChild();
            f.ShowDialog();
            f = null;
            this.Show();
        }

        private void resetbttn_Click(object sender, EventArgs e)
        {
            var ctx = new SDBEntities();
            var lssn = ctx.LessonDBs.ToList();
            var bindingList = new BindingList<LessonDB>(lssn);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }

        
    }
}
