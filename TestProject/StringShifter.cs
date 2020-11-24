using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class StringShifter
    {
        private string InitialString;
        public StringShifter(string itemsToShift)
        {
            InitialString = itemsToShift;
        }

        public string Shift(int steps)
        {
            var items = InitialString.ToCharArray();
            var initialLength = items.Count();
            var newItems = new char[initialLength];
            if (Math.Abs(steps) > initialLength)
            {
                if (steps > 0)
                {
                    steps = steps - initialLength;
                }
                else
                {
                    steps = steps + initialLength;
                }
            }

            if (steps < 0)
            {
                // negative shifts work as positives from the end
                steps = initialLength + steps;
            }

            var counter = 0;
            for (int i = steps; i < initialLength; i++)
            {
                newItems[counter] = items[i];
                counter++;
            }

            for (int i = 0; i < initialLength - counter; i++)
            {
                newItems[counter + i] = items[i];        
            }

            return String.Join(string.Empty, newItems);
        }
    }
}
