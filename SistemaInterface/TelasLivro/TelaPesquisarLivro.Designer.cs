
namespace SistemaInterface.TelasLivro
{
    partial class TelaPesquisarLivro
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
            this.pesquisarBotao = new System.Windows.Forms.Button();
            this.generoLabel = new System.Windows.Forms.Label();
            this.autoresLista = new System.Windows.Forms.ComboBox();
            this.autorLabel = new System.Windows.Forms.Label();
            this.tituloTexto = new System.Windows.Forms.TextBox();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // generoLista
            // 
            this.generoLista.CheckOnClick = true;
            this.generoLista.FormattingEnabled = true;
            this.generoLista.Location = new System.Drawing.Point(218, 163);
            this.generoLista.Name = "generoLista";
            this.generoLista.Size = new System.Drawing.Size(225, 116);
            this.generoLista.Sorted = true;
            this.generoLista.TabIndex = 34;
            // 
            // pesquisarBotao
            // 
            this.pesquisarBotao.Location = new System.Drawing.Point(220, 324);
            this.pesquisarBotao.Name = "pesquisarBotao";
            this.pesquisarBotao.Size = new System.Drawing.Size(223, 64);
            this.pesquisarBotao.TabIndex = 35;
            this.pesquisarBotao.Text = "Pesquisar livros";
            this.pesquisarBotao.UseVisualStyleBackColor = true;
            this.pesquisarBotao.Click += new System.EventHandler(this.pesquisarBotao_Click);
            // 
            // generoLabel
            // 
            this.generoLabel.AutoSize = true;
            this.generoLabel.Location = new System.Drawing.Point(113, 164);
            this.generoLabel.Name = "generoLabel";
            this.generoLabel.Size = new System.Drawing.Size(98, 25);
            this.generoLabel.TabIndex = 40;
            this.generoLabel.Text = "Gênero(s):";
            // 
            // autoresLista
            // 
            this.autoresLista.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.autoresLista.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.autoresLista.FormattingEnabled = true;
            this.autoresLista.Location = new System.Drawing.Point(218, 107);
            this.autoresLista.Name = "autoresLista";
            this.autoresLista.Size = new System.Drawing.Size(225, 33);
            this.autoresLista.Sorted = true;
            this.autoresLista.TabIndex = 33;
            // 
            // autorLabel
            // 
            this.autorLabel.AutoSize = true;
            this.autorLabel.Location = new System.Drawing.Point(148, 107);
            this.autorLabel.Name = "autorLabel";
            this.autorLabel.Size = new System.Drawing.Size(63, 25);
            this.autorLabel.TabIndex = 38;
            this.autorLabel.Text = "Autor:";
            // 
            // tituloTexto
            // 
            this.tituloTexto.Location = new System.Drawing.Point(220, 50);
            this.tituloTexto.Name = "tituloTexto";
            this.tituloTexto.Size = new System.Drawing.Size(223, 33);
            this.tituloTexto.TabIndex = 30;
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Location = new System.Drawing.Point(150, 50);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(64, 25);
            this.tituloLabel.TabIndex = 36;
            this.tituloLabel.Text = "Título:";
            // 
            // TelaPesquisarLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 430);
            this.Controls.Add(this.generoLista);
            this.Controls.Add(this.pesquisarBotao);
            this.Controls.Add(this.generoLabel);
            this.Controls.Add(this.autoresLista);
            this.Controls.Add(this.autorLabel);
            this.Controls.Add(this.tituloTexto);
            this.Controls.Add(this.tituloLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "TelaPesquisarLivro";
            this.Text = "Pesquisar livros";
            this.Load += new System.EventHandler(this.TelaPesquisarLivro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox generoLista;
        private System.Windows.Forms.Button pesquisarBotao;
        private System.Windows.Forms.Label generoLabel;
        private System.Windows.Forms.ComboBox autoresLista;
        private System.Windows.Forms.Label autorLabel;
        private System.Windows.Forms.TextBox tituloTexto;
        private System.Windows.Forms.Label tituloLabel;
    }
}