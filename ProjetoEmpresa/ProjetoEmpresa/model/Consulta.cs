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
        //conexão com o banco de dados
        Conexao conexao = new Conexao();
        
        //variável para armazenar o comando SQL
        SqlCommand query = new SqlCommand();

        //valores retornados do banco
        SqlDataReader leitorBD;

        //parâmetro para realizar o SELECT na consulta
        String paramSql = "";

        public Consulta(String cnpj, String razaoSocial)
        {
            //definindo se iremos pesquisa pelo nome da empresa ou pelo seu cnpj
            if (cnpj != null)
            {
                this.paramSql = "CNPJ = " + cnpj;
            }
            else
            {
                this.paramSql = "RazaoSocial = " + razaoSocial;
            }

            //consulta ao BD
            query.CommandText = "SELECT * FROM Empresas Where @paramSql";         

            //parametros da consulta
            query.Parameters.AddWithValue("@paramSql", paramSql);

            //conexão com o BD
            try
            {

                // O método conectar() retorna um SqlConnection, por isso realizamos essa atribuição para se conectar ao banco
                query.Connection = conexao.conectar();

                //execução do comando - Envia o CommandText para o Connection e cria um SqlDataReader.
                leitorBD = query.ExecuteReader();

                // desconecta do banco de dados
                conexao.desconectar();

                //gravando os dados
                while (leitorBD.Read())
                {
                    Console.WriteLine(leitorBD["nome_da_coluna"]);

                }
            }
            catch (SqlException e)
            {
               MessageBox.Show("Erro na conexão com o Banco de dados!\n\n" + e, "Erro na consulta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
