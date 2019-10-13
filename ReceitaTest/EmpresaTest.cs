using NUnit.Framework;
using Receita;
using System;

namespace Tests
{
    public class Tests
    {
        private Empresa _empresa;
        private const string MATRIZ = "MATRIZ";
        private const string FILIAL = "FILIAL";
        private const string ABERTURA = "06/09/2000";

        [SetUp]
        public void Setup()
        {
            _empresa = new Empresa();
        }

        [Test]
        public void TestCnpjSemFormatacao()
        {
            _empresa.Cnpj("06990590000123");

            Assert.AreEqual("06.990.590/0001-23", _empresa.Cnpj().Formatted);
        }

        [Test]
        public void TestCnpjComFormatacao()
        {
            _empresa.Cnpj("06.990.590/0001-23");

            Assert.AreEqual("06.990.590/0001-23", _empresa.Cnpj().Formatted);
        }

        [Test]
        public void TestTipoTudoMaiusculo()
        {
            _empresa.Tipo = "MATRIZ";

            Assert.AreEqual(MATRIZ, _empresa.Tipo);

            _empresa.Tipo = "FILIAL";

            Assert.AreEqual(FILIAL, _empresa.Tipo);
        }

        [Test]
        public void TestTipoPrimeiroMaiusculo()
        {
            _empresa.Tipo = "Matriz";

            Assert.AreEqual(MATRIZ, _empresa.Tipo);

            _empresa.Tipo = "Filial";

            Assert.AreEqual(FILIAL, _empresa.Tipo);
        }

        [Test]
        public void TestTipoTudoMinusculo()
        {
            _empresa.Tipo = "matriz";

            Assert.AreEqual(MATRIZ, _empresa.Tipo);

            _empresa.Tipo = "filial";

            Assert.AreEqual(FILIAL, _empresa.Tipo);
        }

        [Test]
        public void TestTipoVazio()
        {
            _empresa.Tipo = "";

            Assert.AreEqual(string.Empty, _empresa.Tipo);
        }

        [Test]
        public void TestTipoErrado()
        {
            _empresa.Tipo = "Nova";

            Assert.AreEqual(string.Empty, _empresa.Tipo);
        }

        [Test]
        public void TestDataDeAberturaVazio()
        {
            _empresa.Abertura = "";

            Assert.AreEqual(string.Empty, _empresa.Abertura);
        }

        [Test]
        public void TestDataDeAberturaSemFormatacao()
        {
            _empresa.Abertura = "06092000";

            Assert.AreEqual(ABERTURA, _empresa.Abertura);
        }

        [Test]
        public void TestDataDeAberturaDash()
        {
            _empresa.Abertura = "06-09-2000";
            Console.WriteLine(_empresa.Abertura);
            Assert.AreEqual(ABERTURA, _empresa.Abertura);
        }

        [Test]
        public void TestDataDeAberturaSlash()
        {
            _empresa.Abertura = "06/09/2000";

            Assert.AreEqual(ABERTURA, _empresa.Abertura);
        }

        [Test]
        public void TestRazaoSocial()
        {
            _empresa.RazaoSocial = "Nome da Empresa LTDA";

            Assert.AreEqual("Nome da Empresa LTDA", _empresa.RazaoSocial);
        }

        [Test]
        public void TestRazaoSocialVazio()
        {
            _empresa.RazaoSocial = "";

            Assert.AreEqual(string.Empty, _empresa.RazaoSocial);

        }

        [Test]
        public void TestFantasia()
        {
            _empresa.Fantasia = "Nome Fantasia";

            Assert.AreEqual("Nome Fantasia", _empresa.Fantasia);
        }

        [Test]
        public void TestFantasiaVazio()
        {
            _empresa.Fantasia = "";

            Assert.AreEqual(string.Empty, _empresa.Fantasia);
        }


    }
}