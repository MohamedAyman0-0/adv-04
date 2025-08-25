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

        #region Q2 Find Key with Highest Value
        static string GetKeyWithHighestValue(Hashtable table)
        {
            string maxKey = null;
            int maxValue = int.MinValue;

            foreach (DictionaryEntry entry in table)
            {
                int value = (int)entry.Value;
                if (value > maxValue)
                {
                    maxValue = value;
                    maxKey = (string)entry.Key;
                }
            }
            return maxKey;
        }
        #endregion
    }
}

