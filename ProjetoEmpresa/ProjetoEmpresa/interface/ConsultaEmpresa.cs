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
    public partial class ConsultaEmpresa : Form
    {
        // Instância da classe de Controle, que realiza todo o tratamento das interações entre o back-end e a interface.
        ControleForm control = new ControleForm();

        public ConsultaEmpresa()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCNPJ.ResetText();
            txtNomeEmpresa.ResetText();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            // Passa para a função consulta os dados necessários para realizar a busca no BD e exibe na tela o resultado da consulta.
            control.Consulta(txtCNPJ.Text, txtNomeEmpresa.Text);
        }
    }
}
