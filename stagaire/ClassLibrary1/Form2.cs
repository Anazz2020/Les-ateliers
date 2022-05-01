using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Nom");
            listBox1.Items.Add("Prenom");
            listBox1.Items.Add("CNE");
            listBox1.Items.Add("CIF");
            listBox1.Items.Add("Adress");
            listBox1.Items.Add("ville");
            listBox1.Items.Add("code");
            listBox1.Items.Add("telephone");
            listBox1.Items.Add("Age");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            if (i<0)
            {
                MessageBox.Show("Choisir un element dans la liste 1");
            }
            else
            {
                string v = listBox1.Items[i].ToString();
                listBox2.Items.Add(v);
                listBox1.Items.RemoveAt(i);
            }
        }
    }
}
