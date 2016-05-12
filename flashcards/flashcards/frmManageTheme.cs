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
        public frmManageTheme(string user)
        {
            InitializeComponent();
            this.username = user;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmManage manage = new frmManage(this.username);
            manage.Show();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmNewCard newCard = new frmNewCard(this.username);
            newCard.Show();
        }
    }
}
