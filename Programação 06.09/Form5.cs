using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using tauaneProj;

namespace Programação_06._09
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        private void UpdateListView()
        {
            listinha.Items.Clear();

            UsuarioDAO usuarioDAO = new UsuarioDAO();
            List<Usuario> usuarios = usuarioDAO.SelectUsuario1();

            foreach (Usuario usuario in usuarios)
            {
                ListViewItem item = new ListViewItem(usuario.Id.ToString());
                item.SubItems.Add(usuario.rua);
                item.SubItems.Add(usuario.Bairro);
                item.SubItems.Add(usuario.Numero);
                listinha.Items.Add(item);
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
                UpdateListView();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario("Rua", "Bairro", "Numero", "CEP");
            usuario.rua = textrua.Text;
            usuario.Bairro = textbairro.Text;
            usuario.Numero = textcasa.Text;


            UsuarioDAO usuarioDAO = new UsuarioDAO();
            textID.Clear();
            usuarioDAO.InsertUsuario1(usuario);
            textcasa.Clear();
            textrua.Clear();
            textbairro.Clear();

            UpdateListView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario("Rua", "Bairro", "Numero", "CEP");
            usuario.Id = int.Parse(textID.Text);
            usuario.rua = textrua.Text;
            usuario.Bairro = textbairro.Text;
            usuario.Numero = textcasa.Text;


            UsuarioDAO usuarioDAO = new UsuarioDAO();
            usuarioDAO.UpdateUsuario1(usuario);
            textbairro.Clear();
            textcasa.Clear();
            textrua.Clear();
            textID.Clear();

            UpdateListView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario("Rua", "Bairro", "Numero", "CEP");
            usuario.Id = int.Parse(textID.Text);

            UsuarioDAO usuarioDAO = new UsuarioDAO();
            usuarioDAO.DeleteUsuario1(usuario.Id);
            textID.Clear();

            UpdateListView();
        }
    }
}
