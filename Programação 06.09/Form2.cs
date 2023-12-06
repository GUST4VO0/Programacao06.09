using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using tauaneProj;

namespace Programação_06._09
{
    public partial class Form2 : Form
    {
        private int Id;
        public Form2()
        {
            InitializeComponent();
        }
        private void UpdateListView()
        {
            listinha.Items.Clear();

            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT * FROM Tabela2";

            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();

                while (dr.Read())
                {
                    int ID = (int)dr["ID"];
                    string Nome = (string)dr["Nome"];
                    string Email = (string)dr["Email"];
                    string Senha = (string)dr["Senha"];
                    string CPF = (string)dr["CPF"];

                    ListViewItem lv = new ListViewItem(ID.ToString());

                    lv.SubItems.Add(Nome);
                    lv.SubItems.Add(Email);
                    lv.SubItems.Add(Senha);
                    lv.SubItems.Add(CPF);
                    listinha.Items.Add(lv);

                }
                dr.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                conn.CloseConnection();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            UpdateListView();
        }

        private void textsenha_TextChanged_1(object sender, EventArgs e)
        {
            if (textsenha.Text.Length > 11)
            {
                textsenha.Text = textsenha.Text.Substring(0, 11);
                textsenha.SelectionStart = textsenha.Text.Length;
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
        private bool ValidarCPF(string cpf)
        {
            int[] multiplicador1 = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            cpf = cpf.Trim().Replace(".", "").Replace("-", "");

            if (cpf.Length != 11)
                return false;

            string tempCpf = cpf.Substring(0, 9);
            int soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            int resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            string digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cpf.EndsWith(digito);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cpf = textcpf.Text;

            if (cpf.Length != 11)
            {
                MessageBox.Show("CPF inválido.");
                return;
            }

            if (!ValidarCPF(cpf))
            {
                MessageBox.Show("CPF inválido.");
                return;
            }

            MessageBox.Show("CPF válido.");
            Usuario usuario = new Usuario("Nome", "Email", "Telefone", "Senha");
            usuario.Id = int.Parse(textID.Text);
            usuario.Nome = textnome.Text;
            usuario.Email = textemail.Text;
            usuario.CPF = textcpf.Text;
            usuario.senha = Criptografia.CriptografarSenha(textsenha.Text);

            UsuarioDAO usuarioDAO = new UsuarioDAO();
            usuarioDAO.UpdateUsuario(usuario);
            textnome.Clear();
            textID.Clear();
            textemail.Clear();
            textcpf.Clear();
            textsenha.Clear();

            UpdateListView();
        }
        
        

        private void button2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textID.Text);
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            usuarioDAO.DeletUsuario(id);
            textnome.Clear();
            textID.Clear();
            textemail.Clear();
            textcpf.Clear();
            textsenha.Clear();

            UpdateListView();
        }

        private void listinha_DoubleClick(object sender, EventArgs e)
        {
            int index;

            index = listinha.FocusedItem.Index;

            textID.Text = listinha.Items[index].SubItems[0].Text;

            textnome.Text = listinha.Items[index].SubItems[1].Text;

            textemail.Text = listinha.Items[index].SubItems[2].Text;

            textsenha.Text = listinha.Items[index].SubItems[3].Text;

            textcpf.Text = listinha.Items[index].SubItems[4].Text;
        }
    }
}
