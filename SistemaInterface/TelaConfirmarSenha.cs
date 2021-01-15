using SistemaBiblioteca;
using System;
using System.Media;
using System.Windows.Forms;

namespace SistemaInterface
{
    public partial class TelaConfirmarSenha : Form
    {
        public bool confirmacao = false;
        public TelaConfirmarSenha()
        {
            InitializeComponent();
        }

        private void confirmarBotao_Click(object sender, EventArgs e)
        {
            Configuracoes config = new Configuracoes();
            if (senhaTexto.Text == config.senha)
            {
                this.confirmacao = true;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                SystemSounds.Beep.Play();
            }
        }

        private void cancelarBotao_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
