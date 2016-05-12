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
                foreach(TbTheme theme in context.TbTheme)
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
            if(lvThemes.SelectedItems[0] != null)
            {
                ListViewItem selectedItem = lvThemes.SelectedItems[0];
                frmLearnCards frmLearnCards = new frmLearnCards(selectedItem.Text, this.username);
                this.Hide();
                frmLearnCards.Show();
            }
        }
    }
}
