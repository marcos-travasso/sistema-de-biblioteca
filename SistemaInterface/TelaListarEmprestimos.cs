using SistemaBiblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaInterface
{
    public partial class TelaListarEmprestimos : Form
    {
        List<Emprestimo> listaEmprestimos = new List<Emprestimo>();
        bool selecionar = false;
        public Emprestimo selecionado { get; set; }
        public TelaListarEmprestimos()
        {
            InitializeComponent();
        }
        public TelaListarEmprestimos(bool selecionar = false)
        {
            this.selecionar = selecionar;
            InitializeComponent();
        }

        private void TelaListarEmprestimos_Load(object sender, EventArgs e)
        {
            atualizarGrid();
        }
        private void atualizarGrid()
        {
            BancoEmprestimo banco = new BancoEmprestimo();

            listaEmprestimos = banco.GetEmprestimos(listaEmprestimos);

            emprestimosDGV.ColumnCount = 4;

            List<string> colunas = new List<string> { "Nome", "Título", "Data do empréstimo", "Data de devolução"};
            List<int> colunasTamanho = new List<int> { 150, 250, 170, 150 };

            for (int i = 0; i < emprestimosDGV.ColumnCount; i++)
            {
                emprestimosDGV.Columns[i].Width = colunasTamanho[i];
                emprestimosDGV.Columns[i].Name = colunas[i];

                emprestimosDGV.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                emprestimosDGV.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            var registros = new List<string[]>();
            foreach (Emprestimo emprestimo in listaEmprestimos)
            {
                string[] registro = new string[] { emprestimo.usuario.Nome, emprestimo.livro.Titulo, emprestimo.dataDoPedido.ToString("dd/MM/yyyy"), emprestimo.devolucoes[0].dataDeDevolucao.ToString("dd/MM/yyyy") };
                registros.Add(registro);
            }

            foreach (string[] registro in registros)
            {
                emprestimosDGV.Rows.Add(registro);
            }
        }

        private void emprestimosDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (emprestimosDGV.SelectedCells.Count == 1)
            {
                var linha = emprestimosDGV.SelectedCells[0].RowIndex;
                string nome = Convert.ToString(emprestimosDGV.Rows[linha].Cells[0].Value);

                foreach (Emprestimo emprestimo in listaEmprestimos)
                {
                    if (emprestimo.usuario.Nome == nome)
                    {
                        if (selecionar)
                        {
                            this.selecionado = emprestimo;
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                }
            }
            else
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Você só pode escolher um empréstimo por vez.", "Erro");
            }
        }
    }
}
