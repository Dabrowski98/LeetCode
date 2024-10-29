namespace LeetCode
{
    public class GreatestCommonDivisorOfStringsClass
    {
        public string GcdOfStrings(string str1, string str2)
        {
            if (str1 + str2 != str2 + str1) return "";

            int a = str1.Length;
            int b = str2.Length;
            int temp;

            while (b > 0)
            {
                temp = a;
                a = b;
                b = temp % b;
            }
            return str2.Substring(0, a);
        }
    }
}