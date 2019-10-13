using NUnit.Framework;
using Receita;
using System;

namespace ReceitaTest
{
    class AtividadeEconomicaTest
    {
        private AtividadeEconomica _atividade;
        private const string CODIGO = "12.34-5-67";
        private const string CODIGO_VAZIO = "00.00-0-00";
      
        [SetUp]
        public void Setup()
        {
            _atividade = new AtividadeEconomica();
        }

        [Test]
        public void TestCodigo()
        {
            _atividade.Codigo = "12.34-5-67";

            Assert.AreEqual(CODIGO, _atividade.Codigo);
        }

        [Test]
        public void TestCodigoSemFormatacao()
        {
            _atividade.Codigo = "1234567";

            Assert.AreEqual(CODIGO, _atividade.Codigo);
        }

        [Test]
        public void TestCodigoPonto()
        {
            _atividade.Codigo = "12.34.5.67";

            Assert.AreEqual(CODIGO, _atividade.Codigo);
        }

        [Test]
        public void TestCodigoVazio()
        {
            _atividade.Codigo = "";

            Assert.AreEqual(CODIGO_VAZIO, _atividade.Codigo);
        }

        [Test]
        public void TestCodigoMenor()
        {
            _atividade.Codigo = "1234";

            Assert.AreEqual("12.34-0-00", _atividade.Codigo);
        }

        [Test]
        public void TestCodigoMaior()
        {
            _atividade.Codigo = "12345678";

            Assert.AreEqual("12.34-5-67", _atividade.Codigo);
        }

        [Test]
        public void TestDescricao()
        {
            _atividade.Descricao = "Atividade nova";

            Assert.AreEqual("Atividade nova", _atividade.Descricao);
        }

        [Test]
        public void TestDescricaoVazio()
        {
            _atividade.Descricao = "";

            Assert.AreEqual(string.Empty, _atividade.Descricao);
        }
    }
}
