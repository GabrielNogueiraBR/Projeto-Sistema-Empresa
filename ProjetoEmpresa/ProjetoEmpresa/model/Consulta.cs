using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEmpresa.model
{
    class Consulta
    {

        String mensagem = "Falha na consulta!";
        

        public Consulta(String cnpj, String nomeEmpresa)
        {

            if(!cnpj.Equals("") || !(cnpj == null))
            {


                this.ResultadoConsulta(cnpj, "teste", "atividade teste");
            }//caso cnpj não esteja vazio

            else if(!nomeEmpresa.Equals("") || !(nomeEmpresa == null))
            {
                
            }// caso o nome da empresa não esteje vazio

            else
            {
                MessageBox.Show(mensagem);
            }// caso esteja vazio.


        }

        public void ResultadoConsulta(String cnpj, String nomeEmpresa, String atividadePrincipal)
        {
            ResultadoConsulta result = new ResultadoConsulta(cnpj, nomeEmpresa, "teste1");
            result.Show();
        }



    }
}
