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
    public partial class frmNewCard : MetroFramework.Forms.MetroForm
    {
        private string username;
        private TbTheme theme;
        private TbCard card;

        public frmNewCard(string user, TbTheme theme)
        {
            InitializeComponent();
            this.username = user;
            this.theme = theme;
        }

        public frmNewCard(string user, TbTheme theme, TbCard card)
        {
            InitializeComponent();
            this.username = user;
            this.theme = theme;
            this.card = card;
            this.SetFields();
        }

        private void SetFields()
        {
            txtQuestion.Text = this.card.Question;
            txtAnswer.Text = this.card.Answer;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtQuestion.Text != "" && txtQuestion.Text != " ")
            {
                if (txtQuestion.Text != "" && txtQuestion.Text != " ")
                {
                    if (this.card == null)
                    {
                        createCard();
                    }
                    else
                    {
                        updateCard();
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

        private void createCard()
        {
            this.card = new TbCard();
            card.Question = txtQuestion.Text;
            card.Answer = txtAnswer.Text;
            card.fk_ThemeID = this.theme.ThemeID;

            using (var context = new Lernkartei_Entities())
            {
                context.TbCard.Add(card);

                foreach (TbLogin user in context.TbLogin)
                {
                    TbProgress progress = new TbProgress { fk_UserID = user.UserID, fk_CardID = card.CardID, Level = 0 };
                    context.TbProgress.Add(progress);
                }
                context.SaveChanges();
            }
        }

        private void updateCard()
        {
            using (var context = new Lernkartei_Entities())
            {
                this.card = context.TbCard.Single(p => p.CardID == this.card.CardID);
                card.Question = txtQuestion.Text;
                card.Answer = txtAnswer.Text;
                card.fk_ThemeID = this.theme.ThemeID;
                context.SaveChanges();
            }
        }
    }
}
