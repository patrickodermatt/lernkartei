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
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" && txtUsername.Text != " ")
            {
                if (txtPassword.Text != "" && txtPassword.Text != " ")
                {
                    using (var context = new Lernkartei_Entities())
                    {
                        if (context.TbLogin.SingleOrDefault(u => u.Username == txtUsername.Text) == null)
                        {
                            register();
                            frmMain main = new frmMain(txtUsername.Text);
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Username allready exists");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Password");
                }
            }
            else{
                MessageBox.Show("Invalid Username");
            }
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
