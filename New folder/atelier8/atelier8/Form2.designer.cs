namespace atelier8
{
    partial class Form2
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox3 = new System.Windows.Forms.CheckedListBox();
            this.btncommander = new System.Windows.Forms.Button();
            this.btninit = new System.Windows.Forms.Button();
            this.checkedListBox4 = new System.Windows.Forms.CheckedListBox();
            this.Salades = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Salad de pattes",
            "Salade de chef",
            "Salade marocian",
            "Salade nécoise",
            "Salade verte"});
            this.checkedListBox1.Location = new System.Drawing.Point(2, 126);
            this.checkedListBox1.MultiColumn = true;
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkedListBox1.Size = new System.Drawing.Size(200, 106);
            this.checkedListBox1.TabIndex = 6;
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "Brochette de Boeuf",
            "Brochette de Viande hachée",
            "Brochette de foie",
            "Brochette de poulet"});
            this.checkedListBox2.Location = new System.Drawing.Point(247, 126);
            this.checkedListBox2.MultiColumn = true;
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkedListBox2.Size = new System.Drawing.Size(189, 106);
            this.checkedListBox2.TabIndex = 7;
            // 
            // checkedListBox3
            // 
            this.checkedListBox3.FormattingEnabled = true;
            this.checkedListBox3.Items.AddRange(new object[] {
            "Créme Caramel",
            "Mouse au chocolat",
            "Glasse",
            "Tarte aux pomme",
            "Salade de fuit"});
            this.checkedListBox3.Location = new System.Drawing.Point(465, 126);
            this.checkedListBox3.MultiColumn = true;
            this.checkedListBox3.Name = "checkedListBox3";
            this.checkedListBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkedListBox3.Size = new System.Drawing.Size(196, 106);
            this.checkedListBox3.TabIndex = 8;
            // 
            // btncommander
            // 
            this.btncommander.Location = new System.Drawing.Point(296, 307);
            this.btncommander.Name = "btncommander";
            this.btncommander.Size = new System.Drawing.Size(140, 23);
            this.btncommander.TabIndex = 9;
            this.btncommander.Text = "COMMANDER";
            this.btncommander.UseVisualStyleBackColor = true;
            this.btncommander.Click += new System.EventHandler(this.btncommander_Click);
            // 
            // btninit
            // 
            this.btninit.Location = new System.Drawing.Point(465, 307);
            this.btninit.Name = "btninit";
            this.btninit.Size = new System.Drawing.Size(127, 23);
            this.btninit.TabIndex = 10;
            this.btninit.Text = "INITIALISER";
            this.btninit.UseVisualStyleBackColor = true;
            this.btninit.Click += new System.EventHandler(this.btninit_Click);
            // 
            // checkedListBox4
            // 
            this.checkedListBox4.FormattingEnabled = true;
            this.checkedListBox4.Items.AddRange(new object[] {
            "Jus D\'orange",
            "Jus de Pomme",
            "Jus de citron",
            "Boissons Gazeaux"});
            this.checkedListBox4.Location = new System.Drawing.Point(683, 126);
            this.checkedListBox4.MultiColumn = true;
            this.checkedListBox4.Name = "checkedListBox4";
            this.checkedListBox4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkedListBox4.Size = new System.Drawing.Size(200, 106);
            this.checkedListBox4.TabIndex = 11;
            // 
            // Salades
            // 
            this.Salades.AutoSize = true;
            this.Salades.Location = new System.Drawing.Point(61, 85);
            this.Salades.Name = "Salades";
            this.Salades.Size = new System.Drawing.Size(59, 17);
            this.Salades.TabIndex = 12;
            this.Salades.Text = "Salades";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Plat Principal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(546, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Desserts";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(757, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Boissons";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(382, 389);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 132);
            this.listBox1.TabIndex = 16;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 383);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Salades);
            this.Controls.Add(this.checkedListBox4);
            this.Controls.Add(this.btninit);
            this.Controls.Add(this.btncommander);
            this.Controls.Add(this.checkedListBox3);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.CheckedListBox checkedListBox3;
        private System.Windows.Forms.Button btncommander;
        private System.Windows.Forms.Button btninit;
        private System.Windows.Forms.CheckedListBox checkedListBox4;
        private System.Windows.Forms.Label Salades;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
    }
}