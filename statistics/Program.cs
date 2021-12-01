using System;
using System.Collections.Generic;
using System.Linq;

namespace Dotnet
{
    public class Program
    {
        static int[] test_data = { 40, 38, 37, 36, 34, 33, 32, 31, 30, 30, 30, 29, 26, 26, 19 };
        public static void Main(string[] args)
        {
            var stats = new Stats();
            stats.Numbers = test_data;

            var mean = stats.Mean();
            Console.WriteLine("Mean : " + mean);

            var median = stats.Median();
            Console.WriteLine("Median : " + median);
            
            var mode = stats.Mode();
            Console.WriteLine("Mode : " + mode);

        }
    }
}