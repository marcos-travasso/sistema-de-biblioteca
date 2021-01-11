using SistemaBiblioteca;
using System;
using System.Media;
using System.Windows.Forms;

namespace SistemaInterface
{
    public partial class TelaCadastroAutor : Form
    {
        public TelaCadastroAutor()
        {
            InitializeComponent();
        }

        private void cadastrarBotao_Click(object sender, System.EventArgs e)
        {
            if (nomeTexto.Text != "")
            {
                Autor autor = new Autor();
                autor.Nome = autor.converterNome(nomeTexto.Text);

                if (generoTexto.Text == "Masculino") { autor.Genero = "M"; }
                else if (generoTexto.Text == "Feminino") { autor.Genero = "F"; }
                else { autor.Genero = "O"; }

                try { autor.Nascimento = Convert.ToDateTime(nascimentoTexto.Text); }
                catch { SystemSounds.Beep.Play(); MessageBox.Show("A data de nascimento está incorreta.", "Erro"); nascimentoTexto.Focus(); }

                BancoAutor banco = new BancoAutor();

                try
                {
                    banco.CriarAutor(autor);

                    nomeTexto.Text = "";
                    nascimentoTexto.Text = "";
                    generoTexto.Text = "";

                    MessageBox.Show("Autor cadastrado com sucesso", "Sucesso");
                    this.Close();

                }
                catch
                {
                    SystemSounds.Beep.Play();
                    MessageBox.Show("Não foi possível cadastrar o autor.", "Erro");
                }
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
        private void autorEditar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            abrirEditarAutor();
        }
    }
}
