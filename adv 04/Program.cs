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

        #region Q3 Find Keys for Specific TargetValue
        static void FindKeysForValue(Hashtable table, string targetValue)
        {
            bool found = false;
            foreach (DictionaryEntry entry in table)
            {
                if ((string)entry.Value == targetValue)
                {
                    Console.WriteLine(entry.Key);
                    found = true;
                }
            }
            if (!found) Console.WriteLine("Key not found");
        }
        #endregion
        #region Q4 Group Anagrams
        static List<List<string>> GroupAnagrams(string[] strs)
        {
            var dict = new Dictionary<string, List<string>>();
            foreach (string s in strs)
            {
                string sorted = new string(s.OrderBy(c => c).ToArray());
                if (!dict.ContainsKey(sorted))
                    dict[sorted] = new List<string>();
                dict[sorted].Add(s);
            }
            return dict.Values.ToList();
        }
        #endregion
        #region Q5 Check if Array Contains Duplicates
        static bool ContainsDuplicates(int[] arr)
        {
            return arr.Length != arr.Distinct().Count();
        }
        #endregion
    }
}

