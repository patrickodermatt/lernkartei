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
    public partial class frmLearn : Form
    {
        private string username;
        private List<TbProgress> listOfCards;

        public frmLearn(string user)
        {
            InitializeComponent();
            this.username = user;
            ShowThemes();
        }

        private void ShowThemes()
        {
            using (var context = new Lernkartei_Entities())
            {
                foreach (TbTheme theme in context.TbTheme)
                {
                    this.lvThemes.Items.Add(theme.ThemeName);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lvThemes_DoubleClick(object sender, EventArgs e)
        {
            if (lvThemes.SelectedItems.Count != 0)
            {
                ListViewItem selectedItem = lvThemes.SelectedItems[0];

                using (var context = new Lernkartei_Entities())
                {
                    long minLvls = (from p in context.TbProgress
                                    join l in context.TbLogin on p.fk_UserID equals l.UserID
                                    join c in context.TbCard on p.fk_CardID equals c.CardID
                                    join t in context.TbTheme on c.fk_ThemeID equals t.ThemeID
                                    where l.Username == this.username
                                    where t.ThemeName == selectedItem.Text
                                    orderby p.Level ascending
                                    select p.Level).First();

                    this.listOfCards = (from p in context.TbProgress
                                        join l in context.TbLogin on p.fk_UserID equals l.UserID
                                        join c in context.TbCard on p.fk_CardID equals c.CardID
                                        join t in context.TbTheme on c.fk_ThemeID equals t.ThemeID
                                        where l.Username == this.username
                                        where p.Level == minLvls
                                        where t.ThemeName == selectedItem.Text
                                        select p).ToList();

                    this.Hide();
                    openCards(selectedItem.Text);
                    this.Show();
                }
            }
        }

        private void openCards(string themeName)
        {
            int CardCounter = 0;

            foreach (TbProgress card in listOfCards)
            {
                frmLearnCards frmLearnCards = new frmLearnCards(themeName, this.username, this.listOfCards[CardCounter].TbCard.Question, this.listOfCards[CardCounter].TbCard.Answer, this.listOfCards[CardCounter].Level, this.listOfCards[CardCounter].ProgressID);
                frmLearnCards.ShowDialog();
                CardCounter++;
            }
        }
    }
}
