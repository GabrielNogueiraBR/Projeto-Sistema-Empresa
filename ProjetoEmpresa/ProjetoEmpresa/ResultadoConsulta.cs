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
    public partial class ResultadoConsulta : Form
    {
        public ResultadoConsulta(String cnpj, String razaoSocial, String atividadePrincipal, String logradouro, String numero, String municipio, String uf)
        {
            InitializeComponent(cnpj, razaoSocial, atividadePrincipal, logradouro, numero, municipio, uf);
        }
    }
}
