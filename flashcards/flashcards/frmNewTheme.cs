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
    public partial class frmNewTheme : Form
    {
        private string username;
        public frmNewTheme(string user)
        {
            InitializeComponent();
            this.username = user;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text != "" && txtTitle.Text != " ")
            {
                using (var context = new Lernkartei_Entities())
                {
                    TbTheme newTheme = new TbTheme();
                    newTheme.ThemeName = txtTitle.Text;
                    context.TbTheme.Add(newTheme);
                    context.SaveChanges();
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Empty Title");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnOk_Click(sender, e);
        }
    }
}
