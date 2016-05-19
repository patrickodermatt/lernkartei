namespace flashcards
{
    partial class frmManage
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
            this.lvThemes = new System.Windows.Forms.ListView();
            this.btnNew = new MetroFramework.Controls.MetroButton();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.btnReset = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // lvThemes
            // 
            this.lvThemes.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.lvThemes.Location = new System.Drawing.Point(13, 73);
            this.lvThemes.MultiSelect = false;
            this.lvThemes.Name = "lvThemes";
            this.lvThemes.Size = new System.Drawing.Size(712, 217);
            this.lvThemes.TabIndex = 3;
            this.lvThemes.UseCompatibleStateImageBehavior = false;
            this.lvThemes.DoubleClick += new System.EventHandler(this.lvThemes_DoubleClick);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(12, 25);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(165, 34);
            this.btnNew.TabIndex = 8;
            this.btnNew.Text = "New";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(192, 25);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(165, 34);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(376, 25);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(165, 34);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(560, 25);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(165, 34);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 297);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(713, 34);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(737, 343);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.lvThemes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManage";
            this.Resizable = false;
            this.Click += new System.EventHandler(this.btnDelete_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvThemes;
        private MetroFramework.Controls.MetroButton btnNew;
        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroButton btnReset;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnBack;



    }
}

