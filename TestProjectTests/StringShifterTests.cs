using NUnit.Framework;
using TestProject;

namespace TestProjectTests
{
    public class StringShifterTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("MyString", 2, ExpectedResult = "ngMyStri")]
        [TestCase("", 2, ExpectedResult = "")]
        [TestCase("MyString", 0, ExpectedResult = "MyString")]
        [TestCase("MyString", -2, ExpectedResult = "StringMy")]
        [TestCase(null, 2, ExpectedResult = null)]
        public string ShiftStringRight(string stringToShift, int steps)
        {
            var shifter = new StringShifter(stringToShift);
            return shifter.Shift(steps);
        }
    }
}
