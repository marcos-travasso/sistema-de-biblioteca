using SistemaBiblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaInterface
{
    public partial class TelaConfirmarEmprestimo : Form
    {
        Emprestimo emprestimo;
        public TelaConfirmarEmprestimo(Emprestimo emprestimo)
        {
            this.emprestimo = emprestimo;
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
        }

        private void emprestarBotao_Click(object sender, EventArgs e)
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
    }
}
