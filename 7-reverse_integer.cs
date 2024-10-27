using System.Text;

namespace LeetCode
{
    public class ReverseIntegerClass
    {
        public class Solution
        {
            public int Reverse(int x)
            {
                var sb = new StringBuilder(x.ToString());
                char temp;
                int startIndex = (sb[0] == '-' ? 1 : 0);

                for (int i = 0; i < (sb.Length - startIndex) / 2; i++)
                {
                    temp = sb[sb.Length - 1 - i];
                    sb[sb.Length - 1 - i] = sb[i + startIndex];
                    sb[i + startIndex] = temp;
                }

                int result = (Int32.TryParse(sb.ToString(), out result)) ? result : 0;

                return result;
            }
        }

    }

}