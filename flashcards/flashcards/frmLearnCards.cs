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
    public partial class frmLearnCards : Form
    {
        private string themeName;
        private List<TbCard> cardList;
        private string username;

        public frmLearnCards(string themeName, string username)
        {
            InitializeComponent();
            this.cardList = new List<TbCard>();
            this.themeName = themeName;
            this.username = username;
            this.SetFields();
        }

        private void SetFields()
        {
            this.Text = this.themeName;

            using (var context = new Lernkartei_Entities())
            {
                foreach(TbCard card in context.TbCard)
                {
                    cardList.Add(card);
                }

                long minLvls = (from p in context.TbProgress
                    join l in context.TbLogin on p.fk_UserID equals l.UserID
                    join c in context.TbCard on p.fk_CardID equals c.CardID
                    join t in context.TbTheme on c.fk_ThemeID equals t.ThemeID
                    where l.Username == this.username
                    where t.ThemeName == this.themeName
                    orderby p.Level ascending
                    select p.Level).First();


                //var results = 
                    
                //    from p in context.TbProgress
                //    join l in context.TbLogin on p.fk_UserID equals l.UserID
                //    join c in context.TbCard on p.fk_CardID equals c.CardID
                //    where l.Username == this.username
                //    where p.Level 


            }
        }

        private void txtAnswer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnOk_Click(sender, e);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

        }
    }
}
