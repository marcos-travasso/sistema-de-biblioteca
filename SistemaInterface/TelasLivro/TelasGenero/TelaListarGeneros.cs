using SistemaBiblioteca;
using System;
using System.Collections.Generic;
using System.Media;
using System.Windows.Forms;

namespace SistemaInterface
{
    public partial class TelaListarGeneros : Form
    {
        List<Genero> listaGeneros = new List<Genero>();
        public TelaListarGeneros()
        {
            InitializeComponent();
        }

        private void generosDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (generosDGV.SelectedCells.Count == 1)
            {
                var linha = generosDGV.SelectedCells[0].RowIndex;
                int id = Convert.ToInt32(generosDGV.Rows[linha].Cells[0].Value);

                foreach (Genero genero in listaGeneros)
                {
                    if (genero.idGenero == id)
                    {
                        abrirInformacoesGenero(genero);
                    }
                }
            }
            else
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Você só pode escolher um gênero por vez.", "Erro");
            }
        }
        private void abrirInformacoesGenero(Genero genero)
        {
            bool isOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "TelaInformacoesGenero")
                {
                    isOpen = true;
                    f.BringToFront();
                }
            }

            if (!isOpen)
            {
                TelaInformacoesGenero paginaUsuario = new TelaInformacoesGenero(genero);
                paginaUsuario.Show();
            }
        }

        private void TelaListarGeneros_Load(object sender, EventArgs e)
        {
            atualizarGrid();
        }

        private void atualizarGrid()
        {
            BancoGenero banco = new BancoGenero();

            listaGeneros = banco.GetGeneros(listaGeneros);

            generosDGV.ColumnCount = 2;

            List<string> colunas = new List<string> { "ID", "Nome" };
            List<int> colunasTamanho = new List<int> { 50, 150 };

            for (int i = 0; i < generosDGV.ColumnCount; i++)
            {
                generosDGV.Columns[i].Width = colunasTamanho[i];
                generosDGV.Columns[i].Name = colunas[i];

                if (i != 0) { generosDGV.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; }
                else { generosDGV.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; }

                generosDGV.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            var registros = new List<string[]>();
            foreach (Genero genero in listaGeneros)
            {
                string[] registro = new string[] { Convert.ToString(genero.idGenero), genero.Nome };
                registros.Add(registro);
            }

            foreach (string[] registro in registros)
            {
                generosDGV.Rows.Add(registro);
            }
        }
    }
}
