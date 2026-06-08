/* 2161. Partition Array According to Given Pivot
Solved
Medium

You are given a 0-indexed integer array nums and an integer pivot. Rearrange nums such that:

Every element less than pivot appears before every element greater than pivot.
Every element equal to pivot appears in between the elements less than and greater than pivot.
The relative order of the elements less than pivot and the elements greater than pivot is maintained.

Return nums after the rearrangement.

Example 1:

Input: nums = [9,12,5,10,14,3,10], pivot = 10
Output: [9,5,3,10,10,12,14]

Example 2:

Input: nums = [-3,4,3,2], pivot = 2
Output: [-3,2,4,3]

Constraints:

1 <= nums.length <= 105
-106 <= nums[i] <= 106
pivot equals to an element of nums.
*/
public class Solution
{
    public int[] PivotArray(int[] nums, int pivot)
    {
        int[] result = new int[nums.Length];
        int resultIndex = 0;
        int pivotCount = 0;

        for (int index = 0; index < nums.Length; index++)
        {
            if (nums[index] < pivot)
            {
                result[resultIndex] = nums[index];
                resultIndex++;
            }
            else if (nums[index] == pivot)
            {
                pivotCount++;
            }
        }

        while (pivotCount-- > 0)
        {
            result[resultIndex] = pivot;
            resultIndex++;
        }

        for (int index = 0; index < nums.Length; index++)
        {
            if (nums[index] > pivot)
            {
                result[resultIndex] = nums[index];
                resultIndex++;
            }
        }

        return result;
    }
}
