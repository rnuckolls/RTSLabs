using NUnit.Framework;
using TestProject;

namespace TestProjectTests
{
    public class IntegerCategorizerTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(new int[]{1,5,2,1,10}, 6, ExpectedResult = "above: 1, below: 4")]
        public string GetCategorizedList(int[] list, int divider)
        {
            var categorizer = new IntegerCategorizer(list);
            return categorizer.GetCategorizedList(divider);
        }
    }
}
