namespace LeetCode
{
    class LongestSubstringWithoutRepeatingCharactersClass
    {
        public int LengthOfLongestSubstring(string s)
        {
            var hashset = new HashSet<char>();
            ushort i, j, maxLength;
            i = j = maxLength = 0;

            while (i < s.Length && s.Length - j > maxLength)
            {
                if (hashset.Contains(s[i]))
                {
                    hashset.Remove(s[j]);
                    j++;
                    continue;
                }
                hashset.Add(s[i]);
                if (hashset.Count > maxLength)
                    maxLength = (ushort)hashset.Count;
                i++;
            }
            return maxLength;
        }
    }
}