using SistemaBiblioteca;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaInterface
{
    public partial class TelaCadastroLivro : Form
    {
        public TelaCadastroLivro()
        {
            InitializeComponent();
        }

        private void abrirCadastroAutor()
        {
            bool isOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "TelaCadastroAutor")
                {
                    isOpen = true;
                    f.BringToFront();
                }
            }

            if (!isOpen)
            {
                TelaCadastroAutor janela = new TelaCadastroAutor();
                janela.Show();
            }
        }

        private void abrirCadastroGenero()
        {
            bool isOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "TelaCadastroGenero")
                {
                    isOpen = true;
                    f.BringToFront();
                }
            }

            if (!isOpen)
            {
                TelaCadastroGenero janela = new TelaCadastroGenero();
                janela.Show();
            }
        }

        private void autorAdicionar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            abrirCadastroAutor();
        }

        private void generoAdicionar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            abrirCadastroGenero();
        }

        private void TelaCadastroLivro_Load(object sender, System.EventArgs e)
        {
            atualizarLista();
        }

        private void atualizarLista()
        {
            BancoDeDados banco = new BancoDeDados();
            List<Genero> listaGeneros = new List<Genero>();
            listaGeneros = banco.GetGeneros(listaGeneros);

            generoLista.Items.Clear();

            generoLista.BeginUpdate();

            foreach (Genero genero in listaGeneros)
            {
                generoLista.Items.Add(genero.Nome);
            }

            generoLista.EndUpdate();
        }
        private void TelaCadastroLivro_Activated(object sender, System.EventArgs e)
        {
            atualizarLista();
        }
    }
}
