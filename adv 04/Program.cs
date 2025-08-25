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
        #region Q8 Find Missing Numbers from 1 to N
        static List<int> FindMissingNumbers(int[] arr, int N)
        {
            var set = new HashSet<int>(arr);
            var missing = new List<int>();
            for (int i = 1; i <= N; i++)
                if (!set.Contains(i)) missing.Add(i);
            return missing;
        }
        #endregion
        #region Q9 Unique Values with HashSet
        static HashSet<int> GetUniqueValues(List<int> nums)
        {
            return new HashSet<int>(nums);
        }
        #endregion

        #region Q10  Swap Keys and Values in Hashtable
        static Hashtable SwapKeysAndValues(Hashtable table)
        {
            var swapped = new Hashtable();
            foreach (DictionaryEntry entry in table)
                swapped[entry.Value] = entry.Key;
            return swapped;
        }
        #endregion
        #region Q11  Union of Two Sets
        static HashSet<int> UnionSets(HashSet<int> set1, HashSet<int> set2)
        {
            var union = new HashSet<int>(set1);
            union.UnionWith(set2);
            return union;
        }
        #endregion

        #region Q12 Count Keys Starting with TargetChar
        static int CountKeysStartingWith(Dictionary<string, int> dict, char targetChar)
        {
            return dict.Keys.Count(k => k.StartsWith(targetChar.ToString()));
        }
        #endregion
        #region Q13 Find Elements Greater Than Target in SortedSet
        static List<int> ElementsGreaterThanTarget(SortedSet<int> set, int target)
        {
            return set.Where(n => n > target).ToList();
        }
        #endregion
        #region Q14 Keys with Even Values in SortedList
        static List<int> KeysWithEvenValues(SortedList<int, int> list)
        {
            return list.Where(kv => kv.Value % 2 == 0)
                       .Select(kv => kv.Key)
                       .ToList();
        }
        #endregion

        static void Main(string[] args)
        {
            #region Q1 Count Frequency of Each Element
            int[] arrQ1 = { 1, 2, 2, 3, 1, 4 };
            CountFrequencies(arrQ1);
            #endregion
            #region Q2 Find Key with Highest Value
            Hashtable tableQ2 = new Hashtable()
            {
                { "A", 5 },
                { "B", 10 },
                { "C", 7 }
            };
            #endregion

            #region Q3 Find Keys for Specific TargetValue
            Hashtable tableQ3 = new Hashtable()
            {
                { "key1", "apple" },
                { "key2", "banana" },
                { "key3", "apple" }
            };
            FindKeysForValue(tableQ3, "apple");
            #endregion
            #region Q4 Group Anagrams
            string[] strsQ4 = { "eat", "tea", "tan", "ate", "nat", "bat" };
            var grouped = GroupAnagrams(strsQ4);
            foreach (var group in grouped)
                Console.WriteLine($"[{string.Join(", ", group)}]");
            #endregion




        }
    }
}    

