using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEmpresa.model
{
    // Classe que fará a busca das informações no BD
    class Consulta
    {
        //objeto Empresa que vai possuir os dados da consulta
        Empresa empresa = new Empresa();

        //conexão com o banco de dados
        Conexao conexao = new Conexao();
        
        //variável para armazenar o comando SQL
        SqlCommand query = new SqlCommand();

        //valores retornados do banco
        SqlDataReader leitorBD;

        //parâmetro para realizar o SELECT na consulta
        string paramSql = "";

        //variavel que vai dizer se houve resultado para a classe controle exibir as informacoes
        Boolean _temResultado = true;

        public Consulta(string cnpj, string razaoSocial)
        {
            //definindo se iremos pesquisa pela razao social da empresa ou pelo seu cnpj
            if (cnpj != null)
            {
                //consulta ao BD
                query.CommandText = "SELECT * FROM Empresas WHERE CNPJ = @paramSql";
                this.paramSql = cnpj;
            }
            else
            {
                //consulta ao BD
                query.CommandText = "SELECT * FROM Empresas WHERE RAZAOSOCIAL = @paramSql";
                this.paramSql = razaoSocial;
            }                

            //parametros da consulta
            query.Parameters.AddWithValue("@paramSql", this.paramSql);
            

            //conexão com o BD
            try
            {

                // O método conectar() retorna um SqlConnection, por isso realizamos essa atribuição para se conectar ao banco
                query.Connection = conexao.conectar();

                //execução do comando - Envia o CommandText para o Connection e cria um SqlDataReader.
                leitorBD = query.ExecuteReader();

                if (leitorBD.HasRows) 
                {
                    //gravando os dados
                    while (leitorBD.Read())
                    {
                        empresa.setCNPJ(leitorBD.GetString(0));
                        empresa.setRazaoSocial(leitorBD.GetString(1));
                        empresa.setAtividade(leitorBD.GetString(2));
                        empresa.setLogradouro(leitorBD.GetString(3));
                        empresa.setNumero(leitorBD.GetString(4));
                        empresa.setMunicipio(leitorBD.GetString(5));
                        empresa.setUf(leitorBD.GetString(6));

                    }
                }//caso a consulta tenha algum retorno
                else
                {
                    _temResultado = false;
                    MessageBox.Show("Não existe nenhuma empresa com o CNPJ ou Razão Social infomados.\n\n", "Nenhuma empresa identificada", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }


                // desconecta do banco de dados
                conexao.desconectar();
            }
            catch (SqlException e)
            {
               _temResultado = false;
               MessageBox.Show("Erro na conexão com o Banco de dados!\n\n" + e, "Erro na consulta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        //funcao que retorna os dados da consulta para a classe controle
        public Empresa retornaDados()
        {
            return empresa;
        }

        //getter de hasResult
        public Boolean temResultado()
        {
            return this._temResultado;
        }

        //setters de Consulta




    }

    
}
