using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayCakeCandles_HackerRank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 2,5,6,6,5,4,6,2,3,4,6,4};
            int x = birthdayCakeCandles(list);
            Console.WriteLine(x);
        }

        public static int birthdayCakeCandles(List<int> candles)
        {
            int max = candles.Max();
            int count = 0;
            for (int i = 0; i < candles.Count; i++)
            {
                if (max == candles[i])
                {
                    count++;
                }
            }
            return count;
        }
    }
}
