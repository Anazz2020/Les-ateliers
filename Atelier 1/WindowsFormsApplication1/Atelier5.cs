using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ateleier5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_fermer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("voulez-vous vraiment quitter cette application", "Fermeture", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void Chk_color_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_color.Checked == true)
            {
                this.Height = 233;
                Chk_color.Text = "Masquer les couleurs";
            }
            else
            {
                this.Height = 118;
                Chk_color.Text = "Afficher les couleurs";
            }
        }

        private void Rd_green_CheckedChanged(object sender, EventArgs e)
        {
            Lbl_msg.ForeColor = Color.Red;
        }
        private void Rd_bleu_CheckedChanged(object sender, EventArgs e)
        {
            Lbl_msg.ForeColor = Color.Blue;
        }

        private void Rd_red_CheckedChanged(object sender, EventArgs e)
        {
            Lbl_msg.ForeColor = Color.Green;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Height = 118;
        }

    }
}
