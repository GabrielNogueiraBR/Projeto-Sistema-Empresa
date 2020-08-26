using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEmpresa.model
{
    class Empresa
    {
        //informacoes da empresa
        private String cnpj;
        private String razaoSocial;
        private String atividadePrincipal;
        private String logradouro;
        private String numero;
        private String municipio;
        private String uf;


        //construtor da classe
        public Empresa()
        {

        }


        //construtor da classe com sobreposicao de metodos
        public Empresa(String cnpj, String razaoSocial, String atividadePrincipal, String logradouro, String numero, String municipio, String uf)
        {
            this.cnpj = cnpj;
            this.razaoSocial = razaoSocial;
            this.atividadePrincipal = atividadePrincipal;
            this.logradouro = logradouro;
            this.numero = numero;
            this.municipio = municipio;
            this.uf = uf;

        }


        //configurando os getters da classe
        public String getCNPJ()
        {
            return this.cnpj;
        }
        public String getRazaoSocial()
        {
            return this.razaoSocial;
        }
        public String getAtividade()
        {
            return this.atividadePrincipal;
        }
        public String getLogradouro()
        {
            return this.logradouro;
        }
        public String getNumero()
        {
            return this.numero;
        }
        public String getMunicipio()
        {
            return this.municipio;
        }
        public String getUf()
        {
            return this.uf;
        }



    }
}
