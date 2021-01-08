using SistemaBiblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            usuariosDGV.DataSource = banco.GetUsuarios();
        }
    }
}
