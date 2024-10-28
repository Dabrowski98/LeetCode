using System.Text;

namespace LeetCode
{
    public class MergeStringsAlternately
    {
        public string MergeAlternately(string word1, string word2)
        {
            var result = new StringBuilder();
            int i = 0;
            int lowerLength = Math.Min(word1.Length, word2.Length);

            for (; i < lowerLength; i++)
            {
                result.Append(word1[i]);
                result.Append(word2[i]);
            }

            return (word1.Length > word2.Length) ? result.Append(word1.Substring(i, word1.Length - i)).ToString() : result.Append(word2.Substring(i, word2.Length - i)).ToString();
        }
    }
}