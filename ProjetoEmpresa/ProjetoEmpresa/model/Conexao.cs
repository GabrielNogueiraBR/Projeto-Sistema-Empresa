using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEmpresa.model
{
    class Conexao
    {
        // conecão com o banco de dados
        SqlConnection cn = new SqlConnection();

        public Conexao()
        {
            // inserindo a cadeia de conexão do banco de dados no método connectionString
            cn.ConnectionString = @"Data Source=DK-NOGUEIRA;Initial Catalog=SistemaCadastroEmpresa;Integrated Security=True";
            
        }


        // retornar uma conexão com o nosso banco de dados
        public SqlConnection conectar()
        {
            // vai efetuar a conexão do sistema com o banco de dados caso(IF) esteja desconectado
            if (cn.State == ConnectionState.Closed){
                cn.Open();
            }

            return cn;
        }

        public void desconectar()
        {
            // vai efetuar a desconexão do sistema com o banco de dados caso esteja conectado ao BD
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
        }

    }
}
