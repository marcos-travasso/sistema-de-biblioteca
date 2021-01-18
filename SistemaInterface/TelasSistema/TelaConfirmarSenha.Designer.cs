
namespace SistemaInterface
{
    partial class TelaConfirmarSenha
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
            this.confirmarLabel = new System.Windows.Forms.Label();
            this.confirmarBotao = new System.Windows.Forms.Button();
            this.senhaLabel = new System.Windows.Forms.Label();
            this.senhaTexto = new System.Windows.Forms.MaskedTextBox();
            this.cancelarBotao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // confirmarLabel
            // 
            this.confirmarLabel.AutoSize = true;
            this.confirmarLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmarLabel.Location = new System.Drawing.Point(114, 32);
            this.confirmarLabel.Name = "confirmarLabel";
            this.confirmarLabel.Size = new System.Drawing.Size(152, 25);
            this.confirmarLabel.TabIndex = 36;
            this.confirmarLabel.Text = "Confirmar senha";
            // 
            // confirmarBotao
            // 
            this.confirmarBotao.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmarBotao.Location = new System.Drawing.Point(208, 138);
            this.confirmarBotao.Name = "confirmarBotao";
            this.confirmarBotao.Size = new System.Drawing.Size(134, 35);
            this.confirmarBotao.TabIndex = 2;
            this.confirmarBotao.Text = "Confirmar";
            this.confirmarBotao.UseVisualStyleBackColor = true;
            this.confirmarBotao.Click += new System.EventHandler(this.confirmarBotao_Click);
            // 
            // senhaLabel
            // 
            this.senhaLabel.AutoSize = true;
            this.senhaLabel.Location = new System.Drawing.Point(43, 82);
            this.senhaLabel.Name = "senhaLabel";
            this.senhaLabel.Size = new System.Drawing.Size(68, 25);
            this.senhaLabel.TabIndex = 35;
            this.senhaLabel.Text = "Senha:";
            // 
            // senhaTexto
            // 
            this.senhaTexto.BeepOnError = true;
            this.senhaTexto.ForeColor = System.Drawing.SystemColors.WindowText;
            this.senhaTexto.Location = new System.Drawing.Point(119, 82);
            this.senhaTexto.Name = "senhaTexto";
            this.senhaTexto.PasswordChar = '•';
            this.senhaTexto.Size = new System.Drawing.Size(223, 33);
            this.senhaTexto.TabIndex = 1;
            this.senhaTexto.ValidatingType = typeof(System.DateTime);
            // 
            // cancelarBotao
            // 
            this.cancelarBotao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarBotao.Location = new System.Drawing.Point(48, 138);
            this.cancelarBotao.Name = "cancelarBotao";
            this.cancelarBotao.Size = new System.Drawing.Size(134, 35);
            this.cancelarBotao.TabIndex = 37;
            this.cancelarBotao.Text = "Cancelar";
            this.cancelarBotao.UseVisualStyleBackColor = true;
            this.cancelarBotao.Click += new System.EventHandler(this.cancelarBotao_Click);
            // 
            // TelaConfirmarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 205);
            this.Controls.Add(this.cancelarBotao);
            this.Controls.Add(this.confirmarLabel);
            this.Controls.Add(this.confirmarBotao);
            this.Controls.Add(this.senhaLabel);
            this.Controls.Add(this.senhaTexto);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "TelaConfirmarSenha";
            this.Text = "Confirmar senha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label confirmarLabel;
        private System.Windows.Forms.Button confirmarBotao;
        private System.Windows.Forms.Label senhaLabel;
        private System.Windows.Forms.MaskedTextBox senhaTexto;
        private System.Windows.Forms.Button cancelarBotao;
    }
}