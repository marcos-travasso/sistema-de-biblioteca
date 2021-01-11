using SistemaBiblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaInterface
{
    public partial class TelaInformacoesLivro : Form
    {
        bool admin = false;
        Livro livro;
        List<Autor> listaAutores = new List<Autor>();
        List<Genero> listaGeneros = new List<Genero>();
        public TelaInformacoesLivro()
        {
            InitializeComponent();
        }

        public TelaInformacoesLivro(Livro livro)
        {
            this.livro = livro;
            InitializeComponent();
        }

        public TelaInformacoesLivro(bool admin, Livro livro)
        {
            this.livro = livro;
            this.admin = admin;
            InitializeComponent();
        }

        private void TelaInformacoesLivro_Load(object sender, EventArgs e)
        {
            alterarCaixas();
            setarDados();
        }
        private void alterarCaixas()
        {
            tituloTexto.ReadOnly = !this.admin;
            anoTexto.ReadOnly = !this.admin;
            autoresLista.Enabled = this.admin;
            paginasTexto.ReadOnly = !this.admin;
            generoLista.Enabled = this.admin;

            editarBotao.Enabled = this.admin;
            excluirBotao.Enabled = this.admin;
        }
        private void setarDados()
        {
            idLabel.Text = "Livro número: " + Convert.ToString(livro.idLivro);
            this.Text = "Informações do livro " + Convert.ToString(livro.idLivro);

            tituloTexto.Text = livro.Titulo;
            anoTexto.Text = Convert.ToString(livro.Ano);
            paginasTexto.Text = Convert.ToString(livro.Paginas);

            atualizarListaAutores();
            autoresLista.SelectedIndex = autoresLista.FindString(livro.getAutor());

            if (!admin)
            {
                generoLista.Items.Clear();

                generoLista.BeginUpdate();

                foreach (Genero genero in livro.Generos)
                {
                    generoLista.Items.Add(genero.Nome);
                    generoLista.SetItemChecked(generoLista.Items.IndexOf(genero.Nome), true);
                }

                generoLista.EndUpdate();
            } else
            {
                atualizarListaGeneros();
            }

        }
        private void atualizarListaAutores()
        {
            BancoDeDados banco = new BancoDeDados();

            listaAutores.Clear();
            listaAutores = banco.GetAutores(listaAutores);

            autoresLista.Items.Clear();

            autoresLista.BeginUpdate();

            autoresLista.Items.Add("Desconhecido");

            foreach (Autor autor in listaAutores)
            {
                autoresLista.Items.Add(autor.Nome);
            }

            autoresLista.EndUpdate();
        }
        private void atualizarListaGeneros()
        {
            BancoDeDados banco = new BancoDeDados();

            listaGeneros.Clear();
            listaGeneros = banco.GetGeneros(listaGeneros);

            generoLista.Items.Clear();

            generoLista.BeginUpdate();

            foreach (Genero genero in listaGeneros)
            {
                generoLista.Items.Add(genero.Nome);
            }

            foreach (Genero genero in livro.Generos)
            {
                generoLista.SetItemChecked(generoLista.Items.IndexOf(genero.Nome), true);
            }

            generoLista.EndUpdate();
        }
        private void concluirEdicao()
        {
            MessageBox.Show("Livro editado com sucesso", "Sucesso");
            this.Close();
        }
        private void editarBotao_Click(object sender, EventArgs e)
        {
            if (tituloTexto.Text != "")
            {
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

                livro.Generos.Clear();
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

                BancoDeDados banco = new BancoDeDados();

                try
                {
                    banco.EditarLivro(livro);

                    concluirEdicao();
                }
                catch
                {
                    SystemSounds.Beep.Play();
                    MessageBox.Show("Não foi possível editar o livro.", "Erro");
                }
            } else
            {
                SystemSounds.Beep.Play();
                tituloTexto.Focus();
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

        private void TelaInformacoesLivro_Activated(object sender, EventArgs e)
        {
            if (admin)
            {
                atualizarListaGeneros();
                atualizarListaAutores();
            }
        }
    }
}
