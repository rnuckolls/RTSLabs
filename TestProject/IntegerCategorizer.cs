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
            var aboveList = 0;
            var belowList = 0;

            foreach (var item in Items)
            {
                if (item > separator)
                {
                    aboveList++;
                }
                else if(item < separator)
                {
                    belowList++;
                }
            }

            return $"above: {aboveList}, below: {belowList}";
        }
    }
}
