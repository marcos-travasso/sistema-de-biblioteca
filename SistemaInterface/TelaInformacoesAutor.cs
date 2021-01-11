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
    public partial class TelaInformacoesAutor : Form
    {
        Autor autor;
        public TelaInformacoesAutor()
        {
            InitializeComponent();
        }

        public TelaInformacoesAutor(Autor autor)
        {
            this.autor = autor;
            InitializeComponent();
        }

        private void TelaInformacoesAutor_Load(object sender, EventArgs e)
        {
            setarDados();
        }

        private void setarDados()
        {
            this.Text = "Informações do autor " + Convert.ToString(autor.idAutor);

            idLabel.Text = "Autor número: " + Convert.ToString(autor.idAutor);
            nomeTexto.Text = autor.Nome;
            nascimentoTexto.Text = Convert.ToString(autor.Nascimento).Substring(0, 10);
            generoTexto.Text = autor.getGenero();

        }

        private void excluirBotao_Click(object sender, EventArgs e)
        {
            BancoDeDados banco = new BancoDeDados();
            try
            {
                banco.ExcluirAutor(autor);

                MessageBox.Show("Autor excluído com sucesso.", "Sucesso");
            }
            catch
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Não foi possível excluir o autor.", "Erro");
            }
        }

        private void editarBotao_Click(object sender, EventArgs e)
        {
            if (nomeTexto.Text != "")
            {
                autor.Nome = autor.converterNome(nomeTexto.Text);

                if (generoTexto.Text == "Masculino") { autor.Genero = "M"; }
                else if (generoTexto.Text == "Feminino") { autor.Genero = "F"; }
                else { autor.Genero = "O"; }

                try { autor.Nascimento = Convert.ToDateTime(nascimentoTexto.Text); }
                catch { SystemSounds.Beep.Play(); MessageBox.Show("A data de nascimento está incorreta.", "Erro"); nascimentoTexto.Focus(); }

                BancoDeDados banco = new BancoDeDados();

                try
                {
                    banco.EditarAutor(autor);

                    setarDados();

                    MessageBox.Show("Autor editado com sucesso", "Sucesso");

                }
                catch
                {
                    SystemSounds.Beep.Play();
                    MessageBox.Show("Não foi possível editar o autor.", "Erro");
                }
            }
        }
    }
}
