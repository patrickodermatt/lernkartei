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
        public frmManage()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Hide();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmNewTheme newTheme = new frmNewTheme();
            newTheme.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmManageTheme manageTheme = new frmManageTheme();
            manageTheme.Show();
        }
    }
}
