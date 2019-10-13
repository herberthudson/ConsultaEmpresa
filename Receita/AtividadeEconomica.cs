
using System.Text.RegularExpressions;

namespace Receita
{
    public class AtividadeEconomica
    {
        private string _codigo;
        private string _descricao;
        private const string CODIGO_VAZIO = "00.00-0-00";

        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }

        public string Codigo
        {
            get { return _codigo; }
            set {
                // removendo todos menos numeros
                string cod_sem_formatacao = Regex.Replace(value.ToString(),"[^0-9]", "").ToString();
                
                // normalizando quantidade caracteres
                int tamanho = cod_sem_formatacao.Length;
                if (tamanho < 7)
                {
                    int falta = 7 - tamanho;
                    string complemento = new string('0', falta);
                    cod_sem_formatacao += complemento;
                }
                else if (tamanho > 7)
                {
                    cod_sem_formatacao = cod_sem_formatacao.Substring(0, 7);
                }

                _codigo = string.IsNullOrEmpty(cod_sem_formatacao) ? 
                    CODIGO_VAZIO : 
                    string.Format(
                        $"{cod_sem_formatacao.Substring(0,2)}.{cod_sem_formatacao.Substring(2,2)}-{cod_sem_formatacao.Substring(4,1)}-{cod_sem_formatacao.Substring(5)}"
                    );
            }
        }

    }
}
