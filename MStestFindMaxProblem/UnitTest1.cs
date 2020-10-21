using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindMaximumProblemUsingGeneric;

namespace MStestFindMaxProblem
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// UC 1.1 : Given the maximum number at first position returns the same number.
        /// </summary>
        [TestMethod]
        public void GivenMaxIntegerAtFirstPos_ReturnTheSameNumber()
        {
            //Arrange
            int expected = 50;
            //Act
            int actual = FindMaximum.MaxIntegerAmongThree(50, 30, 10);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// UC 1.2 : Given the maximum number at second position returns the same number.
        /// </summary>
        [TestMethod]
        public void GivenMaxIntegerAtSecondPos_ReturnTheSameNumber()
        {
            //Arrange
            int expected = 80;
            //Act
            int actual = FindMaximum.MaxIntegerAmongThree(50, 80, 10);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// UC 1.3 : Given the maximum number at third position returns the same number.
        /// </summary>
        [TestMethod]
        public void GivenMaxIntegerAtThirdPos_ReturnTheSameNumber()
        {
            //Arrange
            int expected = 100;
            //Act
            int actual = FindMaximum.MaxIntegerAmongThree(50, 30, 100);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// UC 2.1 : Given the maximum float at first position returns the same number.
        /// </summary>
        [TestMethod]
        public void GivenMaxFloatAtFirstPos_ReturnTheSameNumber()
        {
            //Arrange
            double expected = 100.45;
            //Act
            double actual = FindMaximum.MaxFloatAmongThree(100.45, 30, 100.2);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// UC 2.2 : Given the maximum float at second position returns the same number.
        /// </summary>
        [TestMethod]
        public void GivenMaxFloatAtSecondPos_ReturnTheSameNumber()
        {
            //Arrange
            double expected = 0.45;
            //Act
            double actual = FindMaximum.MaxFloatAmongThree(0.35, 0.45, 0.2);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// UC 2.3 : Given the maximum float at third position returns the same number.
        /// </summary>
        [TestMethod]
        public void GivenMaxFloatAtThirdPos_ReturnTheSameNumber()
        {
            //Arrange
            double expected = 5.6;
            //Act
            double actual = FindMaximum.MaxFloatAmongThree(2.987, 5.6, 5.6);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// UC 3.1 : Given the maximum string at first position returns the same string.
        /// </summary>
        [TestMethod]
        public void GivenMaxStringAtFirstPos_ReturnTheSameNumber()
        {
            //Arrange
            string expected = "Kerala";
            //Act
            string actual = FindMaximum.MaxStringAmongThree("Kerala","Apple","Cat");
            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// UC 3.2 : Given the maximum string at second position returns the same string.
        /// </summary>
        [TestMethod]
        public void GivenMaxStringAtSecondPos_ReturnTheSameNumber()
        {
            //Arrange
            string expected = "Zebra";
            //Act
            string actual = FindMaximum.MaxStringAmongThree("Kerala", "Zebra", "Cat");
            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// UC 3.3 : Given the maximum string at third position returns the same string.
        /// </summary>
        [TestMethod]
        public void GivenMaxStringAtThirdPos_ReturnTheSameNumber()
        {
            //Arrange
            string expected = "Zebra";
            //Act
            string actual = FindMaximum.MaxStringAmongThree("Kerala", "Apple", "Zebra");
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
