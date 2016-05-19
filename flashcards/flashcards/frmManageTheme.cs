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
    public partial class frmManageTheme : Form
    {
        private string username;
        private TbTheme theme;
        public frmManageTheme(string user, TbTheme theme)
        {
            InitializeComponent();
            this.username = user;
            this.theme = theme;
            lblTheme.Text = theme.ThemeName;
            ShowCards();
        }

        private void ShowCards()
        {
            using (var context = new Lernkartei_Entities())
            {
                List<TbCard> cards = (from c in context.TbCard
                                      where c.fk_ThemeID == this.theme.ThemeID
                                      select c).ToList();

                foreach (TbCard card in cards)
                {
                    this.lvCards.Items.Add(card.Question, card.Answer);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNewCard newCard = new frmNewCard(this.username, this.theme);
            newCard.Closed += (s, args) => comeBackFromCard();
            newCard.Show();
        }

        private void comeBackFromCard()
        {
            lvCards.Items.Clear();
            ShowCards();
            this.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvCards.SelectedItems.Count != 0)
            {
                TbCard card;
                string question = lvCards.SelectedItems[0].Text;
                using (var context = new Lernkartei_Entities())
                {
                    card = context.TbCard.Single(x => x.Question == question);
                }
                this.Hide();
                frmNewCard newCard = new frmNewCard(this.username, this.theme, card);
                newCard.Closed += (s, args) => comeBackFromCard();
                newCard.Show();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvCards.SelectedItems.Count != 0)
            {
                DialogResult result = MessageBox.Show("Sure?", "Delete Card", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    string question = lvCards.SelectedItems[0].Text;

                    using (var context = new Lernkartei_Entities())
                    {
                        TbCard card = context.TbCard.Single(x => x.Question == question);

                        foreach (TbLogin user in context.TbLogin)
                        {
                            TbProgress progress = context.TbProgress.Single(x => x.fk_UserID == user.UserID && x.fk_CardID == card.CardID);
                            context.TbProgress.Remove(progress);
                        }
                        context.TbCard.Remove(card);
                        context.SaveChanges();
                    }
                    lvCards.Items.Clear();
                    ShowCards();
                }
            }
        }

        private void lvCards_DoubleClick(object sender, EventArgs e)
        {
            btnEdit_Click(sender, e);
        }
    }
}
