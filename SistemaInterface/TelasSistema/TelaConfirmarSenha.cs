using SistemaBiblioteca;
using System;
using System.Configuration;
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
            if (senhaTexto.Text == ConfigurationManager.AppSettings.Get("Senha"))
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
