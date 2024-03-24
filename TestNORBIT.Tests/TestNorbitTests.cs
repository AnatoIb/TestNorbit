using NUnit.Framework;
using System;
using System.IO;

namespace TestNORBIT.Tests
{
    [TestFixture]
    public class Tests
    {
        private StringWriter _consoleOutput;
        private StringReader _consoleInput;

        [SetUp]
        public void Setup()
        {
            _consoleOutput = new StringWriter();
            _consoleInput = new StringReader("-50\n-160\n70\n170\n");
            Console.SetOut(_consoleOutput);
            Console.SetIn(_consoleInput);
        }

        [TearDown]
        public void TearDown()
        {
            _consoleOutput.Dispose();
            _consoleInput.Dispose();
        }

        [Test]
        public void InputData_NegativeWeightAndHeight_ErrorMessageDisplayed()
        {
            _consoleInput = new StringReader("-70\n-180\n80\n196\n");
            Console.SetIn(_consoleInput);
            IndexCalculation indexCalculation = new IndexCalculation();

            indexCalculation.InputData();

            string expectedOutput = "¬ведите вес тела (в кг): \r\n¬ведите свой рост (в см): \r\n" +
                "¬ведены неверные данные, попробуйте ещЄ раз\n\r\n" +
                "¬ведите вес тела (в кг): \r\n¬ведите свой рост (в см): \r\n" +
                "»ћ“ = 20,8 - Ќормальный\r\n";
            Assert.AreEqual(expectedOutput, _consoleOutput.ToString());
        }
    }
}