namespace QRPrint
{
    partial class vueNouveauDossier
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
            this.lb_NomClient = new System.Windows.Forms.Label();
            this.tb_nomClient = new System.Windows.Forms.TextBox();
            this.lb_prenomClient = new System.Windows.Forms.Label();
            this.tb_prenomClient = new System.Windows.Forms.TextBox();
            this.lb_numeroDossier = new System.Windows.Forms.Label();
            this.tb_numeroDossier = new System.Windows.Forms.TextBox();
            this.bt_nouveauDossier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_NomClient
            // 
            this.lb_NomClient.AutoSize = true;
            this.lb_NomClient.Location = new System.Drawing.Point(12, 9);
            this.lb_NomClient.Name = "lb_NomClient";
            this.lb_NomClient.Size = new System.Drawing.Size(72, 13);
            this.lb_NomClient.TabIndex = 0;
            this.lb_NomClient.Text = "Nom du client";
            // 
            // tb_nomClient
            // 
            this.tb_nomClient.Location = new System.Drawing.Point(13, 26);
            this.tb_nomClient.Name = "tb_nomClient";
            this.tb_nomClient.Size = new System.Drawing.Size(100, 20);
            this.tb_nomClient.TabIndex = 1;
            // 
            // lb_prenomClient
            // 
            this.lb_prenomClient.AutoSize = true;
            this.lb_prenomClient.Location = new System.Drawing.Point(138, 8);
            this.lb_prenomClient.Name = "lb_prenomClient";
            this.lb_prenomClient.Size = new System.Drawing.Size(86, 13);
            this.lb_prenomClient.TabIndex = 2;
            this.lb_prenomClient.Text = "Prénom du client";
            // 
            // tb_prenomClient
            // 
            this.tb_prenomClient.Location = new System.Drawing.Point(141, 25);
            this.tb_prenomClient.Name = "tb_prenomClient";
            this.tb_prenomClient.Size = new System.Drawing.Size(100, 20);
            this.tb_prenomClient.TabIndex = 3;
            // 
            // lb_numeroDossier
            // 
            this.lb_numeroDossier.AutoSize = true;
            this.lb_numeroDossier.Location = new System.Drawing.Point(12, 67);
            this.lb_numeroDossier.Name = "lb_numeroDossier";
            this.lb_numeroDossier.Size = new System.Drawing.Size(95, 13);
            this.lb_numeroDossier.TabIndex = 4;
            this.lb_numeroDossier.Text = "Numéro de dossier";
            // 
            // tb_numeroDossier
            // 
            this.tb_numeroDossier.Location = new System.Drawing.Point(13, 84);
            this.tb_numeroDossier.Name = "tb_numeroDossier";
            this.tb_numeroDossier.Size = new System.Drawing.Size(228, 20);
            this.tb_numeroDossier.TabIndex = 5;
            // 
            // bt_nouveauDossier
            // 
            this.bt_nouveauDossier.Location = new System.Drawing.Point(60, 128);
            this.bt_nouveauDossier.Name = "bt_nouveauDossier";
            this.bt_nouveauDossier.Size = new System.Drawing.Size(131, 35);
            this.bt_nouveauDossier.TabIndex = 6;
            this.bt_nouveauDossier.Text = "Enregistrer";
            this.bt_nouveauDossier.UseVisualStyleBackColor = true;
            this.bt_nouveauDossier.Click += new System.EventHandler(this.bt_nouveauDossier_Click);
            // 
            // vueNouveauDossier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 175);
            this.Controls.Add(this.bt_nouveauDossier);
            this.Controls.Add(this.tb_numeroDossier);
            this.Controls.Add(this.lb_numeroDossier);
            this.Controls.Add(this.tb_prenomClient);
            this.Controls.Add(this.lb_prenomClient);
            this.Controls.Add(this.tb_nomClient);
            this.Controls.Add(this.lb_NomClient);
            this.Name = "vueNouveauDossier";
            this.Text = "vueNouveauDossier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_NomClient;
        private System.Windows.Forms.TextBox tb_nomClient;
        private System.Windows.Forms.Label lb_prenomClient;
        private System.Windows.Forms.TextBox tb_prenomClient;
        private System.Windows.Forms.Label lb_numeroDossier;
        private System.Windows.Forms.TextBox tb_numeroDossier;
        private System.Windows.Forms.Button bt_nouveauDossier;
    }
}