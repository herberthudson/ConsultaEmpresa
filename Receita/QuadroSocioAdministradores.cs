using System;
using System.Collections.Generic;
using System.Text;

namespace Receita
{
    public class QuadroSocioAdministradores
    {
        private string nome;
        private string qualificacao;
        private string paisOrigem;
        private string representanteLegal;
        private string qualificaoRepresentanteLegal;

        public string QualificaoRepresentanteLegal
        {
            get { return qualificaoRepresentanteLegal; }
            set { qualificaoRepresentanteLegal = value; }
        }

        public string RepresentanteLegal
        {
            get { return representanteLegal; }
            set { representanteLegal = value; }
        }


        public string PaisOrigem
        {
            get { return paisOrigem; }
            set { paisOrigem = value; }
        }


        public string Qualificacao
        {
            get { return qualificacao; }
            set { qualificacao = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }


    }
}
