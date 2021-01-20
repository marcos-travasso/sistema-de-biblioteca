using System;
using System.Configuration;
using System.Media;
using System.Windows.Forms;

namespace SistemaInterface.TelasSistema
{
    public partial class TelaConfiguracoesBackup : Form
    {
        public TelaConfiguracoesBackup()
        {
            InitializeComponent();
        }

        private void TelaConfiguracoesBackup_Load(object sender, EventArgs e)
        {
            minutosTexto.Text = ConfigurationManager.AppSettings.Get("IntervaloFazerBackup");
            diasTexto.Text = ConfigurationManager.AppSettings.Get("IntervaloApagarBackup");
        }

        private void confirmarBotao_Click(object sender, EventArgs e)
        {
            bool num = true;

            foreach (char numero in minutosTexto.Text)
            {
                if (!Char.IsNumber(numero))
                {
                    num = false;
                }
            }
            foreach (char numero in diasTexto.Text)
            {
                if (!Char.IsNumber(numero))
                {
                    num = false;
                }
            }

            if (num)
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                config.AppSettings.Settings["IntervaloFazerBackup"].Value = minutosTexto.Text;
                config.AppSettings.Settings["IntervaloApagarBackup"].Value = diasTexto.Text;

                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");

                MessageBox.Show("Configurações editadas com sucesso.", "Sucesso");
                this.Close();
            }
            else
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Insira somente números inteiros.", "Erro");
            }
        }
    }
}
