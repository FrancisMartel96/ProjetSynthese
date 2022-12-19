namespace ProjetSynthese.Formulaires
{
    partial class FormModifReserv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModifReserv));
            this.labelErreurNbInvite = new System.Windows.Forms.Label();
            this.labelErreurDateVisite = new System.Windows.Forms.Label();
            this.dateTimePickerReserv = new System.Windows.Forms.DateTimePicker();
            this.labelDateVisite = new System.Windows.Forms.Label();
            this.labelErreurPrix = new System.Windows.Forms.Label();
            this.textBoxPrix = new System.Windows.Forms.TextBox();
            this.labelPrix = new System.Windows.Forms.Label();
            this.comboBoxNbInvite = new System.Windows.Forms.ComboBox();
            this.labelErreurService = new System.Windows.Forms.Label();
            this.labelErreurHote = new System.Windows.Forms.Label();
            this.labelErreurNumReserv = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.comboBoxService = new System.Windows.Forms.ComboBox();
            this.comboBoxHote = new System.Windows.Forms.ComboBox();
            this.textBoxNumReserv = new System.Windows.Forms.TextBox();
            this.btnModifier = new System.Windows.Forms.Button();
            this.labelService = new System.Windows.Forms.Label();
            this.labelHote = new System.Windows.Forms.Label();
            this.labelNbInvite = new System.Windows.Forms.Label();
            this.labelNumReserv = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelErreurNbInvite
            // 
            this.labelErreurNbInvite.AutoSize = true;
            this.labelErreurNbInvite.ForeColor = System.Drawing.Color.Red;
            this.labelErreurNbInvite.Location = new System.Drawing.Point(122, 75);
            this.labelErreurNbInvite.Name = "labelErreurNbInvite";
            this.labelErreurNbInvite.Size = new System.Drawing.Size(0, 13);
            this.labelErreurNbInvite.TabIndex = 104;
            // 
            // labelErreurDateVisite
            // 
            this.labelErreurDateVisite.AutoSize = true;
            this.labelErreurDateVisite.ForeColor = System.Drawing.Color.Red;
            this.labelErreurDateVisite.Location = new System.Drawing.Point(122, 117);
            this.labelErreurDateVisite.Name = "labelErreurDateVisite";
            this.labelErreurDateVisite.Size = new System.Drawing.Size(0, 13);
            this.labelErreurDateVisite.TabIndex = 103;
            // 
            // dateTimePickerReserv
            // 
            this.dateTimePickerReserv.CustomFormat = "dd MMMM yyyy";
            this.dateTimePickerReserv.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerReserv.Location = new System.Drawing.Point(125, 95);
            this.dateTimePickerReserv.Name = "dateTimePickerReserv";
            this.dateTimePickerReserv.Size = new System.Drawing.Size(214, 20);
            this.dateTimePickerReserv.TabIndex = 102;
            // 
            // labelDateVisite
            // 
            this.labelDateVisite.AutoSize = true;
            this.labelDateVisite.Location = new System.Drawing.Point(12, 95);
            this.labelDateVisite.Name = "labelDateVisite";
            this.labelDateVisite.Size = new System.Drawing.Size(75, 13);
            this.labelDateVisite.TabIndex = 101;
            this.labelDateVisite.Text = "Date de visite:";
            // 
            // labelErreurPrix
            // 
            this.labelErreurPrix.AutoSize = true;
            this.labelErreurPrix.ForeColor = System.Drawing.Color.Red;
            this.labelErreurPrix.Location = new System.Drawing.Point(122, 159);
            this.labelErreurPrix.Name = "labelErreurPrix";
            this.labelErreurPrix.Size = new System.Drawing.Size(0, 13);
            this.labelErreurPrix.TabIndex = 100;
            // 
            // textBoxPrix
            // 
            this.textBoxPrix.Location = new System.Drawing.Point(125, 138);
            this.textBoxPrix.Name = "textBoxPrix";
            this.textBoxPrix.ReadOnly = true;
            this.textBoxPrix.Size = new System.Drawing.Size(214, 20);
            this.textBoxPrix.TabIndex = 99;
            // 
            // labelPrix
            // 
            this.labelPrix.AutoSize = true;
            this.labelPrix.Location = new System.Drawing.Point(12, 138);
            this.labelPrix.Name = "labelPrix";
            this.labelPrix.Size = new System.Drawing.Size(27, 13);
            this.labelPrix.TabIndex = 98;
            this.labelPrix.Text = "Prix:";
            // 
            // comboBoxNbInvite
            // 
            this.comboBoxNbInvite.FormattingEnabled = true;
            this.comboBoxNbInvite.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBoxNbInvite.Location = new System.Drawing.Point(125, 52);
            this.comboBoxNbInvite.Name = "comboBoxNbInvite";
            this.comboBoxNbInvite.Size = new System.Drawing.Size(214, 21);
            this.comboBoxNbInvite.TabIndex = 97;
            // 
            // labelErreurService
            // 
            this.labelErreurService.AutoSize = true;
            this.labelErreurService.ForeColor = System.Drawing.Color.Red;
            this.labelErreurService.Location = new System.Drawing.Point(124, 248);
            this.labelErreurService.Name = "labelErreurService";
            this.labelErreurService.Size = new System.Drawing.Size(0, 13);
            this.labelErreurService.TabIndex = 96;
            // 
            // labelErreurHote
            // 
            this.labelErreurHote.AutoSize = true;
            this.labelErreurHote.ForeColor = System.Drawing.Color.Red;
            this.labelErreurHote.Location = new System.Drawing.Point(122, 205);
            this.labelErreurHote.Name = "labelErreurHote";
            this.labelErreurHote.Size = new System.Drawing.Size(0, 13);
            this.labelErreurHote.TabIndex = 95;
            // 
            // labelErreurNumReserv
            // 
            this.labelErreurNumReserv.AutoSize = true;
            this.labelErreurNumReserv.ForeColor = System.Drawing.Color.Red;
            this.labelErreurNumReserv.Location = new System.Drawing.Point(122, 32);
            this.labelErreurNumReserv.Name = "labelErreurNumReserv";
            this.labelErreurNumReserv.Size = new System.Drawing.Size(0, 13);
            this.labelErreurNumReserv.TabIndex = 94;
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnQuitter.Location = new System.Drawing.Point(184, 267);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(156, 35);
            this.btnQuitter.TabIndex = 93;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // comboBoxService
            // 
            this.comboBoxService.FormattingEnabled = true;
            this.comboBoxService.Items.AddRange(new object[] {
            "Première année",
            "Deuxième année",
            "Troisième année"});
            this.comboBoxService.Location = new System.Drawing.Point(125, 224);
            this.comboBoxService.Name = "comboBoxService";
            this.comboBoxService.Size = new System.Drawing.Size(214, 21);
            this.comboBoxService.TabIndex = 92;
            // 
            // comboBoxHote
            // 
            this.comboBoxHote.FormattingEnabled = true;
            this.comboBoxHote.Items.AddRange(new object[] {
            "Techniques de l\'informatique",
            "Soins infirmiers",
            "Techniques de bâtiment"});
            this.comboBoxHote.Location = new System.Drawing.Point(125, 181);
            this.comboBoxHote.Name = "comboBoxHote";
            this.comboBoxHote.Size = new System.Drawing.Size(214, 21);
            this.comboBoxHote.TabIndex = 91;
            // 
            // textBoxNumReserv
            // 
            this.textBoxNumReserv.Location = new System.Drawing.Point(125, 9);
            this.textBoxNumReserv.Name = "textBoxNumReserv";
            this.textBoxNumReserv.Size = new System.Drawing.Size(214, 20);
            this.textBoxNumReserv.TabIndex = 90;
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModifier.Location = new System.Drawing.Point(21, 267);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(157, 35);
            this.btnModifier.TabIndex = 89;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // labelService
            // 
            this.labelService.AutoSize = true;
            this.labelService.Location = new System.Drawing.Point(12, 224);
            this.labelService.Name = "labelService";
            this.labelService.Size = new System.Drawing.Size(46, 13);
            this.labelService.TabIndex = 88;
            this.labelService.Text = "Service:";
            // 
            // labelHote
            // 
            this.labelHote.AutoSize = true;
            this.labelHote.Location = new System.Drawing.Point(12, 181);
            this.labelHote.Name = "labelHote";
            this.labelHote.Size = new System.Drawing.Size(33, 13);
            this.labelHote.TabIndex = 87;
            this.labelHote.Text = "Hôte:";
            // 
            // labelNbInvite
            // 
            this.labelNbInvite.AutoSize = true;
            this.labelNbInvite.Location = new System.Drawing.Point(12, 52);
            this.labelNbInvite.Name = "labelNbInvite";
            this.labelNbInvite.Size = new System.Drawing.Size(94, 13);
            this.labelNbInvite.TabIndex = 86;
            this.labelNbInvite.Text = "Nombre d\'invité(s):";
            // 
            // labelNumReserv
            // 
            this.labelNumReserv.AutoSize = true;
            this.labelNumReserv.Location = new System.Drawing.Point(12, 9);
            this.labelNumReserv.Name = "labelNumReserv";
            this.labelNumReserv.Size = new System.Drawing.Size(47, 13);
            this.labelNumReserv.TabIndex = 85;
            this.labelNumReserv.Text = "Numéro:";
            // 
            // FormModifReserv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 456);
            this.Controls.Add(this.labelErreurNbInvite);
            this.Controls.Add(this.labelErreurDateVisite);
            this.Controls.Add(this.dateTimePickerReserv);
            this.Controls.Add(this.labelDateVisite);
            this.Controls.Add(this.labelErreurPrix);
            this.Controls.Add(this.textBoxPrix);
            this.Controls.Add(this.labelPrix);
            this.Controls.Add(this.comboBoxNbInvite);
            this.Controls.Add(this.labelErreurService);
            this.Controls.Add(this.labelErreurHote);
            this.Controls.Add(this.labelErreurNumReserv);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.comboBoxService);
            this.Controls.Add(this.comboBoxHote);
            this.Controls.Add(this.textBoxNumReserv);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.labelService);
            this.Controls.Add(this.labelHote);
            this.Controls.Add(this.labelNbInvite);
            this.Controls.Add(this.labelNumReserv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormModifReserv";
            this.Text = "Modifier une réservation";
            this.Load += new System.EventHandler(this.FormModifReserv_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelErreurNbInvite;
        private System.Windows.Forms.Label labelErreurDateVisite;
        private System.Windows.Forms.DateTimePicker dateTimePickerReserv;
        private System.Windows.Forms.Label labelDateVisite;
        private System.Windows.Forms.Label labelErreurPrix;
        private System.Windows.Forms.TextBox textBoxPrix;
        private System.Windows.Forms.Label labelPrix;
        private System.Windows.Forms.ComboBox comboBoxNbInvite;
        private System.Windows.Forms.Label labelErreurService;
        private System.Windows.Forms.Label labelErreurHote;
        private System.Windows.Forms.Label labelErreurNumReserv;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.ComboBox comboBoxService;
        private System.Windows.Forms.ComboBox comboBoxHote;
        private System.Windows.Forms.TextBox textBoxNumReserv;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Label labelService;
        private System.Windows.Forms.Label labelHote;
        private System.Windows.Forms.Label labelNbInvite;
        private System.Windows.Forms.Label labelNumReserv;
    }
}