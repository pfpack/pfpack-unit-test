#nullable enable

using Xunit;

namespace PrimeFuncPack.UnitTest.Data.Tests
{
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
        public void ThreeWhiteSpacesString_ExpectWhiteSpaces()
        {
            var actual = TestData.ThreeWhiteSpacesString;

            var expected = new string(' ', 3);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TabString_ExpectTabSymbol()
        {
            var actual = TestData.TabString;

            var expected = new string('\t', 1);
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
    }
}
