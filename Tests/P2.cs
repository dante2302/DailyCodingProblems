using Problems.P2;
namespace Tests;

public class P2
{
    private readonly Solution _solution = new ();

    [Fact]
    public void EmptyArray()
    {
        int[] input = [];
        int[] expected = [];
        
        int[] result = _solution.Method(input);
        
        Assert.Equal(expected, result);
    }

    [Fact]
    public void SingleElementArray()
    {
        int[] input = [5];
        int[] expected = [1];
        
        int[] result = _solution.Method(input);
        
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TwoElementArray()
    {
        int[] input = [3, 6];
        int[] expected = [6, 3];
        
        int[] result = _solution.Method(input);
        
        Assert.Equal(expected, result);
    }

    [Fact]
    public void MultipleElementsArray()
    {
        int[] input = [1, 2, 3, 4, 5];
        int[] expected = [120, 60, 40, 30, 24];
        
        int[] result = _solution.Method(input);
        
        Assert.Equal(expected, result);
    }

    [Fact]
    public void SingleCase()
    {
        int[] input = [1, 2, 3, 4];
        int[] expected = [24, 12, 8, 6];
        
        int[] result = _solution.Method(input);
        
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ArrayWithZeros()
    {
        int[] input = [0, 1, 2, 3];
        int[] expected = [6, 0, 0, 0];
        
        int[] result = _solution.Method(input);
        
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ArrayWithNegativeNumbers()
    {
        int[] input = [-1, -2, -3];
        int[] expected = [6, 3, 2];
        
        int[] result = _solution.Method(input);
        
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ArrayWithAllIdenticalElements()
    {
        int[] input = [2, 2, 2];
        int[] expected = [4, 4, 4];
        
        int[] result = _solution.Method(input);
        
        Assert.Equal(expected, result);
    }

    [Fact]
    public void LargeArray()
    {
        int[] input = new int[1000];
        int[] expected = new int[1000];
        
        for (int i = 0; i < 1000; i++)
        {
            input[i] = i + 1;
        }
        
        for (int i = 0; i < 1000; i++)
        {
            long product = 1;
            for (int j = 0; j < 1000; j++)
            {
                if (j != i)
                {
                    product *= input[j];
                }
            }
            expected[i] = (int)product;
        }
        
        int[] result = _solution.Method(input);
        
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ArrayWithOneNegativeAndOthersPositive()
    {
        int[] input = [-1, 2, 3, 4];
        int[] expected = [24, -12, -8, -6];
        
        int[] result = _solution.Method(input);
        
        Assert.Equal(expected, result);
    }
}
