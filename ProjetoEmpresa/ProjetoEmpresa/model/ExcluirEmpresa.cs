using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEmpresa.model
{
    // classe que fará a exclusão das empresas no Banco de Dados
    class ExcluirEmpresa
    {

        // conexao com o BD
        Conexao conexao = new Conexao();

        // query no SQL
        SqlCommand query = new SqlCommand();

        // parametros da consulta
        String sqlParam = "";

        // linhas afetadas
        int rowsAffected = 0;

        // mensagem
        String mensagem = "";
        String tituloMensagem = "";

        // medoto construtor da classe ExcluirEmpresa
        public ExcluirEmpresa(string cnpj)
        {
            // validacao da string
            if( cnpj.Equals("") || cnpj == null)
            {
                mensagem = "Erro! O campo CNPJ está vazio.\n\n";
                tituloMensagem = "Erro na exclusão";

                MessageBox.Show(mensagem, tituloMensagem, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }// o campo informado esta vazio

            else
            {
                try
                {
                    // definicao dos parametros de consulta
                    this.sqlParam = cnpj;

                    // consulta ao BD e atribuicao de parametros
                    query.CommandText = "DELETE FROM Empresas WHERE CNPJ = @sqlParam";
                    query.Parameters.AddWithValue("@sqlParam", sqlParam);

                    // criacao da conexao
                    query.Connection = conexao.conectar();

                    // consulta sem retorno
                    rowsAffected = query.ExecuteNonQuery();

                    // verificacao se excluiu
                    if (rowsAffected != 0)
                    {
                        mensagem = $"A exclusão da empresa com o CNPJ {sqlParam} ocorreu com sucesso.\n\n";
                        tituloMensagem = "Concluído";
                    }
                    else
                    {
                        mensagem = $"Não foi encontrada a empresa com o CNPJ = {sqlParam} no Banco de dados.\n\n";
                        tituloMensagem = "CNPJ não encontrado";
                    }

                    // desconectar do banco de dados
                    conexao.desconectar();

                    // mensagem de exclusao ocorrida com sucesso
                    MessageBox.Show(mensagem, tituloMensagem, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


                }
                catch (SqlException e)
                {
                    // mensagem de exclusao ocorrida com sucesso
                    mensagem = "Erro na conexão com o Banco de dados!\n\n" + e;
                    tituloMensagem = "Erro ao se conectar";
                    MessageBox.Show(mensagem, tituloMensagem, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    
                }

            }
        }

    }
}
