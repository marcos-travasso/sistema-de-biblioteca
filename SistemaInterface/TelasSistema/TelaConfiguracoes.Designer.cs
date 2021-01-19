
namespace SistemaInterface.TelasSistema
{
    partial class TelaConfiguracoes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.senhaLabel = new System.Windows.Forms.Label();
            this.senhaTexto = new System.Windows.Forms.MaskedTextBox();
            this.nomeTexto = new System.Windows.Forms.TextBox();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.editarBotao = new System.Windows.Forms.Button();
            this.logoBotao = new System.Windows.Forms.Button();
            this.abrirImagem = new System.Windows.Forms.OpenFileDialog();
            this.backupBotao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // senhaLabel
            // 
            this.senhaLabel.AutoSize = true;
            this.senhaLabel.Location = new System.Drawing.Point(145, 124);
            this.senhaLabel.Name = "senhaLabel";
            this.senhaLabel.Size = new System.Drawing.Size(68, 25);
            this.senhaLabel.TabIndex = 34;
            this.senhaLabel.Text = "Senha:";
            // 
            // senhaTexto
            // 
            this.senhaTexto.BeepOnError = true;
            this.senhaTexto.ForeColor = System.Drawing.SystemColors.WindowText;
            this.senhaTexto.Location = new System.Drawing.Point(219, 124);
            this.senhaTexto.Name = "senhaTexto";
            this.senhaTexto.PasswordChar = '•';
            this.senhaTexto.PromptChar = ' ';
            this.senhaTexto.Size = new System.Drawing.Size(223, 33);
            this.senhaTexto.TabIndex = 31;
            this.senhaTexto.ValidatingType = typeof(System.DateTime);
            // 
            // nomeTexto
            // 
            this.nomeTexto.Location = new System.Drawing.Point(219, 70);
            this.nomeTexto.Name = "nomeTexto";
            this.nomeTexto.Size = new System.Drawing.Size(223, 33);
            this.nomeTexto.TabIndex = 30;
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(32, 70);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(181, 25);
            this.nomeLabel.TabIndex = 33;
            this.nomeLabel.Text = "Nome da biblioteca:";
            // 
            // editarBotao
            // 
            this.editarBotao.Location = new System.Drawing.Point(219, 270);
            this.editarBotao.Name = "editarBotao";
            this.editarBotao.Size = new System.Drawing.Size(223, 64);
            this.editarBotao.TabIndex = 36;
            this.editarBotao.Text = "Editar configurações";
            this.editarBotao.UseVisualStyleBackColor = true;
            this.editarBotao.Click += new System.EventHandler(this.editarBotao_Click);
            // 
            // logoBotao
            // 
            this.logoBotao.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoBotao.Location = new System.Drawing.Point(219, 174);
            this.logoBotao.Name = "logoBotao";
            this.logoBotao.Size = new System.Drawing.Size(223, 33);
            this.logoBotao.TabIndex = 37;
            this.logoBotao.Text = "Alterar imagem da logo...";
            this.logoBotao.UseVisualStyleBackColor = true;
            this.logoBotao.Click += new System.EventHandler(this.logoBotao_Click);
            // 
            // abrirImagem
            // 
            this.abrirImagem.Filter = "Arquivos de imagem| *.jpg; *.jpeg; *.png";
            this.abrirImagem.InitialDirectory = ".\\";
            this.abrirImagem.Title = "Localizar imagem da logo";
            // 
            // backupBotao
            // 
            this.backupBotao.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backupBotao.Location = new System.Drawing.Point(219, 222);
            this.backupBotao.Name = "backupBotao";
            this.backupBotao.Size = new System.Drawing.Size(223, 33);
            this.backupBotao.TabIndex = 38;
            this.backupBotao.Text = "Backup...";
            this.backupBotao.UseVisualStyleBackColor = true;
            this.backupBotao.Click += new System.EventHandler(this.backupBotao_Click);
            // 
            // TelaConfiguracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 406);
            this.Controls.Add(this.backupBotao);
            this.Controls.Add(this.logoBotao);
            this.Controls.Add(this.editarBotao);
            this.Controls.Add(this.senhaLabel);
            this.Controls.Add(this.senhaTexto);
            this.Controls.Add(this.nomeTexto);
            this.Controls.Add(this.nomeLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "TelaConfiguracoes";
            this.Text = "TelaConfiguracoes";
            this.Load += new System.EventHandler(this.TelaConfiguracoes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label senhaLabel;
        private System.Windows.Forms.MaskedTextBox senhaTexto;
        private System.Windows.Forms.TextBox nomeTexto;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.Button editarBotao;
        private System.Windows.Forms.Button logoBotao;
        private System.Windows.Forms.OpenFileDialog abrirImagem;
        private System.Windows.Forms.Button backupBotao;
    }
}