using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorldTestProject
{
    [TestClass]
    public class HelloWorldUnitTest
    {
        [TestMethod]
        public void HelloWorldToConsole()
        {
            //Arrange
            string expectedResult = "Hello, World!";

            //Act
            string result = COMP123___S2016___Lesson1.Program.HelloWorldToConsole();

            //Assert
            Assert.AreEqual(expectedResult, result);

        }
    }
}
