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
        private string username;
        private string question;
        private string answer;
        private long level;
        private long progressID;

        public frmLearnCards(string themeName, string username , string question, string answer, long level, long progressID)
        {
            InitializeComponent();
            this.themeName = themeName;
            this.username = username;
            this.question = question;
            this.answer = answer;
            this.level = level;
            this.progressID = progressID;
            this.SetFields();
        }

        private void SetFields()
        {
            this.Text = this.themeName;
            this.lblQuestion.Text = this.question;
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
