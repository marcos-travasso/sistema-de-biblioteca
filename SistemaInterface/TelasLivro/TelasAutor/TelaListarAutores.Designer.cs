
namespace SistemaInterface
{
    partial class TelaListarAutores
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
            this.autoresDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.autoresDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // autoresDGV
            // 
            this.autoresDGV.AllowUserToAddRows = false;
            this.autoresDGV.AllowUserToDeleteRows = false;
            this.autoresDGV.AllowUserToOrderColumns = true;
            this.autoresDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.autoresDGV.DefaultCellStyle = dataGridViewCellStyle1;
            this.autoresDGV.Location = new System.Drawing.Point(12, 12);
            this.autoresDGV.Name = "autoresDGV";
            this.autoresDGV.ReadOnly = true;
            this.autoresDGV.Size = new System.Drawing.Size(435, 550);
            this.autoresDGV.TabIndex = 2;
            this.autoresDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.autoresDGV_CellDoubleClick);
            // 
            // TelaListarAutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 574);
            this.Controls.Add(this.autoresDGV);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "TelaListarAutores";
            this.Text = "Editar autores";
            this.Load += new System.EventHandler(this.TelaListarAutores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.autoresDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView autoresDGV;
    }
}