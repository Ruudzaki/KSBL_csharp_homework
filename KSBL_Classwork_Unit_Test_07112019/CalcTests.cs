using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KSBL_ClassLibrary_071119;

namespace KSBL_Classwork_Unit_Test_07112019
{
    [TestClass]
    public class CalcTests
    {
        [TestMethod]
        public void Add_10and20_30expected()
        {
            //AAA
            //Arange
            Calc calc = new Calc();
            double summand1 = 10;
            double summand2 = 20;
            double actual;
            double expected = 30;
            
            //Act
            actual = calc.Add(summand1, summand2);
            
            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
