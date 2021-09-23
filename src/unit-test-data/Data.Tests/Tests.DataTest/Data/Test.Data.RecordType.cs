using DeepEqual.Syntax;
using Xunit;

namespace PrimeFuncPack.UnitTest.Data.Tests;

partial class TestDataTest
{
    [Fact]
    public void PlusFifteenIdSomeStringNameRecord_ExpectIdIsFifteenAndNameIsSomeString()
    {
        var actual = TestData.PlusFifteenIdSomeStringNameRecord;

        var expected = new RecordType
        {
            Id = TestData.PlusFifteen,
            Name = TestData.SomeString
        };

        actual.ShouldDeepEqual(expected);
    }

    [Fact]
    public void PlusFifteenIdLowerSomeStringNameRecord_ExpectIdIsFifteenAndNameIsLowerSomeString()
    {
        var actual = TestData.PlusFifteenIdLowerSomeStringNameRecord;

        var expected = new RecordType
        {
            Id = TestData.PlusFifteen,
            Name = TestData.LowerSomeString
        };

        actual.ShouldDeepEqual(expected);
    }

    [Fact]
    public void MinusFifteenIdSomeStringNameRecord_ExpectIdIsMinusFifteenAndNameIsSomeString()
    {
        var actual = TestData.MinusFifteenIdSomeStringNameRecord;

        var expected = new RecordType
        {
            Id = TestData.MinusFifteen,
            Name = TestData.SomeString
        };

        actual.ShouldDeepEqual(expected);
    }

    [Fact]
    public void MinusFifteenIdNullNameRecord_ExpectIdIsMinusFifteenAndNameIsNull()
    {
        var actual = TestData.MinusFifteenIdNullNameRecord;

        var expected = new RecordType
        {
            Id = TestData.MinusFifteen
        };

        actual.ShouldDeepEqual(expected);
    }

    [Fact]
    public void ZeroIdNullNameRecord_ExpectIdIsZeroAndNameIsNull()
    {
        var actual = TestData.ZeroIdNullNameRecord;

        var expected = new RecordType();
        actual.ShouldDeepEqual(expected);
    }
}
