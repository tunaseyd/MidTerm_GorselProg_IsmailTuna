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
    

    public partial class Staff : Form // Form names stayed as Administration
    {
        private List<SchoolAdm> staff { get; set; } = new List<SchoolAdm>();
        public Staff()
        {
            InitializeComponent();
        }

        


        private void Administration_Load(object sender, EventArgs e)
        {
            var ctx = new SDBEntities();
            var stff = ctx.StaffDBs.ToList();
            var bindingList = new BindingList<StaffDB>(stff);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }

        

        private void SearchButton_Click(object sender, EventArgs e)
        {
            var ctx = new SDBEntities();
            var stff = ctx.StaffDBs.ToList().Where(x => x.Staff_ID == SearchBox.Text || x.Staff_Name == SearchBox.Text).ToList();


            var bindingList = new BindingList<StaffDB>(stff);
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
            AdminChild f = new AdminChild();
            f.ShowDialog();
            f = null;
            this.Show();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminUChild f = new AdminUChild();
            f.ShowDialog();
            f = null;
            this.Show();
        }

        private void resetbttn_Click(object sender, EventArgs e)
        {
            var ctx = new SDBEntities();
            var stff = ctx.StaffDBs.ToList();
            var bindingList = new BindingList<StaffDB>(stff);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }
    }
}
