using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flashcards
{
    public partial class frmMain : Form
    {
        public frmLearn learn = null;
        public frmManage manage = null;
        public frmStats stats = null;
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnLearn_Click(object sender, EventArgs e)
        {
            if (learn == null)
                learn = new frmLearn();
            this.Hide();
            if (learn.ShowDialog() == DialogResult.Cancel)
                this.Show();
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            if (manage == null)
                manage = new frmManage();
            this.Hide();
            if (manage.ShowDialog() == DialogResult.Cancel)
                this.Show();
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            if (stats == null)
                stats = new frmStats();
            this.Hide();
            if (stats.ShowDialog() == DialogResult.Cancel)
                this.Show();
        }
    }
}
