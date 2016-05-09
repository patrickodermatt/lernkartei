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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            register();
            frmMain main = new frmMain();
            this.Hide();
            if (main.ShowDialog() == DialogResult.Cancel)
                this.Close();
        }

        private void register()
        {
            using (var context = new Lernkartei_Entities())
            {
                context.TbLogin.Add(new TbLogin { UserID=3, Username = this.txtUsername.Text, Password = this.txtPassword.Text });
                context.SaveChanges();
            }
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnOk_Click(sender, e);
        }
    }
}
