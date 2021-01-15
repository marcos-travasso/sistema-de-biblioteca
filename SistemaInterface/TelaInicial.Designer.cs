
namespace SistemaInterface
{
    partial class TelaInicial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.imagemDaLogo = new System.Windows.Forms.PictureBox();
            this.usuariosLabel = new System.Windows.Forms.Label();
            this.livrosLabel = new System.Windows.Forms.Label();
            this.usuariosCadastradosBotao = new System.Windows.Forms.Button();
            this.usuariosEditarBotao = new System.Windows.Forms.Button();
            this.livrosCadastrarBotao = new System.Windows.Forms.Button();
            this.livrosCadastradosBotao = new System.Windows.Forms.Button();
            this.livrosEditarBotao = new System.Windows.Forms.Button();
            this.usuariosCadastrarBotao1 = new System.Windows.Forms.Button();
            this.livrosPesquisarBotao = new System.Windows.Forms.Button();
            this.novoEmprestimoBotao = new System.Windows.Forms.Button();
            this.usuariosCadastrarBotao2 = new System.Windows.Forms.Button();
            this.notificacoesListBox = new System.Windows.Forms.ListBox();
            this.devolutivaBotao = new System.Windows.Forms.Button();
            this.emprestimosBotao = new System.Windows.Forms.Button();
            this.notificacoesLabel = new System.Windows.Forms.Label();
            this.renovarBotao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imagemDaLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // imagemDaLogo
            // 
            this.imagemDaLogo.Location = new System.Drawing.Point(1, 0);
            this.imagemDaLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.imagemDaLogo.Name = "imagemDaLogo";
            this.imagemDaLogo.Size = new System.Drawing.Size(243, 225);
            this.imagemDaLogo.TabIndex = 1;
            this.imagemDaLogo.TabStop = false;
            // 
            // usuariosLabel
            // 
            this.usuariosLabel.AutoSize = true;
            this.usuariosLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuariosLabel.Location = new System.Drawing.Point(12, 246);
            this.usuariosLabel.Name = "usuariosLabel";
            this.usuariosLabel.Size = new System.Drawing.Size(142, 32);
            this.usuariosLabel.TabIndex = 2;
            this.usuariosLabel.Text = "→ Usuários";
            // 
            // livrosLabel
            // 
            this.livrosLabel.AutoSize = true;
            this.livrosLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.livrosLabel.Location = new System.Drawing.Point(12, 412);
            this.livrosLabel.Name = "livrosLabel";
            this.livrosLabel.Size = new System.Drawing.Size(111, 32);
            this.livrosLabel.TabIndex = 3;
            this.livrosLabel.Text = "→ Livros";
            // 
            // usuariosCadastradosBotao
            // 
            this.usuariosCadastradosBotao.Location = new System.Drawing.Point(54, 281);
            this.usuariosCadastradosBotao.Name = "usuariosCadastradosBotao";
            this.usuariosCadastradosBotao.Size = new System.Drawing.Size(154, 33);
            this.usuariosCadastradosBotao.TabIndex = 4;
            this.usuariosCadastradosBotao.Text = "Usuários cadastrados";
            this.usuariosCadastradosBotao.UseVisualStyleBackColor = true;
            this.usuariosCadastradosBotao.Click += new System.EventHandler(this.usuariosCadastradosBotao_Click);
            // 
            // usuariosEditarBotao
            // 
            this.usuariosEditarBotao.Location = new System.Drawing.Point(54, 359);
            this.usuariosEditarBotao.Name = "usuariosEditarBotao";
            this.usuariosEditarBotao.Size = new System.Drawing.Size(154, 33);
            this.usuariosEditarBotao.TabIndex = 5;
            this.usuariosEditarBotao.Text = "Editar usuários";
            this.usuariosEditarBotao.UseVisualStyleBackColor = true;
            this.usuariosEditarBotao.Click += new System.EventHandler(this.usuariosEditarBotao_Click);
            // 
            // livrosCadastrarBotao
            // 
            this.livrosCadastrarBotao.Location = new System.Drawing.Point(54, 486);
            this.livrosCadastrarBotao.Name = "livrosCadastrarBotao";
            this.livrosCadastrarBotao.Size = new System.Drawing.Size(154, 33);
            this.livrosCadastrarBotao.TabIndex = 6;
            this.livrosCadastrarBotao.Text = "Cadastrar novo livro";
            this.livrosCadastrarBotao.UseVisualStyleBackColor = true;
            this.livrosCadastrarBotao.Click += new System.EventHandler(this.livrosCadastrarBotao_Click);
            // 
            // livrosCadastradosBotao
            // 
            this.livrosCadastradosBotao.Location = new System.Drawing.Point(54, 447);
            this.livrosCadastradosBotao.Name = "livrosCadastradosBotao";
            this.livrosCadastradosBotao.Size = new System.Drawing.Size(154, 33);
            this.livrosCadastradosBotao.TabIndex = 7;
            this.livrosCadastradosBotao.Text = "Livros cadastrados";
            this.livrosCadastradosBotao.UseVisualStyleBackColor = true;
            this.livrosCadastradosBotao.Click += new System.EventHandler(this.livrosCadastradosBotao_Click);
            // 
            // livrosEditarBotao
            // 
            this.livrosEditarBotao.Location = new System.Drawing.Point(54, 525);
            this.livrosEditarBotao.Name = "livrosEditarBotao";
            this.livrosEditarBotao.Size = new System.Drawing.Size(154, 33);
            this.livrosEditarBotao.TabIndex = 8;
            this.livrosEditarBotao.Text = "Editar livros";
            this.livrosEditarBotao.UseVisualStyleBackColor = true;
            this.livrosEditarBotao.Click += new System.EventHandler(this.livrosEditarBotao_Click);
            // 
            // usuariosCadastrarBotao1
            // 
            this.usuariosCadastrarBotao1.Location = new System.Drawing.Point(54, 320);
            this.usuariosCadastrarBotao1.Name = "usuariosCadastrarBotao1";
            this.usuariosCadastrarBotao1.Size = new System.Drawing.Size(154, 33);
            this.usuariosCadastrarBotao1.TabIndex = 9;
            this.usuariosCadastrarBotao1.Text = "Cadastrar novo usuário";
            this.usuariosCadastrarBotao1.UseVisualStyleBackColor = true;
            this.usuariosCadastrarBotao1.Click += new System.EventHandler(this.usuariosCadastrarBotao1_Click);
            // 
            // livrosPesquisarBotao
            // 
            this.livrosPesquisarBotao.Location = new System.Drawing.Point(343, 177);
            this.livrosPesquisarBotao.Name = "livrosPesquisarBotao";
            this.livrosPesquisarBotao.Size = new System.Drawing.Size(267, 67);
            this.livrosPesquisarBotao.TabIndex = 10;
            this.livrosPesquisarBotao.Text = "Pesquisar Livros";
            this.livrosPesquisarBotao.UseVisualStyleBackColor = true;
            // 
            // novoEmprestimoBotao
            // 
            this.novoEmprestimoBotao.Location = new System.Drawing.Point(343, 250);
            this.novoEmprestimoBotao.Name = "novoEmprestimoBotao";
            this.novoEmprestimoBotao.Size = new System.Drawing.Size(267, 67);
            this.novoEmprestimoBotao.TabIndex = 11;
            this.novoEmprestimoBotao.Text = "Novo empréstimo";
            this.novoEmprestimoBotao.UseVisualStyleBackColor = true;
            this.novoEmprestimoBotao.Click += new System.EventHandler(this.novoEmprestimoBotao_Click);
            // 
            // usuariosCadastrarBotao2
            // 
            this.usuariosCadastrarBotao2.Location = new System.Drawing.Point(343, 325);
            this.usuariosCadastrarBotao2.Name = "usuariosCadastrarBotao2";
            this.usuariosCadastrarBotao2.Size = new System.Drawing.Size(267, 67);
            this.usuariosCadastrarBotao2.TabIndex = 12;
            this.usuariosCadastrarBotao2.Text = "Novo usuário";
            this.usuariosCadastrarBotao2.UseVisualStyleBackColor = true;
            this.usuariosCadastrarBotao2.Click += new System.EventHandler(this.usuariosCadastrarBotao2_Click);
            // 
            // notificacoesListBox
            // 
            this.notificacoesListBox.FormattingEnabled = true;
            this.notificacoesListBox.ItemHeight = 17;
            this.notificacoesListBox.Location = new System.Drawing.Point(676, 58);
            this.notificacoesListBox.Name = "notificacoesListBox";
            this.notificacoesListBox.Size = new System.Drawing.Size(214, 259);
            this.notificacoesListBox.TabIndex = 13;
            // 
            // devolutivaBotao
            // 
            this.devolutivaBotao.Location = new System.Drawing.Point(676, 342);
            this.devolutivaBotao.Name = "devolutivaBotao";
            this.devolutivaBotao.Size = new System.Drawing.Size(214, 50);
            this.devolutivaBotao.TabIndex = 14;
            this.devolutivaBotao.Text = "Devolutiva";
            this.devolutivaBotao.UseVisualStyleBackColor = true;
            this.devolutivaBotao.Click += new System.EventHandler(this.devolutivaBotao_Click);
            // 
            // emprestimosBotao
            // 
            this.emprestimosBotao.Location = new System.Drawing.Point(676, 398);
            this.emprestimosBotao.Name = "emprestimosBotao";
            this.emprestimosBotao.Size = new System.Drawing.Size(214, 50);
            this.emprestimosBotao.TabIndex = 15;
            this.emprestimosBotao.Text = "Livros emprestados";
            this.emprestimosBotao.UseVisualStyleBackColor = true;
            this.emprestimosBotao.Click += new System.EventHandler(this.emprestimosBotao_Click);
            // 
            // notificacoesLabel
            // 
            this.notificacoesLabel.AutoSize = true;
            this.notificacoesLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notificacoesLabel.Location = new System.Drawing.Point(670, 23);
            this.notificacoesLabel.Name = "notificacoesLabel";
            this.notificacoesLabel.Size = new System.Drawing.Size(157, 32);
            this.notificacoesLabel.TabIndex = 16;
            this.notificacoesLabel.Text = "Notificações";
            // 
            // renovarBotao
            // 
            this.renovarBotao.Location = new System.Drawing.Point(676, 454);
            this.renovarBotao.Name = "renovarBotao";
            this.renovarBotao.Size = new System.Drawing.Size(214, 50);
            this.renovarBotao.TabIndex = 17;
            this.renovarBotao.Text = "Renovar empréstimo";
            this.renovarBotao.UseVisualStyleBackColor = true;
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 588);
            this.Controls.Add(this.renovarBotao);
            this.Controls.Add(this.notificacoesLabel);
            this.Controls.Add(this.emprestimosBotao);
            this.Controls.Add(this.devolutivaBotao);
            this.Controls.Add(this.notificacoesListBox);
            this.Controls.Add(this.usuariosCadastrarBotao2);
            this.Controls.Add(this.novoEmprestimoBotao);
            this.Controls.Add(this.livrosPesquisarBotao);
            this.Controls.Add(this.usuariosCadastrarBotao1);
            this.Controls.Add(this.livrosEditarBotao);
            this.Controls.Add(this.livrosCadastradosBotao);
            this.Controls.Add(this.livrosCadastrarBotao);
            this.Controls.Add(this.usuariosEditarBotao);
            this.Controls.Add(this.usuariosCadastradosBotao);
            this.Controls.Add(this.livrosLabel);
            this.Controls.Add(this.usuariosLabel);
            this.Controls.Add(this.imagemDaLogo);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "TelaInicial";
            this.Text = "Sistema Livrearia";
            ((System.ComponentModel.ISupportInitialize)(this.imagemDaLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imagemDaLogo;
        private System.Windows.Forms.Label usuariosLabel;
        private System.Windows.Forms.Label livrosLabel;
        private System.Windows.Forms.Button usuariosCadastradosBotao;
        private System.Windows.Forms.Button usuariosEditarBotao;
        private System.Windows.Forms.Button livrosCadastrarBotao;
        private System.Windows.Forms.Button livrosCadastradosBotao;
        private System.Windows.Forms.Button livrosEditarBotao;
        private System.Windows.Forms.Button usuariosCadastrarBotao1;
        private System.Windows.Forms.Button livrosPesquisarBotao;
        private System.Windows.Forms.Button novoEmprestimoBotao;
        private System.Windows.Forms.Button usuariosCadastrarBotao2;
        private System.Windows.Forms.ListBox notificacoesListBox;
        private System.Windows.Forms.Button devolutivaBotao;
        private System.Windows.Forms.Button emprestimosBotao;
        private System.Windows.Forms.Label notificacoesLabel;
        private System.Windows.Forms.Button renovarBotao;
    }
}

