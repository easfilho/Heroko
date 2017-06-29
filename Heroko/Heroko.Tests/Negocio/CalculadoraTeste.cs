using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Heroko.Models;

namespace Heroko.Tests.Negocio
{
    [TestClass]
    public class CalculadorTeste
    {
        private Calculadora Calculadora = null;
        private int Numero1 = 0;
        private int Numero2 = 0;

        [TestMethod]
        public void DeveVerficarSeSomaDe2Mais2Igual4()
        {
            //Dado que informo o primeiro número com valor 2
            Numero1 = 2;
            //E que informo o segundo número com o valor 2
            Numero2 = 2;
            // Quando somar os dois números
            Calculadora = new Calculadora(Numero1, Numero2);
            int resultado = Calculadora.Somar();
            // Então o resultado deve ser 4
            Assert.AreEqual(4, resultado);
        }
    }
}
