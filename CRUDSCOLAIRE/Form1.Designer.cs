namespace CRUDSCOLAIRE
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etudantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeClasseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeUtilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diagrammeEtuClasseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diagrammeEtuAnneeScolaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.classeToolStripMenuItem,
            this.etudantToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(106, 29);
            this.fichierToolStripMenuItem.Text = "Utilisateur";
            this.fichierToolStripMenuItem.Click += new System.EventHandler(this.fichierToolStripMenuItem_Click);
            // 
            // classeToolStripMenuItem
            // 
            this.classeToolStripMenuItem.Name = "classeToolStripMenuItem";
            this.classeToolStripMenuItem.Size = new System.Drawing.Size(77, 29);
            this.classeToolStripMenuItem.Text = "Classe";
            this.classeToolStripMenuItem.Click += new System.EventHandler(this.classeToolStripMenuItem_Click);
            // 
            // etudantToolStripMenuItem
            // 
            this.etudantToolStripMenuItem.Name = "etudantToolStripMenuItem";
            this.etudantToolStripMenuItem.Size = new System.Drawing.Size(89, 29);
            this.etudantToolStripMenuItem.Text = "Etudant";
            this.etudantToolStripMenuItem.Click += new System.EventHandler(this.etudantToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeClasseToolStripMenuItem,
            this.listeToolStripMenuItem,
            this.listeUtilisateurToolStripMenuItem,
            this.diagrammeEtuClasseToolStripMenuItem,
            this.diagrammeEtuAnneeScolaireToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(81, 29);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // listeClasseToolStripMenuItem
            // 
            this.listeClasseToolStripMenuItem.Name = "listeClasseToolStripMenuItem";
            this.listeClasseToolStripMenuItem.Size = new System.Drawing.Size(355, 34);
            this.listeClasseToolStripMenuItem.Text = "Liste Classe";
            this.listeClasseToolStripMenuItem.Click += new System.EventHandler(this.listeClasseToolStripMenuItem_Click);
            // 
            // listeToolStripMenuItem
            // 
            this.listeToolStripMenuItem.Name = "listeToolStripMenuItem";
            this.listeToolStripMenuItem.Size = new System.Drawing.Size(355, 34);
            this.listeToolStripMenuItem.Text = "Liste Etudiant";
            this.listeToolStripMenuItem.Click += new System.EventHandler(this.listeToolStripMenuItem_Click);
            // 
            // listeUtilisateurToolStripMenuItem
            // 
            this.listeUtilisateurToolStripMenuItem.Name = "listeUtilisateurToolStripMenuItem";
            this.listeUtilisateurToolStripMenuItem.Size = new System.Drawing.Size(355, 34);
            this.listeUtilisateurToolStripMenuItem.Text = "Liste Utilisateur";
            this.listeUtilisateurToolStripMenuItem.Click += new System.EventHandler(this.listeUtilisateurToolStripMenuItem_Click);
            // 
            // diagrammeEtuClasseToolStripMenuItem
            // 
            this.diagrammeEtuClasseToolStripMenuItem.Name = "diagrammeEtuClasseToolStripMenuItem";
            this.diagrammeEtuClasseToolStripMenuItem.Size = new System.Drawing.Size(355, 34);
            this.diagrammeEtuClasseToolStripMenuItem.Text = "Diagramme Etu_Classe";
            // 
            // diagrammeEtuAnneeScolaireToolStripMenuItem
            // 
            this.diagrammeEtuAnneeScolaireToolStripMenuItem.Name = "diagrammeEtuAnneeScolaireToolStripMenuItem";
            this.diagrammeEtuAnneeScolaireToolStripMenuItem.Size = new System.Drawing.Size(355, 34);
            this.diagrammeEtuAnneeScolaireToolStripMenuItem.Text = "Diagramme Etu_AnneeScolaire";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem etudantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeClasseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeUtilisateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diagrammeEtuClasseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diagrammeEtuAnneeScolaireToolStripMenuItem;
    }
}

