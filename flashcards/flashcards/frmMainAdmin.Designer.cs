namespace flashcards
{
    partial class frmMainAdmin
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
            this.btnManage = new MetroFramework.Controls.MetroButton();
            this.btnManageUser = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnManage
            // 
            this.btnManage.Location = new System.Drawing.Point(23, 55);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(210, 104);
            this.btnManage.TabIndex = 5;
            this.btnManage.Text = "Manage Themes";
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // btnManageUser
            // 
            this.btnManageUser.Location = new System.Drawing.Point(263, 55);
            this.btnManageUser.Name = "btnManageUser";
            this.btnManageUser.Size = new System.Drawing.Size(210, 104);
            this.btnManageUser.TabIndex = 6;
            this.btnManageUser.Text = "Manage User";
            this.btnManageUser.Click += new System.EventHandler(this.btnManageUser_Click);
            // 
            // frmMainAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(496, 182);
            this.Controls.Add(this.btnManageUser);
            this.Controls.Add(this.btnManage);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMainAdmin";
            this.Resizable = false;
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnManage;
        private MetroFramework.Controls.MetroButton btnManageUser;


    }
}

