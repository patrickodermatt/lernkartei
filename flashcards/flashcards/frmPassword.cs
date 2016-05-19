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
    public partial class frmPassword : MetroFramework.Forms.MetroForm
    {
        private string username;
        public frmPassword(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            using (var context = new Lernkartei_Entities())
            {
                var user = context.TbLogin.Single(x=> x.Username == this.username);

                if (this.txtOld.Text == user.Password)
                {
                    if (this.txtNew1.Text == this.txtNew2.Text)
                    {
                        user.Password = this.txtNew1.Text;
                        context.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("password doesn't match");
                    }
                }
                else
                {
                    MessageBox.Show("wrong password");
                }
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
