using System;
using Problems.utils;

namespace Problems.P2;

public class Info : IProblemDescriptor
{
    public string Heading { get; } = "Product of Array Except Self";
    public string Description { get; } = @"
        Given an array of integers, return a new array such that 
        each element at index i of the new array is the product of 
        all the numbers in the original array except the one at i.
        For example, 
        Input: [1, 2, 3, 4, 5], 
        Output: [120, 60, 40, 30, 24]. 
        --------------------------------
        Input: [3, 2, 1], 
        Output: [2, 3, 6].";
}
