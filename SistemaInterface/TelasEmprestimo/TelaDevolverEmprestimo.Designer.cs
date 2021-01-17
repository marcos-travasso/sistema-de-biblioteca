namespace SistemaInterface
{
    partial class TelaDevolverEmprestimo
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
            this.listaEmprestimosLink = new System.Windows.Forms.LinkLabel();
            this.devolverBotao = new System.Windows.Forms.Button();
            this.idLivroLabel = new System.Windows.Forms.Label();
            this.idLivroTexto = new System.Windows.Forms.MaskedTextBox();
            this.idUsuarioTexto = new System.Windows.Forms.TextBox();
            this.idUsuarioLabel = new System.Windows.Forms.Label();
            this.ouLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listaEmprestimosLink
            // 
            this.listaEmprestimosLink.AutoSize = true;
            this.listaEmprestimosLink.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaEmprestimosLink.Location = new System.Drawing.Point(313, 139);
            this.listaEmprestimosLink.Name = "listaEmprestimosLink";
            this.listaEmprestimosLink.Size = new System.Drawing.Size(130, 17);
            this.listaEmprestimosLink.TabIndex = 28;
            this.listaEmprestimosLink.TabStop = true;
            this.listaEmprestimosLink.Text = "lista de empréstimos";
            this.listaEmprestimosLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.listaEmprestimosLink_LinkClicked);
            // 
            // devolverBotao
            // 
            this.devolverBotao.Location = new System.Drawing.Point(220, 191);
            this.devolverBotao.Name = "devolverBotao";
            this.devolverBotao.Size = new System.Drawing.Size(223, 64);
            this.devolverBotao.TabIndex = 3;
            this.devolverBotao.Text = "Devolver livro";
            this.devolverBotao.UseVisualStyleBackColor = true;
            this.devolverBotao.Click += new System.EventHandler(this.devolverBotao_Click);
            // 
            // idLivroLabel
            // 
            this.idLivroLabel.AutoSize = true;
            this.idLivroLabel.Location = new System.Drawing.Point(98, 103);
            this.idLivroLabel.Name = "idLivroLabel";
            this.idLivroLabel.Size = new System.Drawing.Size(103, 25);
            this.idLivroLabel.TabIndex = 26;
            this.idLivroLabel.Text = "ID do livro:";
            // 
            // idLivroTexto
            // 
            this.idLivroTexto.BeepOnError = true;
            this.idLivroTexto.ForeColor = System.Drawing.SystemColors.WindowText;
            this.idLivroTexto.Location = new System.Drawing.Point(220, 103);
            this.idLivroTexto.Name = "idLivroTexto";
            this.idLivroTexto.Size = new System.Drawing.Size(223, 33);
            this.idLivroTexto.TabIndex = 2;
            this.idLivroTexto.ValidatingType = typeof(System.DateTime);
            // 
            // idUsuarioTexto
            // 
            this.idUsuarioTexto.Location = new System.Drawing.Point(220, 38);
            this.idUsuarioTexto.Name = "idUsuarioTexto";
            this.idUsuarioTexto.Size = new System.Drawing.Size(223, 33);
            this.idUsuarioTexto.TabIndex = 1;
            // 
            // idUsuarioLabel
            // 
            this.idUsuarioLabel.AutoSize = true;
            this.idUsuarioLabel.Location = new System.Drawing.Point(72, 38);
            this.idUsuarioLabel.Name = "idUsuarioLabel";
            this.idUsuarioLabel.Size = new System.Drawing.Size(129, 25);
            this.idUsuarioLabel.TabIndex = 25;
            this.idUsuarioLabel.Text = "ID do usuário:";
            // 
            // ouLabel
            // 
            this.ouLabel.AutoSize = true;
            this.ouLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ouLabel.Location = new System.Drawing.Point(142, 78);
            this.ouLabel.Name = "ouLabel";
            this.ouLabel.Size = new System.Drawing.Size(23, 17);
            this.ouLabel.TabIndex = 29;
            this.ouLabel.Text = "ou";
            // 
            // TelaDevolverEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 283);
            this.Controls.Add(this.ouLabel);
            this.Controls.Add(this.listaEmprestimosLink);
            this.Controls.Add(this.devolverBotao);
            this.Controls.Add(this.idLivroLabel);
            this.Controls.Add(this.idLivroTexto);
            this.Controls.Add(this.idUsuarioTexto);
            this.Controls.Add(this.idUsuarioLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "TelaDevolverEmprestimo";
            this.Text = "Devolver livro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel listaEmprestimosLink;
        private System.Windows.Forms.Button devolverBotao;
        private System.Windows.Forms.Label idLivroLabel;
        private System.Windows.Forms.MaskedTextBox idLivroTexto;
        private System.Windows.Forms.TextBox idUsuarioTexto;
        private System.Windows.Forms.Label idUsuarioLabel;
        private System.Windows.Forms.Label ouLabel;
    }
}