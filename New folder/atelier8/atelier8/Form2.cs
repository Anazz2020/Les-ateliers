using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atelier8
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btncommander_Click(object sender, EventArgs e)
        {
            DialogResult m = MessageBox.Show("valider ", "confermation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (m == DialogResult.Yes)
            {
            this.Height = 670;
            listBox1.Items.Add(checkedListBox1.SelectedItem.ToString());
                listBox1.Items.Add(checkedListBox2.SelectedItem.ToString());
            listBox1.Items.Add(checkedListBox3.SelectedItem.ToString());
            listBox1.Items.Add(checkedListBox4.SelectedItem.ToString());
            }
          
        }

        private void btninit_Click(object sender, EventArgs e)
        {
            this.Height = 430;
            listBox1.Items.Clear();
            checkedListBox1.Items.Clear();
            checkedListBox2.Items.Clear();
            checkedListBox3.Items.Clear();
            checkedListBox4.Items.Clear();
        }
    }
}
