﻿using SistemaBiblioteca;
using SistemaInterface.TelasLivro;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Configuration;
using SistemaInterface.TelasSistema;
using System.Drawing;
using System.IO;
using Microsoft.VisualBasic;
using System.Web.Script.Serialization;

namespace SistemaInterface
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
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
        private void usuariosCadastrarBotao1_Click(object sender, EventArgs e)
        {
            bool isOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "TelaCadastroUsuario")
                {
                    isOpen = true;
                    f.BringToFront();
                }
            }

            if (!isOpen)
            {
                TelaCadastroUsuario janela = new TelaCadastroUsuario();
                janela.Show();
            }
        }

        private void usuariosCadastrarBotao2_Click(object sender, EventArgs e)
        {
            bool isOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "TelaCadastroUsuario")
                {
                    isOpen = true;
                    f.BringToFront();
                }
            }

            if (!isOpen)
            {
                TelaCadastroUsuario janela = new TelaCadastroUsuario();
                janela.Show();
            }
        }

        private void livrosCadastrarBotao_Click(object sender, EventArgs e)
        {
            bool isOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "TelaCadastroLivro")
                {
                    isOpen = true;
                    f.BringToFront();
                }
            }

            if (!isOpen)
            {
                TelaCadastroLivro janela = new TelaCadastroLivro();
                janela.Show();
            }
        }

        private void usuariosCadastradosBotao_Click(object sender, EventArgs e)
        {
            bool isOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "TelaListarUsuarios")
                {
                    isOpen = true;
                    f.BringToFront();
                }
            }

            if (!isOpen)
            {
                TelaListarUsuarios janela = new TelaListarUsuarios();
                janela.Show();
            }
        }

        private void usuariosEditarBotao_Click(object sender, EventArgs e)
        {
            if (confirmarSenha())
            {
                bool isOpen = false;

                foreach (Form f in Application.OpenForms)
                {
                    if (f.Name == "TelaListarUsuarios")
                    {
                        isOpen = true;
                        f.BringToFront();
                    }
                }

                if (!isOpen)
                {
                    TelaListarUsuarios janela = new TelaListarUsuarios(true);
                    janela.Show();
                }
            }
        }

        private void livrosCadastradosBotao_Click(object sender, EventArgs e)
        {
            bool isOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "TelaListarLivros")
                {
                    isOpen = true;
                    f.BringToFront();
                }
            }

            if (!isOpen)
            {
                TelaListarLivros janela = new TelaListarLivros();
                janela.Show();
            }
        }

        private void livrosEditarBotao_Click(object sender, EventArgs e)
        {
            if (confirmarSenha())
            {
                bool isOpen = false;

                foreach (Form f in Application.OpenForms)
                {
                    if (f.Name == "TelaListarLivros")
                    {
                        isOpen = true;
                        f.BringToFront();
                    }
                }

                if (!isOpen)
                {
                    TelaListarLivros janela = new TelaListarLivros(true);
                    janela.Show();
                }
            }
        }

        private void novoEmprestimoBotao_Click(object sender, EventArgs e)
        {

            bool isOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "TelaFazerEmprestimo")
                {
                    isOpen = true;
                    f.BringToFront();
                }
            }

            if (!isOpen)
            {
                TelaFazerEmprestimo janela = new TelaFazerEmprestimo();
                janela.Show();
            }
        }

        private void devolutivaBotao_Click(object sender, EventArgs e)
        {
            bool isOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "TelaDevolverEmprestimo")
                {
                    isOpen = true;
                    f.BringToFront();
                }
            }

            if (!isOpen)
            {
                TelaDevolverEmprestimo janela = new TelaDevolverEmprestimo();
                janela.Show();
            }
        }

        private void emprestimosBotao_Click(object sender, EventArgs e)
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
                TelaListarEmprestimos janela = new TelaListarEmprestimos();
                janela.Show();
            }
        }

        private void renovarBotao_Click(object sender, EventArgs e)
        {
            bool isOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "TelaRenovarEmprestimo")
                {
                    isOpen = true;
                    f.BringToFront();
                }
            }

            if (!isOpen)
            {
                TelaRenovarEmprestimo janela = new TelaRenovarEmprestimo();
                janela.Show();
            }
        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {
            this.Text = "Sistema " + ConfigurationManager.AppSettings.Get("Nome");
            verificarBackup();
            carregarNotificacoes();
            atualizarLogo();
        }

        private void verificarBackup()
        {
            if (File.Exists(System.IO.Directory.GetCurrentDirectory() + @"\backupTemp\BancoDeDados.db"))
            {
                File.Delete(System.IO.Directory.GetCurrentDirectory() + @"\BancoDeDados.db");
                File.Move(System.IO.Directory.GetCurrentDirectory() + @"\backupTemp\" + @"\BancoDeDados.db", System.IO.Directory.GetCurrentDirectory() + @"\BancoDeDados.db");
            }
        }

        private void livrosPesquisarBotao_Click(object sender, EventArgs e)
        {
            bool isOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "TelaPesquisarLivro")
                {
                    isOpen = true;
                    f.BringToFront();
                }
            }

            if (!isOpen)
            {
                TelaPesquisarLivro janela = new TelaPesquisarLivro();
                janela.Show();
            }
        }

        private void carregarNotificacoes()
        {
            BancoEmprestimo bancoEmprestimo = new BancoEmprestimo();
            List<Emprestimo> emprestimos = new List<Emprestimo>();
            emprestimos = bancoEmprestimo.GetEmprestimos(emprestimos);

            foreach(Emprestimo emprestimo in emprestimos)
            {
                int atraso = DateTime.Now.Day - Convert.ToDateTime(emprestimo.devolucoes[0].dataDeDevolucao).Day;
                if (atraso > 0)
                {
                    notificacoesListBox.Items.Add($"[ATRASO] {emprestimo.usuario.Nome} | {emprestimo.livro.Titulo}");
                }
            }
        }

        private void configuracoesBotao_Click(object sender, EventArgs e)
        {
            if (confirmarSenha())
            {
                bool isOpen = false;

                foreach (Form f in Application.OpenForms)
                {
                    if (f.Name == "TelaConfiguracoes")
                    {
                        isOpen = true;
                        f.BringToFront();
                    }
                }

                if (!isOpen)
                {
                    TelaConfiguracoes janela = new TelaConfiguracoes();
                    janela.Show();
                }
            }
        }

        private void atualizarLogo()
        {
            string caminho = System.IO.Directory.GetCurrentDirectory();
            if (File.Exists(caminho + @"\novaLogo.png"))
            {
                if (File.Exists(caminho + @"\logo.png"))
                {
                    File.Delete(caminho + @"\logo.png");
                }

                Image imagem = Image.FromFile(caminho + @"\novaLogo.png");
                imagem.Save(caminho + @"\logo.png");
                imagem.Dispose();

                File.Delete(caminho + @"\novaLogo.png");
            }

            if (File.Exists(caminho + @"\logo.png"))
            {
                imagemDaLogo.Image = Image.FromFile(caminho + @"\logo.png");
            }
        }
    }
}
