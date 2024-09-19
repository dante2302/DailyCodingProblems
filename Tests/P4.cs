using Problems.P4;

namespace Tests;

public class P4
{
    private Solution _solution = new();

    [Fact]
    public void BasicCase()
    {
        int[] input = [2, 1, 5, 7, 2, 0, 5];
        double[] expected = [2, 1.5, 2, 3.5, 2, 2, 2]; 

        double[] result = _solution.Method(input);

        Assert.Equal(result, expected);
    }

    [Fact]
    public void EmptyArray()
    {
        int[] input = [];
        double[] expected = [];

        double[] result = _solution.Method(input);

        Assert.Equal(result, expected);
    }

    [Fact]
    public void SingleElement()
    {
        int[] input = [1];
        double[] expected = [1];

        double[] result = _solution.Method(input);

        Assert.Equal(result, expected);
    }

    [Fact]
    public void TwoElements_IntMedian()
    {
        int[] input = [1,3];
        double[] expected = [1,2];

        double[] result = _solution.Method(input);

        Assert.Equal(result, expected);
    }

    [Fact]
    public void TwoElements_DoubleMedian()
    {
        int[] input = [1,2];
        double[] expected = [1,1.5];

        double[] result = _solution.Method(input);

        Assert.Equal(result, expected);
    }

    [Fact]
    public void TwoElements_Same()
    {
        int[] input = [1,1];
        double[] expected = [1,1];

        double[] result = _solution.Method(input);

        Assert.Equal(result, expected);
    }

    [Fact]
    public void ThreeElements_Same()
    {
        int[] input = [1,1,1];
        double[] expected = [1,1,1];

        double[] result = _solution.Method(input);

        Assert.Equal(result, expected);
    }


    [Fact]
    public void SameElements()
    {
        int[] input = [5,5,5,5,5];
        double[] expected = [5,5,5,5,5];

        double[] result = _solution.Method(input);

        Assert.Equal(result, expected);
    }

    [Fact]
    public void Alternating_Odd_Even()
    {
        int[] input = [7, 8, 5, 10, 4, 6, 9];
        double[] expected = [7.0, 7.5, 7.0, 7.5, 7.0, 6.5, 7];

        double[] result = _solution.Method(input);

        Assert.Equal(result, expected);
    }

    [Fact]
    public void LargeElements_Negative()
    {
        int[] input = [-1000000, -999999, -1000001, -999998];
        double[] expected = [-1000000.0, -999999.5, -1000000.0, -999999.5];

        double[] result = _solution.Method(input);

        Assert.Equal(result, expected);
    }

    [Fact]
    public void RepeatingPattern()
    {
        int[] input = [3, 1, 3, 1, 3, 1];
        double[] expected = [3.0, 2.0, 3.0, 2.0, 3.0, 2.0];

        double[] result = _solution.Method(input);

        Assert.Equal(result, expected);
    }

    [Fact]
    public void SmallDifferenceElements()
    {
        int[] input = [1, 2, 3, 1000000, 1000001];
        double[] expected = [1.0, 1.5, 2.0, 2.5, 3.0];

        double[] result = _solution.Method(input);

        Assert.Equal(result, expected);
    }

    [Fact]
    public void Duplicates_Varying()
    {
        int[] input = [1, 1, 1, 2, 2, 2, 3];
        double[] expected = [1.0, 1.0, 1.0, 1.0, 1.5, 1.5, 2.0];

        double[] result = _solution.Method(input);

        Assert.Equal(result, expected);
    }

    [Fact]
    public void Alternating_Small_Large()
    {
        int[] input = [ 1000, 1, 999, 2, 998, 3 ];
        double[] expected = [ 1000.0, 500.5, 999.0, 500.5, 999.0, 500.5 ];

        double[] result = _solution.Method(input);

        Assert.Equal(result, expected);
    }

    [Fact]
    public void IncreasingArray()
    {
        int[] input = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        double[] expected = [1.0, 1.5, 2.0, 2.5, 3.0, 3.5, 4.0, 4.5, 5.0, 5.5];

        double[] result = _solution.Method(input);

        Assert.Equal(result, expected);
    }

    [Fact]
    public void DecreasingArray()
    {
        int[] input = [10, 9, 8, 7, 6, 5, 4, 3, 2, 1];
        double[] expected = [10.0, 9.5, 9.0, 8.5, 8.0, 7.5, 7.0, 6.5, 6.0, 5.5];

        double[] result = _solution.Method(input);

        Assert.Equal(result, expected);
    }

    [Fact]
    public void LargeElements()
    {
        int[] input = [1000000, 999999, 1000001, 999998];
        double[] expected = [1000000.0, 999999.5, 1000000.0, 999999.5];

        double[] result = _solution.Method(input);

        Assert.Equal(result, expected);
    }
    
    [Fact]
    public void NegativeElements()
    {
        int[] input = [-5, -10, -1, -4, -3];
        double[] expected = [-5.0, -7.5, -5.0, -4.5, -4.0];

        double[] result = _solution.Method(input);

        Assert.Equal(result, expected);
    }



    [Fact]
    public void EvenNumbers_EvenLength()
    {
        int[] input = [16, 2, 4, 10, 20, 14];
        double[] expected = [16, 9, 2, 7, 10, 12]; 

        double[] result = _solution.Method(input);

        Assert.Equal(result, expected);
    }

    [Fact]
    public void EvenNumbers_OddLength()
    {
        int[] input = [16, 2, 4, 10, 20];
        double[] expected = [16, 9, 2, 7, 10]; 

        double[] result = _solution.Method(input);

        Assert.Equal(result, expected);
    }

    [Fact]
    public void OddNumbers_EvenLength()
    {
        int[] input = [15, 1, 5, 13, 21, 19];
        double[] expected = [15, 8, 5, 9, 13, 14]; 

        double[] result = _solution.Method(input);

        Assert.Equal(result, expected);
    }

    [Fact]
    public void OddNumbers_OddLength()
    {
        int[] input = [15, 1, 5, 13, 21, 19, 27];
        double[] expected = [15, 8, 5, 9, 13, 14, 15]; 

        double[] result = _solution.Method(input);

        Assert.Equal(result, expected);
    }
}