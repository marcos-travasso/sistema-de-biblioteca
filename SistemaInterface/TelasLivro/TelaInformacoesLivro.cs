﻿using SistemaBiblioteca;
using System;
using System.Collections.Generic;
using System.Media;
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
            }
            else
            {
                atualizarListaGeneros();
            }

        }
        private void atualizarListaAutores()
        {
            BancoAutor banco = new BancoAutor();

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
            BancoGenero banco = new BancoGenero();

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
                if (livro.Autor.Nome == "")
                {
                    try
                    {
                        Autor novoAutor = new Autor(Convert.ToString(autoresLista.Text), "O", "01/01/0001");

                        BancoAutor bancoAutor = new BancoAutor();
                        bancoAutor.CriarAutor(novoAutor);

                        livro.Autor = bancoAutor.GetAutor(novoAutor);
                    }
                    catch
                    {
                        SystemSounds.Beep.Play();
                        MessageBox.Show("Não foi possível editar o autor", "Erro");
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

                BancoLivro banco = new BancoLivro();

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
            }
            else
            {
                SystemSounds.Beep.Play();
                tituloTexto.Focus();
            }
        }
        private void generoAdicionar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            abrirCadastroGenero();
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
                if (f.Name == "TelaListarAutores")
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

        private void TelaInformacoesLivro_Activated(object sender, EventArgs e)
        {
            if (admin)
            {
                atualizarListaGeneros();
                atualizarListaAutores();
            }
        }

        private void excluirBotao_Click(object sender, EventArgs e)
        {
            if (confirmarSenha())
            {
                try
                {
                    BancoLivro banco = new BancoLivro();
                    banco.ExcluirLivro(livro);

                    MessageBox.Show("Livro excluído com sucesso", "Sucesso");
                }
                catch
                {
                    SystemSounds.Beep.Play();
                    MessageBox.Show("Não foi possível excluir o livro.", "Erro");
                }
            }
        }
        private bool confirmarSenha()
        {
            using (var form = new TelaConfirmarSenha())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    if (form.confirmacao)
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        private void autorEditar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            abrirEditarAutor();
        }

        private void historicoBotao_Click(object sender, EventArgs e)
        {
            bool isOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "TelaListarEmprestimos")
                {
                    isOpen = true;
                    f.BringToFront();
                }
            }

            if (!isOpen)
            {
                TelaListarEmprestimos janela = new TelaListarEmprestimos(livro);
                janela.Show();
            }
        }
    }
}
