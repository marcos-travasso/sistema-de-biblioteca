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
    public partial class TelaConfirmarDevolucao : Form
    {
        Emprestimo emprestimo;
        BancoEmprestimo banco = new BancoEmprestimo();
        public TelaConfirmarDevolucao()
        {
            InitializeComponent();
        }
        public TelaConfirmarDevolucao(Emprestimo emprestimo)
        {
            this.emprestimo = emprestimo;
            InitializeComponent();
        }

        private void TelaConfirmarDevolucao_Load(object sender, EventArgs e)
        {
            setarDados();
        }

        private void cancelarBotao_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void setarDados()
        {
            usuarioTexto.Text = emprestimo.usuario.Nome;
            livroTexto.Text = emprestimo.livro.Titulo;
        }

        private void emprestarBotao_Click(object sender, EventArgs e)
        {
            try
            {
                banco.DevolverEmprestimo(emprestimo);

                this.Close();
                MessageBox.Show("Livro devolvido com sucesso!", "Sucesso");
            }
            catch
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Não foi possível devolver o livro.", "Erro");
            }
        }
    }
}
