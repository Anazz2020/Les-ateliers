using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ateleier4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            int i;

            for (i = 1; i < 32; i++)
            {
                Cmb_Jour.Items.Add(i);
            }
            for (i = DateTime.Now.Year - 100; i < DateTime.Now.Year; i++)
            {
                Cmb_Anne.Items.Add(i);
            }
        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            if (Cmb_Jour.Text == "" || Cmb_Anne.Text == "" || Cmb_Mois.Text == "")
            {
                MessageBox.Show("3ammr kolchi assa7bi");


            }
            else
            {
                int age = DateTime.Now.Year - Convert.ToInt16(Cmb_Anne.Text);
                MessageBox.Show("votre date de naissance est : " + Cmb_Jour.Text + "/" + Cmb_Mois.Text + "/" + Cmb_Anne.Text + "date de naissance");
                MessageBox.Show("votre age est : " + age + " age");

            }
        }

        private void Btn_Fermer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("voulez-vous vraiment quitter cette aplication");
        }

        private void Cmb_Anne_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
