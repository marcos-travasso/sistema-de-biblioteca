using SistemaBiblioteca;
using System;
using System.Collections.Generic;
using System.Media;
using System.Windows.Forms;

namespace SistemaInterface
{
    public partial class TelaListarUsuarios : Form
    {
        List<Usuario> listaUsuarios = new List<Usuario>();
        bool admin = false;
        public TelaListarUsuarios()
        {
            this.admin = false;
            InitializeComponent();
        }

        public TelaListarUsuarios(bool editar = false)
        {
            this.admin = editar;
            InitializeComponent();
        }

        private void TelaListarUsuarios_Load(object sender, EventArgs e)
        {
            BancoDeDados banco = new BancoDeDados();

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
        }

        private void usuariosDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (usuariosDGV.SelectedCells.Count == 1)
            {
                var linha = usuariosDGV.SelectedCells[0].RowIndex;
                int id = Convert.ToInt32(usuariosDGV.Rows[linha].Cells[0].Value);

                foreach(Usuario usuario in listaUsuarios)
                {
                    if (usuario.idUsuario == id)
                    {
                        abrirInformacoesUsuario(admin, usuario);
                    }
                }
            } else
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Você só pode escolher um usuário por vez.", "Erro");
            }
        }

        private void abrirInformacoesUsuario(bool editar, Usuario usuario)
        {
            bool isOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "TelaInformacoesUsuario")
                {
                    isOpen = true;
                    f.BringToFront();
                }
            }

            if (!isOpen)
            {
                TelaInformacoesUsuario paginaUsuario = new TelaInformacoesUsuario(editar, usuario);
                paginaUsuario.Show();
            }
        }
    }
}
