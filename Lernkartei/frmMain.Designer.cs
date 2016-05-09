namespace Lernkartei
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
            this.btnLearn = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.btnManage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLearn
            // 
            this.btnLearn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLearn.Location = new System.Drawing.Point(13, 13);
            this.btnLearn.Name = "btnLearn";
            this.btnLearn.Size = new System.Drawing.Size(712, 160);
            this.btnLearn.TabIndex = 0;
            this.btnLearn.Text = "Learn";
            this.btnLearn.UseVisualStyleBackColor = true;
            this.btnLearn.Click += new System.EventHandler(this.btnLearn_Click);
            // 
            // btnStats
            // 
            this.btnStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStats.Location = new System.Drawing.Point(12, 179);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(351, 160);
            this.btnStats.TabIndex = 1;
            this.btnStats.Text = "Stats";
            this.btnStats.UseVisualStyleBackColor = true;
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // btnManage
            // 
            this.btnManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManage.Location = new System.Drawing.Point(369, 179);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(356, 160);
            this.btnManage.TabIndex = 2;
            this.btnManage.Text = "Manage";
            this.btnManage.UseVisualStyleBackColor = true;
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 354);
            this.Controls.Add(this.btnManage);
            this.Controls.Add(this.btnStats);
            this.Controls.Add(this.btnLearn);
            this.Name = "frmMain";
            this.Text = "Flashcards Administration";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLearn;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.Button btnManage;


    }
}

