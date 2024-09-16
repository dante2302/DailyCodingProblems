using Problems.utils;

namespace Problems;

public class P1 : IProblem<int>
{
    public string Heading { get; }  = "First Missing Positive Integer";
    public string Description { get; } = @"
        Given an array of integers, find the first missing positive integer. 
        In other words, find the lowest positive integer that does not exist in the array. 
        The array can contain duplicates and negative numbers as well.
        For example, the input [3, 4, -1, 1] should give 2. The input [1, 2, 0] should give 3.
        You can modify the input array in-place.";

    public int Solution(int[] numbers)
    {
        int answer = 1;
        
        return answer;
    }

    private int Naive(int[] numbers)
    {
        Array.Sort(numbers);
        for (int i = 0, j = 1; i < numbers.Length; i++, j++)
        {
            if (numbers[i] < 0 && numbers[j] > 0)
            {
                int missing = numbers[j] + numbers[i]
                if (missing > 1) return numbers[i] + 1   }
            else
            {
                int missing = numbers[j] - numbers[i];
                if (missing > 1) return numbers[i] + 1}
        }
        return numbers[numbers.Length - 1] + 1;
    }
}

