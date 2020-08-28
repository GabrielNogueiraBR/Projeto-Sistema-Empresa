using ProjetoEmpresa.model;
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
    public partial class ExcluirEmpresas : Form
    {
        public ExcluirEmpresas()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCNPJ.ResetText();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            // instância do objeto para excluir a empresa informada
            ExcluirEmpresa excluirEmpresa = new ExcluirEmpresa(txtCNPJ.Text);
        }
    }
}
