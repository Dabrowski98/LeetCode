using System.Text;

namespace LeetCode
{
    public class ZigzagConversionClass
    {
        public string Convert(string s, int numRows)
        {
            if (s.Length < 2 || numRows == 1) return s;
            string[] rows = new string[numRows];
            int row = 0;
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {
                rows[row] = rows[row] + s[i].ToString();
                row += (i % ((2 * numRows) - 2) < numRows - 1) ? 1 : -1;
            }

            foreach (var rowString in rows) result.Append(rowString);

            return result.ToString();
        }
    }
}
