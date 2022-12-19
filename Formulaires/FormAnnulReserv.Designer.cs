namespace ProjetSynthese.Formulaires
{
    partial class FormAnnulReserv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAnnulReserv));
            this.labelErreurNumReserv = new System.Windows.Forms.Label();
            this.textBoxNumReserv = new System.Windows.Forms.TextBox();
            this.labelNumReserv = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelErreurNumReserv
            // 
            this.labelErreurNumReserv.AutoSize = true;
            this.labelErreurNumReserv.ForeColor = System.Drawing.Color.Red;
            this.labelErreurNumReserv.Location = new System.Drawing.Point(122, 32);
            this.labelErreurNumReserv.Name = "labelErreurNumReserv";
            this.labelErreurNumReserv.Size = new System.Drawing.Size(0, 13);
            this.labelErreurNumReserv.TabIndex = 73;
            // 
            // textBoxNumReserv
            // 
            this.textBoxNumReserv.Location = new System.Drawing.Point(125, 9);
            this.textBoxNumReserv.Name = "textBoxNumReserv";
            this.textBoxNumReserv.Size = new System.Drawing.Size(214, 20);
            this.textBoxNumReserv.TabIndex = 72;
            // 
            // labelNumReserv
            // 
            this.labelNumReserv.AutoSize = true;
            this.labelNumReserv.Location = new System.Drawing.Point(12, 9);
            this.labelNumReserv.Name = "labelNumReserv";
            this.labelNumReserv.Size = new System.Drawing.Size(47, 13);
            this.labelNumReserv.TabIndex = 71;
            this.labelNumReserv.Text = "Numéro:";
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnQuitter.Location = new System.Drawing.Point(148, 62);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(127, 35);
            this.btnQuitter.TabIndex = 75;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAnnuler.Location = new System.Drawing.Point(15, 62);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(127, 35);
            this.btnAnnuler.TabIndex = 74;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // FormAnnulReserv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 161);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.labelErreurNumReserv);
            this.Controls.Add(this.textBoxNumReserv);
            this.Controls.Add(this.labelNumReserv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAnnulReserv";
            this.Text = "Annuler une réservation";
            this.Load += new System.EventHandler(this.FormAnnulReserv_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelErreurNumReserv;
        private System.Windows.Forms.TextBox textBoxNumReserv;
        private System.Windows.Forms.Label labelNumReserv;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnAnnuler;
    }
}