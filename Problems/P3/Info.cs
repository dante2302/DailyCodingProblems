using System;
using Problems.utils;

namespace Problems.P3;

public class Info : IProblemDescriptor
{

    public string Difficulty => "Easy";
    public string Description { get; } = @"
        Good morning! Here's your coding interview problem for today.

        This problem was asked by Amazon.

        Given a string, determine whether any permutation of it is a palindrome.

        For example, carrace should return true, since it can be rearranged to form racecar, which is a palindrome. daily should return false, since there's no rearrangement that can form a palindrome.";
    public string Heading { get; } = "Permutation Palindrome";
    public ProblemDifficulty Difficulty { get; } = ProblemDifficulty.Easy ;
}

