using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExemploTDD;

namespace ExemploTDD.Testes
{
    [TestClass]
    public class CalculoFinanceiroTestes
    {
        [TestMethod]
        public void Teste01()
        {
            double valorAPagar = CalculoFinanceiro.CalcularValorComJurosCompostos(10000, 12, 2);
            Assert.AreEqual(valorAPagar,12682.42);
        }

        [TestMethod]
        public void Teste02()
        {
            double valorAPagar = CalculoFinanceiro.CalcularValorComJurosCompostos(11937.28, 24, 4);
            Assert.AreEqual(valorAPagar, 30598.88);
        }

        [TestMethod]
        public void Teste03()
        {
            double valorAPagar = CalculoFinanceiro.CalcularValorComJurosCompostos(15000, 36, 6);
            Assert.AreEqual(valorAPagar, 122208.78);
        }
    }
}
