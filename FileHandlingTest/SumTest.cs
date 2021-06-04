using FileHandling;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FileHandlingTest
{
    [TestClass]
    public class SumTest
    {
        [TestMethod]
        public void TestAddWholeNum()
        {
            //Arrange
            Sum s = new Sum();
            int expectedResult = 23;
            int expectedFail = 8;
            string expectedFail2 = "Johnny";

            //Act
            int result = s.AddWholeNum(15,8);

            //Assert
            Assert.AreEqual(expectedResult, result);
            Assert.AreNotEqual(expectedResult, expectedFail);
            Assert.AreNotEqual(expectedResult, expectedFail2);
        }
        [TestMethod]
        public void TestAdd()
        {
            //Arrange
            Sum s = new Sum();
            double expectedResult = 31;
            //Act
            double result = s.Add(10.5, 20.5);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void TestSubtract()
        {
            //Arrange
            Sum s = new Sum();
            double expectedResult = 7.5;

            //Act
            double result = s.Substract(15, 7.5);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void TestDivide()
        {
            //Arrange
            Sum s = new Sum();
            double expectedResult = 12;

            //Act
            double result = s.Divide(144, 12);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
