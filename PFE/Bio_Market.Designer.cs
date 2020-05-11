namespace PFE
{
    partial class Bio_Market
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bio_Market));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Connecter = new System.Windows.Forms.ToolStripMenuItem();
            this.Deconnecter = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Utilisateur = new System.Windows.Forms.ToolStripMenuItem();
            this.utili_management = new System.Windows.Forms.ToolStripMenuItem();
            this.Produit = new System.Windows.Forms.ToolStripMenuItem();
            this.produitManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createCompteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editMenu,
            this.helpMenu,
            this.createCompteToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(914, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.Checked = true;
            this.fileMenu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Connecter,
            this.Deconnecter,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(54, 20);
            this.fileMenu.Text = "&Fichier";
            // 
            // Connecter
            // 
            this.Connecter.Image = ((System.Drawing.Image)(resources.GetObject("Connecter.Image")));
            this.Connecter.ImageTransparentColor = System.Drawing.Color.Black;
            this.Connecter.Name = "Connecter";
            this.Connecter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.Connecter.Size = new System.Drawing.Size(184, 22);
            this.Connecter.Text = "Connecter";
            this.Connecter.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // Deconnecter
            // 
            this.Deconnecter.Enabled = false;
            this.Deconnecter.Image = ((System.Drawing.Image)(resources.GetObject("Deconnecter.Image")));
            this.Deconnecter.ImageTransparentColor = System.Drawing.Color.Black;
            this.Deconnecter.Name = "Deconnecter";
            this.Deconnecter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.Deconnecter.Size = new System.Drawing.Size(184, 22);
            this.Deconnecter.Text = "Deconnecter";
            this.Deconnecter.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(181, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.exitToolStripMenuItem.Text = "&Quitter";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editMenu
            // 
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Utilisateur,
            this.utili_management,
            this.Produit,
            this.produitManagement});
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(59, 20);
            this.editMenu.Text = "&Gestion";
            this.editMenu.Click += new System.EventHandler(this.editMenu_Click);
            // 
            // Utilisateur
            // 
            this.Utilisateur.Enabled = false;
            this.Utilisateur.ImageTransparentColor = System.Drawing.Color.Black;
            this.Utilisateur.Name = "Utilisateur";
            this.Utilisateur.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.Utilisateur.Size = new System.Drawing.Size(201, 22);
            this.Utilisateur.Text = "&Utilisateur";
            this.Utilisateur.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // utili_management
            // 
            this.utili_management.Enabled = false;
            this.utili_management.Name = "utili_management";
            this.utili_management.Size = new System.Drawing.Size(201, 22);
            this.utili_management.Text = "Utilisateur Management";
            // 
            // Produit
            // 
            this.Produit.Enabled = false;
            this.Produit.Name = "Produit";
            this.Produit.Size = new System.Drawing.Size(201, 22);
            this.Produit.Text = "Produit";
            this.Produit.Click += new System.EventHandler(this.produitToolStripMenuItem_Click);
            // 
            // produitManagement
            // 
            this.produitManagement.Enabled = false;
            this.produitManagement.Name = "produitManagement";
            this.produitManagement.Size = new System.Drawing.Size(201, 22);
            this.produitManagement.Text = "Produit Management ";
            this.produitManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator8,
            this.aboutToolStripMenuItem});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(43, 20);
            this.helpMenu.Text = "&Aide";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.contentsToolStripMenuItem.Text = "&Contenu";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("indexToolStripMenuItem.Image")));
            this.indexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("searchToolStripMenuItem.Image")));
            this.searchToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.searchToolStripMenuItem.Text = "&Rechercher";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(163, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.aboutToolStripMenuItem.Text = "&À propos de ... ...";
            // 
            // createCompteToolStripMenuItem
            // 
            this.createCompteToolStripMenuItem.Name = "createCompteToolStripMenuItem";
            this.createCompteToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.createCompteToolStripMenuItem.Text = "Create Compte";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(914, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(27, 17);
            this.toolStripStatusLabel.Text = "État";
            // 
            // Bio_Market
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Bio_Market";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bio_Market";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Bio_Market_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        public System.Windows.Forms.MenuStrip menuStrip;
        public System.Windows.Forms.ToolStripMenuItem fileMenu;
        public System.Windows.Forms.ToolStripMenuItem editMenu;
        public System.Windows.Forms.ToolStripMenuItem Utilisateur;
        public System.Windows.Forms.ToolStripMenuItem helpMenu;
        public System.Windows.Forms.ToolStripMenuItem createCompteToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem utili_management;
        public System.Windows.Forms.ToolStripMenuItem Produit;
        public System.Windows.Forms.ToolStripMenuItem produitManagement;
        public System.Windows.Forms.ToolStripMenuItem Connecter;
        public System.Windows.Forms.ToolStripMenuItem Deconnecter;
    }
}



