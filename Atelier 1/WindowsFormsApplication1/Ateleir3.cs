using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ateleier3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Double HT, PU, TTC, TTVA, qte;
        private void Btn_cnx_Click(object sender, EventArgs e)
        {
            if (Txt_PU.Text == "" ||Txt_QteCmd.Text =="" || Txt_TVA.Text =="")
            {
                LblmsgError.Text = "3mr kolchi assa7bi ";
            }
            else
            {                
                qte = (Convert.ToDouble(Txt_QteCmd.Text));
                PU = (Convert.ToDouble(Txt_PU.Text));
                TTVA = (Convert.ToDouble(Txt_TVA.Text));

                HT = qte * PU;
                TTC = (HT *TTVA)/100 + HT;
                Txt_HT.Text = HT.ToString();
                Txt_TTC.Text = TTC.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Init_Click(object sender, EventArgs e)
        {
            LblmsgError.Text = "";
            Txt_PU.Text = "";
            Txt_HT.Text = "";
            Txt_QteCmd.Text = "";
            Txt_TTC.Text = "";
            Txt_TVA.Text = "";
        }

        private void Btn_Fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
