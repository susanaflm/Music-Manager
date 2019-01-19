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
    public partial class signed_in_page : Form
    {
        public signed_in_page()
        {
            InitializeComponent();
        }
        public static string source_path = "C:\\Users\\hp\\Desktop\\App AED - Cenário B\\";

        private void Onload2()
        {
            string tags = source_path + "tags.txt";

            if (File.Exists(tags))
            {
                StreamReader sr = File.OpenText(tags);
                string linha = "";
                while ((linha = sr.ReadLine()) != null)
                {
                    string[] tag = linha.Split(';');
                    listBox1.Items.Add(tag[1]);

                }
                sr.Close();
            }
            else
            {
                MessageBox.Show("Erro a abrir ficheiro");
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
