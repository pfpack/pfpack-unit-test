namespace PrimeFuncPack.UnitTest;

partial class TestData
{
    public static readonly RecordType PlusFifteenIdSomeStringNameRecord
        =
        new()
        {
            Id = PlusFifteen,
            Name = SomeString
        };

    public static readonly RecordType PlusFifteenIdLowerSomeStringNameRecord
        =
        new()
        {
            Id = PlusFifteen,
            Name = LowerSomeString
        };

    public static readonly RecordType MinusFifteenIdSomeStringNameRecord
        =
        new()
        {
            Id = MinusFifteen,
            Name = SomeString
        };

    public static readonly RecordType MinusFifteenIdNullNameRecord
        =
        new()
        {
            Id = MinusFifteen,
            Name = null
        };

    public static readonly RecordType ZeroIdNullNameRecord
        =
        new()
        {
            Id = Zero,
            Name = null
        };
}
