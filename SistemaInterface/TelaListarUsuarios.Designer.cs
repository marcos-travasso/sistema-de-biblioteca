
namespace SistemaInterface
{
    partial class TelaListarUsuarios
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
            this.usuariosDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // usuariosDGV
            // 
            this.usuariosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuariosDGV.Location = new System.Drawing.Point(25, 27);
            this.usuariosDGV.Name = "usuariosDGV";
            this.usuariosDGV.Size = new System.Drawing.Size(1264, 552);
            this.usuariosDGV.TabIndex = 0;
            // 
            // TelaListarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 656);
            this.Controls.Add(this.usuariosDGV);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TelaListarUsuarios";
            this.Text = "Listagem de Usuários";
            this.Load += new System.EventHandler(this.TelaListarUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuariosDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView usuariosDGV;
    }
}