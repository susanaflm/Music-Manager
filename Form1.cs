﻿using System;
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
    public partial class Pagina_inicial : Form
    {
        public Pagina_inicial()
        {
            InitializeComponent();
            onLoad();
        }

        //public static source path string for easy acess
        public static string source_path = "C:\\Users\\hp\\Desktop\\App AED - Cenário B\\"; 

        private void onLoad()
        {
            //this gets the file txt and connects the variable tags to it
            string tags = source_path + "tags.txt";
            //if the file exists you open it
            if (File.Exists(tags))
            {
                //read its contents using file.opentext
                StreamReader sr = File.OpenText(tags);
                //create a string called line represent each line of the file txt
                string linha = "";
                //while the line is being read and isn't null (doesn't exist) the program reads it
                while ((linha = sr.ReadLine()) != null)
                {
                    //the [] its so it only reads after the ;
                    string[] tag = linha.Split(';');
                    //tag[1] so it shows the word on position one and not the ID on the position 0
                    listBox1.Items.Add(tag[1]);
                }
                //closes the stream reader
                sr.Close();
            }
            //if it doesnt open well :(
            else
            {
                //to show a warning to the user
                MessageBox.Show("Erro a abrir ficheiro");
            }
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTag = listBox1.SelectedItem.ToString();
        }

        private void sign_in_Click(object sender, EventArgs e)
        {
            Form f2 = new Sign_in();
            f2.Show();
        }
    }
}
