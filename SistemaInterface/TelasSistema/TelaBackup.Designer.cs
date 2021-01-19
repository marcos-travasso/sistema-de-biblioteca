
namespace SistemaInterface.TelasSistema
{
    partial class TelaBackup
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
            this.fazerBotao = new System.Windows.Forms.Button();
            this.abrirBotao = new System.Windows.Forms.Button();
            this.configBotao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fazerBotao
            // 
            this.fazerBotao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fazerBotao.Location = new System.Drawing.Point(87, 137);
            this.fazerBotao.Name = "fazerBotao";
            this.fazerBotao.Size = new System.Drawing.Size(223, 64);
            this.fazerBotao.TabIndex = 37;
            this.fazerBotao.Text = "Fazer backup";
            this.fazerBotao.UseVisualStyleBackColor = true;
            this.fazerBotao.Click += new System.EventHandler(this.fazerBotao_Click);
            // 
            // abrirBotao
            // 
            this.abrirBotao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abrirBotao.Location = new System.Drawing.Point(87, 222);
            this.abrirBotao.Name = "abrirBotao";
            this.abrirBotao.Size = new System.Drawing.Size(223, 64);
            this.abrirBotao.TabIndex = 39;
            this.abrirBotao.Text = "Abrir um backup";
            this.abrirBotao.UseVisualStyleBackColor = true;
            this.abrirBotao.Click += new System.EventHandler(this.abrirBotao_Click);
            // 
            // configBotao
            // 
            this.configBotao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configBotao.Location = new System.Drawing.Point(87, 53);
            this.configBotao.Name = "configBotao";
            this.configBotao.Size = new System.Drawing.Size(223, 64);
            this.configBotao.TabIndex = 38;
            this.configBotao.Text = "Configurações do Drive";
            this.configBotao.UseVisualStyleBackColor = true;
            this.configBotao.Click += new System.EventHandler(this.configBotao_Click);
            // 
            // TelaBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 356);
            this.Controls.Add(this.abrirBotao);
            this.Controls.Add(this.configBotao);
            this.Controls.Add(this.fazerBotao);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "TelaBackup";
            this.Text = "Backup";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button fazerBotao;
        private System.Windows.Forms.Button abrirBotao;
        private System.Windows.Forms.Button configBotao;
    }
}