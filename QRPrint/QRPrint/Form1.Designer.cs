namespace QRPrint
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
            this.mainButtonCreate = new System.Windows.Forms.Button();
            this.mainButtonPrint = new System.Windows.Forms.Button();
            this.mainButtonMAJ = new System.Windows.Forms.Button();
            this.mainButtonManage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainButtonCreate
            // 
            this.mainButtonCreate.Location = new System.Drawing.Point(24, 23);
            this.mainButtonCreate.Name = "mainButtonCreate";
            this.mainButtonCreate.Size = new System.Drawing.Size(248, 41);
            this.mainButtonCreate.TabIndex = 0;
            this.mainButtonCreate.Text = "Créer";
            this.mainButtonCreate.UseVisualStyleBackColor = true;
            this.mainButtonCreate.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainButtonPrint
            // 
            this.mainButtonPrint.Location = new System.Drawing.Point(24, 78);
            this.mainButtonPrint.Name = "mainButtonPrint";
            this.mainButtonPrint.Size = new System.Drawing.Size(248, 41);
            this.mainButtonPrint.TabIndex = 1;
            this.mainButtonPrint.Text = "Imprimer";
            this.mainButtonPrint.UseVisualStyleBackColor = true;
            this.mainButtonPrint.Click += new System.EventHandler(this.mainButtonPrint_Click);
            // 
            // mainButtonMAJ
            // 
            this.mainButtonMAJ.Location = new System.Drawing.Point(24, 137);
            this.mainButtonMAJ.Name = "mainButtonMAJ";
            this.mainButtonMAJ.Size = new System.Drawing.Size(248, 41);
            this.mainButtonMAJ.TabIndex = 2;
            this.mainButtonMAJ.Text = "Mettre à jour";
            this.mainButtonMAJ.UseVisualStyleBackColor = true;
            this.mainButtonMAJ.Click += new System.EventHandler(this.mainButtonMAJ_Click);
            // 
            // mainButtonManage
            // 
            this.mainButtonManage.Location = new System.Drawing.Point(24, 194);
            this.mainButtonManage.Name = "mainButtonManage";
            this.mainButtonManage.Size = new System.Drawing.Size(248, 41);
            this.mainButtonManage.TabIndex = 3;
            this.mainButtonManage.Text = "Gestion";
            this.mainButtonManage.UseVisualStyleBackColor = true;
            this.mainButtonManage.Click += new System.EventHandler(this.mainButtonManage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.mainButtonManage);
            this.Controls.Add(this.mainButtonMAJ);
            this.Controls.Add(this.mainButtonPrint);
            this.Controls.Add(this.mainButtonCreate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mainButtonCreate;
        private System.Windows.Forms.Button mainButtonPrint;
        private System.Windows.Forms.Button mainButtonMAJ;
        private System.Windows.Forms.Button mainButtonManage;
    }
}

