
namespace SistemaInterface
{
    partial class TelaListarEmprestimos
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
            this.emprestimosDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.emprestimosDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // emprestimosDGV
            // 
            this.emprestimosDGV.AllowUserToAddRows = false;
            this.emprestimosDGV.AllowUserToDeleteRows = false;
            this.emprestimosDGV.AllowUserToOrderColumns = true;
            this.emprestimosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.emprestimosDGV.DefaultCellStyle = dataGridViewCellStyle1;
            this.emprestimosDGV.Location = new System.Drawing.Point(12, 12);
            this.emprestimosDGV.Name = "emprestimosDGV";
            this.emprestimosDGV.ReadOnly = true;
            this.emprestimosDGV.Size = new System.Drawing.Size(892, 523);
            this.emprestimosDGV.TabIndex = 2;
            this.emprestimosDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.emprestimosDGV_CellDoubleClick);
            // 
            // TelaListarEmprestimos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 547);
            this.Controls.Add(this.emprestimosDGV);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "TelaListarEmprestimos";
            this.Text = "Listagem de empréstimos";
            this.Load += new System.EventHandler(this.TelaListarEmprestimos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.emprestimosDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView emprestimosDGV;
    }
}