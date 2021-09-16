#nullable enable

using Xunit;

namespace PrimeFuncPack.UnitTest.Data.Tests
{
    partial class TestDataTest
    {
        [Fact]
        public void SomeTextStructType_ExpectStructTypeTextIsSomeString()
        {
            var actual = TestData.SomeTextStructType;

            var expected = new StructType
            {
                Text = TestData.SomeString
            };

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LowerSomeTextStructType_ExpectStructTypeTextIsLowerSomeString()
        {
            var actual = TestData.LowerSomeTextStructType;

            var expected = new StructType
            {
                Text = TestData.LowerSomeString
            };

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AnotherTextStructType_ExpectStructTypeTextIsAnotherString()
        {
            var actual = TestData.AnotherTextStructType;

            var expected = new StructType
            {
                Text = TestData.AnotherString
            };

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void UpperAnotherTextStructType_ExpectStructTypeTextIsUpperAnotherString()
        {
            var actual = TestData.UpperAnotherTextStructType;

            var expected = new StructType
            {
                Text = TestData.UpperAnotherString
            };

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void NullTextStructType_ExpectDefaultStructTypeValue()
        {
            var actual = TestData.NullTextStructType;

            var expected = default(StructType);

            Assert.Equal(expected, actual);
        }
    }
}
