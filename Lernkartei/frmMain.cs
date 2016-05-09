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
            learn.Show(this);
            this.Hide();
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            frmManage manage = new frmManage();
            manage.Show();
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            frmStats stats = new frmStats();
            stats.Show();
        }
    }
}
