using System;
using Problems.utils;

namespace Problems.P2;

public class Solution : ISolution
{
    public int[] Method(int[] nums)
    {
        int pref = 1;
        int suff = 1;
        int arrayLength = nums.Length;
        int[] answer = Enumerable.Repeat(1, arrayLength).ToArray();
        for (int i = 0; i < arrayLength; i++)
        {
            answer[i] *= pref;
            answer[arrayLength - i - 1] *= suff;
            pref *= nums[i];
            suff *= nums[arrayLength - i - 1];
        }
        return answer;
    }

    public SolutionInfo Info { get; set; } = new()
    {
        Approach = @"Prefix and Suffix product to overcome above problem",
        TimeComplexity = "O(N)",
        SpaceComplexity = "O(1)",
        TimeSpent = "8:33"
    };
}
