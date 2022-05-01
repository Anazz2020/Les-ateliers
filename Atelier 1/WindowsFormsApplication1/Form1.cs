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
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Atelier_1.exercices a = new Atelier_1.exercices();
            a.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Atelier_2.Form1 a = new Atelier_2.Form1();
            a.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Ateleier3.Form1 a = new Ateleier3.Form1();
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ateleier4.Form1 a = new Ateleier4.Form1();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ateleier5.Form1 a = new Ateleier5.Form1();
            a.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormCalcule.Form1 a = new FormCalcule.Form1();
            a.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
