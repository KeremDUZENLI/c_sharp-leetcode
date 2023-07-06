namespace _35_SearchInsertPosition
{
    public class SolutionSearchInsertPosition
    {
        public int SearchInsert(int[] nums, int target)
        {
            for (int l = 0; l < nums.Length; l++)
            {
                if (nums[l] == target)
                {
                    return l;
                }

                if (nums[l] > target)
                {
                    return l;
                }
            }

            for (int h = nums.Length - 1; h >= 0; h--)
            {
                if (nums[h] < target)
                {
                    return h+1;
                }
            }

            return 0;
        }
    }
}
