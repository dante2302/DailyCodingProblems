using System.Collections;
using Problems.utils;

namespace Problems.P4;

public class Solution : ISolution
{
    public double[] Method(int[] numbers)
    {
        int length = numbers.Length;
        double[] answer = new double[length];
        int[] list = new int[length];
        for(int i = 0; i < length; i++)
        {
            list[i] = numbers[i];
            Array.Sort(list);
            answer[i] = ComputeMedian(list);
        }
        return answer;
    }

    private double ComputeMedian(int[] numbers)
    {
        return numbers.Length % 2 == 0
            ? ((double)numbers[numbers.Length / 2 - 1] + numbers[numbers.Length / 2]) / 2
            : numbers[numbers.Length / 2 - 1];
    }

    public SolutionInfo Info { get; set; } = new()
    {
        Approach = "",
        TimeSpent = "",
        TimeComplexity = "",
        SpaceComplexity = "",
    };
}
