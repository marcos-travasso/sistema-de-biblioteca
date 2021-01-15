using SistemaBiblioteca;
using System;
using System.Media;
using System.Windows.Forms;

namespace SistemaInterface
{
    public partial class TelaConfirmarEmprestimo : Form
    {
        Emprestimo emprestimo;
        bool devolver = false;
        public TelaConfirmarEmprestimo(Emprestimo emprestimo)
        {
            this.emprestimo = emprestimo;
            InitializeComponent();
        }
        public TelaConfirmarEmprestimo(Emprestimo emprestimo, bool devolver = false)
        {
            this.emprestimo = emprestimo;
            this.devolver = devolver;
            InitializeComponent();
        }
        private void TelaConfirmarEmprestimo_Load(object sender, EventArgs e)
        {
            setarDados();
        }

        private void cancelarBotao_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void setarDados()
        {
            usuarioTexto.Text = emprestimo.usuario.Nome;
            livroTexto.Text = emprestimo.livro.Titulo;
            dataConfirmarLabel.Text = emprestimo.devolucoes[0].dataDeDevolucao.ToString("dd/MM/yyyy") + " (" + emprestimo.getDiferenca().ToString() + " dias)";
            if (devolver)
            {
                this.Text = "Confirmar renovação";
                confirmarLabel.Text = "Confirmar renovação";
            }
        }

        private void emprestarBotao_Click(object sender, EventArgs e)
        {
            if (!devolver)
            {
                try
                {
                    BancoEmprestimo banco = new BancoEmprestimo();
                    banco.CriarEmprestimo(emprestimo);

                    this.Close();
                    MessageBox.Show("Livro emprestado com sucesso.", "Sucesso");
                }
                catch
                {
                    SystemSounds.Beep.Play();
                    this.Close();
                    MessageBox.Show("Não foi possível realizar o empréstimo.", "Erro");
                }
            }
            else
            {
                try
                {
                    BancoEmprestimo banco = new BancoEmprestimo();
                    banco.RenovarEmprestimo(emprestimo);

                    this.Close();
                    MessageBox.Show("Livro renovado com sucesso.", "Sucesso");
                }
                catch
                {
                    SystemSounds.Beep.Play();
                    this.Close();
                    MessageBox.Show("Não foi possível renovar o empréstimo.", "Erro");
                }
            }
        }
    }
}
