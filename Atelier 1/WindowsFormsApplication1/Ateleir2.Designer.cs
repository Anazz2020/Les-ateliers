namespace Atelier_2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelmot = new System.Windows.Forms.Label();
            this.textBoxNm = new System.Windows.Forms.TextBox();
            this.textBoxMot = new System.Windows.Forms.TextBox();
            this.Btn_cnx = new System.Windows.Forms.Button();
            this.Btn_annuler = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.textError = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(33, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connectez-vous à l’aide de\r\nvotre compte Gmail\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(36, 105);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(121, 17);
            this.labelNom.TabIndex = 1;
            this.labelNom.Text = "Nom d’utilisateur :";
            // 
            // labelmot
            // 
            this.labelmot.AutoSize = true;
            this.labelmot.Location = new System.Drawing.Point(36, 183);
            this.labelmot.Name = "labelmot";
            this.labelmot.Size = new System.Drawing.Size(101, 17);
            this.labelmot.TabIndex = 2;
            this.labelmot.Text = "Mot de passe :";
            this.labelmot.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxNm
            // 
            this.textBoxNm.Location = new System.Drawing.Point(157, 125);
            this.textBoxNm.Name = "textBoxNm";
            this.textBoxNm.Size = new System.Drawing.Size(189, 22);
            this.textBoxNm.TabIndex = 3;
            // 
            // textBoxMot
            // 
            this.textBoxMot.Location = new System.Drawing.Point(157, 207);
            this.textBoxMot.Name = "textBoxMot";
            this.textBoxMot.Size = new System.Drawing.Size(189, 22);
            this.textBoxMot.TabIndex = 4;
            // 
            // Btn_cnx
            // 
            this.Btn_cnx.Location = new System.Drawing.Point(36, 268);
            this.Btn_cnx.Name = "Btn_cnx";
            this.Btn_cnx.Size = new System.Drawing.Size(134, 23);
            this.Btn_cnx.TabIndex = 5;
            this.Btn_cnx.Text = "Se_connecter";
            this.Btn_cnx.UseVisualStyleBackColor = true;
            this.Btn_cnx.Click += new System.EventHandler(this.Btn_cnx_Click);
            // 
            // Btn_annuler
            // 
            this.Btn_annuler.Location = new System.Drawing.Point(221, 268);
            this.Btn_annuler.Name = "Btn_annuler";
            this.Btn_annuler.Size = new System.Drawing.Size(125, 23);
            this.Btn_annuler.TabIndex = 6;
            this.Btn_annuler.Text = "Annuler";
            this.Btn_annuler.UseVisualStyleBackColor = true;
            this.Btn_annuler.Click += new System.EventHandler(this.Btn_annuler_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // textError
            // 
            this.textError.BackColor = System.Drawing.SystemColors.Menu;
            this.textError.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textError.ForeColor = System.Drawing.Color.Red;
            this.textError.Location = new System.Drawing.Point(36, 64);
            this.textError.Name = "textError";
            this.textError.ReadOnly = true;
            this.textError.Size = new System.Drawing.Size(310, 15);
            this.textError.TabIndex = 7;
            this.textError.TextChanged += new System.EventHandler(this.textError_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 318);
            this.Controls.Add(this.textError);
            this.Controls.Add(this.Btn_annuler);
            this.Controls.Add(this.Btn_cnx);
            this.Controls.Add(this.textBoxMot);
            this.Controls.Add(this.textBoxNm);
            this.Controls.Add(this.labelmot);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelmot;
        private System.Windows.Forms.TextBox textBoxNm;
        private System.Windows.Forms.TextBox textBoxMot;
        private System.Windows.Forms.Button Btn_cnx;
        private System.Windows.Forms.Button Btn_annuler;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox textError;
    }
}

