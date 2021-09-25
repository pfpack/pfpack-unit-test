using Xunit;

namespace PrimeFuncPack.UnitTest.Data.Tests;

partial class TestDataTest
{
    [Fact]
    public void EmptyString_ExpectEmptyString()
    {
        var actual = TestData.EmptyString;
        Assert.Empty(actual);
    }

    [Fact]
    public void WhiteSpaceString_ExpectWhiteSpace()
    {
        var actual = TestData.WhiteSpaceString;

        var expected = new string(' ', 1);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TwoWhiteSpacesString_ExpectTwoWhiteSpacesString()
    {
        var actual = TestData.TwoWhiteSpacesString;

        var expected = new string(' ', 2);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ThreeWhiteSpacesString_ExpectThreeWhiteSpacesString()
    {
        var actual = TestData.ThreeWhiteSpacesString;

        var expected = new string(' ', 3);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TabString_ExpectTabString()
    {
        var actual = TestData.TabString;

        var expected = new string('\t', 1);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TwoTabsString_ExpectTwoTabsString()
    {
        var actual = TestData.TwoTabsString;

        var expected = new string('\t', 2);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void MixedWhiteSpacesString_ExpectTheMixedWhiteSpacesString()
    {
        var actual = TestData.MixedWhiteSpacesString;

        var expected = new string(new[] { '\t', '\t', ' ' });
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void SomeString_ExpectTextIsSomeString()
    {
        var actual = TestData.SomeString;

        var expected = "Some String";
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void LowerSomeString_ExpectTextIsResultOfSomeStringToLower()
    {
        var actual = TestData.LowerSomeString;

        var expected = TestData.SomeString.ToLowerInvariant();
        Assert.Equal(expected, actual, true);
    }

    [Fact]
    public void UpperSomeString_ExpectTextIsResultOfSomeStringToUpper()
    {
        var actual = TestData.UpperSomeString;

        var expected = TestData.SomeString.ToUpperInvariant();
        Assert.Equal(expected, actual, true);
    }

    [Fact]
    public void AnotherString_ExpectTextIsSomeString()
    {
        var actual = TestData.AnotherString;

        var expected = "Another string";
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void LowerAnotherString_ExpectTextIsResultOfSomeStringToLower()
    {
        var actual = TestData.LowerAnotherString;

        var expected = TestData.AnotherString.ToLowerInvariant();
        Assert.Equal(expected, actual, true);
    }

    [Fact]
    public void UpperAnotherString_ExpectTextIsResultOfSomeStringToUpper()
    {
        var actual = TestData.UpperAnotherString;

        var expected = TestData.AnotherString.ToUpperInvariant();
        Assert.Equal(expected, actual, true);
    }
}
