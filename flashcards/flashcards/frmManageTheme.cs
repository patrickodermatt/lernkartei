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
            frmNewCard newCard = new frmNewCard(this.username);
            newCard.Closed += (s, args) => this.Show();
            newCard.Show();
        }
    }
}
