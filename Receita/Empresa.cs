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
        private string _tipo;
        private string _abertura;
        private string _razao_social;
        private string _fantasia;

        public string Fantasia
        {
            get { return _fantasia; }
            set { _fantasia = value; }
        }


        public string RazaoSocial
        {
            get { return _razao_social; }
            set { _razao_social = value; }
        }


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
            get { return _abertura; }
            set {
                if (string.IsNullOrEmpty(value))
                {
                    _abertura = string.Empty;
                }
                else
                {
                    string data_sem_formato = Regex.Replace(value.ToString(), "[^0-9]", "");
                    _abertura = string.Format($"{data_sem_formato.Substring(0,2)}/{data_sem_formato.Substring(2,2)}/{data_sem_formato.Substring(4)}");
                }
            }
        }

        public string Tipo
        {
            get { return _tipo; }
            set {
                IList tipos = new List<string>()
                {
                    MATRIZ,
                    FILIAL
                };

                _tipo = tipos.Contains(value.ToUpper()) ? value.ToUpper() : string.Empty;
            }
        }

        public Cnpj Cnpj()
        {
            return _cnpj;
        }

        public Cnpj Cnpj(string cnpj)
        {
            ICheckCnpj checkCnpj = new CheckCnpj();
            _cnpj = checkCnpj.ExtractAndCheckCnpj(cnpj);

            return _cnpj;
        }
   


        
    }
}
