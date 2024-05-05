namespace Gestion_Biblio
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.livresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnNouveauLivreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voirDesLivresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etudiantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnÉtudiantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voirLesInfoDeLétudiantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.émettreDesLivresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retournerDesLivresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.détailsCompletsDuLivreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Wheat;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.livresToolStripMenuItem,
            this.etudiantToolStripMenuItem,
            this.émettreDesLivresToolStripMenuItem,
            this.retournerDesLivresToolStripMenuItem,
            this.détailsCompletsDuLivreToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1800, 58);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // livresToolStripMenuItem
            // 
            this.livresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUnNouveauLivreToolStripMenuItem,
            this.voirDesLivresToolStripMenuItem});
            this.livresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("livresToolStripMenuItem.Image")));
            this.livresToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.livresToolStripMenuItem.Name = "livresToolStripMenuItem";
            this.livresToolStripMenuItem.Size = new System.Drawing.Size(122, 54);
            this.livresToolStripMenuItem.Text = "Livres";
            // 
            // ajouterUnNouveauLivreToolStripMenuItem
            // 
            this.ajouterUnNouveauLivreToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ajouterUnNouveauLivreToolStripMenuItem.Image")));
            this.ajouterUnNouveauLivreToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ajouterUnNouveauLivreToolStripMenuItem.Name = "ajouterUnNouveauLivreToolStripMenuItem";
            this.ajouterUnNouveauLivreToolStripMenuItem.Size = new System.Drawing.Size(333, 60);
            this.ajouterUnNouveauLivreToolStripMenuItem.Text = "Ajouter un nouveau livre";
            this.ajouterUnNouveauLivreToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnNouveauLivreToolStripMenuItem_Click);
            // 
            // voirDesLivresToolStripMenuItem
            // 
            this.voirDesLivresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("voirDesLivresToolStripMenuItem.Image")));
            this.voirDesLivresToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.voirDesLivresToolStripMenuItem.Name = "voirDesLivresToolStripMenuItem";
            this.voirDesLivresToolStripMenuItem.Size = new System.Drawing.Size(333, 60);
            this.voirDesLivresToolStripMenuItem.Text = "Voir les livres";
            this.voirDesLivresToolStripMenuItem.Click += new System.EventHandler(this.voirDesLivresToolStripMenuItem_Click);
            // 
            // etudiantToolStripMenuItem
            // 
            this.etudiantToolStripMenuItem.BackColor = System.Drawing.Color.OldLace;
            this.etudiantToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUnÉtudiantToolStripMenuItem,
            this.voirLesInfoDeLétudiantToolStripMenuItem});
            this.etudiantToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("etudiantToolStripMenuItem.Image")));
            this.etudiantToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.etudiantToolStripMenuItem.Name = "etudiantToolStripMenuItem";
            this.etudiantToolStripMenuItem.Size = new System.Drawing.Size(143, 54);
            this.etudiantToolStripMenuItem.Text = "Etudiant";
            // 
            // ajouterUnÉtudiantToolStripMenuItem
            // 
            this.ajouterUnÉtudiantToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ajouterUnÉtudiantToolStripMenuItem.Image")));
            this.ajouterUnÉtudiantToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ajouterUnÉtudiantToolStripMenuItem.Name = "ajouterUnÉtudiantToolStripMenuItem";
            this.ajouterUnÉtudiantToolStripMenuItem.Size = new System.Drawing.Size(336, 60);
            this.ajouterUnÉtudiantToolStripMenuItem.Text = "Ajouter un étudiant";
            this.ajouterUnÉtudiantToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnÉtudiantToolStripMenuItem_Click);
            // 
            // voirLesInfoDeLétudiantToolStripMenuItem
            // 
            this.voirLesInfoDeLétudiantToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("voirLesInfoDeLétudiantToolStripMenuItem.Image")));
            this.voirLesInfoDeLétudiantToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.voirLesInfoDeLétudiantToolStripMenuItem.Name = "voirLesInfoDeLétudiantToolStripMenuItem";
            this.voirLesInfoDeLétudiantToolStripMenuItem.Size = new System.Drawing.Size(336, 60);
            this.voirLesInfoDeLétudiantToolStripMenuItem.Text = "Voir les info de l\'étudiant";
            this.voirLesInfoDeLétudiantToolStripMenuItem.Click += new System.EventHandler(this.voirLesInfoDeLétudiantToolStripMenuItem_Click);
            // 
            // émettreDesLivresToolStripMenuItem
            // 
            this.émettreDesLivresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("émettreDesLivresToolStripMenuItem.Image")));
            this.émettreDesLivresToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.émettreDesLivresToolStripMenuItem.Name = "émettreDesLivresToolStripMenuItem";
            this.émettreDesLivresToolStripMenuItem.Size = new System.Drawing.Size(217, 54);
            this.émettreDesLivresToolStripMenuItem.Text = "Émettre des livres";
            this.émettreDesLivresToolStripMenuItem.Click += new System.EventHandler(this.émettreDesLivresToolStripMenuItem_Click);
            // 
            // retournerDesLivresToolStripMenuItem
            // 
            this.retournerDesLivresToolStripMenuItem.BackColor = System.Drawing.Color.OldLace;
            this.retournerDesLivresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("retournerDesLivresToolStripMenuItem.Image")));
            this.retournerDesLivresToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.retournerDesLivresToolStripMenuItem.Name = "retournerDesLivresToolStripMenuItem";
            this.retournerDesLivresToolStripMenuItem.Size = new System.Drawing.Size(233, 54);
            this.retournerDesLivresToolStripMenuItem.Text = "Retourner des livres";
            this.retournerDesLivresToolStripMenuItem.Click += new System.EventHandler(this.retournerDesLivresToolStripMenuItem_Click);
            // 
            // détailsCompletsDuLivreToolStripMenuItem
            // 
            this.détailsCompletsDuLivreToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("détailsCompletsDuLivreToolStripMenuItem.Image")));
            this.détailsCompletsDuLivreToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.détailsCompletsDuLivreToolStripMenuItem.Name = "détailsCompletsDuLivreToolStripMenuItem";
            this.détailsCompletsDuLivreToolStripMenuItem.Size = new System.Drawing.Size(272, 54);
            this.détailsCompletsDuLivreToolStripMenuItem.Text = "Détails complets du livre";
            this.détailsCompletsDuLivreToolStripMenuItem.Click += new System.EventHandler(this.détailsCompletsDuLivreToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.OldLace;
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(105, 54);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1800, 1055);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.Text = "_";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem livresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnNouveauLivreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voirDesLivresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem etudiantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnÉtudiantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voirLesInfoDeLétudiantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem émettreDesLivresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retournerDesLivresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem détailsCompletsDuLivreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}