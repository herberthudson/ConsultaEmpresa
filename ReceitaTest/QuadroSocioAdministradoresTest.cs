using NUnit.Framework;
using Receita;

namespace ReceitaTest
{
    class QuadroSocioAdministradoresTest
    {
        private QuadroSocioAdministradores _socio;

        [SetUp]
        public void Setup()
        {
            _socio = new QuadroSocioAdministradores();
        }

        [Test]
        public void TestNome()
        {
            _socio.Nome = "Nome do Socio";

            Assert.AreEqual("Nome do Socio", _socio.Nome);
        }

        [Test]
        public void TestNomeVazio()
        {
            _socio.Nome = "";

            Assert.AreEqual(string.Empty, _socio.Nome);
        }

        [Test]
        public void TestQualificacao()
        {
            _socio.Qualificacao = "Qualificacao";

            Assert.AreEqual("Qualificacao", _socio.Qualificacao);
        }

        [Test]
        public void TestQualificacaoVazio()
        {
            _socio.Qualificacao = "";

            Assert.AreEqual(string.Empty, _socio.Qualificacao);
        }

        [Test]
        public void TestRepresentanteLegal()
        {
            _socio.RepresentanteLegal = "Representante Legal";

            Assert.AreEqual("Representante Legal", _socio.RepresentanteLegal);
        }

        [Test]
        public void TestRepresentanteLegalVazio()
        {
            _socio.RepresentanteLegal = "";

            Assert.AreEqual(string.Empty, _socio.RepresentanteLegal);
        }

        [Test]
        public void TestQUalificacaoRepresentanteLegal()
        {
            _socio.QualificaoRepresentanteLegal = "Qualificacao Representante Legal";

            Assert.AreEqual("Qualificacao Representante Legal", _socio.QualificaoRepresentanteLegal);
        }

    }
}
