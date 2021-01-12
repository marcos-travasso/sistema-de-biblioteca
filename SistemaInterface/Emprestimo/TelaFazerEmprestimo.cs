using SistemaBiblioteca;
using System;
using System.Collections.Generic;
using System.Media;
using System.Windows.Forms;

namespace SistemaInterface
{
    public partial class TelaFazerEmprestimo : Form
    {
        public TelaFazerEmprestimo()
        {
            InitializeComponent();
        }
        private void abrirConfirmarEmprestimo(Emprestimo emprestimo)
        {
            bool isOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "TelaConfirmarEmprestimo")
                {
                    isOpen = true;
                    f.BringToFront();
                }
            }

            if (!isOpen)
            {
                TelaConfirmarEmprestimo janela = new TelaConfirmarEmprestimo(emprestimo);
                janela.Show();
            }
        }

        private void listaUsuariosLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (var form = new TelaListarUsuarios(true, ""))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Usuario usuarioSelecionado = form.selecionado;
                    idUsuarioTexto.Text = usuarioSelecionado.idUsuario.ToString();
                }
            }
        }

        private void listaLivrosLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (var form = new TelaListarLivros(true, ""))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Livro livroSelecionado = form.selecionado;
                    idLivroTexto.Text = livroSelecionado.idLivro.ToString();
                }
            }
        }

        private void emprestarBotao_Click(object sender, EventArgs e)
        {
            if (idUsuarioTexto.Text != "" && idLivroTexto.Text != "")
            {
                var diferenca = Math.Ceiling((devolucaoData.Value - DateTime.Now).TotalDays);
                if (diferenca >= 1)
                {
                    try
                    {
                        Emprestimo emprestimo = new Emprestimo();
                        emprestimo.dataDoPedido = DateTime.Now;

                        Livro livro = new Livro(Convert.ToInt32(idLivroTexto.Text));
                        BancoLivro bancoLivro = new BancoLivro();
                        livro = bancoLivro.GetLivro(livro);
                        emprestimo.livro = livro;

                        Usuario usuario = new Usuario(Convert.ToInt32(idUsuarioTexto.Text));
                        BancoUsuario bancoUsuario = new BancoUsuario();
                        usuario = bancoUsuario.GetUsuario(usuario);
                        emprestimo.usuario = usuario;

                        Devolucao devolucao = new Devolucao();
                        devolucao.dataDeDevolucao = devolucaoData.Value;
                        devolucao.emprestimo = emprestimo;
                        emprestimo.devolucoes.Add(devolucao);

                        BancoEmprestimo banco = new BancoEmprestimo();
                        List<string> livroEmprestado = banco.EstaEmprestado(emprestimo);

                        if (!banco.TemEmprestado(emprestimo))
                        {
                            if (livroEmprestado.Count.Equals(0))
                            {
                                abrirConfirmarEmprestimo(emprestimo);
                            }
                            else
                            {
                                SystemSounds.Beep.Play();
                                MessageBox.Show("O livro já está sendo emprestado. Previsão de entrega é de " + livroEmprestado[0] + " dia(s) (" + livroEmprestado[1] + ")", "Erro");
                            }
                        }
                        else
                        {
                            SystemSounds.Beep.Play();
                            MessageBox.Show("O usuário já está com um livro emprestado.", "Erro");
                        }
                        //TODO clicar na grid e preencher o ID
                    }
                    catch
                    {
                        SystemSounds.Beep.Play();
                        MessageBox.Show("Não foi possível emprestar o livro.", "Erro");
                    }
                }
                else
                {
                    SystemSounds.Beep.Play();
                    MessageBox.Show("O empréstimo deve ser de no mínimo um dia.", "Erro");
                    devolucaoData.Focus();
                }
            }
            else
            {
                SystemSounds.Beep.Play();
            }
        }

        private void TelaFazerEmprestimo_Load(object sender, EventArgs e)
        {
            devolucaoData.Value = devolucaoData.Value.AddDays(14);
        }
    }
}
