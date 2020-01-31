using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleUtilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUtilities.Tests
{
    [TestClass()]
    public class UtilitiesTests
    {
        [TestMethod()]
        public void WriteLineTest()
        {
            // Arrange
            Utilities utilities = new Utilities();
            string stringInputText = "Hello World!";
            string stringExpected = "Hello World!";

            // Act
            string output = utilities.WriteLine(stringInputText);

            // Assert
            Assert.AreEqual(stringExpected, output);
        }
    }
}