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
    public partial class frmMainAdmin : MetroFramework.Forms.MetroForm
    {
        private string username;
        public frmMainAdmin(string user)
        {
            this.username = user;
            InitializeComponent();
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmManage frmManage = new frmManage(this.username);
            frmManage.Closed += (s, args) => this.Show();
            frmManage.Show();
        }

        private void btnManageUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmManageUser frmManageUser = new frmManageUser(this.username);
            frmManageUser.Closed += (s, args) => this.Show();
            frmManageUser.Show();
        }
    }
}
