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
        public void Consulta(String cnpj, String razaoSocial)
        {
            Consulta consulta;
            String mensagem = "Falha na consulta! Informe um CNPJ ou nome de empresa válido.";
            
            if (!cnpj.Equals("") && !(cnpj == null) || !razaoSocial.Equals("") && !(razaoSocial == null))
            {
               
                if (!cnpj.Equals("") && !(cnpj == null))
                {
                    //chamada da consulta
                    consulta = new Consulta(cnpj, null);
                } //realiza a pesquisa atraves do cnpj

                else
                {
                    consulta = new Consulta(null, razaoSocial);

                } //realiza a pesquisa atraves da razao social

                //retorno dos dados da consulta
                Empresa empresa = consulta.retornaDados();

                // Chamada da função que EXIBE o resultado
                if (consulta.temResultado())
                    this.ResultadoConsulta(empresa.getCNPJ(), empresa.getRazaoSocial(), empresa.getAtividade(), empresa.getLogradouro(), empresa.getNumero(), empresa.getMunicipio(), empresa.getUf());

            }

            

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
