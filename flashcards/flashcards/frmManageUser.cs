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
    public partial class frmManageUser : MetroFramework.Forms.MetroForm
    {
        private string username;
        public frmManageUser(string user)
        {
            InitializeComponent();
            this.username = user;
            ShowUsers();
        }

        private void ShowUsers()
        {
            using (var context = new Lernkartei_Entities())
            {
                List<TbLogin> users = (from u in context.TbLogin select u).ToList();

                foreach (TbLogin user in users)
                {
                    this.lvUser.Items.Add(user.Username);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
        //    if (lvCards.SelectedItems.Count != 0)
        //    {
        //        TbCard card;
        //        string question = lvCards.SelectedItems[0].Text;
        //        using (var context = new Lernkartei_Entities())
        //        {
        //            card = context.TbCard.Single(x => x.Question == question);
        //        }
        //        this.Hide();
        //        frmNewCard newCard = new frmNewCard(this.username, this.theme, card);
        //        newCard.Closed += (s, args) => comeBackFromCard();
        //        newCard.Show();
        //    }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvUser.SelectedItems.Count != 0)
            {
                DialogResult result = MessageBox.Show("Sure?", "Delete User", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    string usernameofuser = lvUser.SelectedItems[0].Text;
                    using (var context = new Lernkartei_Entities())
                    {
                        TbLogin user = context.TbLogin.Single(x => x.Username == usernameofuser);

                        var progresses = (from p in context.TbProgress
                                          where p.fk_UserID == user.UserID
                                          select p).ToList();

                        foreach (TbProgress progress in progresses)
                        {
                            context.TbProgress.Remove(progress);
                        }
                        context.TbLogin.Remove(user);
                        context.SaveChanges();
                    }
                    lvUser.Items.Clear();
                    ShowUsers();
                }
            }
        }

        private void lvCards_DoubleClick(object sender, EventArgs e)
        {
            btnEdit_Click(sender, e);
        }
    }
}
