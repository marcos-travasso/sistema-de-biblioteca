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
    public partial class TelaListarAutores : Form
    {
        List<Autor> listaAutores = new List<Autor>();
        public TelaListarAutores()
        {
            InitializeComponent();
        }

        private void autoresDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (autoresDGV.SelectedCells.Count == 1)
            {
                var linha = autoresDGV.SelectedCells[0].RowIndex;
                int id = Convert.ToInt32(autoresDGV.Rows[linha].Cells[0].Value);

                foreach (Autor autor in listaAutores)
                {
                    if (autor.idAutor == id)
                    {
                        abrirInformacoesAutor(autor);
                    }
                }
            }
            else
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Você só pode escolher um autor por vez.", "Erro");
            }
        }
        private void abrirInformacoesAutor(Autor autor)
        {
            bool isOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "TelaInformacoesAutor")
                {
                    isOpen = true;
                    f.BringToFront();
                }
            }

            if (!isOpen)
            {
                TelaInformacoesAutor pagina = new TelaInformacoesAutor(autor);
                pagina.Show();
            }
        }

        private void TelaListarAutores_Load(object sender, EventArgs e)
        {
            atualizarGrid();
        }

        private void atualizarGrid()
        {
            BancoDeDados banco = new BancoDeDados();

            listaAutores = banco.GetAutores(listaAutores);

            autoresDGV.ColumnCount = 4;

            List<string> colunas = new List<string> { "ID", "Nome", "Nascimento", "Gênero" };
            List<int> colunasTamanho = new List<int> { 50, 180, 80, 80 };

            for (int i = 0; i < autoresDGV.ColumnCount; i++)
            {
                autoresDGV.Columns[i].Width = colunasTamanho[i];
                autoresDGV.Columns[i].Name = colunas[i];

                if (i != 0) { autoresDGV.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; }
                else { autoresDGV.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; }

                autoresDGV.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            var registros = new List<string[]>();
            foreach (Autor autor in listaAutores)
            {
                string[] registro = new string[] { Convert.ToString(autor.idAutor), autor.Nome, Convert.ToString(autor.Nascimento), autor.getGenero() };
                registros.Add(registro);
            }

            foreach (string[] registro in registros)
            {
                autoresDGV.Rows.Add(registro);
            }
        }
    }
}
