namespace LeetCode
{
    public class KidsWithTheGreatestNumberOfCandiesClass
    {
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            var result = new List<bool>();
            byte maxCandies = 0;

            foreach (var cand in candies)
                if (cand > maxCandies) maxCandies = (byte)cand;

            foreach (var cand in candies)
                result.Add(cand + extraCandies >= maxCandies ? true : false);

            return result;
        }
    }
}
