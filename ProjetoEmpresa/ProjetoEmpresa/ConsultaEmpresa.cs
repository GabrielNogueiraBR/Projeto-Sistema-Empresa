﻿using ProjetoEmpresa.model;
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
            Consulta consulta = new Consulta(txtCNPJ.Text, txtNomeEmpresa.Text);
        }
    }
}
