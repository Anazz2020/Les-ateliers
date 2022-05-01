namespace Ateleier3
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
            this.Btn_Init = new System.Windows.Forms.Button();
            this.Btn_Calculer = new System.Windows.Forms.Button();
            this.Txt_QteCmd = new System.Windows.Forms.TextBox();
            this.Txt_PU = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_TVA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_TTC = new System.Windows.Forms.TextBox();
            this.Txt_HT = new System.Windows.Forms.TextBox();
            this.Btn_Fermer = new System.Windows.Forms.Button();
            this.LblmsgError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Init
            // 
            this.Btn_Init.Location = new System.Drawing.Point(552, 160);
            this.Btn_Init.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Init.Name = "Btn_Init";
            this.Btn_Init.Size = new System.Drawing.Size(133, 49);
            this.Btn_Init.TabIndex = 13;
            this.Btn_Init.Text = "Initialiser";
            this.Btn_Init.UseVisualStyleBackColor = true;
            this.Btn_Init.Click += new System.EventHandler(this.Btn_Init_Click);
            // 
            // Btn_Calculer
            // 
            this.Btn_Calculer.Location = new System.Drawing.Point(552, 92);
            this.Btn_Calculer.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Calculer.Name = "Btn_Calculer";
            this.Btn_Calculer.Size = new System.Drawing.Size(133, 49);
            this.Btn_Calculer.TabIndex = 12;
            this.Btn_Calculer.Text = "Calculer";
            this.Btn_Calculer.UseVisualStyleBackColor = true;
            this.Btn_Calculer.Click += new System.EventHandler(this.Btn_cnx_Click);
            // 
            // Txt_QteCmd
            // 
            this.Txt_QteCmd.Location = new System.Drawing.Point(277, 135);
            this.Txt_QteCmd.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_QteCmd.Name = "Txt_QteCmd";
            this.Txt_QteCmd.Size = new System.Drawing.Size(229, 22);
            this.Txt_QteCmd.TabIndex = 11;
            // 
            // Txt_PU
            // 
            this.Txt_PU.Location = new System.Drawing.Point(276, 98);
            this.Txt_PU.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_PU.Name = "Txt_PU";
            this.Txt_PU.Size = new System.Drawing.Size(231, 22);
            this.Txt_PU.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Quantité Commandé : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Prix Unitaire : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(489, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 58);
            this.label1.TabIndex = 7;
            this.label1.Text = "Facture";
            // 
            // Txt_TVA
            // 
            this.Txt_TVA.Location = new System.Drawing.Point(277, 175);
            this.Txt_TVA.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_TVA.Name = "Txt_TVA";
            this.Txt_TVA.Size = new System.Drawing.Size(229, 22);
            this.Txt_TVA.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 175);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Taux TVA :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(516, 176);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(143, 346);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Prix T.T.C : ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(143, 292);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Prix H.T : ";
            // 
            // Txt_TTC
            // 
            this.Txt_TTC.Location = new System.Drawing.Point(277, 342);
            this.Txt_TTC.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_TTC.Name = "Txt_TTC";
            this.Txt_TTC.ReadOnly = true;
            this.Txt_TTC.Size = new System.Drawing.Size(229, 22);
            this.Txt_TTC.TabIndex = 20;
            // 
            // Txt_HT
            // 
            this.Txt_HT.Location = new System.Drawing.Point(277, 292);
            this.Txt_HT.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_HT.Name = "Txt_HT";
            this.Txt_HT.ReadOnly = true;
            this.Txt_HT.Size = new System.Drawing.Size(229, 22);
            this.Txt_HT.TabIndex = 19;
            // 
            // Btn_Fermer
            // 
            this.Btn_Fermer.Location = new System.Drawing.Point(552, 304);
            this.Btn_Fermer.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Fermer.Name = "Btn_Fermer";
            this.Btn_Fermer.Size = new System.Drawing.Size(133, 49);
            this.Btn_Fermer.TabIndex = 21;
            this.Btn_Fermer.Text = "Fermer";
            this.Btn_Fermer.UseVisualStyleBackColor = true;
            this.Btn_Fermer.Click += new System.EventHandler(this.Btn_Fermer_Click);
            // 
            // LblmsgError
            // 
            this.LblmsgError.AutoSize = true;
            this.LblmsgError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblmsgError.Location = new System.Drawing.Point(143, 235);
            this.LblmsgError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblmsgError.Name = "LblmsgError";
            this.LblmsgError.Size = new System.Drawing.Size(0, 20);
            this.LblmsgError.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.facturationelec2;
            this.ClientSize = new System.Drawing.Size(723, 400);
            this.Controls.Add(this.LblmsgError);
            this.Controls.Add(this.Btn_Fermer);
            this.Controls.Add(this.Txt_TTC);
            this.Controls.Add(this.Txt_HT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txt_TVA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Btn_Init);
            this.Controls.Add(this.Btn_Calculer);
            this.Controls.Add(this.Txt_QteCmd);
            this.Controls.Add(this.Txt_PU);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Facture :";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Init;
        private System.Windows.Forms.Button Btn_Calculer;
        private System.Windows.Forms.TextBox Txt_QteCmd;
        private System.Windows.Forms.TextBox Txt_PU;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_TVA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_TTC;
        private System.Windows.Forms.TextBox Txt_HT;
        private System.Windows.Forms.Button Btn_Fermer;
        private System.Windows.Forms.Label LblmsgError;
    }
}

