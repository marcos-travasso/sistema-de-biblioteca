﻿using System;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace SistemaInterface.TelasSistema
{
    public partial class TelaConfiguracoes : Form
    {
        Image imagem;
        string caminho = System.IO.Directory.GetCurrentDirectory();
        public TelaConfiguracoes()
        {
            InitializeComponent();
        }
        private bool confirmarSenha()
        {
            using (var form = new TelaConfirmarSenha())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    if (form.confirmacao)
                    {
                        return true;
                    }
                }
                return false;
            }
        }
        private void editarBotao_Click(object sender, EventArgs e)
        {
            if (confirmarSenha())
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                config.AppSettings.Settings["Nome"].Value = nomeTexto.Text;
                if (senhaTexto.Text != "") { config.AppSettings.Settings["Senha"].Value = senhaTexto.Text; }

                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");

                if (this.imagem != null)
                {
                    this.caminho += $@"\novaLogo.png";
                    imagem.Save(this.caminho, System.Drawing.Imaging.ImageFormat.Png);
                    imagem.Dispose();
                }

                MessageBox.Show("Configurações editadas com sucesso.", "Sucesso");
                logoBotao.Text = "Alterar imagem da logo...";
                senhaTexto.Text = "";
            }
        }

        private void TelaConfiguracoes_Load(object sender, EventArgs e)
        {
            nomeTexto.Text = ConfigurationManager.AppSettings.Get("Nome");
        }

        private void logoBotao_Click(object sender, EventArgs e)
        {
            abrirImagem.InitialDirectory = this.caminho;

            if (abrirImagem.ShowDialog() == DialogResult.OK)
            {
                string arquivo = abrirImagem.FileName;
                string[] diretorios = arquivo.Split('\\');
                this.imagem = Image.FromFile(arquivo);

                logoBotao.Text = diretorios[diretorios.Length - 1];
            }
        }

        private void backupBotao_Click(object sender, EventArgs e)
        {
            if (File.Exists(System.IO.Directory.GetCurrentDirectory() + @"\credentials.json"))
            {
                bool isOpen = false;

                foreach (Form f in Application.OpenForms)
                {
                    if (f.Name == "TelaBackup")
                    {
                        isOpen = true;
                        f.BringToFront();
                    }
                }

                if (!isOpen)
                {
                    TelaBackup janela = new TelaBackup();
                    janela.Show();
                }
            }
            else
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Arquivo credentials.json não foi encontrado", "Erro");
            }
        }
    }
}
