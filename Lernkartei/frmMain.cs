using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lernkartei
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnLearn_Click(object sender, EventArgs e)
        {
            frmLearn learn = new frmLearn();
            this.Hide();
            if (learn.ShowDialog() == DialogResult.Cancel)
                this.Show();
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            frmManage manage = new frmManage();
            this.Hide();
            if (manage.ShowDialog() == DialogResult.Cancel)
                this.Show();
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            frmStats stats = new frmStats();
            stats.Show();
        }
    }
}
