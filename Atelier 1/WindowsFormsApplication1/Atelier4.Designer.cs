namespace FormCalcule
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
            this.Txt_nb1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_nb2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_res = new System.Windows.Forms.TextBox();
            this.Btn_sous = new System.Windows.Forms.Button();
            this.Btn_som = new System.Windows.Forms.Button();
            this.Btn_div = new System.Windows.Forms.Button();
            this.Btn_mult = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_Init = new System.Windows.Forms.Button();
            this.Btn_Fermer = new System.Windows.Forms.Button();
            this.LblmsgError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_nb1
            // 
            this.Txt_nb1.Location = new System.Drawing.Point(77, 88);
            this.Txt_nb1.Name = "Txt_nb1";
            this.Txt_nb1.Size = new System.Drawing.Size(127, 38);
            this.Txt_nb1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nb 1 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nb 2 :";
            // 
            // Txt_nb2
            // 
            this.Txt_nb2.Location = new System.Drawing.Point(77, 153);
            this.Txt_nb2.Name = "Txt_nb2";
            this.Txt_nb2.Size = new System.Drawing.Size(127, 38);
            this.Txt_nb2.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 35;
            this.label7.Text = "Résultat";
            // 
            // Txt_res
            // 
            this.Txt_res.Location = new System.Drawing.Point(96, 268);
            this.Txt_res.Name = "Txt_res";
            this.Txt_res.ReadOnly = true;
            this.Txt_res.Size = new System.Drawing.Size(252, 38);
            this.Txt_res.TabIndex = 40;
            // 
            // Btn_sous
            // 
            this.Btn_sous.Location = new System.Drawing.Point(299, 151);
            this.Btn_sous.Name = "Btn_sous";
            this.Btn_sous.Size = new System.Drawing.Size(40, 40);
            this.Btn_sous.TabIndex = 50;
            this.Btn_sous.Text = "-";
            this.Btn_sous.UseVisualStyleBackColor = true;
            this.Btn_sous.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_som
            // 
            this.Btn_som.Location = new System.Drawing.Point(235, 151);
            this.Btn_som.Name = "Btn_som";
            this.Btn_som.Size = new System.Drawing.Size(40, 40);
            this.Btn_som.TabIndex = 45;
            this.Btn_som.Text = "+";
            this.Btn_som.UseVisualStyleBackColor = true;
            this.Btn_som.Click += new System.EventHandler(this.button2_Click);
            // 
            // Btn_div
            // 
            this.Btn_div.Location = new System.Drawing.Point(235, 88);
            this.Btn_div.Name = "Btn_div";
            this.Btn_div.Size = new System.Drawing.Size(40, 40);
            this.Btn_div.TabIndex = 55;
            this.Btn_div.Text = "/";
            this.Btn_div.UseVisualStyleBackColor = true;
            this.Btn_div.Click += new System.EventHandler(this.button3_Click);
            // 
            // Btn_mult
            // 
            this.Btn_mult.Location = new System.Drawing.Point(299, 98);
            this.Btn_mult.Name = "Btn_mult";
            this.Btn_mult.Size = new System.Drawing.Size(40, 40);
            this.Btn_mult.TabIndex = 60;
            this.Btn_mult.Text = "*";
            this.Btn_mult.UseVisualStyleBackColor = true;
            this.Btn_mult.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.SystemColors.Menu;
            this.label4.Location = new System.Drawing.Point(91, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(284, 47);
            this.label4.TabIndex = 61;
            this.label4.Text = "Calculatrice";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_Init
            // 
            this.Btn_Init.Location = new System.Drawing.Point(354, 88);
            this.Btn_Init.Name = "Btn_Init";
            this.Btn_Init.Size = new System.Drawing.Size(131, 38);
            this.Btn_Init.TabIndex = 62;
            this.Btn_Init.Text = "Initialiser";
            this.Btn_Init.UseVisualStyleBackColor = true;
            this.Btn_Init.Click += new System.EventHandler(this.Btn_Init_Click);
            // 
            // Btn_Fermer
            // 
            this.Btn_Fermer.Location = new System.Drawing.Point(354, 141);
            this.Btn_Fermer.Name = "Btn_Fermer";
            this.Btn_Fermer.Size = new System.Drawing.Size(131, 49);
            this.Btn_Fermer.TabIndex = 63;
            this.Btn_Fermer.Text = "Fermer";
            this.Btn_Fermer.UseVisualStyleBackColor = true;
            this.Btn_Fermer.Click += new System.EventHandler(this.Btn_Fermer_Click);
            // 
            // LblmsgError
            // 
            this.LblmsgError.AutoSize = true;
            this.LblmsgError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.LblmsgError.Location = new System.Drawing.Point(93, 59);
            this.LblmsgError.Name = "LblmsgError";
            this.LblmsgError.Size = new System.Drawing.Size(0, 16);
            this.LblmsgError.TabIndex = 64;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
           // this.BackgroundImage = global::FormCalcule.Properties.Resources.image_20160927_14593_1rf92dt;
            this.ClientSize = new System.Drawing.Size(524, 332);
            this.Controls.Add(this.LblmsgError);
            this.Controls.Add(this.Btn_Fermer);
            this.Controls.Add(this.Btn_Init);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Btn_mult);
            this.Controls.Add(this.Btn_div);
            this.Controls.Add(this.Btn_som);
            this.Controls.Add(this.Btn_sous);
            this.Controls.Add(this.Txt_res);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Txt_nb2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txt_nb1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Calculatrice :";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_nb1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_nb2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txt_res;
        private System.Windows.Forms.Button Btn_sous;
        private System.Windows.Forms.Button Btn_som;
        private System.Windows.Forms.Button Btn_div;
        private System.Windows.Forms.Button Btn_mult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_Init;
        private System.Windows.Forms.Button Btn_Fermer;
        private System.Windows.Forms.Label LblmsgError;
    }

    internal class Properties
    {
    }
}

