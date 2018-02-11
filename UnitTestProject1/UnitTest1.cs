using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        GetNameday name = new GetNameday();
        [TestMethod]
        public void InputIsValidatedIndex()
        {
            string number = "5";
            string expectedError = name.indexError;
            string actualError = name.IsInt(number);
            Assert.AreEqual(expectedError, actualError);
        }

        [TestMethod]
        public void InputIsValidatedNumber()
        {
            string number = "a";
            string expectedError = name.numberError;
            string actualError = name.IsInt(number);
            Assert.AreEqual(expectedError, actualError);
        }

    }
}
