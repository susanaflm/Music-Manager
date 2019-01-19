using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Cenário_B
{
    public partial class Sign_in : Form
    {
        public Sign_in()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form f3 = new Register();
            f3.Show();
        }
        public bool valido(string nome)
        {
            string meuFicheiro = @"C:\\Users\\hp\\Desktop\\App AED - Cenário B\\users.txt";
            StreamReader sr;
            if (File.Exists(meuFicheiro))
            {
                sr = File.OpenText(meuFicheiro);
                string linha;
                while ((linha = sr.ReadLine()) != null)
                {
                    string[] campo = linha.Split(';');
                    if (campo[0] == nome)
                    {
                        return false;
                    }

                }
                sr.Close();
            }
            return true;
        }

            private void pictureBox2_Click(object sender, EventArgs e)
            {
            if (richTextBox1.Text == textBox1.Text && valido(richTextBox1.Text) == true) 
            {
                Form f4 = new signed_in_page();
                f4.Show();
            }
            else
            {
                MessageBox.Show("O utilizador não existe");
            }
           
            }
    }
}
