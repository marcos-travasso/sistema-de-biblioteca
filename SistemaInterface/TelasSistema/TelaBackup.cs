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
using System.IO.Compression;
using System.IO;
using System.Configuration;

namespace SistemaInterface.TelasSistema
{
    public partial class TelaBackup : Form
    {
        public TelaBackup()
        {
            InitializeComponent();
        }

        private void fazerBotao_Click(object sender, EventArgs e)
        {
            try
            {
                fazerBackup();

                MessageBox.Show("Backup realizado com sucesso!", "Sucesso");
            }
            catch
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Não foi possível realizar o backup", "Erro");
            }

        }
        public void fazerBackup()
        {
            BackupDrive backup = new BackupDrive();

            string caminho = ziparArquivo();
            backup.SalvarArquivo(caminho, ConfigurationManager.AppSettings.Get("PastaDrive"));
        }
        private string ziparArquivo()
        {
            string caminhoInicial = System.IO.Directory.GetCurrentDirectory() + @"\backupTemp";
            string caminhoZip = System.IO.Directory.GetCurrentDirectory() + $@"\backups\backup-{DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss")}.zip";

            System.IO.File.Copy(System.IO.Directory.GetCurrentDirectory() + $@"\BancoDeDados.db", caminhoInicial + $@"\BancoDeDados.db", true);

            ZipFile.CreateFromDirectory(caminhoInicial, caminhoZip);
            File.Delete(caminhoInicial + $@"\BancoDeDados.db");

            return caminhoZip;
        }

        private void configBotao_Click(object sender, EventArgs e)
        {
            bool isOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "TelaSelecionarPasta")
                {
                    isOpen = true;
                    f.BringToFront();
                }
            }

            if (!isOpen)
            {
                TelaListarBackup janela = new TelaListarBackup(false);
                janela.Show();
            }
        }

        private void abrirBotao_Click(object sender, EventArgs e)
        {
            bool isOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "TelaSelecionarPasta")
                {
                    isOpen = true;
                    f.BringToFront();
                }
            }

            if (!isOpen)
            {
                TelaListarBackup janela = new TelaListarBackup(true);
                janela.Show();
            }
        }
    }
}
