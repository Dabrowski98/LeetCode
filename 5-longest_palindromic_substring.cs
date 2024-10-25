namespace LeetCode
{
    public class Solution
    {
        public string LongestPalindrome(string s)
        {
            int maxLength = 0;
            int atIndex = 0;

            if (s.Length < 2) return s;
            if (s.Length == 2 && s[0] == s[1]) return s;

            for (int i = 0; i < s.Length; i++)
            {
                int oddLength = checkForPalindrome(s, i, i);
                int evenLength = checkForPalindrome(s, i, i + 1);

                int longerLength = (oddLength > evenLength) ? oddLength : evenLength;

                if (longerLength > maxLength)
                {
                    maxLength = longerLength;
                    atIndex = i - (longerLength - 1) / 2;
                }
            }

            return s.Substring(atIndex, maxLength);
        }

        private int checkForPalindrome(string s, int left, int right)
        {
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                left--;
                right++;
            }
            if (left != right)
                left++; right--;

            return right - left + 1;
        }
    }
}