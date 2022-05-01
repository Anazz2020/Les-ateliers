namespace Ateleier5
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
            this.Chk_color = new System.Windows.Forms.CheckBox();
            this.Btn_fermer = new System.Windows.Forms.Button();
            this.Rd_green = new System.Windows.Forms.RadioButton();
            this.Rd_bleu = new System.Windows.Forms.RadioButton();
            this.Rd_red = new System.Windows.Forms.RadioButton();
            this.Lbl_msg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Chk_color
            // 
            this.Chk_color.AutoSize = true;
            this.Chk_color.Location = new System.Drawing.Point(108, 46);
            this.Chk_color.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Chk_color.Name = "Chk_color";
            this.Chk_color.Size = new System.Drawing.Size(158, 21);
            this.Chk_color.TabIndex = 0;
            this.Chk_color.Text = "Afficher les couleurs";
            this.Chk_color.UseVisualStyleBackColor = true;
            this.Chk_color.CheckedChanged += new System.EventHandler(this.Chk_color_CheckedChanged);
            // 
            // Btn_fermer
            // 
            this.Btn_fermer.Location = new System.Drawing.Point(537, 39);
            this.Btn_fermer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_fermer.Name = "Btn_fermer";
            this.Btn_fermer.Size = new System.Drawing.Size(100, 28);
            this.Btn_fermer.TabIndex = 1;
            this.Btn_fermer.Text = "Quitter";
            this.Btn_fermer.UseVisualStyleBackColor = true;
            this.Btn_fermer.Click += new System.EventHandler(this.Btn_fermer_Click);
            // 
            // Rd_green
            // 
            this.Rd_green.AutoSize = true;
            this.Rd_green.ForeColor = System.Drawing.Color.Red;
            this.Rd_green.Location = new System.Drawing.Point(108, 113);
            this.Rd_green.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Rd_green.Name = "Rd_green";
            this.Rd_green.Size = new System.Drawing.Size(71, 21);
            this.Rd_green.TabIndex = 2;
            this.Rd_green.TabStop = true;
            this.Rd_green.Text = "Rouge";
            this.Rd_green.UseVisualStyleBackColor = true;
            this.Rd_green.CheckedChanged += new System.EventHandler(this.Rd_green_CheckedChanged);
            // 
            // Rd_bleu
            // 
            this.Rd_bleu.AutoSize = true;
            this.Rd_bleu.ForeColor = System.Drawing.Color.Blue;
            this.Rd_bleu.Location = new System.Drawing.Point(292, 113);
            this.Rd_bleu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Rd_bleu.Name = "Rd_bleu";
            this.Rd_bleu.Size = new System.Drawing.Size(57, 21);
            this.Rd_bleu.TabIndex = 3;
            this.Rd_bleu.TabStop = true;
            this.Rd_bleu.Text = "Bleu";
            this.Rd_bleu.UseVisualStyleBackColor = true;
            this.Rd_bleu.CheckedChanged += new System.EventHandler(this.Rd_bleu_CheckedChanged);
            // 
            // Rd_red
            // 
            this.Rd_red.AutoSize = true;
            this.Rd_red.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Rd_red.Location = new System.Drawing.Point(459, 113);
            this.Rd_red.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Rd_red.Name = "Rd_red";
            this.Rd_red.Size = new System.Drawing.Size(55, 21);
            this.Rd_red.TabIndex = 4;
            this.Rd_red.TabStop = true;
            this.Rd_red.Text = "Vert";
            this.Rd_red.UseVisualStyleBackColor = true;
            this.Rd_red.CheckedChanged += new System.EventHandler(this.Rd_red_CheckedChanged);
            // 
            // Lbl_msg
            // 
            this.Lbl_msg.AutoSize = true;
            this.Lbl_msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_msg.Location = new System.Drawing.Point(99, 154);
            this.Lbl_msg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_msg.Name = "Lbl_msg";
            this.Lbl_msg.Size = new System.Drawing.Size(378, 48);
            this.Lbl_msg.TabIndex = 6;
            this.Lbl_msg.Text = "Bienvenue les TDI";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 247);
            this.Controls.Add(this.Lbl_msg);
            this.Controls.Add(this.Rd_red);
            this.Controls.Add(this.Rd_bleu);
            this.Controls.Add(this.Rd_green);
            this.Controls.Add(this.Btn_fermer);
            this.Controls.Add(this.Chk_color);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Couleurs :";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Chk_color;
        private System.Windows.Forms.Button Btn_fermer;
        private System.Windows.Forms.RadioButton Rd_green;
        private System.Windows.Forms.RadioButton Rd_bleu;
        private System.Windows.Forms.RadioButton Rd_red;
        private System.Windows.Forms.Label Lbl_msg;
    }
}

