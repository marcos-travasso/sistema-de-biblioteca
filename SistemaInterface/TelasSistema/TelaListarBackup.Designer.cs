
namespace SistemaInterface.TelasSistema
{
    partial class TelaListarBackup
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
            this.pastasLista = new System.Windows.Forms.ListBox();
            this.selecionarBotao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pastasLista
            // 
            this.pastasLista.FormattingEnabled = true;
            this.pastasLista.ItemHeight = 17;
            this.pastasLista.Location = new System.Drawing.Point(39, 36);
            this.pastasLista.Name = "pastasLista";
            this.pastasLista.Size = new System.Drawing.Size(223, 276);
            this.pastasLista.TabIndex = 0;
            // 
            // selecionarBotao
            // 
            this.selecionarBotao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selecionarBotao.Location = new System.Drawing.Point(39, 336);
            this.selecionarBotao.Name = "selecionarBotao";
            this.selecionarBotao.Size = new System.Drawing.Size(223, 64);
            this.selecionarBotao.TabIndex = 38;
            this.selecionarBotao.Text = "Selecionar pasta";
            this.selecionarBotao.UseVisualStyleBackColor = true;
            this.selecionarBotao.Click += new System.EventHandler(this.selecionarBotao_Click);
            // 
            // TelaListarBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 433);
            this.Controls.Add(this.selecionarBotao);
            this.Controls.Add(this.pastasLista);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "TelaListarBackup";
            this.Text = "Selecionar pasta de backup";
            this.Load += new System.EventHandler(this.TelaSelecionarPasta_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox pastasLista;
        private System.Windows.Forms.Button selecionarBotao;
    }
}