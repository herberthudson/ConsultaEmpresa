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

        private Cnpj _cnpj;
        private string tipo;
        private string abertura;
        private AtividadeEconomica atividadePrincipal;
        private List<AtividadeEconomica> atividadeSecundarias;

        public string Fantasia { get; set; }
        public string RazaoSocial { get; set; }
        public string NaturezaJurica { get; set; }
        public AtividadeEconomica AtividadePrincipal { get; set; }
        public List<AtividadeEconomica> AtividadeSecundarias { get; set; }

        /// <summary>
        /// Definição da Empresa sem parâmetros
        /// </summary>
        public Empresa(){}

        public Empresa(string cnpj)
        {
            this.Cnpj(cnpj);
        }

        public string Abertura
        {
            get { return abertura; }
            set {
                if (string.IsNullOrEmpty(value))
                {
                    abertura = string.Empty;
                }
                else
                {
                    string data_sem_formato = Regex.Replace(value.ToString(), "[^0-9]", "");
                    abertura = string.Format($"{data_sem_formato.Substring(0,2)}/{data_sem_formato.Substring(2,2)}/{data_sem_formato.Substring(4)}");
                }
            }
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

        public Cnpj Cnpj() => _cnpj;

        public Cnpj Cnpj(string cnpj)
        {
            ICheckCnpj checkCnpj = new CheckCnpj();
            _cnpj = checkCnpj.ExtractAndCheckCnpj(cnpj);

            return _cnpj;
        }
   


        
    }
}
