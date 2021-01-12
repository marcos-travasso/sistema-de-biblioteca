
namespace SistemaInterface
{
    partial class TelaListarGeneros
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.generosDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.generosDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // generosDGV
            // 
            this.generosDGV.AllowUserToAddRows = false;
            this.generosDGV.AllowUserToDeleteRows = false;
            this.generosDGV.AllowUserToOrderColumns = true;
            this.generosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.generosDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.generosDGV.Location = new System.Drawing.Point(21, 23);
            this.generosDGV.Name = "generosDGV";
            this.generosDGV.ReadOnly = true;
            this.generosDGV.Size = new System.Drawing.Size(255, 477);
            this.generosDGV.TabIndex = 1;
            this.generosDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.generosDGV_CellDoubleClick);
            // 
            // TelaListarGeneros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 522);
            this.Controls.Add(this.generosDGV);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "TelaListarGeneros";
            this.Text = "Editar gêneros";
            this.Load += new System.EventHandler(this.TelaListarGeneros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.generosDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView generosDGV;
    }
}