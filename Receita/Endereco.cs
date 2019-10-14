using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Receita
{
    public class Endereco
    {
        private string logradouro;
        private string numero;
        private string complemento;
        private string cep;
        private string bairro;
        private string municipio;
        private string uf;

        public string Uf
        {
            get { return uf; }
            set { uf = value; }
        }


        public string Municipio
        {
            get { return municipio; }
            set { municipio = value; }
        }


        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }


        public string Cep
        {
            get { return cep; }
            set {

                if (string.IsNullOrEmpty(value))
                {
                    cep = string.Empty;
                }
                else
                {
                    string cep_sem_formato = Regex.Replace(value.ToString(), "[^0-9]", "");
                    cep = String.Format($"{cep_sem_formato.Substring(0,2)}.{cep_sem_formato.Substring(2,3)}-{cep_sem_formato.Substring(5)}");
                }
            }
        }

        public string Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }


        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public string Logradouro
        {
            get { return logradouro; }
            set { logradouro = value; }
        }


    }
}
