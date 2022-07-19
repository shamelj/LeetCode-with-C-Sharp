//-----------------------------------------------------------------------------
// Runtime: 126 ms
// Memory Usage: 36.9 MB
// Link: https://leetcode.com/submissions/detail/751001601
//-----------------------------------------------------------------------------
namespace LeetCode;
public class _13_RomanToInteger
{
    public int RomanToInt(string s)
    {
        Dictionary<char, int> map = new();
        int n = s.Length;
        map.Add('I', 1);
        map.Add('V', 5);
        map.Add('X', 10);
        map.Add('L', 50);
        map.Add('C', 100);
        map.Add('D', 500);
        map.Add('M', 1000);
        char prev = s[n - 1];
        int sum = map[prev];
        for (int i = n - 2; i >= 0; i--)
        {
            char curr = s[i];
            sum += map[curr] < map[prev] ? -map[curr] : map[curr];
            prev = curr;
        }
        return sum;

    }
}