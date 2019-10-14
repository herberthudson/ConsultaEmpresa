using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using DataValidator.Cnpj;

namespace Receita
{
    public class Empresa : Object
    {
        private const string MATRIZ = "MATRIZ";
        private const string FILIAL = "FILIAL";

        private Cnpj cnpj;
        private string tipo;
        private string abertura;
        private AtividadeEconomica atividadePrincipal;
        private List<AtividadeEconomica> atividadeSecundarias;
        private Endereco endereco;
        private string email;
        private string telefone;
        private string efr;
        private string situacao;
        private string dataSituacao;
        private string motivoSituacao;
        private string situacaoEspecial;
        private string dataSituacaoEspecial;
        private string capitalSocial;
        private string extra;

        public string Fantasia { get; set; }
        public string RazaoSocial { get; set; }
        public string NaturezaJurica { get; set; }
        public AtividadeEconomica AtividadePrincipal { get; set; }
        public List<AtividadeEconomica> AtividadeSecundarias { get; set; }
    
        /// <summary>
        /// Definição da Empresa sem parâmetros
        /// </summary>
        public Empresa(){}

        public Empresa(string _cnpj, string _tipo, string _abertura, string _razao_social, string _fantasia, 
            AtividadeEconomica _atividade_principal, List<AtividadeEconomica> _atividades_secundarias, Endereco _endereco,
            string _natureza_juridica = "", string _email = "", string _telefone = "", string _efr = "", string _situacao = "")
        {
            this.Cnpj(_cnpj);
            this.Tipo = _tipo;
            this.Abertura = _abertura;
            this.RazaoSocial = _razao_social;
            this.Fantasia = _fantasia;
            this.AtividadePrincipal = _atividade_principal;
            this.AtividadeSecundarias = _atividades_secundarias;
            this.NaturezaJurica = _natureza_juridica;
            this.Endereco = _endereco;
            this.Email = _email;
            this.Telefone = _telefone;
            this.Efr = _efr;
            this.Situacao = _situacao;
        }

        public string Extra
        {
            get { return extra; }
            set { extra = value; }
        }

        public string CapitalSocial
        {
            get { return capitalSocial; }
            set { capitalSocial = value; }
        }

        public string DataSituacaoEspecial
        {
            get { return dataSituacaoEspecial; }
            set { dataSituacaoEspecial = formata_data(value.ToString()); }
        }

        public string SituacaoEspecial
        {
            get { return situacaoEspecial; }
            set { situacaoEspecial = value; }
        }

        public string MotivoSituacao
        {
            get { return motivoSituacao; }
            set { motivoSituacao = value; }
        }

        public string DataSituacao
        {
            get { return dataSituacao; }
            set { dataSituacao = formata_data(value.ToString()); }
        }

        public string Efr
        {
            get { return efr; }
            set { efr = value; }
        }

        public string Situacao
        {
            get { return situacao; }
            set { situacao = value; }
        }

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public string Email
        {
            get { return email; }
            set
            {

                Regex regEmail = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regEmail.Match(value);

                if (match.Success)
                {
                    email = value;
                }
                else
                {
                    email = string.Empty;
                }

            }
        }

        public Endereco Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public string Abertura
        {
            get { return abertura; }
            set { abertura = formata_data(value.ToString()); }
        }

        private string formata_data(string data)
        {
            string data_formatada;

            if (string.IsNullOrEmpty(data))
            {
                data_formatada = string.Empty;
            }
            else
            {
                string data_sem_formato = Regex.Replace(data.ToString(), "[^0-9]", "");
                data_formatada = string.Format($"{data_sem_formato.Substring(0, 2)}/{data_sem_formato.Substring(2, 2)}/{data_sem_formato.Substring(4)}");
            }

            return data_formatada;
        }

        public string Tipo
        {
            get { return tipo; }
            set {
                IList tipos = new List<string>()
                {
                    MATRIZ,
                    FILIAL
                };

                tipo = tipos.Contains(value.ToUpper()) ? value.ToUpper() : string.Empty;
            }
        }

        public Cnpj Cnpj() => cnpj;

        public Cnpj Cnpj(string _cnpj)
        {
            ICheckCnpj checkCnpj = new CheckCnpj();
            cnpj = checkCnpj.ExtractAndCheckCnpj(_cnpj);

            return cnpj;
        }


    }
}
