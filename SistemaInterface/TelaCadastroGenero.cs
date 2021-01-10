using SistemaBiblioteca;
using System.Media;
using System.Windows.Forms;

namespace SistemaInterface
{
    public partial class TelaCadastroGenero : Form
    {
        public TelaCadastroGenero()
        {
            InitializeComponent();
        }

        private void abrirEditarGenero()
        {
            bool isOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "TelaListarGeneros")
                {
                    isOpen = true;
                    f.BringToFront();
                }
            }

            if (!isOpen)
            {
                TelaListarGeneros janela = new TelaListarGeneros();
                janela.Show();
            }
        }
        private void generoEditar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            abrirEditarGenero();
        }

        private void cadastrarBotao_Click(object sender, System.EventArgs e)
        {
            if (generoTexto.Text != "")
            {
                try
                {
                    BancoDeDados banco = new BancoDeDados();
                    Genero genero = new Genero(generoTexto.Text);

                    banco.CriarGenero(genero);

                    MessageBox.Show("Gênero cadastrado com sucesso.", "Sucesso");
                    generoTexto.Text = "";
                }
                catch
                {
                    SystemSounds.Beep.Play();
                    MessageBox.Show("Não foi possível cadastrar o gênero.", "Erro");
                }
            } else
            {
                SystemSounds.Beep.Play();
                generoTexto.Focus();
            }
        }
    }
}
