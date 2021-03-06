﻿
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
            this.autoresLista = new System.Windows.Forms.ComboBox();
            this.generoLabel = new System.Windows.Forms.Label();
            this.cadastrarBotao = new System.Windows.Forms.Button();
            this.paginasLabel = new System.Windows.Forms.Label();
            this.paginasTexto = new System.Windows.Forms.MaskedTextBox();
            this.generoLista = new System.Windows.Forms.CheckedListBox();
            this.autorEditar = new System.Windows.Forms.LinkLabel();
            this.generoAdicionar = new System.Windows.Forms.LinkLabel();
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
            this.anoTexto.Name = "anoTexto";
            this.anoTexto.PromptChar = ' ';
            this.anoTexto.Size = new System.Drawing.Size(223, 33);
            this.anoTexto.TabIndex = 2;
            this.anoTexto.ValidatingType = typeof(System.DateTime);
            // 
            // tituloTexto
            // 
            this.tituloTexto.Location = new System.Drawing.Point(232, 50);
            this.tituloTexto.Name = "tituloTexto";
            this.tituloTexto.Size = new System.Drawing.Size(223, 33);
            this.tituloTexto.TabIndex = 1;
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Location = new System.Drawing.Point(158, 50);
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
            // autoresLista
            // 
            this.autoresLista.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.autoresLista.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.autoresLista.FormattingEnabled = true;
            this.autoresLista.Location = new System.Drawing.Point(230, 208);
            this.autoresLista.Name = "autoresLista";
            this.autoresLista.Size = new System.Drawing.Size(225, 33);
            this.autoresLista.Sorted = true;
            this.autoresLista.TabIndex = 4;
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
            // cadastrarBotao
            // 
            this.cadastrarBotao.Location = new System.Drawing.Point(232, 445);
            this.cadastrarBotao.Name = "cadastrarBotao";
            this.cadastrarBotao.Size = new System.Drawing.Size(223, 64);
            this.cadastrarBotao.TabIndex = 6;
            this.cadastrarBotao.Text = "Cadastrar livro";
            this.cadastrarBotao.UseVisualStyleBackColor = true;
            this.cadastrarBotao.Click += new System.EventHandler(this.cadastrarBotao_Click);
            // 
            // paginasLabel
            // 
            this.paginasLabel.AutoSize = true;
            this.paginasLabel.Location = new System.Drawing.Point(40, 155);
            this.paginasLabel.Name = "paginasLabel";
            this.paginasLabel.Size = new System.Drawing.Size(182, 25);
            this.paginasLabel.TabIndex = 29;
            this.paginasLabel.Text = "Número de páginas:";
            // 
            // paginasTexto
            // 
            this.paginasTexto.BeepOnError = true;
            this.paginasTexto.ForeColor = System.Drawing.SystemColors.WindowText;
            this.paginasTexto.Location = new System.Drawing.Point(232, 155);
            this.paginasTexto.Name = "paginasTexto";
            this.paginasTexto.PromptChar = ' ';
            this.paginasTexto.Size = new System.Drawing.Size(223, 33);
            this.paginasTexto.TabIndex = 3;
            this.paginasTexto.ValidatingType = typeof(System.DateTime);
            // 
            // generoLista
            // 
            this.generoLista.CheckOnClick = true;
            this.generoLista.FormattingEnabled = true;
            this.generoLista.Location = new System.Drawing.Point(230, 284);
            this.generoLista.Name = "generoLista";
            this.generoLista.Size = new System.Drawing.Size(225, 116);
            this.generoLista.Sorted = true;
            this.generoLista.TabIndex = 5;
            // 
            // autorEditar
            // 
            this.autorEditar.AutoSize = true;
            this.autorEditar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autorEditar.Location = new System.Drawing.Point(365, 244);
            this.autorEditar.Name = "autorEditar";
            this.autorEditar.Size = new System.Drawing.Size(90, 17);
            this.autorEditar.TabIndex = 12;
            this.autorEditar.TabStop = true;
            this.autorEditar.Text = "editar autores";
            this.autorEditar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.autorEditar_LinkClicked);
            // 
            // generoAdicionar
            // 
            this.generoAdicionar.AutoSize = true;
            this.generoAdicionar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generoAdicionar.Location = new System.Drawing.Point(314, 403);
            this.generoAdicionar.Name = "generoAdicionar";
            this.generoAdicionar.Size = new System.Drawing.Size(141, 17);
            this.generoAdicionar.TabIndex = 16;
            this.generoAdicionar.TabStop = true;
            this.generoAdicionar.Text = "adicionar novo gênero";
            this.generoAdicionar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.generoAdicionar_LinkClicked);
            // 
            // TelaCadastroLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 544);
            this.Controls.Add(this.generoLista);
            this.Controls.Add(this.paginasLabel);
            this.Controls.Add(this.paginasTexto);
            this.Controls.Add(this.cadastrarBotao);
            this.Controls.Add(this.generoAdicionar);
            this.Controls.Add(this.generoLabel);
            this.Controls.Add(this.autoresLista);
            this.Controls.Add(this.autorEditar);
            this.Controls.Add(this.autorLabel);
            this.Controls.Add(this.anoLabel);
            this.Controls.Add(this.anoTexto);
            this.Controls.Add(this.tituloTexto);
            this.Controls.Add(this.tituloLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "TelaCadastroLivro";
            this.Text = "Cadastro de Livro";
            this.Activated += new System.EventHandler(this.TelaCadastroLivro_Activated);
            this.Load += new System.EventHandler(this.TelaCadastroLivro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label anoLabel;
        private System.Windows.Forms.MaskedTextBox anoTexto;
        private System.Windows.Forms.TextBox tituloTexto;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Label autorLabel;
        private System.Windows.Forms.ComboBox autoresLista;
        private System.Windows.Forms.Label generoLabel;
        private System.Windows.Forms.Button cadastrarBotao;
        private System.Windows.Forms.Label paginasLabel;
        private System.Windows.Forms.MaskedTextBox paginasTexto;
        private System.Windows.Forms.CheckedListBox generoLista;
        private System.Windows.Forms.LinkLabel autorEditar;
        private System.Windows.Forms.LinkLabel generoAdicionar;
    }
}