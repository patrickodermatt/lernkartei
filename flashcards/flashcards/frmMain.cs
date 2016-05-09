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
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnLearn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLearn frmLearn = new frmLearn();
            frmLearn.Closed += (s, args) => this.Close();
            frmLearn.Show();
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmManage frmManage = new frmManage();
            frmManage.Closed += (s, args) => this.Close();
            frmManage.Show();
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStats frmStats = new frmStats();
            frmStats.Closed += (s, args) => this.Close();
            frmStats.Show();
        }
    }
}
