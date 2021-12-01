using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet
{
    internal class Stats
    {
        internal int[] Numbers { set; get; }

        public decimal Mean()
        {
            int sum = 0;
            decimal mean = 0;
            foreach (int test in Numbers)
            {
                sum += test;
            }
            mean = (decimal)sum / Numbers.Length;
            return mean;
        }

        public int Median()
        {
            Array.Sort(Numbers);
            int m = (Numbers.Length / 2);
            return m;
        }

        public int Mode()
        {
            int maxcount = 0, mode = 0;
            for (int i = 0; i < Numbers.Length; i++)
            {
                int count = 0;
                for (int j = 1; j < Numbers.Length - 1; j++)
                {
                    if (Numbers[i] == Numbers[j])
                    {
                        count++;
                    }
                }
                if (count > maxcount)
                {
                    maxcount = count;
                    mode = Numbers[i];
                }
            }
            return mode;
        }
    }
}
