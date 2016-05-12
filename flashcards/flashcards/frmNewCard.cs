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
    public partial class frmNewCard : Form
    {
        private string username;
        public frmNewCard(string user)
        {
            InitializeComponent();
            this.username = user;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void txtAnswer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnOk_Click(sender, e);
        }
    }
}
