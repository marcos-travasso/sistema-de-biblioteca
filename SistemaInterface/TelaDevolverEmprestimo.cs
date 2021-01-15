using SistemaBiblioteca;
using System;
using System.Media;
using System.Windows.Forms;

namespace SistemaInterface
{
    public partial class TelaDevolverEmprestimo : Form
    {
        BancoEmprestimo banco = new BancoEmprestimo();
        public TelaDevolverEmprestimo()
        {
            InitializeComponent();
        }
        private void abrirConfirmarDevolucao(Emprestimo emprestimo)
        {
            bool isOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "TelaConfirmarDevolucao")
                {
                    isOpen = true;
                    f.BringToFront();
                }
            }

            if (!isOpen)
            {
                TelaConfirmarDevolucao janela = new TelaConfirmarDevolucao(emprestimo);
                janela.Show();
            }
        }
        private void devolverBotao_Click(object sender, EventArgs e)
        {
            Emprestimo emprestimo = new Emprestimo();
            try
            {
                if (idUsuarioTexto.Text != "")
                {
                    emprestimo.usuario = new Usuario(Convert.ToInt32(idUsuarioTexto.Text));

                    BancoUsuario bancoUsuario = new BancoUsuario();
                    emprestimo.usuario = bancoUsuario.GetUsuario(emprestimo.usuario);

                    if (!banco.TemEmprestado(emprestimo))
                    {
                        SystemSounds.Beep.Play();
                        emprestimo.usuario = null;
                        MessageBox.Show("Esse usuário não tem livro emprestado.", "Erro");
                    }
                }
                else if (idLivroTexto.Text != "")
                {
                    emprestimo.livro = new Livro(Convert.ToInt32(idLivroTexto.Text));

                    BancoLivro bancoLivro = new BancoLivro();
                    emprestimo.livro = bancoLivro.GetLivro(emprestimo.livro);

                    if (!(banco.EstaEmprestado(emprestimo, true).Count != 0))
                    {
                        SystemSounds.Beep.Play();
                        emprestimo.livro = null;
                        MessageBox.Show("Esse livro não está sendo emprestado.", "Erro");
                    }
                }
                else
                {
                    SystemSounds.Beep.Play();
                }
            }
            catch
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Ocorreu um erro ao tentar localizar o usuário/livro.", "Erro");
            }

            if (emprestimo.usuario != null || emprestimo.livro != null)
            {
                emprestimo = banco.GetEmprestimo(emprestimo);
                abrirConfirmarDevolucao(emprestimo);

                emprestimo = null;
                idUsuarioTexto.Text = "";
                idLivroTexto.Text = "";
            }
        }

        private void listaEmprestimosLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (var form = new TelaListarEmprestimos(true))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Emprestimo emprestimo = form.selecionado;
                    idUsuarioTexto.Text = emprestimo.usuario.idUsuario.ToString();
                    idLivroTexto.Text = emprestimo.livro.idLivro.ToString();
                }
            }
        }
    }
}
