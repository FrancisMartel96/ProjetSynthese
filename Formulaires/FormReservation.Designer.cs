namespace ProjetSynthese.Formulaires
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.réservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutResevToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifResevToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.annulerReservToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listReservsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spaStatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientToolStripMenuItem,
            this.réservationToolStripMenuItem,
            this.afficherToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.afficherToolStripMenuItem;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(799, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajoutClientToolStripMenuItem,
            this.modifClientToolStripMenuItem});
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.clientToolStripMenuItem.Text = "Client";
            // 
            // ajoutClientToolStripMenuItem
            // 
            this.ajoutClientToolStripMenuItem.Name = "ajoutClientToolStripMenuItem";
            this.ajoutClientToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ajoutClientToolStripMenuItem.Text = "Créer un client";
            this.ajoutClientToolStripMenuItem.Click += new System.EventHandler(this.ajoutClientToolStripMenuItem_Click);
            // 
            // modifClientToolStripMenuItem
            // 
            this.modifClientToolStripMenuItem.Name = "modifClientToolStripMenuItem";
            this.modifClientToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modifClientToolStripMenuItem.Text = "Modifier un client";
            this.modifClientToolStripMenuItem.Click += new System.EventHandler(this.modifClientToolStripMenuItem_Click);
            // 
            // réservationToolStripMenuItem
            // 
            this.réservationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajoutResevToolStripMenuItem,
            this.modifResevToolStripMenuItem,
            this.annulerReservToolStripMenuItem});
            this.réservationToolStripMenuItem.Name = "réservationToolStripMenuItem";
            this.réservationToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.réservationToolStripMenuItem.Text = "Réservation";
            // 
            // ajoutResevToolStripMenuItem
            // 
            this.ajoutResevToolStripMenuItem.Name = "ajoutResevToolStripMenuItem";
            this.ajoutResevToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.ajoutResevToolStripMenuItem.Text = "Créer une réservation";
            this.ajoutResevToolStripMenuItem.Click += new System.EventHandler(this.ajoutResevToolStripMenuItem_Click);
            // 
            // modifResevToolStripMenuItem
            // 
            this.modifResevToolStripMenuItem.Name = "modifResevToolStripMenuItem";
            this.modifResevToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.modifResevToolStripMenuItem.Text = "Modifier une réservation";
            this.modifResevToolStripMenuItem.Click += new System.EventHandler(this.modifResevToolStripMenuItem_Click);
            // 
            // annulerReservToolStripMenuItem
            // 
            this.annulerReservToolStripMenuItem.Name = "annulerReservToolStripMenuItem";
            this.annulerReservToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.annulerReservToolStripMenuItem.Text = "Annuler une réservation";
            this.annulerReservToolStripMenuItem.Click += new System.EventHandler(this.annulerReservToolStripMenuItem_Click);
            // 
            // afficherToolStripMenuItem
            // 
            this.afficherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listReservsToolStripMenuItem,
            this.spaStatsToolStripMenuItem,
            this.toolStripSeparator1});
            this.afficherToolStripMenuItem.Name = "afficherToolStripMenuItem";
            this.afficherToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.afficherToolStripMenuItem.Text = "Afficher";
            // 
            // listReservsToolStripMenuItem
            // 
            this.listReservsToolStripMenuItem.Name = "listReservsToolStripMenuItem";
            this.listReservsToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.listReservsToolStripMenuItem.Text = "Liste des réservations";
            this.listReservsToolStripMenuItem.Click += new System.EventHandler(this.listReservsToolStripMenuItem_Click);
            // 
            // spaStatsToolStripMenuItem
            // 
            this.spaStatsToolStripMenuItem.Name = "spaStatsToolStripMenuItem";
            this.spaStatsToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.spaStatsToolStripMenuItem.Text = "Statistiques du spa";
            this.spaStatsToolStripMenuItem.Click += new System.EventHandler(this.spaStatsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(182, 6);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 561);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "mainForm";
            this.Text = "Gestion de spa";
            this.Load += new System.EventHandler(this.FormReservation_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem réservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutResevToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifResevToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem annulerReservToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listReservsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spaStatsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}