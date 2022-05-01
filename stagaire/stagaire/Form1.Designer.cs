namespace stagaire
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1Nom = new System.Windows.Forms.TextBox();
            this.textBox3Penom = new System.Windows.Forms.TextBox();
            this.dateTimePicker1Date = new System.Windows.Forms.DateTimePicker();
            this.sexeM = new System.Windows.Forms.RadioButton();
            this.sexeF = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.intNon = new System.Windows.Forms.RadioButton();
            this.IntrOui = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.filier = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2NuIN = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 370);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "filier";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 184);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "DateNissance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 243);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "sexe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 100);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Prenom";
            // 
            // textBox1Nom
            // 
            this.textBox1Nom.Location = new System.Drawing.Point(173, 50);
            this.textBox1Nom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1Nom.Name = "textBox1Nom";
            this.textBox1Nom.Size = new System.Drawing.Size(76, 20);
            this.textBox1Nom.TabIndex = 5;
            this.textBox1Nom.TextChanged += new System.EventHandler(this.textBox1Nom_TextChanged);
            // 
            // textBox3Penom
            // 
            this.textBox3Penom.Location = new System.Drawing.Point(173, 98);
            this.textBox3Penom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox3Penom.Name = "textBox3Penom";
            this.textBox3Penom.Size = new System.Drawing.Size(76, 20);
            this.textBox3Penom.TabIndex = 7;
            // 
            // dateTimePicker1Date
            // 
            this.dateTimePicker1Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1Date.Location = new System.Drawing.Point(169, 184);
            this.dateTimePicker1Date.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1Date.Name = "dateTimePicker1Date";
            this.dateTimePicker1Date.Size = new System.Drawing.Size(106, 20);
            this.dateTimePicker1Date.TabIndex = 8;
            // 
            // sexeM
            // 
            this.sexeM.AutoSize = true;
            this.sexeM.Location = new System.Drawing.Point(0, 17);
            this.sexeM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sexeM.Name = "sexeM";
            this.sexeM.Size = new System.Drawing.Size(34, 17);
            this.sexeM.TabIndex = 9;
            this.sexeM.TabStop = true;
            this.sexeM.Text = "M";
            this.sexeM.UseVisualStyleBackColor = true;
            // 
            // sexeF
            // 
            this.sexeF.AutoSize = true;
            this.sexeF.Location = new System.Drawing.Point(80, 17);
            this.sexeF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sexeF.Name = "sexeF";
            this.sexeF.Size = new System.Drawing.Size(31, 17);
            this.sexeF.TabIndex = 10;
            this.sexeF.TabStop = true;
            this.sexeF.Text = "F";
            this.sexeF.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sexeF);
            this.groupBox1.Controls.Add(this.sexeM);
            this.groupBox1.Location = new System.Drawing.Point(169, 229);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(162, 43);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.intNon);
            this.groupBox2.Controls.Add(this.IntrOui);
            this.groupBox2.Location = new System.Drawing.Point(169, 296);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(162, 42);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // intNon
            // 
            this.intNon.AutoSize = true;
            this.intNon.Location = new System.Drawing.Point(75, 15);
            this.intNon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.intNon.Name = "intNon";
            this.intNon.Size = new System.Drawing.Size(43, 17);
            this.intNon.TabIndex = 1;
            this.intNon.TabStop = true;
            this.intNon.Text = "non";
            this.intNon.UseVisualStyleBackColor = true;
            // 
            // IntrOui
            // 
            this.IntrOui.AutoSize = true;
            this.IntrOui.Location = new System.Drawing.Point(4, 15);
            this.IntrOui.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IntrOui.Name = "IntrOui";
            this.IntrOui.Size = new System.Drawing.Size(39, 17);
            this.IntrOui.TabIndex = 0;
            this.IntrOui.TabStop = true;
            this.IntrOui.Text = "oui";
            this.IntrOui.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 312);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "interne";
            // 
            // filier
            // 
            this.filier.FormattingEnabled = true;
            this.filier.Items.AddRange(new object[] {
            "TDI",
            "TRI",
            "TMSIR",
            "TSGE",
            ""});
            this.filier.Location = new System.Drawing.Point(169, 366);
            this.filier.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.filier.Name = "filier";
            this.filier.Size = new System.Drawing.Size(92, 21);
            this.filier.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 145);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Numero d\'incription";
            // 
            // textBox2NuIN
            // 
            this.textBox2NuIN.Location = new System.Drawing.Point(173, 140);
            this.textBox2NuIN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2NuIN.Name = "textBox2NuIN";
            this.textBox2NuIN.Size = new System.Drawing.Size(76, 20);
            this.textBox2NuIN.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(340, 46);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 17;
            this.button1.Text = "ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(340, 100);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 19);
            this.button2.TabIndex = 18;
            this.button2.Text = "modifier";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(340, 161);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 19);
            this.button3.TabIndex = 19;
            this.button3.Text = "Vider";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 421);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2NuIN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.filier);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePicker1Date);
            this.Controls.Add(this.textBox3Penom);
            this.Controls.Add(this.textBox1Nom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Nom";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1Nom;
        private System.Windows.Forms.TextBox textBox3Penom;
        private System.Windows.Forms.DateTimePicker dateTimePicker1Date;
        private System.Windows.Forms.RadioButton sexeM;
        private System.Windows.Forms.RadioButton sexeF;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton intNon;
        private System.Windows.Forms.RadioButton IntrOui;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox filier;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2NuIN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

