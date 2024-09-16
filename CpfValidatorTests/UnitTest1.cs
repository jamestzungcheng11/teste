using Microsoft.VisualStudio.TestTools.UnitTesting;
using CpfValidatorTests;


namespace CpfValidatorTests
{
    [TestClass]
    public class ValidatorTests
    {
        [TestMethod]
        public void DeveRemoverCarateresNaoNumericos()
        {
            string cpfComMascara = "123.456.789-09";
            string cpfEsperado = "12345678909";

            string cpfSemMascara = CpfValidatorTests.RemoverCarateresNaoNumericos((cpfComMascara));
            Assert.AreEqual(cpfSemMascara, cpfEsperado);
        }

        [TestMethod]
        public void DeveRetornarFalsoParacpfIncorrecto()
        {
            string cpfComTamanhoErrado = "123.456.78";

            bool resultado = CpfValidatorTests.VerificarTamanho(cpfComTamanhoErrado);
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void DeveRetornarVerdadeiroParaCpfComTamanhoCorrecto()
        {
            string cpfComTamanhoCorrecto = "12345678909";
            bool resultado=CpfValidatorTests.VerificarTamanho(cpfComTamanhoCorrecto);
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void DeveRetornarFalsoParaCpfParaTodosDigitosIguais()
        {
            string cpfTodosIguais = "11111111111";

            bool resultado=CpfValidatorTests.TodosDigitosIguais(cpfTodosIguais);
        }
        [TestMethod]
        public void DeveRetornarFalsoParaCpfParaTodosDigitosDiferentes()
        {
            string cpfTodosDiferente = "1234567891011";
            bool resultado = CpfValidatorTests.TodosDigitosIguais(cpfTodosDiferente);
            Assert.IsFalse(resultado);
        }
     
    }
}