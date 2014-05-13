using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Prototipo_Presidio.Regra_de_Negocio
{
    class IniciaTextCadastroPresidiario
    {
        private String matricula = "Matrícula";

        public String Matricula
        {
            get { return matricula; }
            private set { matricula = value; }
        }
        private String nome = "Nome";

        public String Nome
        {
            get { return nome; }
            private set { nome = value; }
        }
        private String rg = "RG";

        public String Rg
        {
            get { return rg; }
            private set { rg = value; }
        }
        private String cpf = "CPF";

        public String Cpf
        {
            get { return cpf; }
            private set { cpf = value; }
        }
        private String endereco = "Endereço";

        public String Endereco
        {
            get { return endereco; }
            private set { endereco = value; }
        }
        private String bairro = "Bairro";

        public String Bairro
        {
            get { return bairro; }
            private set { bairro = value; }
        }
        private String cep = "CEP";

        public String Cep
        {
            get { return cep; }
            private set { cep = value; }
        }
        private String nomePai = "Nome do Pai";

        public String NomePai
        {
            get { return nomePai; }
            private set { nomePai = value; }
        }
        private String nomeMae = "Nome da Mãe";

        public String NomeMae
        {
            get { return nomeMae; }
            private set { nomeMae = value; }
        }
        private String telefone = "Telefone";

        public String Telefone
        {
            get { return telefone; }
            private set { telefone = value; }
        }
        private String grauPerigo = "Grau de Perigo";

        public String GrauPerigo
        {
            get { return grauPerigo; }
           private set { grauPerigo = value; }
        }
        private String cargo = "Cargo que Exerce";

        public String Cargo
        {
            get { return cargo; }
            private set { cargo = value; }
        }


    }
}
