//Given a string s, return the maximum length of a substring such that it contains at most two occurrences of each character.
//LeetCode 3090
public class Solution
{
    public int MaximumLengthSubstring(string s)
    {
        int left = 0;
        int right = 0;
        int max = int.MinValue;
        Dictionary<char, int> counter = new();
        for (; right < s.Length; right++)
        {
            if (counter.ContainsKey(s[right]))
                counter[s[right]]++;
            else
                counter.Add(s[right], 1);
            while (counter[s[right]] > 2)
            {
                counter[s[left]]--;
                left++;
            }
            max = Math.Max(max, right - left + 1);
        }
        return max;
    }
}