using System;
using System.Collections.Generic;
using System.Text;

namespace Receita
{
    interface IConsultaEmpresa
    {
        Empresa Consultar();
        Empresa Consultar(Empresa empresa);
        Empresa Consultar(string url);
        Empresa Consultar(Empresa empresa, string url);
    }
}
