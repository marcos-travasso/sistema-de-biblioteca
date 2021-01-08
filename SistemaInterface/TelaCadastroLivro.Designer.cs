
namespace SistemaInterface
{
    partial class TelaCadastroLivro
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
            this.anoLabel = new System.Windows.Forms.Label();
            this.anoTexto = new System.Windows.Forms.MaskedTextBox();
            this.tituloTexto = new System.Windows.Forms.TextBox();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.autorLabel = new System.Windows.Forms.Label();
            this.autorAdicionar = new System.Windows.Forms.LinkLabel();
            this.autorTexto = new System.Windows.Forms.ComboBox();
            this.generoLista = new System.Windows.Forms.ListBox();
            this.generoLabel = new System.Windows.Forms.Label();
            this.generoAdicionar = new System.Windows.Forms.LinkLabel();
            this.cadastrarBotao = new System.Windows.Forms.Button();
            this.paginasLabel = new System.Windows.Forms.Label();
            this.paginasTexto = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // anoLabel
            // 
            this.anoLabel.AutoSize = true;
            this.anoLabel.Location = new System.Drawing.Point(49, 104);
            this.anoLabel.Name = "anoLabel";
            this.anoLabel.Size = new System.Drawing.Size(173, 25);
            this.anoLabel.TabIndex = 9;
            this.anoLabel.Text = "Ano de publicação:";
            // 
            // anoTexto
            // 
            this.anoTexto.BeepOnError = true;
            this.anoTexto.ForeColor = System.Drawing.SystemColors.WindowText;
            this.anoTexto.Location = new System.Drawing.Point(232, 104);
            this.anoTexto.Mask = "9000";
            this.anoTexto.Name = "anoTexto";
            this.anoTexto.PromptChar = ' ';
            this.anoTexto.Size = new System.Drawing.Size(223, 33);
            this.anoTexto.TabIndex = 8;
            this.anoTexto.ValidatingType = typeof(System.DateTime);
            // 
            // tituloTexto
            // 
            this.tituloTexto.Location = new System.Drawing.Point(232, 55);
            this.tituloTexto.Name = "tituloTexto";
            this.tituloTexto.Size = new System.Drawing.Size(223, 33);
            this.tituloTexto.TabIndex = 7;
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Location = new System.Drawing.Point(159, 58);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(64, 25);
            this.tituloLabel.TabIndex = 6;
            this.tituloLabel.Text = "Título:";
            // 
            // autorLabel
            // 
            this.autorLabel.AutoSize = true;
            this.autorLabel.Location = new System.Drawing.Point(160, 208);
            this.autorLabel.Name = "autorLabel";
            this.autorLabel.Size = new System.Drawing.Size(63, 25);
            this.autorLabel.TabIndex = 10;
            this.autorLabel.Text = "Autor:";
            // 
            // autorAdicionar
            // 
            this.autorAdicionar.AutoSize = true;
            this.autorAdicionar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autorAdicionar.Location = new System.Drawing.Point(325, 241);
            this.autorAdicionar.Name = "autorAdicionar";
            this.autorAdicionar.Size = new System.Drawing.Size(130, 17);
            this.autorAdicionar.TabIndex = 12;
            this.autorAdicionar.TabStop = true;
            this.autorAdicionar.Text = "adicionar novo autor";
            this.autorAdicionar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.autorAdicionar_LinkClicked);
            // 
            // autorTexto
            // 
            this.autorTexto.FormattingEnabled = true;
            this.autorTexto.Location = new System.Drawing.Point(230, 208);
            this.autorTexto.Name = "autorTexto";
            this.autorTexto.Size = new System.Drawing.Size(225, 33);
            this.autorTexto.TabIndex = 13;
            // 
            // generoLista
            // 
            this.generoLista.FormattingEnabled = true;
            this.generoLista.ItemHeight = 25;
            this.generoLista.Location = new System.Drawing.Point(230, 284);
            this.generoLista.Name = "generoLista";
            this.generoLista.Size = new System.Drawing.Size(225, 104);
            this.generoLista.TabIndex = 14;
            // 
            // generoLabel
            // 
            this.generoLabel.AutoSize = true;
            this.generoLabel.Location = new System.Drawing.Point(125, 285);
            this.generoLabel.Name = "generoLabel";
            this.generoLabel.Size = new System.Drawing.Size(98, 25);
            this.generoLabel.TabIndex = 15;
            this.generoLabel.Text = "Gênero(s):";
            // 
            // generoAdicionar
            // 
            this.generoAdicionar.AutoSize = true;
            this.generoAdicionar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generoAdicionar.Location = new System.Drawing.Point(314, 391);
            this.generoAdicionar.Name = "generoAdicionar";
            this.generoAdicionar.Size = new System.Drawing.Size(141, 17);
            this.generoAdicionar.TabIndex = 16;
            this.generoAdicionar.TabStop = true;
            this.generoAdicionar.Text = "adicionar novo gênero";
            this.generoAdicionar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.generoAdicionar_LinkClicked);
            // 
            // cadastrarBotao
            // 
            this.cadastrarBotao.Enabled = false;
            this.cadastrarBotao.Location = new System.Drawing.Point(232, 432);
            this.cadastrarBotao.Name = "cadastrarBotao";
            this.cadastrarBotao.Size = new System.Drawing.Size(223, 64);
            this.cadastrarBotao.TabIndex = 27;
            this.cadastrarBotao.Text = "Cadastrar livro";
            this.cadastrarBotao.UseVisualStyleBackColor = true;
            // 
            // paginasLabel
            // 
            this.paginasLabel.AutoSize = true;
            this.paginasLabel.Location = new System.Drawing.Point(141, 155);
            this.paginasLabel.Name = "paginasLabel";
            this.paginasLabel.Size = new System.Drawing.Size(81, 25);
            this.paginasLabel.TabIndex = 29;
            this.paginasLabel.Text = "Páginas:";
            // 
            // paginasTexto
            // 
            this.paginasTexto.BeepOnError = true;
            this.paginasTexto.ForeColor = System.Drawing.SystemColors.WindowText;
            this.paginasTexto.Location = new System.Drawing.Point(232, 155);
            this.paginasTexto.Mask = "999990";
            this.paginasTexto.Name = "paginasTexto";
            this.paginasTexto.PromptChar = ' ';
            this.paginasTexto.Size = new System.Drawing.Size(223, 33);
            this.paginasTexto.TabIndex = 28;
            this.paginasTexto.ValidatingType = typeof(System.DateTime);
            // 
            // TelaCadastroLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 544);
            this.Controls.Add(this.paginasLabel);
            this.Controls.Add(this.paginasTexto);
            this.Controls.Add(this.cadastrarBotao);
            this.Controls.Add(this.generoAdicionar);
            this.Controls.Add(this.generoLabel);
            this.Controls.Add(this.generoLista);
            this.Controls.Add(this.autorTexto);
            this.Controls.Add(this.autorAdicionar);
            this.Controls.Add(this.autorLabel);
            this.Controls.Add(this.anoLabel);
            this.Controls.Add(this.anoTexto);
            this.Controls.Add(this.tituloTexto);
            this.Controls.Add(this.tituloLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "TelaCadastroLivro";
            this.Text = "Cadastro de Livro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label anoLabel;
        private System.Windows.Forms.MaskedTextBox anoTexto;
        private System.Windows.Forms.TextBox tituloTexto;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Label autorLabel;
        private System.Windows.Forms.LinkLabel autorAdicionar;
        private System.Windows.Forms.ComboBox autorTexto;
        private System.Windows.Forms.ListBox generoLista;
        private System.Windows.Forms.Label generoLabel;
        private System.Windows.Forms.LinkLabel generoAdicionar;
        private System.Windows.Forms.Button cadastrarBotao;
        private System.Windows.Forms.Label paginasLabel;
        private System.Windows.Forms.MaskedTextBox paginasTexto;
    }
}