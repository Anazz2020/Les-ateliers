using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atelier7._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
             listBox2.Items.Clear(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            for (int i = 0; i < listBox1.Items.Count; i++)
            { 
                listBox2.Items.Add(listBox1.Items[i].ToString());
            }
            listBox1.Items.Clear();
            button1.Enabled = false;
            button3.Enabled = false;
            button2.Enabled = true;
            button4.Enabled = true;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1) {
            listBox2.Items.Add(listBox1.SelectedItem);
            }
            else
            {
                MessageBox.Show("Selected");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                for (int i = 0; i < listBox2.Items.Count; i++)
                {
                    listBox1.Items.Add(listBox2.Items[i].ToString());
                }
                listBox2.Items.Clear();
                button2.Enabled = false;
                button4.Enabled = false;
                button1.Enabled = true;
                button3.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Add("Code");
            listBox1.Items.Add("CIN");
            listBox1.Items.Add("Nom");
            listBox1.Items.Add("Prénom");
            listBox1.Items.Add("Adresse");
            listBox1.Items.Add("Fax");
            listBox1.Items.Add("Télephone");
            listBox1.Items.Add("Portable");
            listBox1.Items.Add("Ville");
    }
    }
    
}
