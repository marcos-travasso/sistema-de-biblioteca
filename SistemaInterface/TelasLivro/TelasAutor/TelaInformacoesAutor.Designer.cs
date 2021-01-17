
namespace SistemaInterface
{
    partial class TelaInformacoesAutor
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
            this.editarBotao = new System.Windows.Forms.Button();
            this.generoTexto = new System.Windows.Forms.ComboBox();
            this.generoLabel = new System.Windows.Forms.Label();
            this.nascimentoLabel = new System.Windows.Forms.Label();
            this.nascimentoTexto = new System.Windows.Forms.MaskedTextBox();
            this.nomeTexto = new System.Windows.Forms.TextBox();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.excluirBotao = new System.Windows.Forms.Button();
            this.idLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // editarBotao
            // 
            this.editarBotao.Location = new System.Drawing.Point(167, 207);
            this.editarBotao.Name = "editarBotao";
            this.editarBotao.Size = new System.Drawing.Size(223, 64);
            this.editarBotao.TabIndex = 32;
            this.editarBotao.Text = "Editar autor";
            this.editarBotao.UseVisualStyleBackColor = true;
            this.editarBotao.Click += new System.EventHandler(this.editarBotao_Click);
            // 
            // generoTexto
            // 
            this.generoTexto.AutoCompleteCustomSource.AddRange(new string[] {
            "Masculino",
            "Feminino",
            "Outro"});
            this.generoTexto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.generoTexto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.generoTexto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.generoTexto.FormattingEnabled = true;
            this.generoTexto.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outro"});
            this.generoTexto.Location = new System.Drawing.Point(167, 153);
            this.generoTexto.Name = "generoTexto";
            this.generoTexto.Size = new System.Drawing.Size(223, 33);
            this.generoTexto.TabIndex = 31;
            this.generoTexto.Tag = "";
            // 
            // generoLabel
            // 
            this.generoLabel.AutoSize = true;
            this.generoLabel.Location = new System.Drawing.Point(83, 153);
            this.generoLabel.Name = "generoLabel";
            this.generoLabel.Size = new System.Drawing.Size(78, 25);
            this.generoLabel.TabIndex = 35;
            this.generoLabel.Text = "Gênero:";
            // 
            // nascimentoLabel
            // 
            this.nascimentoLabel.AutoSize = true;
            this.nascimentoLabel.Location = new System.Drawing.Point(45, 106);
            this.nascimentoLabel.Name = "nascimentoLabel";
            this.nascimentoLabel.Size = new System.Drawing.Size(116, 25);
            this.nascimentoLabel.TabIndex = 34;
            this.nascimentoLabel.Text = "Nascimento:";
            // 
            // nascimentoTexto
            // 
            this.nascimentoTexto.BeepOnError = true;
            this.nascimentoTexto.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nascimentoTexto.Location = new System.Drawing.Point(167, 103);
            this.nascimentoTexto.Mask = "00/00/0000";
            this.nascimentoTexto.Name = "nascimentoTexto";
            this.nascimentoTexto.Size = new System.Drawing.Size(223, 33);
            this.nascimentoTexto.TabIndex = 30;
            this.nascimentoTexto.ValidatingType = typeof(System.DateTime);
            // 
            // nomeTexto
            // 
            this.nomeTexto.Location = new System.Drawing.Point(167, 54);
            this.nomeTexto.Name = "nomeTexto";
            this.nomeTexto.Size = new System.Drawing.Size(223, 33);
            this.nomeTexto.TabIndex = 29;
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(94, 57);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(67, 25);
            this.nomeLabel.TabIndex = 33;
            this.nomeLabel.Text = "Nome:";
            // 
            // excluirBotao
            // 
            this.excluirBotao.Location = new System.Drawing.Point(167, 277);
            this.excluirBotao.Name = "excluirBotao";
            this.excluirBotao.Size = new System.Drawing.Size(223, 64);
            this.excluirBotao.TabIndex = 36;
            this.excluirBotao.Text = "Excluir autor";
            this.excluirBotao.UseVisualStyleBackColor = true;
            this.excluirBotao.Click += new System.EventHandler(this.excluirBotao_Click);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(125, 9);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(185, 32);
            this.idLabel.TabIndex = 59;
            this.idLabel.Text = "Autor número:";
            // 
            // TelaInformacoesAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 370);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.excluirBotao);
            this.Controls.Add(this.editarBotao);
            this.Controls.Add(this.generoTexto);
            this.Controls.Add(this.generoLabel);
            this.Controls.Add(this.nascimentoLabel);
            this.Controls.Add(this.nascimentoTexto);
            this.Controls.Add(this.nomeTexto);
            this.Controls.Add(this.nomeLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "TelaInformacoesAutor";
            this.Text = "Informações do autor";
            this.Load += new System.EventHandler(this.TelaInformacoesAutor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editarBotao;
        private System.Windows.Forms.ComboBox generoTexto;
        private System.Windows.Forms.Label generoLabel;
        private System.Windows.Forms.Label nascimentoLabel;
        private System.Windows.Forms.MaskedTextBox nascimentoTexto;
        private System.Windows.Forms.TextBox nomeTexto;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.Button excluirBotao;
        private System.Windows.Forms.Label idLabel;
    }
}