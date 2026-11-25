public class Solution {
        private static void AddToDict(string word, ref Dictionary<char, int> dict)
        {
            foreach (char c in word)
            {
                if (!dict.TryAdd(c, 1))
                    dict[c] += 1;
            }
        }

        private bool IsAnagram(string wordOne, string wordTwo)
        {
            if (wordOne.Length != wordTwo.Length)
                return false;

            Dictionary<char, int> dictOne = [];
            Dictionary<char, int> dictTwo = [];

            AddToDict(wordOne, ref dictOne);
            AddToDict(wordTwo, ref dictTwo);

            foreach (KeyValuePair<char, int> kv in dictOne)
            {
                if (!dictTwo.TryGetValue(kv.Key, out int count))
                    return false;

                if (count != kv.Value)
                    return false;
            }

            return true;
        }

        private static string ToAlphabeticOrder(string word)
        {
            return new string(word.OrderBy(c => c).ToArray());
        }

               public List<List<string>> GroupAnagrams(string[] strs)
        {
            if (strs.Length == 0)
                return [];

            List<List<string>> result = [];
            Dictionary<string, List<string>> anagrams = [];
            
            foreach (string str in strs)
            {
                string ao = ToAlphabeticOrder(str);

                if (!anagrams.TryAdd(ao, [str]))
                    anagrams[ao].Add(str);
            }

            foreach (var kv in anagrams)
            {
                result.Add(kv.Value.ToList());
            }

            return result;
        }
}
