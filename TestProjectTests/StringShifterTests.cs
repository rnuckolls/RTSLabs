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
        public string ShiftStringRight(string stringToShift, int steps)
        {
            var shifter = new StringShifter(stringToShift);
            return shifter.Shift(steps);
        }
    }
}
