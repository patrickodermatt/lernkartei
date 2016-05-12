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
    public partial class frmManage : Form
    {
        private string username;
        public frmManage(string user)
        {
            InitializeComponent();
            this.username = user;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmNewTheme newTheme = new frmNewTheme(this.username);
            newTheme.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmManageTheme manageTheme = new frmManageTheme(this.username);
            manageTheme.Show();
        }
    }
}
