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

        //configurando os setters da classe
        public void setCNPJ(String cnpj)
        {
            this.cnpj = cnpj;
        }
        public void setRazaoSocial(String razaoSocial)
        {
            this.razaoSocial = razaoSocial;
        }
        public void setAtividade(String atividadePrincipal)
        {
            this.atividadePrincipal = atividadePrincipal;
        }
        public void setLogradouro(String logradouro)
        {
            this.logradouro = logradouro;
        }
        public void setNumero(String numero)
        {
            this.numero = numero;
        }
        public void setMunicipio(String municipio)
        {
            this.municipio = municipio;
        }
        public void setUf(String uf)
        {
            this.uf = uf;
        }


        //Funcao de Verificacao de preenchimento
        public Boolean isPreenchida()
        {
            if(
                (this.cnpj.Equals("") || this.cnpj == null) &&
                (this.razaoSocial.Equals("") || this.razaoSocial == null) &&
                (this.atividadePrincipal.Equals("") || this.atividadePrincipal == null) &&
                (this.logradouro.Equals("") || this.logradouro == null) &&
                (this.numero.Equals("") || this.numero == null) &&
                (this.municipio.Equals("") || this.municipio == null) &&
                (this.uf.Equals("") || this.uf == null)
                )
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
