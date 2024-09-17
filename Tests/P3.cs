using Problems.P3;

namespace Tests;

public class P3
{
    private readonly Solution _solution = new();

    [Fact]
    public void BasicCase_True()
    {
        string input = "carrace";
        bool expected  = true;

        bool result = _solution.Method(input);

        Assert.Equal(result, expected);
    }

    [Fact]
    public void BasicCase_False()
    {
        string input = "asd";
        bool expected = false;

        bool result = _solution.Method(input);

        Assert.Equal(result, expected);
    }

    [Fact]
    public void SingleOdd_OddLength()
    {
        string input = "acsca";
        bool expected = true;

        bool result = _solution.Method(input);

        Assert.Equal(result, expected);
    }

    [Fact]
    public void MultipleOdd_OddLength()
    {

        string input = "aafcaa";
        bool expected = false;

        bool result = _solution.Method(input);

        Assert.Equal(result, expected);
    }

    [Fact]
    public void NoOdd_EvenLength()
    {
        string input = "aabb";
        bool expected = true;

        bool result = _solution.Method(input);

        Assert.Equal(result, expected);
    }

    [Fact]
    public void MultipleOdd_EvenLength()
    {
        string input = "aacfbb";
        bool expected = false;

        bool result = _solution.Method(input);

        Assert.Equal(result, expected);
    }

    [Fact]
    public void EmptyString()
    {
        string input = "";
        bool expected = true;

        bool result = _solution.Method(input);

        Assert.Equal(result, expected);
    }
    
    [Fact]
    public void SingleCharacter()
    {
        string input = "a";
        bool expected = true;

        bool result = _solution.Method(input);

        Assert.Equal(result, expected);
    }

    [Fact]
    public void TwoSameCharacters()
    {
        string input = "aa";
        bool expected = true;

        bool result = _solution.Method(input);

        Assert.Equal(result, expected);
    }


    [Fact]
    public void TwoDifferentCharacters()
    {
        string input = "ab";
        bool expected = false;

        bool result = _solution.Method(input);

        Assert.Equal(result, expected);
    }

    [Fact]
    public void MixedCase_Short_True()
    {
        string input = "aA";
        bool expected = true;

        bool result = _solution.Method(input);

        Assert.Equal(result, expected);
    }

    [Fact]
    public void MixedCase_Long_True()
    {
        string input = "AbcDefGhiJkLmnOpoNmlKjIhGfeDcba";
        bool expected = true;

        bool result = _solution.Method(input);

        Assert.Equal(result, expected);
    }  

    [Fact]
    public void MixedCase_Short_False()
    {
        string input = "aABC";
        bool expected = false;

        bool result = _solution.Method(input);

        Assert.Equal(result, expected);
    }

    [Fact]
    public void MixedCase_Long_False()
    {
        string input = "AbcDeFgHiJkLmNoPqRsTuVwXyZ";
        bool expected = false;

        bool result = _solution.Method(input);

        Assert.Equal(result, expected);
    }
}