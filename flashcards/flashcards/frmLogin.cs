﻿using System;
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
    public partial class frmLogin : MetroFramework.Forms.MetroForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (login())
            {
                if(this.txtUsername.Text == "admin")
                {
                    this.Hide();
                    frmMainAdmin frmMainAdmin = new frmMainAdmin(txtUsername.Text);
                    frmMainAdmin.Closed += (s, args) => this.Close();
                    frmMainAdmin.Show();
                }
                else
                {
                    this.Hide();
                    frmMain frmMain = new frmMain(txtUsername.Text);
                    frmMain.Closed += (s, args) => this.Close();
                    frmMain.Show();
                }
            }
        }

        private bool login()
        {
            using(var context = new Lernkartei_Entities())
            {
                TbLogin person = context.TbLogin.SingleOrDefault(p => p.Username == this.txtUsername.Text);

                if(person == null)
                {
                   MessageBox.Show("User not found");
                    return false;
                }

                if(person.Password == this.txtPassword.Text)
                    return true;

                else
                {
                    MessageBox.Show("Password incorrect");
                    return false;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnOk_Click(sender, e);
        }

        private void lnkRegister_LinkClicked(object sender, EventArgs e)
        {
            this.Hide();
            frmRegister register = new frmRegister();
            register.Closed += (s, args) => this.Show();
            register.Show();
        }
    }
}
