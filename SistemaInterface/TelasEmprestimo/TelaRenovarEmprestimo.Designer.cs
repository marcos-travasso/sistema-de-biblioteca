
namespace SistemaInterface
{
    partial class TelaRenovarEmprestimo
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
            this.devolucaoLabel = new System.Windows.Forms.Label();
            this.devolucaoData = new System.Windows.Forms.DateTimePicker();
            this.listaEmprestimosLink = new System.Windows.Forms.LinkLabel();
            this.renovarBotao = new System.Windows.Forms.Button();
            this.idLivroLabel = new System.Windows.Forms.Label();
            this.idLivroTexto = new System.Windows.Forms.MaskedTextBox();
            this.idUsuarioTexto = new System.Windows.Forms.TextBox();
            this.idUsuarioLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // devolucaoLabel
            // 
            this.devolucaoLabel.AutoSize = true;
            this.devolucaoLabel.Location = new System.Drawing.Point(20, 168);
            this.devolucaoLabel.Name = "devolucaoLabel";
            this.devolucaoLabel.Size = new System.Drawing.Size(173, 25);
            this.devolucaoLabel.TabIndex = 29;
            this.devolucaoLabel.Text = "Data de devolução:";
            // 
            // devolucaoData
            // 
            this.devolucaoData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.devolucaoData.Location = new System.Drawing.Point(212, 168);
            this.devolucaoData.Name = "devolucaoData";
            this.devolucaoData.Size = new System.Drawing.Size(223, 33);
            this.devolucaoData.TabIndex = 23;
            // 
            // listaEmprestimosLink
            // 
            this.listaEmprestimosLink.AutoSize = true;
            this.listaEmprestimosLink.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaEmprestimosLink.Location = new System.Drawing.Point(305, 70);
            this.listaEmprestimosLink.Name = "listaEmprestimosLink";
            this.listaEmprestimosLink.Size = new System.Drawing.Size(130, 17);
            this.listaEmprestimosLink.TabIndex = 27;
            this.listaEmprestimosLink.TabStop = true;
            this.listaEmprestimosLink.Text = "lista de empréstimos";
            this.listaEmprestimosLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.listaEmprestimosLink_LinkClicked);
            // 
            // renovarBotao
            // 
            this.renovarBotao.Location = new System.Drawing.Point(212, 231);
            this.renovarBotao.Name = "renovarBotao";
            this.renovarBotao.Size = new System.Drawing.Size(223, 64);
            this.renovarBotao.TabIndex = 24;
            this.renovarBotao.Text = "Renovar livro";
            this.renovarBotao.UseVisualStyleBackColor = true;
            this.renovarBotao.Click += new System.EventHandler(this.renovarBotao_Click);
            // 
            // idLivroLabel
            // 
            this.idLivroLabel.AutoSize = true;
            this.idLivroLabel.Location = new System.Drawing.Point(90, 99);
            this.idLivroLabel.Name = "idLivroLabel";
            this.idLivroLabel.Size = new System.Drawing.Size(103, 25);
            this.idLivroLabel.TabIndex = 26;
            this.idLivroLabel.Text = "ID do livro:";
            // 
            // idLivroTexto
            // 
            this.idLivroTexto.BeepOnError = true;
            this.idLivroTexto.ForeColor = System.Drawing.SystemColors.WindowText;
            this.idLivroTexto.Location = new System.Drawing.Point(212, 99);
            this.idLivroTexto.Name = "idLivroTexto";
            this.idLivroTexto.Size = new System.Drawing.Size(223, 33);
            this.idLivroTexto.TabIndex = 22;
            this.idLivroTexto.ValidatingType = typeof(System.DateTime);
            // 
            // idUsuarioTexto
            // 
            this.idUsuarioTexto.Location = new System.Drawing.Point(212, 34);
            this.idUsuarioTexto.Name = "idUsuarioTexto";
            this.idUsuarioTexto.Size = new System.Drawing.Size(223, 33);
            this.idUsuarioTexto.TabIndex = 21;
            // 
            // idUsuarioLabel
            // 
            this.idUsuarioLabel.AutoSize = true;
            this.idUsuarioLabel.Location = new System.Drawing.Point(64, 34);
            this.idUsuarioLabel.Name = "idUsuarioLabel";
            this.idUsuarioLabel.Size = new System.Drawing.Size(129, 25);
            this.idUsuarioLabel.TabIndex = 25;
            this.idUsuarioLabel.Text = "ID do usuário:";
            // 
            // TelaRenovarEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 337);
            this.Controls.Add(this.devolucaoLabel);
            this.Controls.Add(this.devolucaoData);
            this.Controls.Add(this.listaEmprestimosLink);
            this.Controls.Add(this.renovarBotao);
            this.Controls.Add(this.idLivroLabel);
            this.Controls.Add(this.idLivroTexto);
            this.Controls.Add(this.idUsuarioTexto);
            this.Controls.Add(this.idUsuarioLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "TelaRenovarEmprestimo";
            this.Text = "TelaRenovarEmprestimo";
            this.Load += new System.EventHandler(this.TelaRenovarEmprestimo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label devolucaoLabel;
        private System.Windows.Forms.DateTimePicker devolucaoData;
        private System.Windows.Forms.LinkLabel listaEmprestimosLink;
        private System.Windows.Forms.Button renovarBotao;
        private System.Windows.Forms.Label idLivroLabel;
        private System.Windows.Forms.MaskedTextBox idLivroTexto;
        private System.Windows.Forms.TextBox idUsuarioTexto;
        private System.Windows.Forms.Label idUsuarioLabel;
    }
}