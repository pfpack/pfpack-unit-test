#nullable enable

namespace PrimeFuncPack.UnitTest
{
    partial class TestData
    {
        public static readonly RecordType PlusFifteenIdSomeStringNameRecord
            =
            new RecordType
            {
                Id = PlusFifteen,
                Name = SomeString
            };

        public static readonly RecordType PlusFifteenIdLowerSomeStringNameRecord
            =
            new RecordType
            {
                Id = PlusFifteen,
                Name = LowerSomeString
            };

        public static readonly RecordType MinusFifteenIdSomeStringNameRecord
            =
            new RecordType
            {
                Id = MinusFifteen,
                Name = SomeString
            };

        public static readonly RecordType MinusFifteenIdNullNameRecord
            =
            new RecordType
            {
                Id = MinusFifteen,
                Name = null
            };

        public static readonly RecordType ZeroIdNullNameRecord
            =
            new RecordType
            {
                Id = Zero,
                Name = null
            };
    }
}