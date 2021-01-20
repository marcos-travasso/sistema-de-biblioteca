
namespace SistemaInterface
{
    partial class TelaFazerEmprestimo
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
            this.emprestarBotao = new System.Windows.Forms.Button();
            this.idLivroLabel = new System.Windows.Forms.Label();
            this.idLivroTexto = new System.Windows.Forms.MaskedTextBox();
            this.idUsuarioTexto = new System.Windows.Forms.TextBox();
            this.idUsuarioLabel = new System.Windows.Forms.Label();
            this.listaUsuariosLink = new System.Windows.Forms.LinkLabel();
            this.procurarLivrosLink = new System.Windows.Forms.LinkLabel();
            this.devolucaoData = new System.Windows.Forms.DateTimePicker();
            this.devolucaoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // emprestarBotao
            // 
            this.emprestarBotao.Location = new System.Drawing.Point(204, 232);
            this.emprestarBotao.Name = "emprestarBotao";
            this.emprestarBotao.Size = new System.Drawing.Size(223, 64);
            this.emprestarBotao.TabIndex = 4;
            this.emprestarBotao.Text = "Emprestar livro";
            this.emprestarBotao.UseVisualStyleBackColor = true;
            this.emprestarBotao.Click += new System.EventHandler(this.emprestarBotao_Click);
            // 
            // idLivroLabel
            // 
            this.idLivroLabel.AutoSize = true;
            this.idLivroLabel.Location = new System.Drawing.Point(82, 100);
            this.idLivroLabel.Name = "idLivroLabel";
            this.idLivroLabel.Size = new System.Drawing.Size(103, 25);
            this.idLivroLabel.TabIndex = 16;
            this.idLivroLabel.Text = "ID do livro:";
            // 
            // idLivroTexto
            // 
            this.idLivroTexto.BeepOnError = true;
            this.idLivroTexto.ForeColor = System.Drawing.SystemColors.WindowText;
            this.idLivroTexto.Location = new System.Drawing.Point(204, 100);
            this.idLivroTexto.Name = "idLivroTexto";
            this.idLivroTexto.Size = new System.Drawing.Size(223, 33);
            this.idLivroTexto.TabIndex = 2;
            this.idLivroTexto.ValidatingType = typeof(System.DateTime);
            // 
            // idUsuarioTexto
            // 
            this.idUsuarioTexto.Location = new System.Drawing.Point(204, 35);
            this.idUsuarioTexto.Name = "idUsuarioTexto";
            this.idUsuarioTexto.Size = new System.Drawing.Size(223, 33);
            this.idUsuarioTexto.TabIndex = 1;
            // 
            // idUsuarioLabel
            // 
            this.idUsuarioLabel.AutoSize = true;
            this.idUsuarioLabel.Location = new System.Drawing.Point(56, 35);
            this.idUsuarioLabel.Name = "idUsuarioLabel";
            this.idUsuarioLabel.Size = new System.Drawing.Size(129, 25);
            this.idUsuarioLabel.TabIndex = 15;
            this.idUsuarioLabel.Text = "ID do usuário:";
            // 
            // listaUsuariosLink
            // 
            this.listaUsuariosLink.AutoSize = true;
            this.listaUsuariosLink.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaUsuariosLink.Location = new System.Drawing.Point(324, 71);
            this.listaUsuariosLink.Name = "listaUsuariosLink";
            this.listaUsuariosLink.Size = new System.Drawing.Size(103, 17);
            this.listaUsuariosLink.TabIndex = 17;
            this.listaUsuariosLink.TabStop = true;
            this.listaUsuariosLink.Text = "lista de usuários";
            this.listaUsuariosLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.listaUsuariosLink_LinkClicked);
            // 
            // procurarLivrosLink
            // 
            this.procurarLivrosLink.AutoSize = true;
            this.procurarLivrosLink.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.procurarLivrosLink.Location = new System.Drawing.Point(333, 136);
            this.procurarLivrosLink.Name = "procurarLivrosLink";
            this.procurarLivrosLink.Size = new System.Drawing.Size(94, 17);
            this.procurarLivrosLink.TabIndex = 18;
            this.procurarLivrosLink.TabStop = true;
            this.procurarLivrosLink.Text = "procurar livros";
            this.procurarLivrosLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.listaLivrosLink_LinkClicked);
            // 
            // devolucaoData
            // 
            this.devolucaoData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.devolucaoData.Location = new System.Drawing.Point(204, 169);
            this.devolucaoData.Name = "devolucaoData";
            this.devolucaoData.Size = new System.Drawing.Size(223, 33);
            this.devolucaoData.TabIndex = 3;
            // 
            // devolucaoLabel
            // 
            this.devolucaoLabel.AutoSize = true;
            this.devolucaoLabel.Location = new System.Drawing.Point(12, 169);
            this.devolucaoLabel.Name = "devolucaoLabel";
            this.devolucaoLabel.Size = new System.Drawing.Size(173, 25);
            this.devolucaoLabel.TabIndex = 20;
            this.devolucaoLabel.Text = "Data de devolução:";
            // 
            // TelaFazerEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 337);
            this.Controls.Add(this.devolucaoLabel);
            this.Controls.Add(this.devolucaoData);
            this.Controls.Add(this.procurarLivrosLink);
            this.Controls.Add(this.listaUsuariosLink);
            this.Controls.Add(this.emprestarBotao);
            this.Controls.Add(this.idLivroLabel);
            this.Controls.Add(this.idLivroTexto);
            this.Controls.Add(this.idUsuarioTexto);
            this.Controls.Add(this.idUsuarioLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "TelaFazerEmprestimo";
            this.Text = "Novo Empréstimo";
            this.Load += new System.EventHandler(this.TelaFazerEmprestimo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button emprestarBotao;
        private System.Windows.Forms.Label idLivroLabel;
        private System.Windows.Forms.MaskedTextBox idLivroTexto;
        private System.Windows.Forms.TextBox idUsuarioTexto;
        private System.Windows.Forms.Label idUsuarioLabel;
        private System.Windows.Forms.LinkLabel listaUsuariosLink;
        private System.Windows.Forms.LinkLabel procurarLivrosLink;
        private System.Windows.Forms.DateTimePicker devolucaoData;
        private System.Windows.Forms.Label devolucaoLabel;
    }
}