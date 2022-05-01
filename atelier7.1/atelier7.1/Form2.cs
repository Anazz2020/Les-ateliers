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
    public partial class Form2 : Form
    {
        double val1, val2;
        double TotalCrédit = 0;
        double TotalDébit = 0;
        
        public Form2()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            val1 = double.Parse(textBoxMontant.Text);
            if (radioButton1.Checked == true)
            {
                    listBox1.Items.Add(val1);
                    listBox2.Items.Add(0);
                    TotalCrédit = TotalCrédit + val1;
                    label7.Text = TotalCrédit.ToString();
                   Balance.Text = (TotalCrédit - TotalDébit).ToString();
                

            }
            if (radioButton2.Checked == true)
            {


                listBox2.Items.Add(val1);
                listBox1.Items.Add(0);
                TotalDébit = TotalDébit + val1 ;
                label8.Text = TotalDébit.ToString();
                Balance.Text = (TotalCrédit - TotalDébit).ToString();


            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            val1 = Convert.ToDouble(listBox1.Items[listBox1.Items.Count - 1]);
            val2 = Convert.ToDouble(listBox2.Items[listBox2.Items.Count - 1]);
            listBox1.Items.RemoveAt(listBox1.Items.Count - 1);
            listBox2.Items.RemoveAt(listBox2.Items.Count - 1);
            TotalCrédit = TotalCrédit - val1;
            TotalDébit = TotalDébit - val2;
            label8.Text = TotalCrédit.ToString();
            TotalDebut.Text = TotalDebut.ToString();
            Balance.Text = (TotalCrédit - TotalDébit).ToString();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if ((radioButton1.Checked == true) || (radioButton2.Checked == true))
            {
                button1.Enabled = true;

            }
            else
            {
                button1.Enabled = false;

            }
        }

        private void totaleCredit_TextChanged(object sender, EventArgs e)
        {
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if ((radioButton1.Checked == true) || (radioButton2.Checked == true))
            {
                button1.Enabled = true;

            }
            else
            {
                button1.Enabled = false;

            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
                
        }
    }
}
