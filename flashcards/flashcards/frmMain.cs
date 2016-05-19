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
    public partial class frmMain : MetroFramework.Forms.MetroForm
    {
        private string username;
        public frmMain(string user)
        {
            this.username = user;
            InitializeComponent();
        }

        private void btnLearn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLearn frmLearn = new frmLearn(this.username);
            frmLearn.Closed += (s, args) => this.Show();
            frmLearn.Show();
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmManage frmManage = new frmManage(this.username);
            frmManage.Closed += (s, args) => this.Show();
            frmManage.Show();
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStats frmStats = new frmStats(this.username);
            frmStats.Closed += (s, args) => this.Show();
            frmStats.Show();
        }

        private void lnkPassword_Click(object sender, EventArgs e)
        {
            frmPassword frmPassword = new frmPassword(this.username);
            frmPassword.ShowDialog();
        }
    }
}
