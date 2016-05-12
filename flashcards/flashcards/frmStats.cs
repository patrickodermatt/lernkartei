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
    public partial class frmStats : Form
    {
        private string username;
        public frmStats(string user)
        {
            InitializeComponent();
            this.username = user;
            this.Text = "Stats for user " + username;
            this.ShowStats();
            this.Controls[1].Select();
        }

        private void ShowStats()
        {
            using (var context = new Lernkartei_Entities())
            {
                Label lblName = new Label();
                lblName.Text = "learning progress for user " + username;
                lblName.AutoSize = true;
                lblName.Font = new Font("Arial", 25);
                lblName.Location = new System.Drawing.Point(97, 30);
                this.Controls.Add(lblName);

                int themeNameOffset = 100;

                foreach(TbTheme theme in context.TbTheme)
                {
                    int totalCards = (from p in context.TbProgress
                        join l in context.TbLogin on p.fk_UserID equals l.UserID
                        join c in context.TbCard on p.fk_CardID equals c.CardID
                        join t in context.TbTheme on c.fk_ThemeID equals t.ThemeID
                        where l.Username == this.username
                        where t.ThemeName == theme.ThemeName
                        select c).Count();

                    Label lblTheme = new Label();
                    lblTheme.Text = theme.ThemeName;
                    lblTheme.Location = new System.Drawing.Point(100, themeNameOffset);
                    themeNameOffset = themeNameOffset + 200;                    
                    this.Controls.Add(lblTheme);

                    int cardOffset = 100;

                    for(int i = 0; i < 8; i++)
                    {
                        List<TbCard> cards = (from p in context.TbProgress
                            join l in context.TbLogin on p.fk_UserID equals l.UserID
                            join c in context.TbCard on p.fk_CardID equals c.CardID
                            join t in context.TbTheme on c.fk_ThemeID equals t.ThemeID
                            where l.Username == this.username
                            where t.ThemeName == theme.ThemeName
                            where p.Level == i
                            select c).ToList();

                        VerticalProgressBar verticalProgressBar = new VerticalProgressBar();
                        verticalProgressBar.Value = (100 / totalCards) * cards.Count();
                        verticalProgressBar.Width = 30;
                        verticalProgressBar.Height = 100;
                        verticalProgressBar.Location = new System.Drawing.Point(cardOffset, themeNameOffset - 170);
                        this.Controls.Add(verticalProgressBar);

                        Label lblLevel = new Label();
                        lblLevel.Text = Convert.ToString(i);
                        lblLevel.AutoSize = true;
                        lblLevel.Location = new System.Drawing.Point(cardOffset + 6, themeNameOffset - 65);
                        this.Controls.Add(lblLevel);
                        cardOffset = cardOffset + 75;
                    }
                }

                Button button = new Button();
                button.Text = "Back";
                button.Location = new System.Drawing.Point(100, themeNameOffset);
                button.Width = 555;
                button.Height = 50;
                button.Click += this.btnBack_Click;
                this.Controls.Add(button);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
