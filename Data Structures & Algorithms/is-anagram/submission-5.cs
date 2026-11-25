public class Solution {
    private static void AddToDict(string word, ref Dictionary<char, int> dict)
    {
        foreach (char c in word)
        {
            if (!dict.TryAdd(c, 1))
                dict[c] += 1;
        }
    }

    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
            return false;

        Dictionary<char, int> dictS = [];
        Dictionary<char, int> dictT = [];

        AddToDict(s, ref dictS);
        AddToDict(t, ref dictT);

        if (dictS.Count != dictT.Count)
            return false;

        foreach(var keyPair in dictS)
        {
            if (!dictT.TryGetValue(keyPair.Key, out int _))
                return false;

            if (dictT[keyPair.Key] != keyPair.Value)
                return false;
        }

        return true;
    }
}
