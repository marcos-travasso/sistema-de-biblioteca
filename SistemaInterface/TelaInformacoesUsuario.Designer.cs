
namespace SistemaInterface
{
    partial class TelaInformacoesUsuario
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
            this.emailTexto = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.historicoBotao = new System.Windows.Forms.Button();
            this.responsavelPanel = new System.Windows.Forms.Panel();
            this.responsavelLabel = new System.Windows.Forms.Label();
            this.generoResponsavelTexto = new System.Windows.Forms.ComboBox();
            this.nomeResponsavelTexto = new System.Windows.Forms.TextBox();
            this.generoResponsavelLabel = new System.Windows.Forms.Label();
            this.nomeResponsavelLabel = new System.Windows.Forms.Label();
            this.nascimentoResponsavelLabel = new System.Windows.Forms.Label();
            this.nascimentoResponsavelTexto = new System.Windows.Forms.MaskedTextBox();
            this.complementoLabel = new System.Windows.Forms.Label();
            this.complementoTexto = new System.Windows.Forms.MaskedTextBox();
            this.cepLabel = new System.Windows.Forms.Label();
            this.cepTexto = new System.Windows.Forms.MaskedTextBox();
            this.numeroLabel = new System.Windows.Forms.Label();
            this.ruaTexto = new System.Windows.Forms.MaskedTextBox();
            this.ruaLabel = new System.Windows.Forms.Label();
            this.bairroTexto = new System.Windows.Forms.MaskedTextBox();
            this.bairroLabel = new System.Windows.Forms.Label();
            this.cidadeTexto = new System.Windows.Forms.MaskedTextBox();
            this.cidadeLabel = new System.Windows.Forms.Label();
            this.numeroTexto = new System.Windows.Forms.MaskedTextBox();
            this.generoTexto = new System.Windows.Forms.ComboBox();
            this.cpfLabel = new System.Windows.Forms.Label();
            this.cpfTexto = new System.Windows.Forms.MaskedTextBox();
            this.telefoneLabel = new System.Windows.Forms.Label();
            this.telefoneTexto = new System.Windows.Forms.MaskedTextBox();
            this.celularLabel = new System.Windows.Forms.Label();
            this.generoLabel = new System.Windows.Forms.Label();
            this.nascimentoLabel = new System.Windows.Forms.Label();
            this.celularTexto = new System.Windows.Forms.MaskedTextBox();
            this.nascimentoTexto = new System.Windows.Forms.MaskedTextBox();
            this.nomeTexto = new System.Windows.Forms.TextBox();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.editarBotao = new System.Windows.Forms.Button();
            this.excluirBotao = new System.Windows.Forms.Button();
            this.idLabel = new System.Windows.Forms.Label();
            this.responsavelPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // emailTexto
            // 
            this.emailTexto.Location = new System.Drawing.Point(158, 358);
            this.emailTexto.Name = "emailTexto";
            this.emailTexto.Size = new System.Drawing.Size(223, 33);
            this.emailTexto.TabIndex = 7;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(90, 360);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(62, 25);
            this.emailLabel.TabIndex = 55;
            this.emailLabel.Text = "Email:";
            // 
            // historicoBotao
            // 
            this.historicoBotao.Location = new System.Drawing.Point(592, 369);
            this.historicoBotao.Name = "historicoBotao";
            this.historicoBotao.Size = new System.Drawing.Size(223, 64);
            this.historicoBotao.TabIndex = 48;
            this.historicoBotao.Text = "Histórico do usuário";
            this.historicoBotao.UseVisualStyleBackColor = true;
            // 
            // responsavelPanel
            // 
            this.responsavelPanel.Controls.Add(this.responsavelLabel);
            this.responsavelPanel.Controls.Add(this.generoResponsavelTexto);
            this.responsavelPanel.Controls.Add(this.nomeResponsavelTexto);
            this.responsavelPanel.Controls.Add(this.generoResponsavelLabel);
            this.responsavelPanel.Controls.Add(this.nomeResponsavelLabel);
            this.responsavelPanel.Controls.Add(this.nascimentoResponsavelLabel);
            this.responsavelPanel.Controls.Add(this.nascimentoResponsavelTexto);
            this.responsavelPanel.Location = new System.Drawing.Point(28, 422);
            this.responsavelPanel.Name = "responsavelPanel";
            this.responsavelPanel.Size = new System.Drawing.Size(353, 192);
            this.responsavelPanel.TabIndex = 54;
            this.responsavelPanel.Visible = false;
            // 
            // responsavelLabel
            // 
            this.responsavelLabel.AutoSize = true;
            this.responsavelLabel.Location = new System.Drawing.Point(92, 3);
            this.responsavelLabel.Name = "responsavelLabel";
            this.responsavelLabel.Size = new System.Drawing.Size(200, 25);
            this.responsavelLabel.TabIndex = 26;
            this.responsavelLabel.Text = "Dados do Responsável";
            // 
            // generoResponsavelTexto
            // 
            this.generoResponsavelTexto.AutoCompleteCustomSource.AddRange(new string[] {
            "Masculino",
            "Feminino",
            "Outro"});
            this.generoResponsavelTexto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.generoResponsavelTexto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.generoResponsavelTexto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.generoResponsavelTexto.FormattingEnabled = true;
            this.generoResponsavelTexto.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outro"});
            this.generoResponsavelTexto.Location = new System.Drawing.Point(127, 138);
            this.generoResponsavelTexto.Name = "generoResponsavelTexto";
            this.generoResponsavelTexto.Size = new System.Drawing.Size(223, 33);
            this.generoResponsavelTexto.TabIndex = 29;
            this.generoResponsavelTexto.Tag = "";
            // 
            // nomeResponsavelTexto
            // 
            this.nomeResponsavelTexto.Location = new System.Drawing.Point(127, 39);
            this.nomeResponsavelTexto.Name = "nomeResponsavelTexto";
            this.nomeResponsavelTexto.Size = new System.Drawing.Size(223, 33);
            this.nomeResponsavelTexto.TabIndex = 27;
            // 
            // generoResponsavelLabel
            // 
            this.generoResponsavelLabel.AutoSize = true;
            this.generoResponsavelLabel.Location = new System.Drawing.Point(43, 138);
            this.generoResponsavelLabel.Name = "generoResponsavelLabel";
            this.generoResponsavelLabel.Size = new System.Drawing.Size(78, 25);
            this.generoResponsavelLabel.TabIndex = 31;
            this.generoResponsavelLabel.Text = "Gênero:";
            // 
            // nomeResponsavelLabel
            // 
            this.nomeResponsavelLabel.AutoSize = true;
            this.nomeResponsavelLabel.Location = new System.Drawing.Point(54, 42);
            this.nomeResponsavelLabel.Name = "nomeResponsavelLabel";
            this.nomeResponsavelLabel.Size = new System.Drawing.Size(67, 25);
            this.nomeResponsavelLabel.TabIndex = 26;
            this.nomeResponsavelLabel.Text = "Nome:";
            // 
            // nascimentoResponsavelLabel
            // 
            this.nascimentoResponsavelLabel.AutoSize = true;
            this.nascimentoResponsavelLabel.Location = new System.Drawing.Point(5, 91);
            this.nascimentoResponsavelLabel.Name = "nascimentoResponsavelLabel";
            this.nascimentoResponsavelLabel.Size = new System.Drawing.Size(116, 25);
            this.nascimentoResponsavelLabel.TabIndex = 30;
            this.nascimentoResponsavelLabel.Text = "Nascimento:";
            // 
            // nascimentoResponsavelTexto
            // 
            this.nascimentoResponsavelTexto.BeepOnError = true;
            this.nascimentoResponsavelTexto.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nascimentoResponsavelTexto.Location = new System.Drawing.Point(127, 88);
            this.nascimentoResponsavelTexto.Mask = "00/00/0000";
            this.nascimentoResponsavelTexto.Name = "nascimentoResponsavelTexto";
            this.nascimentoResponsavelTexto.Size = new System.Drawing.Size(223, 33);
            this.nascimentoResponsavelTexto.TabIndex = 28;
            this.nascimentoResponsavelTexto.ValidatingType = typeof(System.DateTime);
            this.nascimentoResponsavelTexto.Leave += new System.EventHandler(this.nascimentoResponsavelTexto_Leave);
            // 
            // complementoLabel
            // 
            this.complementoLabel.AutoSize = true;
            this.complementoLabel.Location = new System.Drawing.Point(451, 311);
            this.complementoLabel.Name = "complementoLabel";
            this.complementoLabel.Size = new System.Drawing.Size(135, 25);
            this.complementoLabel.TabIndex = 53;
            this.complementoLabel.Text = "Complemento:";
            // 
            // complementoTexto
            // 
            this.complementoTexto.ForeColor = System.Drawing.SystemColors.WindowText;
            this.complementoTexto.Location = new System.Drawing.Point(592, 308);
            this.complementoTexto.Name = "complementoTexto";
            this.complementoTexto.Size = new System.Drawing.Size(223, 33);
            this.complementoTexto.TabIndex = 13;
            // 
            // cepLabel
            // 
            this.cepLabel.AutoSize = true;
            this.cepLabel.Location = new System.Drawing.Point(538, 64);
            this.cepLabel.Name = "cepLabel";
            this.cepLabel.Size = new System.Drawing.Size(49, 25);
            this.cepLabel.TabIndex = 52;
            this.cepLabel.Text = "CEP:";
            // 
            // cepTexto
            // 
            this.cepTexto.BeepOnError = true;
            this.cepTexto.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cepTexto.Location = new System.Drawing.Point(592, 61);
            this.cepTexto.Mask = "00000-000";
            this.cepTexto.Name = "cepTexto";
            this.cepTexto.Size = new System.Drawing.Size(223, 33);
            this.cepTexto.TabIndex = 8;
            // 
            // numeroLabel
            // 
            this.numeroLabel.AutoSize = true;
            this.numeroLabel.Location = new System.Drawing.Point(501, 261);
            this.numeroLabel.Name = "numeroLabel";
            this.numeroLabel.Size = new System.Drawing.Size(85, 25);
            this.numeroLabel.TabIndex = 51;
            this.numeroLabel.Text = "Número:";
            // 
            // ruaTexto
            // 
            this.ruaTexto.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ruaTexto.Location = new System.Drawing.Point(592, 210);
            this.ruaTexto.Name = "ruaTexto";
            this.ruaTexto.PromptChar = ' ';
            this.ruaTexto.Size = new System.Drawing.Size(223, 33);
            this.ruaTexto.TabIndex = 11;
            // 
            // ruaLabel
            // 
            this.ruaLabel.AutoSize = true;
            this.ruaLabel.Location = new System.Drawing.Point(538, 213);
            this.ruaLabel.Name = "ruaLabel";
            this.ruaLabel.Size = new System.Drawing.Size(48, 25);
            this.ruaLabel.TabIndex = 50;
            this.ruaLabel.Text = "Rua:";
            // 
            // bairroTexto
            // 
            this.bairroTexto.ForeColor = System.Drawing.SystemColors.WindowText;
            this.bairroTexto.Location = new System.Drawing.Point(592, 160);
            this.bairroTexto.Name = "bairroTexto";
            this.bairroTexto.Size = new System.Drawing.Size(223, 33);
            this.bairroTexto.TabIndex = 10;
            // 
            // bairroLabel
            // 
            this.bairroLabel.AutoSize = true;
            this.bairroLabel.Location = new System.Drawing.Point(519, 163);
            this.bairroLabel.Name = "bairroLabel";
            this.bairroLabel.Size = new System.Drawing.Size(67, 25);
            this.bairroLabel.TabIndex = 49;
            this.bairroLabel.Text = "Bairro:";
            // 
            // cidadeTexto
            // 
            this.cidadeTexto.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cidadeTexto.Location = new System.Drawing.Point(592, 110);
            this.cidadeTexto.Name = "cidadeTexto";
            this.cidadeTexto.Size = new System.Drawing.Size(223, 33);
            this.cidadeTexto.TabIndex = 9;
            // 
            // cidadeLabel
            // 
            this.cidadeLabel.AutoSize = true;
            this.cidadeLabel.Location = new System.Drawing.Point(511, 113);
            this.cidadeLabel.Name = "cidadeLabel";
            this.cidadeLabel.Size = new System.Drawing.Size(75, 25);
            this.cidadeLabel.TabIndex = 47;
            this.cidadeLabel.Text = "Cidade:";
            // 
            // numeroTexto
            // 
            this.numeroTexto.BeepOnError = true;
            this.numeroTexto.ForeColor = System.Drawing.SystemColors.WindowText;
            this.numeroTexto.Location = new System.Drawing.Point(592, 258);
            this.numeroTexto.Mask = "999990";
            this.numeroTexto.Name = "numeroTexto";
            this.numeroTexto.PromptChar = ' ';
            this.numeroTexto.Size = new System.Drawing.Size(223, 33);
            this.numeroTexto.TabIndex = 12;
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
            this.generoTexto.Location = new System.Drawing.Point(158, 160);
            this.generoTexto.Name = "generoTexto";
            this.generoTexto.Size = new System.Drawing.Size(223, 33);
            this.generoTexto.TabIndex = 3;
            this.generoTexto.Tag = "";
            // 
            // cpfLabel
            // 
            this.cpfLabel.AutoSize = true;
            this.cpfLabel.Location = new System.Drawing.Point(104, 312);
            this.cpfLabel.Name = "cpfLabel";
            this.cpfLabel.Size = new System.Drawing.Size(48, 25);
            this.cpfLabel.TabIndex = 43;
            this.cpfLabel.Text = "CPF:";
            // 
            // cpfTexto
            // 
            this.cpfTexto.BeepOnError = true;
            this.cpfTexto.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cpfTexto.Location = new System.Drawing.Point(158, 308);
            this.cpfTexto.Mask = "000\\.000\\.000\\-00";
            this.cpfTexto.Name = "cpfTexto";
            this.cpfTexto.Size = new System.Drawing.Size(223, 33);
            this.cpfTexto.TabIndex = 6;
            // 
            // telefoneLabel
            // 
            this.telefoneLabel.AutoSize = true;
            this.telefoneLabel.Location = new System.Drawing.Point(65, 261);
            this.telefoneLabel.Name = "telefoneLabel";
            this.telefoneLabel.Size = new System.Drawing.Size(87, 25);
            this.telefoneLabel.TabIndex = 40;
            this.telefoneLabel.Text = "Telefone:";
            // 
            // telefoneTexto
            // 
            this.telefoneTexto.BeepOnError = true;
            this.telefoneTexto.ForeColor = System.Drawing.SystemColors.WindowText;
            this.telefoneTexto.Location = new System.Drawing.Point(158, 258);
            this.telefoneTexto.Mask = "\\(00) 0000\\-0000";
            this.telefoneTexto.Name = "telefoneTexto";
            this.telefoneTexto.Size = new System.Drawing.Size(223, 33);
            this.telefoneTexto.TabIndex = 5;
            // 
            // celularLabel
            // 
            this.celularLabel.AutoSize = true;
            this.celularLabel.Location = new System.Drawing.Point(76, 213);
            this.celularLabel.Name = "celularLabel";
            this.celularLabel.Size = new System.Drawing.Size(76, 25);
            this.celularLabel.TabIndex = 37;
            this.celularLabel.Text = "Celular:";
            // 
            // generoLabel
            // 
            this.generoLabel.AutoSize = true;
            this.generoLabel.Location = new System.Drawing.Point(74, 160);
            this.generoLabel.Name = "generoLabel";
            this.generoLabel.Size = new System.Drawing.Size(78, 25);
            this.generoLabel.TabIndex = 35;
            this.generoLabel.Text = "Gênero:";
            // 
            // nascimentoLabel
            // 
            this.nascimentoLabel.AutoSize = true;
            this.nascimentoLabel.Location = new System.Drawing.Point(36, 113);
            this.nascimentoLabel.Name = "nascimentoLabel";
            this.nascimentoLabel.Size = new System.Drawing.Size(116, 25);
            this.nascimentoLabel.TabIndex = 33;
            this.nascimentoLabel.Text = "Nascimento:";
            // 
            // celularTexto
            // 
            this.celularTexto.BeepOnError = true;
            this.celularTexto.ForeColor = System.Drawing.SystemColors.WindowText;
            this.celularTexto.Location = new System.Drawing.Point(158, 210);
            this.celularTexto.Mask = "(00) 00000\\-0000";
            this.celularTexto.Name = "celularTexto";
            this.celularTexto.Size = new System.Drawing.Size(223, 33);
            this.celularTexto.TabIndex = 4;
            // 
            // nascimentoTexto
            // 
            this.nascimentoTexto.BeepOnError = true;
            this.nascimentoTexto.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nascimentoTexto.Location = new System.Drawing.Point(158, 110);
            this.nascimentoTexto.Mask = "00/00/0000";
            this.nascimentoTexto.Name = "nascimentoTexto";
            this.nascimentoTexto.Size = new System.Drawing.Size(223, 33);
            this.nascimentoTexto.TabIndex = 2;
            this.nascimentoTexto.ValidatingType = typeof(System.DateTime);
            this.nascimentoTexto.Leave += new System.EventHandler(this.nascimentoTexto_Leave);
            // 
            // nomeTexto
            // 
            this.nomeTexto.Location = new System.Drawing.Point(158, 61);
            this.nomeTexto.Name = "nomeTexto";
            this.nomeTexto.Size = new System.Drawing.Size(223, 33);
            this.nomeTexto.TabIndex = 1;
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(85, 64);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(67, 25);
            this.nomeLabel.TabIndex = 28;
            this.nomeLabel.Text = "Nome:";
            // 
            // editarBotao
            // 
            this.editarBotao.Enabled = false;
            this.editarBotao.Location = new System.Drawing.Point(592, 444);
            this.editarBotao.Name = "editarBotao";
            this.editarBotao.Size = new System.Drawing.Size(223, 64);
            this.editarBotao.TabIndex = 14;
            this.editarBotao.Text = "Editar usuário";
            this.editarBotao.UseVisualStyleBackColor = true;
            this.editarBotao.Click += new System.EventHandler(this.editarBotao_Click);
            // 
            // excluirBotao
            // 
            this.excluirBotao.Enabled = false;
            this.excluirBotao.Location = new System.Drawing.Point(592, 521);
            this.excluirBotao.Name = "excluirBotao";
            this.excluirBotao.Size = new System.Drawing.Size(223, 64);
            this.excluirBotao.TabIndex = 57;
            this.excluirBotao.Text = "Excluir usuário";
            this.excluirBotao.UseVisualStyleBackColor = true;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(316, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(214, 32);
            this.idLabel.TabIndex = 58;
            this.idLabel.Text = "Usuário número: ";
            // 
            // TelaInformacoesUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 674);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.excluirBotao);
            this.Controls.Add(this.editarBotao);
            this.Controls.Add(this.emailTexto);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.historicoBotao);
            this.Controls.Add(this.responsavelPanel);
            this.Controls.Add(this.complementoLabel);
            this.Controls.Add(this.complementoTexto);
            this.Controls.Add(this.cepLabel);
            this.Controls.Add(this.cepTexto);
            this.Controls.Add(this.numeroLabel);
            this.Controls.Add(this.ruaTexto);
            this.Controls.Add(this.ruaLabel);
            this.Controls.Add(this.bairroTexto);
            this.Controls.Add(this.bairroLabel);
            this.Controls.Add(this.cidadeTexto);
            this.Controls.Add(this.cidadeLabel);
            this.Controls.Add(this.numeroTexto);
            this.Controls.Add(this.generoTexto);
            this.Controls.Add(this.cpfLabel);
            this.Controls.Add(this.cpfTexto);
            this.Controls.Add(this.telefoneLabel);
            this.Controls.Add(this.telefoneTexto);
            this.Controls.Add(this.celularLabel);
            this.Controls.Add(this.generoLabel);
            this.Controls.Add(this.nascimentoLabel);
            this.Controls.Add(this.celularTexto);
            this.Controls.Add(this.nascimentoTexto);
            this.Controls.Add(this.nomeTexto);
            this.Controls.Add(this.nomeLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "TelaInformacoesUsuario";
            this.Text = "Informações do usuário";
            this.Load += new System.EventHandler(this.TelaInformacoesUsuario_Load);
            this.responsavelPanel.ResumeLayout(false);
            this.responsavelPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emailTexto;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Button historicoBotao;
        private System.Windows.Forms.Panel responsavelPanel;
        private System.Windows.Forms.Label responsavelLabel;
        private System.Windows.Forms.ComboBox generoResponsavelTexto;
        private System.Windows.Forms.TextBox nomeResponsavelTexto;
        private System.Windows.Forms.Label generoResponsavelLabel;
        private System.Windows.Forms.Label nomeResponsavelLabel;
        private System.Windows.Forms.Label nascimentoResponsavelLabel;
        private System.Windows.Forms.MaskedTextBox nascimentoResponsavelTexto;
        private System.Windows.Forms.Label complementoLabel;
        private System.Windows.Forms.MaskedTextBox complementoTexto;
        private System.Windows.Forms.Label cepLabel;
        private System.Windows.Forms.MaskedTextBox cepTexto;
        private System.Windows.Forms.Label numeroLabel;
        private System.Windows.Forms.MaskedTextBox ruaTexto;
        private System.Windows.Forms.Label ruaLabel;
        private System.Windows.Forms.MaskedTextBox bairroTexto;
        private System.Windows.Forms.Label bairroLabel;
        private System.Windows.Forms.MaskedTextBox cidadeTexto;
        private System.Windows.Forms.Label cidadeLabel;
        private System.Windows.Forms.MaskedTextBox numeroTexto;
        private System.Windows.Forms.ComboBox generoTexto;
        private System.Windows.Forms.Label cpfLabel;
        private System.Windows.Forms.MaskedTextBox cpfTexto;
        private System.Windows.Forms.Label telefoneLabel;
        private System.Windows.Forms.MaskedTextBox telefoneTexto;
        private System.Windows.Forms.Label celularLabel;
        private System.Windows.Forms.Label generoLabel;
        private System.Windows.Forms.Label nascimentoLabel;
        private System.Windows.Forms.MaskedTextBox celularTexto;
        private System.Windows.Forms.MaskedTextBox nascimentoTexto;
        private System.Windows.Forms.TextBox nomeTexto;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.Button editarBotao;
        private System.Windows.Forms.Button excluirBotao;
        private System.Windows.Forms.Label idLabel;
    }
}