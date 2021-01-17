
namespace SistemaInterface
{
    partial class TelaCadastroAutor
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
            this.generoTexto = new System.Windows.Forms.ComboBox();
            this.generoLabel = new System.Windows.Forms.Label();
            this.nascimentoLabel = new System.Windows.Forms.Label();
            this.nascimentoTexto = new System.Windows.Forms.MaskedTextBox();
            this.nomeTexto = new System.Windows.Forms.TextBox();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.cadastrarBotao = new System.Windows.Forms.Button();
            this.autorEditar = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
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
            this.generoTexto.Location = new System.Drawing.Point(160, 155);
            this.generoTexto.Name = "generoTexto";
            this.generoTexto.Size = new System.Drawing.Size(223, 33);
            this.generoTexto.TabIndex = 3;
            this.generoTexto.Tag = "";
            // 
            // generoLabel
            // 
            this.generoLabel.AutoSize = true;
            this.generoLabel.Location = new System.Drawing.Point(76, 155);
            this.generoLabel.Name = "generoLabel";
            this.generoLabel.Size = new System.Drawing.Size(78, 25);
            this.generoLabel.TabIndex = 12;
            this.generoLabel.Text = "Gênero:";
            // 
            // nascimentoLabel
            // 
            this.nascimentoLabel.AutoSize = true;
            this.nascimentoLabel.Location = new System.Drawing.Point(38, 108);
            this.nascimentoLabel.Name = "nascimentoLabel";
            this.nascimentoLabel.Size = new System.Drawing.Size(116, 25);
            this.nascimentoLabel.TabIndex = 11;
            this.nascimentoLabel.Text = "Nascimento:";
            // 
            // nascimentoTexto
            // 
            this.nascimentoTexto.BeepOnError = true;
            this.nascimentoTexto.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nascimentoTexto.Location = new System.Drawing.Point(160, 105);
            this.nascimentoTexto.Mask = "00/00/0000";
            this.nascimentoTexto.Name = "nascimentoTexto";
            this.nascimentoTexto.Size = new System.Drawing.Size(223, 33);
            this.nascimentoTexto.TabIndex = 2;
            this.nascimentoTexto.ValidatingType = typeof(System.DateTime);
            // 
            // nomeTexto
            // 
            this.nomeTexto.Location = new System.Drawing.Point(160, 56);
            this.nomeTexto.Name = "nomeTexto";
            this.nomeTexto.Size = new System.Drawing.Size(223, 33);
            this.nomeTexto.TabIndex = 1;
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(87, 59);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(67, 25);
            this.nomeLabel.TabIndex = 7;
            this.nomeLabel.Text = "Nome:";
            // 
            // cadastrarBotao
            // 
            this.cadastrarBotao.Location = new System.Drawing.Point(160, 209);
            this.cadastrarBotao.Name = "cadastrarBotao";
            this.cadastrarBotao.Size = new System.Drawing.Size(223, 64);
            this.cadastrarBotao.TabIndex = 4;
            this.cadastrarBotao.Text = "Cadastrar autor";
            this.cadastrarBotao.UseVisualStyleBackColor = true;
            this.cadastrarBotao.Click += new System.EventHandler(this.cadastrarBotao_Click);
            // 
            // autorEditar
            // 
            this.autorEditar.AutoSize = true;
            this.autorEditar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autorEditar.Location = new System.Drawing.Point(293, 276);
            this.autorEditar.Name = "autorEditar";
            this.autorEditar.Size = new System.Drawing.Size(90, 17);
            this.autorEditar.TabIndex = 28;
            this.autorEditar.TabStop = true;
            this.autorEditar.Text = "editar autores";
            this.autorEditar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.autorEditar_LinkClicked);
            // 
            // TelaCadastroAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 345);
            this.Controls.Add(this.autorEditar);
            this.Controls.Add(this.cadastrarBotao);
            this.Controls.Add(this.generoTexto);
            this.Controls.Add(this.generoLabel);
            this.Controls.Add(this.nascimentoLabel);
            this.Controls.Add(this.nascimentoTexto);
            this.Controls.Add(this.nomeTexto);
            this.Controls.Add(this.nomeLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "TelaCadastroAutor";
            this.Text = "Cadastro de Autor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox generoTexto;
        private System.Windows.Forms.Label generoLabel;
        private System.Windows.Forms.Label nascimentoLabel;
        private System.Windows.Forms.MaskedTextBox nascimentoTexto;
        private System.Windows.Forms.TextBox nomeTexto;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.Button cadastrarBotao;
        private System.Windows.Forms.LinkLabel autorEditar;
    }
}