using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet
{
    public class Stats
    {
        public static void Statistics()
        {
            int[] test_data = { 40, 38, 37, 36, 34, 33, 32, 31, 30, 30, 30, 29, 26, 26, 19 };
            int sum = 0 , maxcount = 0 , mode = 0 ;
            decimal mean = 0;

            // MEAN
            foreach (int test in test_data)
            {
                sum += test;
            }
            mean = (decimal)sum / test_data.Length;
            Console.WriteLine($"Mean : {mean}");

            // MEDIAN
            Array.Sort(test_data);
            int m = (test_data.Length / 2);
            Console.WriteLine($"Median : {test_data[m]}");

            // MODE
            for (int i = 0; i < test_data.Length; i++)
            {
                int count = 0;
                for (int j = 1; j < test_data.Length - 1; j++)
                {
                    if(test_data[i] == test_data[j])
                        {
                            count++;
                        }
                    }
                if(count > maxcount)
                {
                    maxcount = count;
                    mode = test_data[i];
                }
                Console.WriteLine($"Mode : {mode}");
            }
        }
    }
}
