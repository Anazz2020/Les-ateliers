using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Atelier_1
{
    public partial class exercices : Form
    {
        public exercices()
        {
            InitializeComponent();
        }

        private void exercices_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ex2 g = new ex2();
            g.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ex1 a = new ex1();
            a.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ex3 a = new ex3();
            a.Show();
        }
    }
}
