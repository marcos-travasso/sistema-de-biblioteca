
namespace SistemaInterface
{
    partial class TelaInformacoesGenero
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
            this.nomeTexto = new System.Windows.Forms.TextBox();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.idTexto = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.excluirBotao = new System.Windows.Forms.Button();
            this.editarBotao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nomeTexto
            // 
            this.nomeTexto.Location = new System.Drawing.Point(83, 84);
            this.nomeTexto.Name = "nomeTexto";
            this.nomeTexto.Size = new System.Drawing.Size(223, 33);
            this.nomeTexto.TabIndex = 1;
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(10, 84);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(67, 25);
            this.nomeLabel.TabIndex = 30;
            this.nomeLabel.Text = "Nome:";
            // 
            // idTexto
            // 
            this.idTexto.Location = new System.Drawing.Point(83, 36);
            this.idTexto.Name = "idTexto";
            this.idTexto.ReadOnly = true;
            this.idTexto.Size = new System.Drawing.Size(223, 33);
            this.idTexto.TabIndex = 31;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(43, 36);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(34, 25);
            this.idLabel.TabIndex = 32;
            this.idLabel.Text = "ID:";
            // 
            // excluirBotao
            // 
            this.excluirBotao.Location = new System.Drawing.Point(83, 228);
            this.excluirBotao.Name = "excluirBotao";
            this.excluirBotao.Size = new System.Drawing.Size(223, 64);
            this.excluirBotao.TabIndex = 3;
            this.excluirBotao.Text = "Excluir gênero";
            this.excluirBotao.UseVisualStyleBackColor = true;
            this.excluirBotao.Click += new System.EventHandler(this.excluirBotao_Click);
            // 
            // editarBotao
            // 
            this.editarBotao.Location = new System.Drawing.Point(83, 151);
            this.editarBotao.Name = "editarBotao";
            this.editarBotao.Size = new System.Drawing.Size(223, 64);
            this.editarBotao.TabIndex = 2;
            this.editarBotao.Text = "Editar gênero";
            this.editarBotao.UseVisualStyleBackColor = true;
            this.editarBotao.Click += new System.EventHandler(this.editarBotao_Click);
            // 
            // TelaInformacoesGenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 321);
            this.Controls.Add(this.excluirBotao);
            this.Controls.Add(this.editarBotao);
            this.Controls.Add(this.idTexto);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.nomeTexto);
            this.Controls.Add(this.nomeLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "TelaInformacoesGenero";
            this.Text = "Informações do gênero";
            this.Load += new System.EventHandler(this.TelaInformacoesGenero_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nomeTexto;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.TextBox idTexto;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Button excluirBotao;
        private System.Windows.Forms.Button editarBotao;
    }
}