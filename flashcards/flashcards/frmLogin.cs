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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (login())
            {
                frmMain main = new frmMain();
                this.Hide();
                if (main.ShowDialog() == DialogResult.Cancel)
                    this.Close();
            }
        }

        private bool login()
        {
            switch (txtUsername.Text)
            {
                case "Admin":
                    if (txtPassword.Text == "1234" || txtPassword.Text == "")
                        return true;
                    else
                        return false;
                default:
                    return true;
            }
        }

        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegister register = new frmRegister();
            this.Hide();
            if (register.ShowDialog() == DialogResult.Cancel)
                this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnOk_Click(sender, e);
        }
    }
}
