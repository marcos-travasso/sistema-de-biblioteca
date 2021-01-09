
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usuariosDGV.DefaultCellStyle = dataGridViewCellStyle1;
            this.usuariosDGV.Location = new System.Drawing.Point(31, 30);
            this.usuariosDGV.Name = "usuariosDGV";
            this.usuariosDGV.ReadOnly = true;
            this.usuariosDGV.Size = new System.Drawing.Size(1383, 603);
            this.usuariosDGV.TabIndex = 0;
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