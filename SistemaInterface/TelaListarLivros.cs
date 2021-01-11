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
    public partial class TelaListarLivros : Form
    {
        List<Livro> listaLivros = new List<Livro>();
        bool admin = false;
        public TelaListarLivros()
        {
            this.admin = false;
            InitializeComponent();
        }

        public TelaListarLivros(bool editar = false)
        {
            this.admin = editar;
            InitializeComponent();
        }

        private void TelaListarLivros_Load(object sender, EventArgs e)
        {
            atualizarGrid();
        }

        private void atualizarGrid()
        {
            BancoLivro banco = new BancoLivro();

            listaLivros = banco.GetLivros(listaLivros);

            livrosDGV.ColumnCount = 3;

            List<string> colunas = new List<string> { "ID", "Título", "Autor" };
            List<int> colunasTamanho = new List<int> { 50, 150, 150 };

            for (int i = 0; i < livrosDGV.ColumnCount; i++)
            {
                livrosDGV.Columns[i].Width = colunasTamanho[i];
                livrosDGV.Columns[i].Name = colunas[i];

                if (i != 0) { livrosDGV.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; }
                else { livrosDGV.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; }

                livrosDGV.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            var registros = new List<string[]>();
            foreach (Livro livro in listaLivros)
            {
                string[] registro = new string[] { Convert.ToString(livro.idLivro), livro.Titulo, livro.getAutor()};
                registros.Add(registro);
            }

            foreach (string[] registro in registros)
            {
                livrosDGV.Rows.Add(registro);
            }
        }

        private void livrosDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (livrosDGV.SelectedCells.Count == 1)
            {
                var linha = livrosDGV.SelectedCells[0].RowIndex;
                int id = Convert.ToInt32(livrosDGV.Rows[linha].Cells[0].Value);

                foreach (Livro livro in listaLivros)
                {
                    if (livro.idLivro == id)
                    {
                        abrirInformacoesLivro(admin, livro);
                    }
                }
            }
            else
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Você só pode escolher um usuário por vez.", "Erro");
            }
        }

        private void abrirInformacoesLivro(bool editar, Livro livro)
        {
            bool isOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "TelaInformacoesLivro")
                {
                    isOpen = true;
                    f.BringToFront();
                }
            }

            if (!isOpen)
            {
                TelaInformacoesLivro paginaUsuario = new TelaInformacoesLivro(editar, livro);
                paginaUsuario.Show();
            }
        }
    }
}
