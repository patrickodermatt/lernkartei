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
    public partial class frmRegister : MetroFramework.Forms.MetroForm
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
                            main.Closed += (s, args) => Application.Exit();
                            main.Show();
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
                TbLogin newUser = new TbLogin { Username = this.txtUsername.Text, Password = this.txtPassword.Text };
                context.TbLogin.Add(newUser);

                var themes = (from t in context.TbTheme select t).ToList();
                foreach (TbTheme theme in themes)
                {
                    var cards = (from c in context.TbCard
                                 where c.fk_ThemeID == theme.ThemeID
                                 select c).ToList();
                    foreach (TbCard card in cards)
                    {
                        context.TbProgress.Add(new TbProgress { fk_CardID = card.CardID, fk_UserID = newUser.UserID, Level = 0 });
                    }
                }

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
