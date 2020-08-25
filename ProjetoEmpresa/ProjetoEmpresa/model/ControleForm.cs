using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEmpresa.model
{
    class ControleForm
    {
        // Essa classe será a classe controle que vai tratar das interações da interface com o Back-end do sistema



        // Função que realiza a busca das informações no Banco de Dados
        public void Consulta(String cnpj, String nomeEmpresa)
        {

            String mensagem = "Falha na consulta! Informe um CNPJ ou nome de empresa válido.";
                       
            if (!cnpj.Equals("") && !(cnpj == null))
            {
                

                
                // Chamada da função que EXIBE o resultado
                this.ResultadoConsulta(cnpj, "teste", "atividade teste","rua alameda", "110", "bairro", "São Paulo");
            }//caso cnpj não esteja vazio

            else if (!nomeEmpresa.Equals("") && !(nomeEmpresa == null))
            {

            }// caso o nome da empresa não esteje vazio

            else
            {
                MessageBox.Show(mensagem, "Erro na consulta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }// caso esteja vazio.
          }


        // Função que retorna as informações consultadas para a Interface
        public void ResultadoConsulta(String cnpj, String razaoSocial, String atividadePrincipal, String logradouro, String numero, String municipio, String uf)
        {
            //Instância do WindowsForm ResultadoConsulta passando as informações pelo construtor
            ResultadoConsulta result = new ResultadoConsulta(cnpj, razaoSocial, atividadePrincipal,logradouro,numero,municipio,uf);
            result.Show();
        }

    }
}
