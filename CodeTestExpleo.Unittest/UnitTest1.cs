using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeTestExpleo.Unittest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AnagramChecker_IsAnagramOrNot_ReturnsTrue()
        {
            //Arrange data
            string wordOne = "john";
            string wordTwo = "nhoj";

            //Act the method
            var answear = Anagram.AnagramChecker(wordOne, wordTwo);

            //Assert: expected return value.
            Assert.IsTrue(answear);
        }
    }
}
