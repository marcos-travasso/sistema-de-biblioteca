using SistemaBiblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaInterface.TelasSistema
{
    public partial class TelaListarBackup : Form
    {
        BackupDrive backupDrive = new BackupDrive();
        List<Pasta> listaPasta = new List<Pasta>();
        List<Arquivo> listaArquivo = new List<Arquivo>();
        string diretorio = System.IO.Directory.GetCurrentDirectory() + @"\backupTemp\";
        bool backup = false;
        public TelaListarBackup()
        {
            InitializeComponent();
        }
        public TelaListarBackup(bool backup = false)
        {
            this.backup = backup;
            InitializeComponent();
        }

        private void TelaSelecionarPasta_Load(object sender, EventArgs e)
        {
            if (!backup) { carregarPastas(); }
            else { carregarArquivos(); }
        }

        private void selecionarBotao_Click(object sender, EventArgs e)
        {
            if (!backup) { selecionarPasta(); }
            else { selecionarBackup(); }
            this.Close();
        }
        private void carregarPastas()
        {
            var pastas = backupDrive.GetPastas();

            Pasta pasta = new Pasta("<root>", "");
            this.listaPasta.Add(pasta);
            pastasLista.Items.Add(pasta.Nome);

            foreach (var pastaRaw in pastas)
            {
                pasta = new Pasta(pastaRaw.Name, pastaRaw.Id);
                this.listaPasta.Add(pasta);
                pastasLista.Items.Add(pasta.Nome);
            }
        }
        private void carregarArquivos()
        {
            this.Text = "Selecionar arquivo de backup";
            selecionarBotao.Text = "Selecionar backup";

            var arquivos = backupDrive.GetArquivos();

            foreach (var arquivoRaw in arquivos)
            {
                Arquivo arquivo = new Arquivo(arquivoRaw.Name, arquivoRaw.Id);
                this.listaArquivo.Add(arquivo);
                pastasLista.Items.Add(arquivo.Nome);
            }
        }
        private void selecionarPasta()
        {
            try
            {
                if (pastasLista.SelectedItem != null)
                {
                    foreach (Pasta pasta in listaPasta)
                    {
                        if (pasta.Nome == pastasLista.SelectedItem.ToString())
                        {
                            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                            config.AppSettings.Settings["PastaDrive"].Value = pasta.Id;
                            config.Save(ConfigurationSaveMode.Modified);
                            ConfigurationManager.RefreshSection("appSettings");
                            MessageBox.Show("Pasta de backup alterada com sucesso", "Sucesso");

                            break;
                        }
                    }
                }
            }
            catch
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Não foi possível alterar a pasta de backup", "Erro");
            }
        }
        private void selecionarBackup()
        {
            try
            {
                if (pastasLista.SelectedItem != null)
                {
                    foreach (Arquivo arquivo in listaArquivo)
                    {
                        if (arquivo.Nome == pastasLista.SelectedItem.ToString())
                        {
                            trocarBackup(arquivo);

                            ConfigurationManager.RefreshSection("appSettings");

                            break;
                        }
                    }
                }
            }
            catch
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Não foi possível abrir o backup", "Erro");
            }
        }
        private void trocarBackup(Arquivo arquivo)
        {
            try
            {
                backupDrive.BaixarArquivo(arquivo.Id, diretorio + arquivo.Nome);

                deziparArquivo(arquivo.Nome);
                File.Delete(diretorio + arquivo.Nome);

                Application.Restart();
            }
            catch
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Não foi possível baixar o backup", "Erro");
            }
        }
        private void deziparArquivo(string nome)
        {
            ZipFile.ExtractToDirectory(diretorio + nome, diretorio);
        }
    }
}
