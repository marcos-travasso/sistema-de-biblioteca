using SistemaBiblioteca;
using SistemaInterface.TelasLivro;
using System;
using System.Windows.Forms;

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
            Configuracoes config = new Configuracoes();
            this.Text = "Sistema " + config.nomeDaBiblioteca;
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
    }
}
