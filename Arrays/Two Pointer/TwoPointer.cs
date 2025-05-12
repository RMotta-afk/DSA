// Reverse Words in a String
// Given a string s, reverse the order of characters in each word within a sentence while still preserving whitespace and initial word order
// LeetCode 557.

public class Solution
{
    public string ReverseWords(string s)
    {
        string[] words = s.Split(" ");

        for (int i = 0; i < words.Length; i++)
        {
            char[] characters = words[i].ToCharArray();
            int l = 0;
            int h = characters.Length - 1;
            while (l < h)
            {
                (characters[l], characters[h]) = (characters[h], characters[l]);
                l++;
                h--;
            }
            words[i] = new string(characters);
        }
        return String.Join(" ", words);
    }

}