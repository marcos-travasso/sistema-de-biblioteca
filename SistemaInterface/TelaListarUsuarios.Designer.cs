
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.usuariosDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // usuariosDGV
            // 
            this.usuariosDGV.AllowUserToAddRows = false;
            this.usuariosDGV.AllowUserToDeleteRows = false;
            this.usuariosDGV.AllowUserToOrderColumns = true;
            this.usuariosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usuariosDGV.DefaultCellStyle = dataGridViewCellStyle4;
            this.usuariosDGV.Location = new System.Drawing.Point(31, 30);
            this.usuariosDGV.Name = "usuariosDGV";
            this.usuariosDGV.ReadOnly = true;
            this.usuariosDGV.Size = new System.Drawing.Size(1383, 603);
            this.usuariosDGV.TabIndex = 0;
            this.usuariosDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usuariosDGV_CellDoubleClick);
            // 
            // TelaListarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1439, 658);
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