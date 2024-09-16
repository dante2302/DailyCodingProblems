using System;
using Problems.utils;

namespace Problems.P2;

public class Solution : ISolution
{
    public int[] Method(int[] nums)
    {
        int pref = 1;
        int suff = 1;
        for(int i = 0; i < nums.Length; i++)
        {
            nums[i] *= pref;
            nums[nums.Length - i - 1] *= suff;
            pref *= nums[i];
            suff *= nums[nums.Length - i - 1];
        }
        return nums;
    }

    public SolutionInfo Info { get; set; } = new()
    {
        Approach = @"Prefix and Suffix product to overcome above problem",
        TimeComplexity = "O(N)",
        SpaceComplexity = "O(1)",
        TimeSpent = "8:33"
    };
}
