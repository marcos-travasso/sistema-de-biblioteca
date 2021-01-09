using SistemaBiblioteca;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaInterface
{
    public partial class TelaListarUsuarios : Form
    {
        public TelaListarUsuarios()
        {
            InitializeComponent();
        }

        private void TelaListarUsuarios_Load(object sender, EventArgs e)
        {
            BancoDeDados banco = new BancoDeDados();
            List<Usuario> listaUsuarios = new List<Usuario>();

            listaUsuarios = banco.GetUsuarios(listaUsuarios);

            usuariosDGV.ColumnCount = 11;

            List<string> colunas = new List<string> { "ID", "Nome", "Nascimento", "Gênero", "Email", "Telefone", "Celular", "Cidade", "Bairro", "Rua", "Número" };
            List<int> colunasTamanho = new List<int> { 50, 180, 80, 80, 200, 110, 120, 150, 100, 150, 60 };

            for (int i = 0; i < usuariosDGV.ColumnCount; i++)
            {
                usuariosDGV.Columns[i].Width = colunasTamanho[i];
                usuariosDGV.Columns[i].Name = colunas[i];

                if (i != 0 && i != 1 & i != 4) { usuariosDGV.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; }
                else if (i != 0) { usuariosDGV.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft; }
                else { usuariosDGV.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; }

                usuariosDGV.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            var registros = new List<string[]>();
            foreach (Usuario usuario in listaUsuarios)
            {
                string[] registro = new string[] { Convert.ToString(usuario.idUsuario), usuario.Nome, Convert.ToString(usuario.Nascimento), usuario.getGenero(), usuario.Email, usuario.getTelefone(), usuario.getCelular(), usuario.Endereco.Cidade, usuario.Endereco.Bairro, usuario.Endereco.Rua, Convert.ToString(usuario.Endereco.Numero) };
                registros.Add(registro);
            }

            foreach (string[] registro in registros)
            {
                usuariosDGV.Rows.Add(registro);
            }
            //usuariosDGV.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //usuariosDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
        }
    }
}
