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
    public partial class frmManage : Form
    {
        private string username;
        public frmManage(string user)
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

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNewTheme newTheme = new frmNewTheme(this.username);
            newTheme.Closed += (s, args) => comeBackFromNewTheme();
            newTheme.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            lvThemes_DoubleClick(sender, e);
        }

        private void lvThemes_DoubleClick(object sender, EventArgs e)
        {
            if (lvThemes.SelectedItems.Count != 0)
            {
                ListViewItem selectedItem = lvThemes.SelectedItems[0];

                using (var context = new Lernkartei_Entities())
                {
                    TbTheme theme = context.TbTheme.Single(x => x.ThemeName == selectedItem.Text);
                    this.Hide();
                    frmManageTheme manageTheme = new frmManageTheme(this.username, theme);
                    manageTheme.Closed += (s, args) => this.Show();
                    manageTheme.Show();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvThemes.SelectedItems.Count != 0)
            {
                DialogResult result = MessageBox.Show("Sure?", "Delete Theme", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    string themeName = lvThemes.SelectedItems[0].Text;
                    using (var context = new Lernkartei_Entities())
                    {
                        TbTheme theme = context.TbTheme.Single(x => x.ThemeName == themeName);

                        foreach (TbCard card in context.TbCard)
                        {
                            if (card.fk_ThemeID == theme.ThemeID)
                            {
                                foreach (TbProgress progress in context.TbProgress)
                                {
                                    if (progress.fk_CardID == card.CardID)
                                    {
                                        context.TbProgress.Remove(progress);
                                    }
                                }
                                context.TbCard.Remove(card);
                            }
                        }
                        context.TbTheme.Remove(theme);
                        context.SaveChanges();
                    }
                    lvThemes.Items.Clear();
                    ShowThemes();
                }
            }
        }

        private void comeBackFromNewTheme()
        {
            lvThemes.Items.Clear();
            ShowThemes();
            this.Show();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (lvThemes.SelectedItems.Count != 0)
            { 
                DialogResult result = MessageBox.Show("Sure?", "Reset Theme", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    string themeName = lvThemes.SelectedItems[0].Text;
                    using (var context = new Lernkartei_Entities())
                    {
                        TbTheme theme = context.TbTheme.Single(x => x.ThemeName == themeName);
                        var cards = (from c in context.TbCard
                                     where c.fk_ThemeID == theme.ThemeID
                                     select c).ToList();

                        var user = context.TbLogin.Single(x => x.Username == username);
                        foreach (TbCard card in cards)
                        {
                            var progress = context.TbProgress.Single(x => x.fk_CardID == card.CardID && x.fk_UserID == user.UserID);
                            progress.Level = 0;
                        }
                        context.SaveChanges();
                    }
                }
            }
        }
    }
}
