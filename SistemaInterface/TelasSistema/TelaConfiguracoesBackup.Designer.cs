
namespace SistemaInterface.TelasSistema
{
    partial class TelaConfiguracoesBackup
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
            this.intervaloLabel = new System.Windows.Forms.Label();
            this.intervaloApagarLabel = new System.Windows.Forms.Label();
            this.minutosTexto = new System.Windows.Forms.TextBox();
            this.diasTexto = new System.Windows.Forms.TextBox();
            this.diasLabel = new System.Windows.Forms.Label();
            this.minutosLabel = new System.Windows.Forms.Label();
            this.confirmarBotao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // intervaloLabel
            // 
            this.intervaloLabel.AutoSize = true;
            this.intervaloLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intervaloLabel.Location = new System.Drawing.Point(126, 48);
            this.intervaloLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.intervaloLabel.Name = "intervaloLabel";
            this.intervaloLabel.Size = new System.Drawing.Size(183, 25);
            this.intervaloLabel.TabIndex = 0;
            this.intervaloLabel.Text = "Intervalo do backup:";
            // 
            // intervaloApagarLabel
            // 
            this.intervaloApagarLabel.AutoSize = true;
            this.intervaloApagarLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intervaloApagarLabel.Location = new System.Drawing.Point(14, 97);
            this.intervaloApagarLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.intervaloApagarLabel.Name = "intervaloApagarLabel";
            this.intervaloApagarLabel.Size = new System.Drawing.Size(295, 25);
            this.intervaloApagarLabel.TabIndex = 1;
            this.intervaloApagarLabel.Text = "Intervalo da remoção de backups:";
            // 
            // minutosTexto
            // 
            this.minutosTexto.Location = new System.Drawing.Point(317, 48);
            this.minutosTexto.Name = "minutosTexto";
            this.minutosTexto.Size = new System.Drawing.Size(64, 33);
            this.minutosTexto.TabIndex = 1;
            // 
            // diasTexto
            // 
            this.diasTexto.Location = new System.Drawing.Point(317, 97);
            this.diasTexto.Name = "diasTexto";
            this.diasTexto.Size = new System.Drawing.Size(64, 33);
            this.diasTexto.TabIndex = 2;
            // 
            // diasLabel
            // 
            this.diasLabel.AutoSize = true;
            this.diasLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diasLabel.Location = new System.Drawing.Point(389, 97);
            this.diasLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.diasLabel.Name = "diasLabel";
            this.diasLabel.Size = new System.Drawing.Size(50, 25);
            this.diasLabel.TabIndex = 4;
            this.diasLabel.Text = "dias.";
            // 
            // minutosLabel
            // 
            this.minutosLabel.AutoSize = true;
            this.minutosLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutosLabel.Location = new System.Drawing.Point(389, 48);
            this.minutosLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.minutosLabel.Name = "minutosLabel";
            this.minutosLabel.Size = new System.Drawing.Size(84, 25);
            this.minutosLabel.TabIndex = 5;
            this.minutosLabel.Text = "minutos.";
            // 
            // confirmarBotao
            // 
            this.confirmarBotao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmarBotao.Location = new System.Drawing.Point(177, 163);
            this.confirmarBotao.Name = "confirmarBotao";
            this.confirmarBotao.Size = new System.Drawing.Size(156, 34);
            this.confirmarBotao.TabIndex = 3;
            this.confirmarBotao.Text = "Confirmar";
            this.confirmarBotao.UseVisualStyleBackColor = true;
            this.confirmarBotao.Click += new System.EventHandler(this.confirmarBotao_Click);
            // 
            // TelaConfiguracoesBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 233);
            this.Controls.Add(this.confirmarBotao);
            this.Controls.Add(this.minutosLabel);
            this.Controls.Add(this.diasLabel);
            this.Controls.Add(this.diasTexto);
            this.Controls.Add(this.minutosTexto);
            this.Controls.Add(this.intervaloApagarLabel);
            this.Controls.Add(this.intervaloLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "TelaConfiguracoesBackup";
            this.Text = "Configurações de backup";
            this.Load += new System.EventHandler(this.TelaConfiguracoesBackup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label intervaloLabel;
        private System.Windows.Forms.Label intervaloApagarLabel;
        private System.Windows.Forms.TextBox minutosTexto;
        private System.Windows.Forms.TextBox diasTexto;
        private System.Windows.Forms.Label diasLabel;
        private System.Windows.Forms.Label minutosLabel;
        private System.Windows.Forms.Button confirmarBotao;
    }
}