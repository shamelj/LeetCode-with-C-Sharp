//-----------------------------------------------------------------------------
// Runtime: 164 ms
// Memory Usage: 46.1 MB
// Link: https://leetcode.com/submissions/detail/751018763/
//-----------------------------------------------------------------------------
namespace LeetCode;
public class _26_RemoveDuplicatesFromSortedArray
{
    public int RemoveDuplicates(int[] nums)
    {
        int l = 0, r = 1;
        while(r< nums.Length)
        {
            if (nums[r] != nums[l])
                nums[++l] = nums[r];
            r++;
        }
        return l + 1;
    }
}