using Xunit;

namespace PrimeFuncPack.UnitTest.Data.Tests;

partial class TestDataTest
{
    [Theory]
    [InlineData(TestData.MinusFifteen, -15)]
    [InlineData(TestData.MinusOne, -1)]
    [InlineData(TestData.Zero, 0)]
    [InlineData(TestData.One, 1)]
    [InlineData(TestData.PlusFifteen, 15)]
    public void Int32_ExpectTheValue(int actual, int expected)
        =>
        Assert.Equal(expected, actual);
}
