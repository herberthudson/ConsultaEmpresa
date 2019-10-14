using System;
using System.Collections.Generic;
using System.Text;

namespace Receita
{
    class ReceitaWS : IConsultaEmpresa
    {
        private Empresa empresa;

        public Empresa Consultar()
        {
            empresa = new Empresa();

            return empresa;
        }

        public Empresa Consultar(Empresa _empresa)
        {
            return empresa = _empresa;
        }

        public Empresa Consultar(string url)
        {
            return empresa;
        }

        public Empresa Consultar(Empresa _empresa, string url)
        {

            return empresa;
        }
    }
}
