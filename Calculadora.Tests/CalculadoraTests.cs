using NUnit.Framework;
using System;

namespace Calculadora.Tests
{
    public class CalculadoraTests
    {
        [TestFixture]
        public class CalculadoraSimplesTests
        {
            //Teste Classe AdicionarDoisNumeros
            [Test]
            public void DeveAdicionarDoisNumeros()
            {
                //SUT - System Under Test
                var sut = new CalculadoraSimples();

                var resultado = sut.Adicionar(5, 5);

                Assert.That(resultado, Is.EqualTo(10));
            }

            //Teste Classe Multiplicar
            //DoisNumeros
            [Test]
        }
    }
}
