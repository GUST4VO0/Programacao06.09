using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using tauaneProj;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Programação_06._09
{
    public partial class Form1 : Form
    {
        private int Id;

        public Form1()
        {
            InitializeComponent();

        }

        private void UpdateListView()
        {
            listinha.Items.Clear();

            UsuarioDAO usuarioDAO = new UsuarioDAO();
            List<Usuario> usuarios = usuarioDAO.SelectUsuario();

            foreach (Usuario usuario in usuarios)
            {
                ListViewItem item = new ListViewItem(usuario.Id.ToString());
                item.SubItems.Add(usuario.Nome);
                item.SubItems.Add(usuario.Email);
                item.SubItems.Add(usuario.CPF);
                item.SubItems.Add(usuario.senha);
                listinha.Items.Add(item);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateListView();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                try
                {
                    
                    string cpf = textcpf.Text;
                    if (new CPFValidator().IsValid(cpf))
                    {
                        MessageBox.Show("CPF válido!");


                        Usuario usuario = new Usuario("nome", "email", "senha","cpf");
                        usuario.Nome = textnome.Text;
                        usuario.Email = textemail.Text;
                        usuario.senha = Criptografia.CriptografarSenha(textsenha.Text);
                        usuario.CPF = textcpf.Text;

                        UsuarioDAO usuarioDao = new UsuarioDAO();
                        usuarioDao.InsertUsuario(usuario);

                        textnome.Clear();
                        textcpf.Clear();
                        textsenha.Clear();
                        textemail.Clear();

                        UpdateListView();
                    }
                    else
                    {
                        MessageBox.Show("CPF inválido");

                    }
                }

                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            else
            {
                MessageBox.Show("Aceite os termos e condições");
            }

        }
        private void textsenha_TextChanged(object sender, EventArgs e)
        {

            int maxLength = 8;
            if (textsenha.Text.Length > maxLength)
            {
                MessageBox.Show("Você atingiu o limite de caracteres permitidos.");
            }
        }
        private void textcpf_TextChanged(object sender, EventArgs e)
        {
            if (textcpf.Text.Length > 11)
            {
                textcpf.Text = textcpf.Text.Substring(0, 11);
                textcpf.SelectionStart = textcpf.Text.Length;
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            {
                Form2 form2 = new Form2();
                form2.Show();
            }

        }

        private void listinha_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void listinha_DoubleClick(object sender, EventArgs e)
        {
            int index;

            index = listinha.FocusedItem.Index;

            Id = int.Parse(listinha.Items[index].SubItems[0].Text);

            textnome.Text = listinha.Items[index].SubItems[1].Text;

            textemail.Text = listinha.Items[index].SubItems[2].Text;

            textsenha.Text = listinha.Items[index].SubItems[3].Text;

            textcpf.Text = listinha.Items[index].SubItems[4].Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}



