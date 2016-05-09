namespace flashcards
{
    partial class frmLearn
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
            this.btnBack = new System.Windows.Forms.Button();
            this.lvThemes = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 305);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(713, 34);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lvThemes
            // 
            this.lvThemes.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.lvThemes.BackColor = System.Drawing.Color.White;
            this.lvThemes.Cursor = System.Windows.Forms.Cursors.Default;
            this.lvThemes.Location = new System.Drawing.Point(12, 12);
            this.lvThemes.MultiSelect = false;
            this.lvThemes.Name = "lvThemes";
            this.lvThemes.Size = new System.Drawing.Size(713, 278);
            this.lvThemes.TabIndex = 3;
            this.lvThemes.UseCompatibleStateImageBehavior = false;
            this.lvThemes.DoubleClick += new System.EventHandler(this.lvThemes_DoubleClick);
            // 
            // frmLearn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 350);
            this.Controls.Add(this.lvThemes);
            this.Controls.Add(this.btnBack);
            this.Name = "frmLearn";
            this.Text = "Flashcards Administration";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListView lvThemes;



    }
}

