using SistemaBiblioteca;
using System;
using System.Media;
using System.Windows.Forms;

namespace SistemaInterface
{
    public partial class TelaInformacoesGenero : Form
    {
        Genero genero;
        public TelaInformacoesGenero()
        {
            InitializeComponent();
        }

        public TelaInformacoesGenero(Genero genero)
        {
            this.genero = genero;
            InitializeComponent();
        }

        private void editarBotao_Click(object sender, EventArgs e)
        {
            if (nomeTexto.Text != "")
            {
                BancoGenero banco = new BancoGenero();
                try
                {
                    genero.Nome = nomeTexto.Text;
                    banco.EditarGenero(genero);

                    MessageBox.Show("Gênero editado com sucesso.", "Sucesso");
                }
                catch
                {
                    SystemSounds.Beep.Play();
                    MessageBox.Show("Não foi possível editado o gênero.", "Erro");
                }
            }
            else
            {
                SystemSounds.Beep.Play();
                nomeTexto.Focus();
            }
        }

        private void excluirBotao_Click(object sender, EventArgs e)
        {
            BancoGenero banco = new BancoGenero();
            try
            {
                banco.ExcluirGenero(genero);

                MessageBox.Show("Gênero excluído com sucesso.", "Sucesso");
                this.Close();
            }
            catch
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Não foi possível excluir o gênero.", "Erro");
            }
        }

        private void TelaInformacoesGenero_Load(object sender, EventArgs e)
        {
            setarDados();
        }

        private void setarDados()
        {
            this.Text = "Informações do gênero " + Convert.ToString(genero.idGenero);

            idTexto.Text = Convert.ToString(genero.idGenero);
            nomeTexto.Text = genero.Nome;
        }
    }
}
