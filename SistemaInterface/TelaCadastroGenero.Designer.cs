
namespace SistemaInterface
{
    partial class TelaCadastroGenero
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
            this.generoEditar = new System.Windows.Forms.LinkLabel();
            this.cadastrarBotao = new System.Windows.Forms.Button();
            this.generoTexto = new System.Windows.Forms.TextBox();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // generoEditar
            // 
            this.generoEditar.AutoSize = true;
            this.generoEditar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generoEditar.Location = new System.Drawing.Point(333, 179);
            this.generoEditar.Name = "generoEditar";
            this.generoEditar.Size = new System.Drawing.Size(94, 17);
            this.generoEditar.TabIndex = 32;
            this.generoEditar.TabStop = true;
            this.generoEditar.Text = "editar gêneros";
            // 
            // cadastrarBotao
            // 
            this.cadastrarBotao.Enabled = false;
            this.cadastrarBotao.Location = new System.Drawing.Point(200, 112);
            this.cadastrarBotao.Name = "cadastrarBotao";
            this.cadastrarBotao.Size = new System.Drawing.Size(223, 64);
            this.cadastrarBotao.TabIndex = 31;
            this.cadastrarBotao.Text = "Cadastrar gênero";
            this.cadastrarBotao.UseVisualStyleBackColor = true;
            // 
            // generoTexto
            // 
            this.generoTexto.Location = new System.Drawing.Point(200, 55);
            this.generoTexto.Name = "generoTexto";
            this.generoTexto.Size = new System.Drawing.Size(223, 33);
            this.generoTexto.TabIndex = 30;
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(35, 58);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(159, 25);
            this.nomeLabel.TabIndex = 29;
            this.nomeLabel.Text = "Nome do gênero:";
            // 
            // TelaCadastroGenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 227);
            this.Controls.Add(this.generoEditar);
            this.Controls.Add(this.cadastrarBotao);
            this.Controls.Add(this.generoTexto);
            this.Controls.Add(this.nomeLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "TelaCadastroGenero";
            this.Text = "Cadastrar Gênero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel generoEditar;
        private System.Windows.Forms.Button cadastrarBotao;
        private System.Windows.Forms.TextBox generoTexto;
        private System.Windows.Forms.Label nomeLabel;
    }
}