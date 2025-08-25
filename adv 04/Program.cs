using System.Collections;

namespace Adv_4
{
    internal class Program
    {
        #region Q1 Count Frequency of Each Element
        static void CountFrequencies(int[] arr)
        {
            var freq = new Dictionary<int, int>();
            foreach (int num in arr)
                if (freq.ContainsKey(num)) freq[num]++;
                else freq[num] = 1;

            foreach (var kv in freq)
                Console.WriteLine($"{kv.Key} : {kv.Value}");

        }
        #endregion

     
        }
    }

