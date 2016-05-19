namespace flashcards
{
    partial class frmMain
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
            this.btnLearn = new MetroFramework.Controls.MetroButton();
            this.btnStats = new MetroFramework.Controls.MetroButton();
            this.btnManage = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnLearn
            // 
            this.btnLearn.Location = new System.Drawing.Point(23, 24);
            this.btnLearn.Name = "btnLearn";
            this.btnLearn.Size = new System.Drawing.Size(448, 104);
            this.btnLearn.TabIndex = 3;
            this.btnLearn.Text = "Learn";
            this.btnLearn.Click += new System.EventHandler(this.btnLearn_Click);
            // 
            // btnStats
            // 
            this.btnStats.Location = new System.Drawing.Point(239, 134);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(232, 104);
            this.btnStats.TabIndex = 4;
            this.btnStats.Text = "Stats";
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // btnManage
            // 
            this.btnManage.Location = new System.Drawing.Point(23, 134);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(210, 104);
            this.btnManage.TabIndex = 5;
            this.btnManage.Text = "Manage";
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(496, 262);
            this.Controls.Add(this.btnManage);
            this.Controls.Add(this.btnStats);
            this.Controls.Add(this.btnLearn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Resizable = false;
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnLearn;
        private MetroFramework.Controls.MetroButton btnStats;
        private MetroFramework.Controls.MetroButton btnManage;


    }
}

