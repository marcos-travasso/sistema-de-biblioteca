
namespace SistemaInterface
{
    partial class TelaConfirmarEmprestimo
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
            this.dataLabel = new System.Windows.Forms.Label();
            this.emprestarBotao = new System.Windows.Forms.Button();
            this.livroLabel = new System.Windows.Forms.Label();
            this.livroTexto = new System.Windows.Forms.MaskedTextBox();
            this.usuarioTexto = new System.Windows.Forms.TextBox();
            this.usuarioLabel = new System.Windows.Forms.Label();
            this.dataConfirmarLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelarBotao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dataLabel
            // 
            this.dataLabel.AutoSize = true;
            this.dataLabel.Location = new System.Drawing.Point(135, 205);
            this.dataLabel.Name = "dataLabel";
            this.dataLabel.Size = new System.Drawing.Size(130, 25);
            this.dataLabel.TabIndex = 29;
            this.dataLabel.Text = "Para devolver:";
            // 
            // emprestarBotao
            // 
            this.emprestarBotao.Location = new System.Drawing.Point(284, 268);
            this.emprestarBotao.Name = "emprestarBotao";
            this.emprestarBotao.Size = new System.Drawing.Size(223, 64);
            this.emprestarBotao.TabIndex = 23;
            this.emprestarBotao.Text = "Confirmar";
            this.emprestarBotao.UseVisualStyleBackColor = true;
            this.emprestarBotao.Click += new System.EventHandler(this.emprestarBotao_Click);
            // 
            // livroLabel
            // 
            this.livroLabel.AutoSize = true;
            this.livroLabel.Location = new System.Drawing.Point(208, 136);
            this.livroLabel.Name = "livroLabel";
            this.livroLabel.Size = new System.Drawing.Size(57, 25);
            this.livroLabel.TabIndex = 25;
            this.livroLabel.Text = "Livro:";
            // 
            // livroTexto
            // 
            this.livroTexto.BeepOnError = true;
            this.livroTexto.ForeColor = System.Drawing.SystemColors.WindowText;
            this.livroTexto.Location = new System.Drawing.Point(284, 136);
            this.livroTexto.Name = "livroTexto";
            this.livroTexto.ReadOnly = true;
            this.livroTexto.Size = new System.Drawing.Size(223, 33);
            this.livroTexto.TabIndex = 22;
            this.livroTexto.ValidatingType = typeof(System.DateTime);
            // 
            // usuarioTexto
            // 
            this.usuarioTexto.Location = new System.Drawing.Point(284, 71);
            this.usuarioTexto.Name = "usuarioTexto";
            this.usuarioTexto.ReadOnly = true;
            this.usuarioTexto.Size = new System.Drawing.Size(223, 33);
            this.usuarioTexto.TabIndex = 21;
            // 
            // usuarioLabel
            // 
            this.usuarioLabel.AutoSize = true;
            this.usuarioLabel.Location = new System.Drawing.Point(184, 71);
            this.usuarioLabel.Name = "usuarioLabel";
            this.usuarioLabel.Size = new System.Drawing.Size(81, 25);
            this.usuarioLabel.TabIndex = 24;
            this.usuarioLabel.Text = "Usuário:";
            // 
            // dataConfirmarLabel
            // 
            this.dataConfirmarLabel.AutoSize = true;
            this.dataConfirmarLabel.Location = new System.Drawing.Point(299, 205);
            this.dataConfirmarLabel.Name = "dataConfirmarLabel";
            this.dataConfirmarLabel.Size = new System.Drawing.Size(192, 25);
            this.dataConfirmarLabel.TabIndex = 30;
            this.dataConfirmarLabel.Text = "XX/XX/XXXX (XX dias)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "Confirmar empréstimo";
            // 
            // cancelarBotao
            // 
            this.cancelarBotao.Location = new System.Drawing.Point(42, 268);
            this.cancelarBotao.Name = "cancelarBotao";
            this.cancelarBotao.Size = new System.Drawing.Size(223, 64);
            this.cancelarBotao.TabIndex = 32;
            this.cancelarBotao.Text = "Cancelar";
            this.cancelarBotao.UseVisualStyleBackColor = true;
            this.cancelarBotao.Click += new System.EventHandler(this.cancelarBotao_Click);
            // 
            // TelaConfirmarEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 374);
            this.Controls.Add(this.cancelarBotao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataConfirmarLabel);
            this.Controls.Add(this.dataLabel);
            this.Controls.Add(this.emprestarBotao);
            this.Controls.Add(this.livroLabel);
            this.Controls.Add(this.livroTexto);
            this.Controls.Add(this.usuarioTexto);
            this.Controls.Add(this.usuarioLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "TelaConfirmarEmprestimo";
            this.Text = "Confirmar empréstimo";
            this.Load += new System.EventHandler(this.TelaConfirmarEmprestimo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dataLabel;
        private System.Windows.Forms.Button emprestarBotao;
        private System.Windows.Forms.Label livroLabel;
        private System.Windows.Forms.MaskedTextBox livroTexto;
        private System.Windows.Forms.TextBox usuarioTexto;
        private System.Windows.Forms.Label usuarioLabel;
        private System.Windows.Forms.Label dataConfirmarLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelarBotao;
    }
}