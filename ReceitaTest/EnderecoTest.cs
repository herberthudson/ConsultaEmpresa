using NUnit.Framework;
using Receita;

namespace ReceitaTest
{
    class EnderecoTest
    {
        private Endereco _endereco;
        private const string CEP = "12.345-678";
        private const string CEPDASH = "12-345-678";
        private const string CEPDOT = "12.345.678";
        private const string CEPUNFORMAT = "12345678";

        [SetUp]
        public void Setup()
        {
            _endereco = new Endereco();
        }

        [Test]
        public void TestLogradouro()
        {
            _endereco.Logradouro = "Logradouro principal";

            Assert.AreEqual("Logradouro principal", _endereco.Logradouro);
        }

        [Test]
        public void TestLogradouroVazio()
        {
            _endereco.Logradouro = "";

            Assert.AreEqual(string.Empty, _endereco.Logradouro);
        }

        [Test]
        public void TestNumero()
        {
            _endereco.Numero = "123455 A";

            Assert.AreEqual("123455 A", _endereco.Numero);
        }

        [Test]
        public void TestNumeroVazio()
        {
            _endereco.Numero = "";

            Assert.AreEqual(string.Empty, _endereco.Numero);
        }

        [Test]
        public void TestComplemento()
        {
            _endereco.Complemento = "Bloco C";

            Assert.AreEqual("Bloco C", _endereco.Complemento);
        }

        [Test]
        public void TestComplementoVazio()
        {
            _endereco.Complemento = "";

            Assert.AreEqual(string.Empty, _endereco.Complemento);
        }

        [Test]
        public void TestCep()
        {
            _endereco.Cep = CEP;

            Assert.AreEqual(CEP, _endereco.Cep);
        }

        [Test]
        public void TestCepDash()
        {
            _endereco.Cep = CEPDASH;

            Assert.AreEqual(CEP, _endereco.Cep);
        }

        [Test]
        public void TestCepDot()
        {
            _endereco.Cep = CEPDOT;

            Assert.AreEqual(CEP, _endereco.Cep);
        }

        [Test]
        public void TestCepSemFormato()
        {
            _endereco.Cep = CEPUNFORMAT;

            Assert.AreEqual(CEP, _endereco.Cep);
        }

        [Test]
        public void TestBairro()
        {
            _endereco.Bairro = "Bairro Novo";

            Assert.AreEqual("Bairro Novo", _endereco.Bairro);
        }

        [Test]
        public void TestBairroVazio()
        {
            _endereco.Bairro = "";

            Assert.AreEqual(string.Empty, _endereco.Bairro);
        }

        [Test]
        public void TestMunicipio()
        {
            _endereco.Municipio = "Nova Cidade";

            Assert.AreEqual("Nova Cidade", _endereco.Municipio);
        }

        [Test]
        public void TestMunicipioVazio()
        {
            _endereco.Municipio = "";

            Assert.AreEqual(string.Empty, _endereco.Municipio);
        }

        [Test]
        public void TestUf()
        {
            _endereco.Uf = "SP";

            Assert.AreEqual("SP", _endereco.Uf);
        }
    }
}
