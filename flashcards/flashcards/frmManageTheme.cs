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
        public frmManageTheme()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmManage manage = new frmManage();
            manage.Show();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmNewCard newCard = new frmNewCard();
            newCard.Show();
        }
    }
}
