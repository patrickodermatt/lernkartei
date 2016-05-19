namespace flashcards
{
    partial class frmPassword
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnOK = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.lblOld = new MetroFramework.Controls.MetroLabel();
            this.lblNew1 = new MetroFramework.Controls.MetroLabel();
            this.txtNew1 = new MetroFramework.Controls.MetroTextBox();
            this.txtNew2 = new MetroFramework.Controls.MetroTextBox();
            this.lblNew2 = new MetroFramework.Controls.MetroLabel();
            this.txtOld = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(50, 14);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(182, 25);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Reset Password";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(34, 150);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(106, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(146, 150);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblOld
            // 
            this.lblOld.AutoSize = true;
            this.lblOld.Location = new System.Drawing.Point(34, 55);
            this.lblOld.Name = "lblOld";
            this.lblOld.Size = new System.Drawing.Size(66, 19);
            this.lblOld.TabIndex = 10;
            this.lblOld.Text = "Password:";
            // 
            // lblNew1
            // 
            this.lblNew1.AutoSize = true;
            this.lblNew1.Location = new System.Drawing.Point(34, 84);
            this.lblNew1.Name = "lblNew1";
            this.lblNew1.Size = new System.Drawing.Size(93, 19);
            this.lblNew1.TabIndex = 11;
            this.lblNew1.Text = "new Password:";
            // 
            // txtNew1
            // 
            this.txtNew1.Location = new System.Drawing.Point(129, 84);
            this.txtNew1.Name = "txtNew1";
            this.txtNew1.PasswordChar = '●';
            this.txtNew1.Size = new System.Drawing.Size(123, 23);
            this.txtNew1.TabIndex = 2;
            this.txtNew1.UseSystemPasswordChar = true;
            // 
            // txtNew2
            // 
            this.txtNew2.Location = new System.Drawing.Point(129, 113);
            this.txtNew2.Name = "txtNew2";
            this.txtNew2.PasswordChar = '●';
            this.txtNew2.Size = new System.Drawing.Size(123, 23);
            this.txtNew2.TabIndex = 3;
            this.txtNew2.UseSystemPasswordChar = true;
            // 
            // lblNew2
            // 
            this.lblNew2.AutoSize = true;
            this.lblNew2.Location = new System.Drawing.Point(34, 113);
            this.lblNew2.Name = "lblNew2";
            this.lblNew2.Size = new System.Drawing.Size(57, 19);
            this.lblNew2.TabIndex = 15;
            this.lblNew2.Text = "confirm:";
            // 
            // txtOld
            // 
            this.txtOld.Location = new System.Drawing.Point(129, 55);
            this.txtOld.Name = "txtOld";
            this.txtOld.PasswordChar = '●';
            this.txtOld.Size = new System.Drawing.Size(123, 23);
            this.txtOld.TabIndex = 1;
            this.txtOld.UseSystemPasswordChar = true;
            // 
            // frmPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(290, 192);
            this.Controls.Add(this.txtOld);
            this.Controls.Add(this.txtNew2);
            this.Controls.Add(this.lblNew2);
            this.Controls.Add(this.txtNew1);
            this.Controls.Add(this.lblNew1);
            this.Controls.Add(this.lblOld);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblLogin);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPassword";
            this.Resizable = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private MetroFramework.Controls.MetroButton btnOK;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroLabel lblOld;
        private MetroFramework.Controls.MetroLabel lblNew1;
        private MetroFramework.Controls.MetroTextBox txtNew1;
        private MetroFramework.Controls.MetroTextBox txtNew2;
        private MetroFramework.Controls.MetroLabel lblNew2;
        private MetroFramework.Controls.MetroTextBox txtOld;

    }
}

