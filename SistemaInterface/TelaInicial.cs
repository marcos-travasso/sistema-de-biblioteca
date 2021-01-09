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

        private void abrirCadastroUsuario()
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

        private void abrirCadastroLivro()
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

        private void abrirListarUsuarios()
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
        private void abrirEditarUsuarios()
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

        private void usuariosCadastrarBotao1_Click(object sender, EventArgs e)
        {
            abrirCadastroUsuario();
        }

        private void usuariosCadastrarBotao2_Click(object sender, EventArgs e)
        {
            abrirCadastroUsuario();
        }

        private void livrosCadastrarBotao_Click(object sender, EventArgs e)
        {
            abrirCadastroLivro();
        }

        private void usuariosCadastradosBotao_Click(object sender, EventArgs e)
        {
            abrirListarUsuarios();
        }

        private void usuariosEditarBotao_Click(object sender, EventArgs e)
        {
            abrirEditarUsuarios();
        }
    }
}
