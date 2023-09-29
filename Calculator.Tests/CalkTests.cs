using Calkulator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Calculator.Tests
{
    [TestClass]
    public class CalkTests
    {
        [TestMethod]
        public void SQRT_100_10returen()
        {
            int a = 100; //что есть
            int expected = 10; //хотим получить

            Calc calc = new Calc();
            int actual = calc.SQRT(a);
            //Assert.AreEqual(expected, actual);
            //Assert.IsNull(a, "Не пустое");
            //Assert.Fail();//принудительное завершение
            //Assert.Inconclusive(); //пропуск теста. Не будет запускаться
            StringAssert.Contains("Никита?","?");
            StringAssert.EndsWith("Никита?", "?");




        }
    }
}
