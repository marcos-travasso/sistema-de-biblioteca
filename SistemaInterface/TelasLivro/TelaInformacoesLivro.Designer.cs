
namespace SistemaInterface
{
    partial class TelaInformacoesLivro
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
            this.generoLista = new System.Windows.Forms.CheckedListBox();
            this.paginasLabel = new System.Windows.Forms.Label();
            this.paginasTexto = new System.Windows.Forms.MaskedTextBox();
            this.historicoBotao = new System.Windows.Forms.Button();
            this.generoAdicionar = new System.Windows.Forms.LinkLabel();
            this.generoLabel = new System.Windows.Forms.Label();
            this.autoresLista = new System.Windows.Forms.ComboBox();
            this.autorAdicionar = new System.Windows.Forms.LinkLabel();
            this.autorLabel = new System.Windows.Forms.Label();
            this.anoLabel = new System.Windows.Forms.Label();
            this.anoTexto = new System.Windows.Forms.MaskedTextBox();
            this.tituloTexto = new System.Windows.Forms.TextBox();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.editarBotao = new System.Windows.Forms.Button();
            this.excluirBotao = new System.Windows.Forms.Button();
            this.idLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // generoLista
            // 
            this.generoLista.CheckOnClick = true;
            this.generoLista.FormattingEnabled = true;
            this.generoLista.Location = new System.Drawing.Point(243, 277);
            this.generoLista.Name = "generoLista";
            this.generoLista.Size = new System.Drawing.Size(225, 116);
            this.generoLista.TabIndex = 5;
            // 
            // paginasLabel
            // 
            this.paginasLabel.AutoSize = true;
            this.paginasLabel.Location = new System.Drawing.Point(53, 148);
            this.paginasLabel.Name = "paginasLabel";
            this.paginasLabel.Size = new System.Drawing.Size(182, 25);
            this.paginasLabel.TabIndex = 42;
            this.paginasLabel.Text = "Número de páginas:";
            // 
            // paginasTexto
            // 
            this.paginasTexto.BeepOnError = true;
            this.paginasTexto.ForeColor = System.Drawing.SystemColors.WindowText;
            this.paginasTexto.Location = new System.Drawing.Point(245, 148);
            this.paginasTexto.Name = "paginasTexto";
            this.paginasTexto.PromptChar = ' ';
            this.paginasTexto.ReadOnly = true;
            this.paginasTexto.Size = new System.Drawing.Size(223, 33);
            this.paginasTexto.TabIndex = 3;
            this.paginasTexto.ValidatingType = typeof(System.DateTime);
            // 
            // historicoBotao
            // 
            this.historicoBotao.Enabled = false;
            this.historicoBotao.Location = new System.Drawing.Point(245, 438);
            this.historicoBotao.Name = "historicoBotao";
            this.historicoBotao.Size = new System.Drawing.Size(223, 64);
            this.historicoBotao.TabIndex = 35;
            this.historicoBotao.Text = "Histórico do livro";
            this.historicoBotao.UseVisualStyleBackColor = true;
            // 
            // generoAdicionar
            // 
            this.generoAdicionar.AutoSize = true;
            this.generoAdicionar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generoAdicionar.Location = new System.Drawing.Point(327, 396);
            this.generoAdicionar.Name = "generoAdicionar";
            this.generoAdicionar.Size = new System.Drawing.Size(141, 17);
            this.generoAdicionar.TabIndex = 41;
            this.generoAdicionar.TabStop = true;
            this.generoAdicionar.Text = "adicionar novo gênero";
            this.generoAdicionar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.generoAdicionar_LinkClicked);
            // 
            // generoLabel
            // 
            this.generoLabel.AutoSize = true;
            this.generoLabel.Location = new System.Drawing.Point(138, 278);
            this.generoLabel.Name = "generoLabel";
            this.generoLabel.Size = new System.Drawing.Size(98, 25);
            this.generoLabel.TabIndex = 40;
            this.generoLabel.Text = "Gênero(s):";
            // 
            // autoresLista
            // 
            this.autoresLista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.autoresLista.FormattingEnabled = true;
            this.autoresLista.Location = new System.Drawing.Point(243, 201);
            this.autoresLista.Name = "autoresLista";
            this.autoresLista.Size = new System.Drawing.Size(225, 33);
            this.autoresLista.TabIndex = 4;
            // 
            // autorAdicionar
            // 
            this.autorAdicionar.AutoSize = true;
            this.autorAdicionar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autorAdicionar.Location = new System.Drawing.Point(338, 234);
            this.autorAdicionar.Name = "autorAdicionar";
            this.autorAdicionar.Size = new System.Drawing.Size(130, 17);
            this.autorAdicionar.TabIndex = 39;
            this.autorAdicionar.TabStop = true;
            this.autorAdicionar.Text = "adicionar novo autor";
            this.autorAdicionar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.autorAdicionar_LinkClicked);
            // 
            // autorLabel
            // 
            this.autorLabel.AutoSize = true;
            this.autorLabel.Location = new System.Drawing.Point(173, 201);
            this.autorLabel.Name = "autorLabel";
            this.autorLabel.Size = new System.Drawing.Size(63, 25);
            this.autorLabel.TabIndex = 38;
            this.autorLabel.Text = "Autor:";
            // 
            // anoLabel
            // 
            this.anoLabel.AutoSize = true;
            this.anoLabel.Location = new System.Drawing.Point(62, 97);
            this.anoLabel.Name = "anoLabel";
            this.anoLabel.Size = new System.Drawing.Size(173, 25);
            this.anoLabel.TabIndex = 37;
            this.anoLabel.Text = "Ano de publicação:";
            // 
            // anoTexto
            // 
            this.anoTexto.BeepOnError = true;
            this.anoTexto.ForeColor = System.Drawing.SystemColors.WindowText;
            this.anoTexto.Location = new System.Drawing.Point(245, 97);
            this.anoTexto.Name = "anoTexto";
            this.anoTexto.PromptChar = ' ';
            this.anoTexto.ReadOnly = true;
            this.anoTexto.Size = new System.Drawing.Size(223, 33);
            this.anoTexto.TabIndex = 2;
            this.anoTexto.ValidatingType = typeof(System.DateTime);
            // 
            // tituloTexto
            // 
            this.tituloTexto.Location = new System.Drawing.Point(245, 43);
            this.tituloTexto.Name = "tituloTexto";
            this.tituloTexto.ReadOnly = true;
            this.tituloTexto.Size = new System.Drawing.Size(223, 33);
            this.tituloTexto.TabIndex = 1;
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Location = new System.Drawing.Point(172, 51);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(64, 25);
            this.tituloLabel.TabIndex = 36;
            this.tituloLabel.Text = "Título:";
            // 
            // editarBotao
            // 
            this.editarBotao.Enabled = false;
            this.editarBotao.Location = new System.Drawing.Point(245, 508);
            this.editarBotao.Name = "editarBotao";
            this.editarBotao.Size = new System.Drawing.Size(223, 64);
            this.editarBotao.TabIndex = 6;
            this.editarBotao.Text = "Editar livro";
            this.editarBotao.UseVisualStyleBackColor = true;
            this.editarBotao.Click += new System.EventHandler(this.editarBotao_Click);
            // 
            // excluirBotao
            // 
            this.excluirBotao.Enabled = false;
            this.excluirBotao.Location = new System.Drawing.Point(245, 578);
            this.excluirBotao.Name = "excluirBotao";
            this.excluirBotao.Size = new System.Drawing.Size(223, 64);
            this.excluirBotao.TabIndex = 7;
            this.excluirBotao.Text = "Excluir livro";
            this.excluirBotao.UseVisualStyleBackColor = true;
            this.excluirBotao.Click += new System.EventHandler(this.excluirBotao_Click);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(158, 8);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(176, 32);
            this.idLabel.TabIndex = 60;
            this.idLabel.Text = "Livro número:";
            // 
            // TelaInformacoesLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 661);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.excluirBotao);
            this.Controls.Add(this.editarBotao);
            this.Controls.Add(this.generoLista);
            this.Controls.Add(this.paginasLabel);
            this.Controls.Add(this.paginasTexto);
            this.Controls.Add(this.historicoBotao);
            this.Controls.Add(this.generoAdicionar);
            this.Controls.Add(this.generoLabel);
            this.Controls.Add(this.autoresLista);
            this.Controls.Add(this.autorAdicionar);
            this.Controls.Add(this.autorLabel);
            this.Controls.Add(this.anoLabel);
            this.Controls.Add(this.anoTexto);
            this.Controls.Add(this.tituloTexto);
            this.Controls.Add(this.tituloLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "TelaInformacoesLivro";
            this.Text = "Informações do livro";
            this.Activated += new System.EventHandler(this.TelaInformacoesLivro_Activated);
            this.Load += new System.EventHandler(this.TelaInformacoesLivro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox generoLista;
        private System.Windows.Forms.Label paginasLabel;
        private System.Windows.Forms.MaskedTextBox paginasTexto;
        private System.Windows.Forms.Button historicoBotao;
        private System.Windows.Forms.LinkLabel generoAdicionar;
        private System.Windows.Forms.Label generoLabel;
        private System.Windows.Forms.ComboBox autoresLista;
        private System.Windows.Forms.LinkLabel autorAdicionar;
        private System.Windows.Forms.Label autorLabel;
        private System.Windows.Forms.Label anoLabel;
        private System.Windows.Forms.MaskedTextBox anoTexto;
        private System.Windows.Forms.TextBox tituloTexto;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Button editarBotao;
        private System.Windows.Forms.Button excluirBotao;
        private System.Windows.Forms.Label idLabel;
    }
}