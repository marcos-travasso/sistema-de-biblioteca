using SistemaBiblioteca;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SistemaInterface.TelasLivro
{
    public partial class TelaPesquisarLivro : Form
    {
        bool admin = false;
        List<Autor> listaAutores = new List<Autor>();
        List<Genero> listaGeneros = new List<Genero>();
        List<Livro> listaLivros = new List<Livro>();
        public TelaPesquisarLivro()
        {
            this.admin = false;
            InitializeComponent();
        }
        public TelaPesquisarLivro(bool admin)
        {
            this.admin = admin;
            InitializeComponent();
        }
        private void tituloLabel_Click(object sender, EventArgs e)
        {

        }
        private void TelaPesquisarLivro_Load(object sender, EventArgs e)
        {
            atualizarListaGeneros();
            atualizarListaAutores();

            BancoLivro banco = new BancoLivro();
            banco.GetLivros(listaLivros);
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
        private void pesquisarBotao_Click(object sender, EventArgs e)
        {
            Livro pesquisa = new Livro();
            pesquisa.Titulo = tituloTexto.Text;

            foreach (Autor autor in listaAutores)
            {
                if (autor.Nome == Convert.ToString(autoresLista.SelectedItem))
                {
                    pesquisa.Autor = autor;
                    break;
                }
            }
            if (pesquisa.Autor == null) { pesquisa.Autor = new Autor(); pesquisa.Autor.Nome = autoresLista.Text; }

            foreach (var generoEscolhido in generoLista.CheckedItems)
            {
                foreach (Genero genero in listaGeneros)
                {
                    if (generoEscolhido.ToString() == genero.Nome)
                    {
                        pesquisa.Generos.Add(genero);
                        break;
                    }
                }
            }

            List<Livro> lista = new List<Livro>();
            lista = PesquisarLivros(pesquisa);

            abrirLista(lista);
        }
        private List<Livro> PesquisarLivros(Livro pesquisa)
        {
            List<Livro> listaDeRetorno;

            if (generoLista.CheckedItems.Count > 0)
            {
                listaDeRetorno = new List<Livro>();

                BancoGenero bancoGenero = new BancoGenero();
                List<Livro> livrosComGeneros = bancoGenero.ProcurarGeneros(pesquisa.Generos);

                BancoLivro bancoLivro = new BancoLivro();
                foreach (Livro livro in livrosComGeneros)
                {
                    bancoLivro.GetLivro(livro);
                    int soma = generoLista.CheckedItems.Count;
                    foreach (Genero genero in livro.Generos)
                    {
                        if (generoLista.CheckedItems.Contains(genero.Nome))
                        {
                            soma--;
                        }
                    }

                    if (soma == 0)
                    {
                        bool tem = false;
                        foreach (Livro livroExistente in listaDeRetorno)
                        {
                            if (livroExistente.idLivro == livro.idLivro)
                            {
                                tem = true;
                            }
                        }
                        if (!tem) { listaDeRetorno.Add(livro); }
                    }
                }

            }
            else
            {
                listaDeRetorno = new List<Livro>(listaLivros);
            }

            List<Livro> livrosAtuais = new List<Livro>(listaDeRetorno);

            if (pesquisa.Titulo != "")
            {
                foreach (Livro livro in livrosAtuais)
                {
                    if (!Regex.IsMatch(livro.Titulo.ToLower(), WildCardToRegular($"{pesquisa.Titulo.ToLower()}*")))
                    {
                        listaDeRetorno.Remove(livro);
                    }
                }
            }

            livrosAtuais = new List<Livro>(listaDeRetorno);
            if (pesquisa.Autor.idAutor == 0)
            {
                foreach (Livro livro in livrosAtuais)
                {
                    if (!Regex.IsMatch(livro.Autor.Nome.ToLower(), WildCardToRegular($"{pesquisa.Autor.Nome.ToLower()}*")))
                    {
                        listaDeRetorno.Remove(livro);
                    }
                }
            }
            else
            {
                foreach (Livro livro in livrosAtuais)
                {
                    if (livro.Autor.idAutor != pesquisa.Autor.idAutor)
                    {
                        listaDeRetorno.Remove(livro);
                    }
                }
            }

            return listaDeRetorno;
        }
        private static String WildCardToRegular(String value)
        {
            return "^" + Regex.Escape(value).Replace("\\*", ".*") + "$";
        }
        private void abrirLista(List<Livro> lista)
        {
            bool isOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "TelaListarLivros")
                {
                    isOpen = true;
                    f.Close();

                    TelaListarLivros janela = new TelaListarLivros(lista, this.admin);
                    janela.Show();
                }
            }

            if (!isOpen)
            {
                TelaListarLivros janela = new TelaListarLivros(lista, this.admin);
                janela.Show();
            }
        }
    }
}
