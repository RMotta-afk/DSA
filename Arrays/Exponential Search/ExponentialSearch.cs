public class Solution
{
    private static int BinarySearch(int[] nums, int num)
    {
        int low = 0;
        int high = nums.Length;

        while (low < high)
        {
            int middle = low + (high - low) / 2;
            if (nums[middle] == num)
                return middle;
            else if (nums[middle] < num)
                low = middle + 1;
            else
                high = middle;
        }
        return -1;
    }

}