using SistemaBiblioteca;
using System;
using System.Collections.Generic;
using System.Media;
using System.Windows.Forms;

namespace SistemaInterface
{
    public partial class TelaCadastroLivro : Form
    {
        List<Autor> listaAutores = new List<Autor>();
        List<Genero> listaGeneros = new List<Genero>();
        public TelaCadastroLivro()
        {
            InitializeComponent();
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
        private void abrirEditarAutor()
        {
            bool isOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "TelaListarAutor")
                {
                    isOpen = true;
                    f.BringToFront();
                }
            }

            if (!isOpen)
            {
                TelaListarAutores janela = new TelaListarAutores();
                janela.Show();
            }
        }

        private void generoAdicionar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            abrirCadastroGenero();
        }

        private void TelaCadastroLivro_Load(object sender, System.EventArgs e)
        {
            atualizarListaGeneros();
            atualizarListaAutores();
        }

        private void atualizarListaGeneros()
        {
            BancoGenero banco = new BancoGenero();
            listaGeneros.Clear();
            listaGeneros = banco.GetGeneros(listaGeneros);

            generoLista.Items.Clear();

            generoLista.BeginUpdate();

            foreach (Genero genero in listaGeneros)
            {
                generoLista.Items.Add(genero.Nome);
            }

            generoLista.EndUpdate();
        }
        private void atualizarListaAutores()
        {
            BancoAutor banco = new BancoAutor();
            listaAutores.Clear();
            listaAutores = banco.GetAutores(listaAutores);

            autoresLista.Items.Clear();

            autoresLista.BeginUpdate();

            foreach (Autor autor in listaAutores)
            {
                autoresLista.Items.Add(autor.Nome);
            }

            autoresLista.EndUpdate();
        }
        private void TelaCadastroLivro_Activated(object sender, System.EventArgs e)
        {
            atualizarListaGeneros();
        }

        private void cadastrarBotao_Click(object sender, System.EventArgs e)
        {
            if (tituloTexto.Text != "")
            {
                Livro livro = new Livro();
                livro.Titulo = tituloTexto.Text;

                try
                {
                    if (anoTexto.Text != "") { livro.Ano = Convert.ToInt32(anoTexto.Text); } else { livro.Ano = 0; }
                    if (paginasTexto.Text != "") { livro.Paginas = Convert.ToInt32(paginasTexto.Text); } else { livro.Paginas = 1; }
                }
                catch
                {
                    SystemSounds.Beep.Play();
                    MessageBox.Show("Algum dado foi inserido incorretamente.", "Erro");
                }

                foreach (Autor autor in listaAutores)
                {
                    if (autor.Nome == Convert.ToString(autoresLista.SelectedItem))
                    {
                        livro.Autor = autor;
                        break;
                    }
                }
                if (livro.Autor == null)
                {
                    try
                    {
                        Autor novoAutor = new Autor(Convert.ToString(autoresLista.Text));

                        BancoAutor bancoAutor = new BancoAutor();
                        bancoAutor.CriarAutor(novoAutor);

                        livro.Autor = bancoAutor.GetAutor(novoAutor);
                    }
                    catch
                    {
                        SystemSounds.Beep.Play();
                        MessageBox.Show("Não foi possível cadastrar o autor", "Erro");
                    }
                }

                foreach (var generoEscolhido in generoLista.CheckedItems)
                {
                    foreach (Genero genero in listaGeneros)
                    {
                        if (generoEscolhido.ToString() == genero.Nome)
                        {
                            livro.Generos.Add(genero);
                            break;
                        }
                    }
                }

                BancoLivro banco = new BancoLivro();

                try
                {
                    banco.CriarLivro(livro);

                    concluirCadastro();
                }
                catch
                {
                    SystemSounds.Beep.Play();
                    MessageBox.Show("Não foi possível cadastrar o livro.", "Erro");
                }


            }
            else
            {
                SystemSounds.Beep.Play();
                tituloTexto.Focus();
            }
        }
        private void concluirCadastro()
        {
            tituloTexto.Text = "";
            anoTexto.Text = "";
            paginasTexto.Text = "";

            autoresLista.SelectedIndex = -1;

            while (generoLista.CheckedIndices.Count > 0)
            {
                generoLista.SetItemChecked(generoLista.CheckedIndices[0], false);
            }

            MessageBox.Show("Cadastro concluído com sucesso.", "Sucesso");
        }

        private void autorEditar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            abrirEditarAutor();
        }
    }
}
