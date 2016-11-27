namespace QRPrint
{
    partial class viewManageType
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
            this.lb_nameInter = new System.Windows.Forms.Label();
            this.tb_nameInter = new System.Windows.Forms.TextBox();
            this.lb_parent = new System.Windows.Forms.Label();
            this.Cb_parentInter = new System.Windows.Forms.ComboBox();
            this.bt_addInter = new System.Windows.Forms.Button();
            this.lb_deleteInter = new System.Windows.Forms.Label();
            this.Cb_delete = new System.Windows.Forms.ComboBox();
            this.bt_deleteInter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_nameInter
            // 
            this.lb_nameInter.AutoSize = true;
            this.lb_nameInter.Location = new System.Drawing.Point(13, 31);
            this.lb_nameInter.Name = "lb_nameInter";
            this.lb_nameInter.Size = new System.Drawing.Size(83, 13);
            this.lb_nameInter.TabIndex = 0;
            this.lb_nameInter.Text = "Nom intercalaire";
            // 
            // tb_nameInter
            // 
            this.tb_nameInter.Location = new System.Drawing.Point(13, 48);
            this.tb_nameInter.Name = "tb_nameInter";
            this.tb_nameInter.Size = new System.Drawing.Size(178, 20);
            this.tb_nameInter.TabIndex = 1;
            // 
            // lb_parent
            // 
            this.lb_parent.AutoSize = true;
            this.lb_parent.Location = new System.Drawing.Point(13, 75);
            this.lb_parent.Name = "lb_parent";
            this.lb_parent.Size = new System.Drawing.Size(38, 13);
            this.lb_parent.TabIndex = 2;
            this.lb_parent.Text = "Parent";
            // 
            // Cb_parentInter
            // 
            this.Cb_parentInter.FormattingEnabled = true;
            this.Cb_parentInter.Location = new System.Drawing.Point(14, 91);
            this.Cb_parentInter.Name = "Cb_parentInter";
            this.Cb_parentInter.Size = new System.Drawing.Size(179, 21);
            this.Cb_parentInter.TabIndex = 3;
            // 
            // bt_addInter
            // 
            this.bt_addInter.Location = new System.Drawing.Point(12, 124);
            this.bt_addInter.Name = "bt_addInter";
            this.bt_addInter.Size = new System.Drawing.Size(75, 23);
            this.bt_addInter.TabIndex = 4;
            this.bt_addInter.Text = "Ajouter";
            this.bt_addInter.UseVisualStyleBackColor = true;
            this.bt_addInter.Click += new System.EventHandler(this.bt_addInter_Click);
            // 
            // lb_deleteInter
            // 
            this.lb_deleteInter.AutoSize = true;
            this.lb_deleteInter.Location = new System.Drawing.Point(10, 170);
            this.lb_deleteInter.Name = "lb_deleteInter";
            this.lb_deleteInter.Size = new System.Drawing.Size(129, 13);
            this.lb_deleteInter.TabIndex = 5;
            this.lb_deleteInter.Text = "Supprimer une intercalaire";
            // 
            // Cb_delete
            // 
            this.Cb_delete.FormattingEnabled = true;
            this.Cb_delete.Location = new System.Drawing.Point(14, 187);
            this.Cb_delete.Name = "Cb_delete";
            this.Cb_delete.Size = new System.Drawing.Size(175, 21);
            this.Cb_delete.TabIndex = 6;
            // 
            // bt_deleteInter
            // 
            this.bt_deleteInter.Location = new System.Drawing.Point(13, 215);
            this.bt_deleteInter.Name = "bt_deleteInter";
            this.bt_deleteInter.Size = new System.Drawing.Size(75, 23);
            this.bt_deleteInter.TabIndex = 7;
            this.bt_deleteInter.Text = "Supprimer";
            this.bt_deleteInter.UseVisualStyleBackColor = true;
            this.bt_deleteInter.Click += new System.EventHandler(this.bt_deleteInter_Click);
            // 
            // viewManageType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.bt_deleteInter);
            this.Controls.Add(this.Cb_delete);
            this.Controls.Add(this.lb_deleteInter);
            this.Controls.Add(this.bt_addInter);
            this.Controls.Add(this.Cb_parentInter);
            this.Controls.Add(this.lb_parent);
            this.Controls.Add(this.tb_nameInter);
            this.Controls.Add(this.lb_nameInter);
            this.Name = "viewManageType";
            this.Text = "viewManageType";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_nameInter;
        private System.Windows.Forms.TextBox tb_nameInter;
        private System.Windows.Forms.Label lb_parent;
        private System.Windows.Forms.ComboBox Cb_parentInter;
        private System.Windows.Forms.Button bt_addInter;
        private System.Windows.Forms.Label lb_deleteInter;
        private System.Windows.Forms.ComboBox Cb_delete;
        private System.Windows.Forms.Button bt_deleteInter;
    }
}