using NUnit.Framework;
using Receita;
using System;
using System.Collections;
using System.Collections.Generic;

namespace ReceitaTest
{
    public class EmpresaTest
    {
        private Empresa _empresa;
        private const string MATRIZ = "MATRIZ";
        private const string FILIAL = "FILIAL";
        private const string ABERTURA = "06/09/2000";
        private const string ATIVIDADE = "Atividade";
        private const string CODIGO = "12.34-5-67";
        private const string CODIGODASH = "12-34-5-67";
        private const string CODIGODOT = "12.34.5.67";
        private const string CODIGOLIMPO = "1234567";

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

        [Test]
        public void TestAtividadePrincipal()
        {
            AtividadeEconomica atividadePrincipal = new AtividadeEconomica
            {
                Codigo = "00.00-0-00",
                Descricao = "Atividade Principal"
            };

            _empresa.AtividadePrincipal = atividadePrincipal;

            Assert.AreEqual(atividadePrincipal, _empresa.AtividadePrincipal);
        }

        [Test]
        public void TestAtividadesSecundarias()
        {
            _empresa.AtividadeSecundarias = new List<AtividadeEconomica>();

            IList codigos = new List<string>()
            {
                CODIGO,
                CODIGODASH,
                CODIGODOT,
                CODIGOLIMPO
            };

            foreach (string codigo in codigos)
            {
                AtividadeEconomica atividade = new AtividadeEconomica()
                {
                    Codigo = codigo,
                    Descricao = ATIVIDADE
                };

                _empresa.AtividadeSecundarias.Add(atividade);
            }

            foreach (AtividadeEconomica atividade in _empresa.AtividadeSecundarias)
            {
                Assert.AreEqual(CODIGO, atividade.Codigo);

                Assert.AreEqual(ATIVIDADE, atividade.Descricao);
            }
        }

        [Test]
        public void TestNaturezaJuridica()
        {
            _empresa.NaturezaJurica = "Natureza Jurídica";

            Assert.AreEqual("Natureza Jurídica", _empresa.NaturezaJurica);
        }

        [Test]
        public void TestNaturezaJuridicaVazio()
        {
            _empresa.NaturezaJurica = "";

            Assert.AreEqual(string.Empty, _empresa.NaturezaJurica);
        }

        [Test]
        public void TestEmailValido()
        {
            _empresa.Email = "example@example.com";

            Assert.AreEqual("example@example.com", _empresa.Email);
        }

        [Test]
        public void TestEmailInvalido()
        {
            _empresa.Email = "meuemail.com";

            Assert.AreEqual(string.Empty, _empresa.Email);
        }

        [Test]
        public void TestTelefoneValido()
        {
            _empresa.Telefone = "19 99999-9999";

            Assert.AreEqual("19 99999-9999", _empresa.Telefone);
        }

        [Test]
        public void TestTelefoneVazio()
        {
            _empresa.Telefone = "";

            Assert.AreEqual(string.Empty, _empresa.Telefone);
        }

        [Test]
        public void TestEfr()
        {
            _empresa.Efr = "Ente Federativo Responsavel";

            Assert.AreEqual("Ente Federativo Responsavel", _empresa.Efr);
        }

        [Test]
        public void TestEfrVazio()
        {
            _empresa.Efr = "";

            Assert.AreEqual(string.Empty, _empresa.Efr);
        }

        [Test]
        public void TestSituacao()
        {
            _empresa.Situacao = "Ativo";

            Assert.AreEqual("Ativo", _empresa.Situacao);
        }

        [Test]
        public void TestSituacaoVazio()
        {
            _empresa.Situacao = "";

            Assert.AreEqual(string.Empty, _empresa.Situacao);
        }

        [Test]
        public void TestDataSituacaoSemFormatacao()
        {
            _empresa.DataSituacao = "06092000";

            Assert.AreEqual(ABERTURA, _empresa.DataSituacao);
        }

        [Test]
        public void TestDataSituacaoDash()
        {
            _empresa.DataSituacao = "06-09-2000";
            Assert.AreEqual(ABERTURA, _empresa.DataSituacao);
        }

        [Test]
        public void TestDataSituacaoSlash()
        {
            _empresa.DataSituacao = "06/09/2000";

            Assert.AreEqual(ABERTURA, _empresa.DataSituacao);
        }

        [Test]
        public void TestMotivoSituacao()
        {
            _empresa.MotivoSituacao = "Motivo da Situacao";

            Assert.AreEqual("Motivo da Situacao", _empresa.MotivoSituacao);
        }

        [Test]
        public void TestMotivoSituacaoVazio()
        {
            _empresa.MotivoSituacao = "";

            Assert.AreEqual(string.Empty, _empresa.MotivoSituacao);
        }

        [Test]
        public void TestSituacaoEspecial()
        {
            _empresa.SituacaoEspecial = "Situação Especial";

            Assert.AreEqual("Situação Especial", _empresa.SituacaoEspecial);
        }

        [Test]
        public void TestSituacaoEspecialVazio()
        {
            _empresa.SituacaoEspecial = "";

            Assert.AreEqual(string.Empty, _empresa.SituacaoEspecial);
        }

        [Test]
        public void TestDataSituacaoEspecialSemFormatacao()
        {
            _empresa.DataSituacaoEspecial = "06092000";

            Assert.AreEqual(ABERTURA, _empresa.DataSituacaoEspecial);
        }

        [Test]
        public void TestDataSituacaoEspecialDash()
        {
            _empresa.DataSituacaoEspecial = "06-09-2000";
            Assert.AreEqual(ABERTURA, _empresa.DataSituacaoEspecial);
        }

        [Test]
        public void TestDataSituacaoEspecialSlash()
        {
            _empresa.DataSituacaoEspecial = "06/09/2000";

            Assert.AreEqual(ABERTURA, _empresa.DataSituacaoEspecial);
        }

        [Test]
        public void TestCapitalSocial()
        {
            _empresa.CapitalSocial = "0.00";

            Assert.AreEqual("0.00", _empresa.CapitalSocial);
        }
    }
}