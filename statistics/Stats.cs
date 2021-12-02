using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet
{
    internal class Stats
    {
        internal int[] Numbers { get; set; }

        internal Results GetStatsResult()
        {
            var result = new Results();
            result.Mean = CalcMean();
            result.Median = CalcMedian();
            result.Mode = CalcMode();
            return result;
        }

        private int CalcMean() => Numbers.Sum() / Numbers.Length;

        private int CalcMedian()
        {
            var sortedData = Numbers.OrderBy(i => i).ToArray();
            var n = sortedData.Length;
            var median = n % 2 == 0
                ? (sortedData[n / 2 - 1] + sortedData[n / 2]) / 2
                : sortedData[n / 2];
            return median;
        }

        private int CalcMode()
        {
            int mode = 0 , maxcount =0 ;
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