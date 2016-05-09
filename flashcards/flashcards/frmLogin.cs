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
                this.Hide();
                frmMain frmMain = new frmMain();
                frmMain.Closed += (s, args) => this.Close();
                frmMain.Show();
            }
        }

        private bool login()
        {
            using(var context = new Lernkartei_Entities())
            {
                TbLogin person = context.TbLogin.SingleOrDefault(p => p.Username == this.txtUsername.Text);

                if(person == null)
                {
                    MessageBox.Show("User not found");
                    return false;
                }

                if(person.Password == this.txtPassword.Text)
                    return true;

                else
                {
                    MessageBox.Show("Password incorrect");
                    return false;
                }
            }
        }

        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegister register = new frmRegister();
            this.Hide();
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
