using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NumberToWord.Tests
{
    [TestClass]
    public class ParseTest
    {
        int _number;

        [TestMethod]
        public void Number_1_To_Word()
        {
            // Arrange
            _number = 1;

            var expected = "one";

            // Act
            var actual = _number.ToWord();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Number_2_To_Word()
        {
            // Arrange
            _number = 2;

            var expected = "two";

            // Act
            var actual = _number.ToWord();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Number_12_To_Word()
        {
            // Arrange
            _number = 12;

            var expected = "twelve";

            // Act
            var actual = _number.ToWord();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Number_23_To_Word()
        {
            // Arrange
            _number = 23;

            var expected = "twenty-three";

            // Act
            var actual = _number.ToWord();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Number_123_To_Word()
        {
            // Arrange
            _number = 123;

            var expected = "one hundred twenty-three";

            // Act
            var actual = _number.ToWord();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Number_937_To_Word()
        {
            // Arrange
            _number = 937;

            var expected = "nine hundred thirty-seven";

            // Act
            var actual = _number.ToWord();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Number_605_To_Word()
        {
            // Arrange
            _number = 605;

            var expected = "six hundred and five";

            // Act
            var actual = _number.ToWord();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Number_6265_To_Word()
        {
            // Arrange
            _number = 6265;

            var expected = "six thousand two hundred sixty-five";

            // Act
            var actual = _number.ToWord();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Number_12530122_To_Word()
        {
            // Arrange
            _number = 12530122;

            var expected = "twelve million five hundred thirty thousand one hundred twenty-two";

            // Act
            var actual = _number.ToWord();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Number_999999999_To_Word()
        {
            // Arrange
            _number = 999999999;

            var expected = "nine hundred ninety-nine million nine hundred ninety-nine thousand nine hundred ninety-nine";

            // Act
            var actual = _number.ToWord();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Number_1999999999_To_Word()
        {
            // Arrange
            _number = 1999999999;

            var expected = "one billion nine hundred ninety-nine million nine hundred ninety-nine thousand nine hundred ninety-nine";

            // Act
            var actual = _number.ToWord();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
