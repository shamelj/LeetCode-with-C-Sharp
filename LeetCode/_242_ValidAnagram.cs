using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Runtime: 87 ms, faster than 88.02% of C# online submissions for Valid Anagram.
Memory Usage: 40 MB, less than 18.66% of C# online submissions for Valid Anagram.
 */
namespace LeetCode_with_C_Sharp.LeetCode
{
    public class _242_ValidAnagram
    {
        public bool IsAnagram(string s, string t)
        {
            var dict1 = FillDictionary(new Dictionary<char, int>(), s);
            var dict2 = FillDictionary(new Dictionary<char, int>(), t);
            return AreEqual(dict1,dict2) && t.Length==s.Length;
        }

        private bool AreEqual(Dictionary<char, int> dict1, Dictionary<char, int> dict2)
        {
            foreach (var pair in dict1)
            {
                if (!dict2.ContainsKey(pair.Key) || pair.Value != dict2[pair.Key])
                    return false;
            }
            return true;
        }

        public Dictionary<char, int> FillDictionary(Dictionary<char,int> dict, string source)
        {
            foreach (var c in source)
            {
                if (!dict.ContainsKey(c))
                dict.Add(c, 0);
                dict[c] += 1;
            }
            return dict;
        }
    }
}
