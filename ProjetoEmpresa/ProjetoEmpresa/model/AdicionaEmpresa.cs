using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEmpresa.model
{
    class AdicionaEmpresa
    {

        //conexao ao BD
        Conexao conexao = new Conexao();

        //consulta do banco
        SqlCommand query = new SqlCommand();

        //variavel do tipo Empresa
        Empresa emp;

        //mensagem
        String mensagem = "";
        String tituloMensagem = "";

        //linhas afetadas
        int rowsAfected = 0;

        public AdicionaEmpresa(Empresa emp)
        {
            if (emp.isPreenchida())
            {
                try
                {
                    //referenciando a variavel ao objeto criado na ação de Click do Windows Form
                    this.emp = emp;

                    //construindo a query para o SQL
                    query.CommandText = "INSERT INTO Empresas VALUES(" +
                        "@cnpj," +
                        "@razaoSocial," +
                        "@atividadePrinc," +
                        "@logradouro," +
                        "@numero," +
                        "@municipio," +
                        "@uf)";

                    //atribuindo o valor dos parametros
                    query.Parameters.AddWithValue("@cnpj", emp.getCNPJ());
                    query.Parameters.AddWithValue("@razaoSocial", emp.getRazaoSocial());
                    query.Parameters.AddWithValue("@atividadePrinc", emp.getAtividade());
                    query.Parameters.AddWithValue("@logradouro", emp.getLogradouro());
                    query.Parameters.AddWithValue("@numero", emp.getNumero());
                    query.Parameters.AddWithValue("@municipio", emp.getMunicipio());
                    query.Parameters.AddWithValue("@uf", emp.getUf());

                    //criando conexao ao BD
                    query.Connection = conexao.conectar();

                    //executando o INSERT e gravando as linhas afetadas na variavel
                    rowsAfected = query.ExecuteNonQuery();

                    //desconectando do banco de dados
                    conexao.desconectar();

                    //verificacao se cadastrou com sucesso
                    if (rowsAfected > 0)
                    {
                        //definindo mensagem
                        tituloMensagem = "Sucesso na gravação";
                        mensagem = "Empresa Registrada com sucesso!\n\n";
                    }
                    else
                    {
                        //definindo mensagem
                        tituloMensagem = "Erro na gravação";
                        mensagem = "A empresa não foi registrada com sucesso, por favor tente novamente.\n\n";
                    }
                    
                    //mensagem final
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
            else
            {
                tituloMensagem = "Erro!";
                mensagem = "Valide o preenchimento das informações e tente novamente.";
                MessageBox.Show(mensagem, tituloMensagem, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            
        }



    }
}
