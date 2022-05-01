using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Les_ateleirs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Atelier_2.Form1 a = new Atelier_2.Form1();
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Atelier_1.exercices a = new Atelier_1.exercices();
            a.Show();
        }
    }
}
