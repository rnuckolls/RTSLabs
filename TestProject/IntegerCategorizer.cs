using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class IntegerCategorizer
    {
        private int[] Items { get;  }
        public IntegerCategorizer(int[] items)
        {
            Items = items;
        }

        public string GetCategorizedList(int separator)
        {
            // Assumption: drop values from list equal to separator
            var aboveList = new List<int>();
            var belowList = new List<int>();

            foreach (var item in Items)
            {
                if (item > separator)
                {
                    aboveList.Add(item);
                }
                else if(item < separator)
                {
                    belowList.Add(item);
                }
            }

            return $"above: {String.Join(",", aboveList)}, below: {String.Join(",", belowList)}";
        }
    }
}
