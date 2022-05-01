namespace Ateleier4
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
            this.Btn_OK = new System.Windows.Forms.Button();
            this.Btn_Fermer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cmb_Jour = new System.Windows.Forms.ComboBox();
            this.Cmb_Mois = new System.Windows.Forms.ComboBox();
            this.Cmb_Anne = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Btn_OK
            // 
            this.Btn_OK.Location = new System.Drawing.Point(72, 204);
            this.Btn_OK.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_OK.Name = "Btn_OK";
            this.Btn_OK.Size = new System.Drawing.Size(100, 28);
            this.Btn_OK.TabIndex = 0;
            this.Btn_OK.Text = "OK";
            this.Btn_OK.UseVisualStyleBackColor = true;
            this.Btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
            // 
            // Btn_Fermer
            // 
            this.Btn_Fermer.Location = new System.Drawing.Point(224, 204);
            this.Btn_Fermer.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Fermer.Name = "Btn_Fermer";
            this.Btn_Fermer.Size = new System.Drawing.Size(100, 28);
            this.Btn_Fermer.TabIndex = 1;
            this.Btn_Fermer.Text = "Fermer";
            this.Btn_Fermer.UseVisualStyleBackColor = true;
            this.Btn_Fermer.Click += new System.EventHandler(this.Btn_Fermer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Entrer votre date de naissance : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Date de Naissance";
            // 
            // Cmb_Jour
            // 
            this.Cmb_Jour.FormattingEnabled = true;
            this.Cmb_Jour.ItemHeight = 16;
            this.Cmb_Jour.Location = new System.Drawing.Point(43, 119);
            this.Cmb_Jour.Margin = new System.Windows.Forms.Padding(4);
            this.Cmb_Jour.Name = "Cmb_Jour";
            this.Cmb_Jour.Size = new System.Drawing.Size(89, 24);
            this.Cmb_Jour.TabIndex = 4;
            // 
            // Cmb_Mois
            // 
            this.Cmb_Mois.FormattingEnabled = true;
            this.Cmb_Mois.Items.AddRange(new object[] {
            "janvier",
            "février",
            "mars",
            "avril",
            "mai",
            "juin",
            "juillet",
            "août",
            "septembre",
            "octobre",
            "nevember",
            "décember"});
            this.Cmb_Mois.Location = new System.Drawing.Point(141, 119);
            this.Cmb_Mois.Margin = new System.Windows.Forms.Padding(4);
            this.Cmb_Mois.Name = "Cmb_Mois";
            this.Cmb_Mois.Size = new System.Drawing.Size(107, 24);
            this.Cmb_Mois.TabIndex = 5;
            // 
            // Cmb_Anne
            // 
            this.Cmb_Anne.FormattingEnabled = true;
            this.Cmb_Anne.Location = new System.Drawing.Point(257, 119);
            this.Cmb_Anne.Margin = new System.Windows.Forms.Padding(4);
            this.Cmb_Anne.Name = "Cmb_Anne";
            this.Cmb_Anne.Size = new System.Drawing.Size(89, 24);
            this.Cmb_Anne.TabIndex = 6;
            this.Cmb_Anne.SelectedIndexChanged += new System.EventHandler(this.Cmb_Anne_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.date_de_naissance;
            this.ClientSize = new System.Drawing.Size(606, 515);
            this.Controls.Add(this.Cmb_Anne);
            this.Controls.Add(this.Cmb_Mois);
            this.Controls.Add(this.Cmb_Jour);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_Fermer);
            this.Controls.Add(this.Btn_OK);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Date de Naissance :";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_OK;
        private System.Windows.Forms.Button Btn_Fermer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cmb_Jour;
        private System.Windows.Forms.ComboBox Cmb_Mois;
        private System.Windows.Forms.ComboBox Cmb_Anne;
    }
}

