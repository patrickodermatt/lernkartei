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
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
