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
    public partial class frmLearnCards : MetroFramework.Forms.MetroForm
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
            this.Text = this.themeName + " Level: " + this.level;
            this.lblQuestion2.Text = this.question;
        }

        private void txtAnswer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnOk_Click(sender, e);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(this.txtAnswer2.Text == this.answer)
            {
                MessageBox.Show(this.txtAnswer2.Text + " is correct!", "Correct Answer");

                using (var context = new Lernkartei_Entities())
                {
                    TbProgress progress = context.TbProgress.SingleOrDefault(p => p.ProgressID == this.progressID);

                    if(progress.Level < 7) //max Level = 7
                    {
                        progress.Level++;
                        context.SaveChanges();
                    }
                }
            }

            else
            {
                MessageBox.Show(this.txtAnswer2.Text + " is not correct!" + Environment.NewLine + "The correct answer is: " + this.answer, "Incorrect Answer");
            }

            this.Close();
        }
    }
}
