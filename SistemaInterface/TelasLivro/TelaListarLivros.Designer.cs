
namespace SistemaInterface
{
    partial class TelaListarLivros
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.livrosDGV = new System.Windows.Forms.DataGridView();
            this.procurarLink = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.livrosDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // livrosDGV
            // 
            this.livrosDGV.AllowUserToAddRows = false;
            this.livrosDGV.AllowUserToDeleteRows = false;
            this.livrosDGV.AllowUserToOrderColumns = true;
            this.livrosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.livrosDGV.DefaultCellStyle = dataGridViewCellStyle1;
            this.livrosDGV.Location = new System.Drawing.Point(28, 28);
            this.livrosDGV.Name = "livrosDGV";
            this.livrosDGV.ReadOnly = true;
            this.livrosDGV.Size = new System.Drawing.Size(392, 603);
            this.livrosDGV.TabIndex = 1;
            this.livrosDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.livrosDGV_CellDoubleClick);
            // 
            // procurarLink
            // 
            this.procurarLink.AutoSize = true;
            this.procurarLink.Location = new System.Drawing.Point(323, 8);
            this.procurarLink.Name = "procurarLink";
            this.procurarLink.Size = new System.Drawing.Size(97, 17);
            this.procurarLink.TabIndex = 2;
            this.procurarLink.TabStop = true;
            this.procurarLink.Text = "procurar livro...";
            this.procurarLink.Visible = false;
            this.procurarLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.procurarLink_LinkClicked);
            // 
            // TelaListarLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 658);
            this.Controls.Add(this.procurarLink);
            this.Controls.Add(this.livrosDGV);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "TelaListarLivros";
            this.Text = "Listagem de livros";
            this.Load += new System.EventHandler(this.TelaListarLivros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.livrosDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView livrosDGV;
        private System.Windows.Forms.LinkLabel procurarLink;
    }
}