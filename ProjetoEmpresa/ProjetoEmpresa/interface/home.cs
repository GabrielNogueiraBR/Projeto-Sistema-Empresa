using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEmpresa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            AdicionarEmpresa adicionar = new AdicionarEmpresa();
            adicionar.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ConsultaEmpresa consulta = new ConsultaEmpresa();
            consulta.Show();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ExcluirEmpresas excluir = new ExcluirEmpresas();
            excluir.Show();

        }
    }
}
