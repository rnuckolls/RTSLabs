using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var listToCategorize = new int[] { 1, 1, 2, 3, 4, 5, 7, 8, 8, 99, 0, 8, -15, -4, 1723548754};
            var categorizer = new IntegerCategorizer(listToCategorize);
            Console.WriteLine(categorizer.GetCategorizedList(1));
            Console.ReadLine();

            var stringToShift = "ABCDEFG";
            var shifter = new StringShifter(stringToShift);
            Console.WriteLine(shifter.Shift(-13));
            Console.ReadLine();
        }
    }
}
