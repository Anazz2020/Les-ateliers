using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace FormCalcule
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double Nb1 = 0, Nb2 = 0, Re = 0;
        int x = 1;
        Char y = '+';

        public object Information { get; private set; }

        private void some()
        {
            Nb1 = Convert.ToDouble(Txt_nb1.Text);
            Nb2 = Convert.ToDouble(Txt_nb2.Text);
            if (x == 1)
            {
                Re = Nb1 + Nb2;
            }
            else if (x == 2)
            {
                Re = Nb1 - Nb2;
            }
            else if (x == 3)
            {
                Re = Nb1 / Nb2;
            }
            else if (x == 4)
            {
                Re = Nb1 * Nb2;
            }
            Txt_res.Text = Nb1.ToString() + " " + y + " " + Nb2 + " = " + Re;
            LblmsgError.Text = " ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((Txt_nb1.Text != "") && (Txt_nb2.Text != ""))
            {
                if (Microsoft.VisualBasic.Information.IsNumeric(this.Txt_nb1.Text) && Microsoft.VisualBasic.Information.IsNumeric(this.Txt_nb2.Text))
                {
                    x = 1;
                    y = '+';
                    some();
                    Txt_res.Text = Re.ToString();
                }
                else
                {
                    LblmsgError.Text = "Zones numérique";
                }
            }
            else if ((Txt_nb1.Text == "") || (Txt_nb2.Text == ""))
            {
                LblmsgError.Text = "Zones obligatoires";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((Txt_nb1.Text != "") && (Txt_nb2.Text != ""))
            {
                if (Microsoft.VisualBasic.Information.IsNumeric(this.Txt_nb1.Text) && Microsoft.VisualBasic.Information.IsNumeric(this.Txt_nb2.Text))
                {
                    x = 2;
                    y = '-';
                    some();
                    Txt_res.Text = Re.ToString();
                }
                else
                {
                    LblmsgError.Text = "Zones numérique";
                }
            }
            else if ((Txt_nb1.Text == "") || (Txt_nb2.Text == ""))
            {
                LblmsgError.Text = "Zones obligatoires";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((Txt_nb1.Text != "") && (Txt_nb2.Text != ""))
            {
                if (Microsoft.VisualBasic.Information.IsNumeric(this.Txt_nb1.Text) && Microsoft.VisualBasic.Information.IsNumeric(this.Txt_nb2.Text))
                {
                    if (Txt_nb2.Text != "0")
                    {
                        x = 3;
                        y = '/';
                        some();
                        Txt_res.Text = Re.ToString();
                    }
                    else
                    {
                        LblmsgError.Text = "Impossible de diviser sur zéro";
                    }
                }
                else
                {
                    LblmsgError.Text = "Zones numérique";
                }
            }
            else if ((Txt_nb1.Text == "") || (Txt_nb2.Text == ""))
            {
                LblmsgError.Text = "Zones obligatoires";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if ((Txt_nb1.Text != "") && (Txt_nb2.Text != ""))
            {
                if (Microsoft.VisualBasic.Information.IsNumeric(this.Txt_nb1.Text) && Microsoft.VisualBasic.Information.IsNumeric(this.Txt_nb2.Text))
                {
                    x = 4;
                    y = '*';
                    some();
                    Txt_res.Text = Re.ToString();
                }
                else
                {
                    LblmsgError.Text = "Zones numérique";
                }
            }
            else if ((Txt_nb1.Text == "") || (Txt_nb2.Text == ""))
            {
                LblmsgError.Text = "Zones obligatoires";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Init_Click(object sender, EventArgs e)
        {
            Txt_nb1.Text = "";
            Txt_nb2.Text = "";
            Txt_res.Text = "";
        }

        private void Btn_Fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
