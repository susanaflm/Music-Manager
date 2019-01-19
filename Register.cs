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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            Form f2 = new Sign_in();
            f2.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form f2 = new Sign_in();
            f2.Show();
        }

        public int user_number = 0;

        //functions through the program
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string firstname = richTextBox1.Text;
            string email = richTextBox2.Text; 
            string password = textBox1.Text;
            string confirm_password = textBox2.Text;
            string username = richTextBox4.Text;
           

            if ((firstname != null) && (email != null) && (username != null) && (password != null))
            {
                //using the class user where setting up an user

                //gets the file
                string meuFicheiro = "C:\\Users\\hp\\Desktop\\App AED - Cenário B\\users.txt";

                //if name
                if (confirm_password == password && valido(username) == true)
                {
                    User utilizador = new User();

                    utilizador.username = username;
                    utilizador.email = email;
                    utilizador.password = password;
                    utilizador.id = user_number+1;


                    if (checkBox1.Checked)
                    {
                        utilizador.perfil = "ADMIN";
                    }
                    if (checkBox2.Checked)
                    {
                        utilizador.perfil = "STANDARD";
                    }

                    StreamWriter sw;
                    if (File.Exists(meuFicheiro))
                    {
                        sw = File.AppendText(meuFicheiro);
                    }
                    else
                    {
                        sw = File.CreateText(meuFicheiro);
                    }
                    string linha = utilizador.id + ";" + utilizador.username + ";" + utilizador.email + ";" + utilizador.password + ";" + utilizador.perfil;
                    sw.WriteLine(linha);
                    sw.Close();
                    System.Windows.Forms.MessageBox.Show("Conta criada com sucesso!!");

                    //depois de criar conta com sucesso abre-se o novo form
                    if (checkBox1.Checked)
                    {
                        Form f5 = new Admin_signed_in();
                        f5.Show();
                        Form f6 = new signed_in_page();
                        f6.Hide();
                    }
                    if (checkBox2.Checked)
                    {
                        Form f6 = new signed_in_page();
                        f6.Show();
                        Form f5 = new Admin_signed_in();
                        f5.Hide();
                    }
                    //se nenhuma das checkboxes for escolhida o programa manda uma mensagem de aviso, ! nega a condição à frente
                    if((!checkBox1.Checked) && (!checkBox2.Checked))
                    {
                        System.Windows.Forms.MessageBox.Show("Não selecionou nenhum perfil!");
                    }
                    //checkbox is a bool if they are both true then:
                    if ((checkBox1.Checked) && (checkBox2.Checked))
                    {
                        System.Windows.Forms.MessageBox.Show("Não pode selecionar ambos perfis!");
                    }
                }
                else
                {
                    if (password != confirm_password)
                    {
                        System.Windows.Forms.MessageBox.Show("Erro: Passwords não coincidem!");

                    }
                    if (valido(username) == false)
                    {
                        System.Windows.Forms.MessageBox.Show("Erro: Nome do utilizador já existe!");
                    }
                }
                //Form f4 = new signed_in_page();
                //f4.Show();
            }

            else
            {
                MessageBox.Show("Preencha todos os campos");
            }

           

            
        }
        public bool valido(string nome)
        {
            //variavel contadora das linhas do txt aka dos utilizadores do site
            int count = 0;
            string meuFicheiro = "C:\\Users\\hp\\Desktop\\App AED - Cenário B\\users.txt";
            StreamReader sr;
            if (File.Exists(meuFicheiro))
            {
                sr = File.OpenText(meuFicheiro);
                string linha;
               
                while ((linha = sr.ReadLine()) != null)
                {
                    string[] campo = linha.Split(';');
                    if (campo[1] == nome)
                    {
                        return false;
                    }
                    count++;
                }
                sr.Close();
            }
            user_number = count;
            return true;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
