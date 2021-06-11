using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ConversorNumerosRomanosEIndoArabicos;

namespace ConversorNumerosRomanosEIndoArabicosTeste
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        [DataRow("I", 1)]
        [DataRow("II", 2)]
        [DataRow("IV", 4)]
        [DataRow("VI", 6)]
        [DataRow("X", 10)]
        [DataRow("IX", 9)]
        [DataRow("XIX", 19)]
        [DataRow("XXIX", 29)]
        [DataRow("XLIV", 44)]
        [DataRow("LXXX", 80)]
        [DataRow("XCIX", 99)]
        [DataRow("CXXI", 121)]
        [DataRow("CLXVIII", 168)]
        [DataRow("CXCIX", 199)]
        [DataRow("CCLIII", 253)]
        [DataRow("CCCLXXI", 371)]
        [DataRow("CDXXVIII", 428)]
        [DataRow("DLXXVI", 576)]
        [DataRow("LXXXV", 85)]
        [DataRow("ĪV̄", 4000)]
        [DataRow("V̄", 5000)]
        [DataRow("V̄C", 5100)]
        [DataRow("V̄C", 5100)]
        [DataRow("V̄Ī", 6000)]
        [DataRow("V̄ĪĪĪ", 8000)]
        [DataRow("ĪX̄", 9000)]
        [DataRow("ĪX̄D", 9500)]
        [DataRow("X̄", 10000)]
        public void VerificaRomanoParaArabico(string numeroRomano, int numeroArabico)
        {
            Numeros valor = new Numeros();

            Assert.AreEqual(numeroArabico, valor.ConversorRomanosAInteiros(numeroRomano));
        }

        [TestMethod]
        [DataRow("I", 1)]
        [DataRow("II", 2)]
        [DataRow("IV", 4)]
        [DataRow("VI", 6)]
        [DataRow("X", 10)]
        [DataRow("IX", 9)]
        [DataRow("XIX", 19)]
        [DataRow("XXIX", 29)]
        [DataRow("XLIV", 44)]
        [DataRow("LXXX", 80)]
        [DataRow("XCIX", 99)]
        [DataRow("CXXI", 121)]
        [DataRow("CLXVIII", 168)]
        [DataRow("CXCIX", 199)]
        [DataRow("CCLIII", 253)]
        [DataRow("CCCLXXI", 371)]
        [DataRow("CDXXVIII", 428)]
        [DataRow("DLXXVI", 576)]
        [DataRow("LXXXV", 85)]
        [DataRow("ĪV̄", 4000)]
        [DataRow("V̄", 5000)]
        [DataRow("V̄C", 5100)]
        [DataRow("V̄C", 5100)]
        [DataRow("V̄Ī", 6000)]
        [DataRow("V̄ĪD", 6500)]
        [DataRow("ĪX̄D", 9500)]
        [DataRow("X̄", 10000)]
        public void VerificaArabicoParaRomano(string numeroRomano, int numeroArabico)
        {
            Numeros valor = new Numeros();

            Assert.AreEqual(numeroRomano, valor.ConversorInteirosARomanos(numeroArabico));
        }
    }
}
