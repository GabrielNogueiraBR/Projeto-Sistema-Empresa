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
    public partial class AdicionarEmpresa : Form
    {

        public AdicionarEmpresa()
        {
            InitializeComponent();

       
       
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCNPJ.ResetText();
            txtRazaoSocial.ResetText();
            txtAtividadePrincipal.ResetText();
            txtLogradouro.ResetText();
            txtNumero.ResetText();
            txtMunicipio.ResetText();
            txtUF.ResetText();

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            // Instância do objeto Empresa com o método construtor
            Empresa empresa = new Empresa(
                    txtCNPJ.Text.ToUpper(), 
                    txtRazaoSocial.Text.ToUpper(),
                    txtAtividadePrincipal.Text.ToUpper(),
                    txtLogradouro.Text.ToUpper(),
                    txtNumero.Text.ToUpper(),
                    txtMunicipio.Text.ToUpper(),
                    txtUF.Text.ToUpper()
                );

            AdicionaEmpresa adicionaEmpresa = new AdicionaEmpresa(empresa);


        }
    }
}
