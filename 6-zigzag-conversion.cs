using System.Text;

namespace LeetCode
{
    public class ZigzagConversionClass
    {
        public string Convert(string s, int numRows)
        {
            if (s.Length < 2 || numRows == 1) return s;
            string[] rows = new string[numRows];
            StringBuilder result = new StringBuilder();
            int row = 0;

            for (int i = 0; i < s.Length; i++)
            {
                rows[row] = rows[row] + s[i].ToString();

                if (i % ((2 * numRows) - 2) < numRows - 1)
                {
                    row++;
                }
                else { row--; }
            }

            foreach (var rowString in rows)
            {
                result.Append(rowString);
            }
            return result.ToString();
        }
    }
}
