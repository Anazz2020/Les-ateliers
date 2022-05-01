using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atelier_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_cnx_Click(object sender, EventArgs e)
        {
           
            if ( Convert.ToBoolean(textBoxMot.Text == textBoxNm.Text))
            {

            Form2 frm = new Form2();
            frm.Show();
        }
            else
            {
                textError.Text = "Le nom d’utilisateur ou le mot de passe que vous avez saisie sont incorrects";
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textError_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
