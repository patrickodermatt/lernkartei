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
        private TbTheme theme;
        public frmNewCard(string user, TbTheme theme)
        {
            InitializeComponent();
            this.username = user;
            this.theme = theme;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtQuestion.Text != "" && txtQuestion.Text != " ")
            {
                if (txtQuestion.Text != "" && txtQuestion.Text != " ")
                {
                    TbCard newCard = new TbCard();
                    newCard.Question = txtQuestion.Text;
                    newCard.Answer = txtAnswer.Text;
                    newCard.fk_ThemeID = this.theme.ThemeID;

                    using (var context = new Lernkartei_Entities())
                    {
                        context.TbCard.Add(newCard);

                        foreach (TbLogin user in context.TbLogin)
                        {
                            TbProgress progress = new TbProgress();
                            progress.fk_UserID = user.UserID;
                            progress.fk_CardID = newCard.CardID;
                            progress.Level = 0;
                            context.TbProgress.Add(progress);
                        }

                        context.SaveChanges();
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Empty Question");
                }
            }
            else
            {
                MessageBox.Show("Empty Question");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAnswer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnOk_Click(sender, e);
        }
    }
}
