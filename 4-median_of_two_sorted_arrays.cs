namespace LeetCode
{
    class MedianOfTwoSortedArraysClass
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var arr = new int[nums1.Length + nums2.Length];
            int j = 0;
            int k = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i == arr.Length / 2 + 1) break;
                if (j == nums1.Length || k == nums2.Length)
                {
                    if (j == nums1.Length) arr[i] = nums2[k++];
                    else if (k == nums2.Length) arr[i] = nums1[j++];
                    continue;
                }

                if (nums1[j] <= nums2[k])
                {
                    arr[i] = nums1[j];
                    j++;
                }
                else if (nums1[j] > nums2[k])
                {
                    arr[i] = nums2[k];
                    k++;
                }

            }
            return (arr.Length % 2 == 1) ? arr[arr.Length / 2] : ((double)(arr[arr.Length / 2 - 1] + arr[(arr.Length / 2)]) / 2);
        }
    }
}