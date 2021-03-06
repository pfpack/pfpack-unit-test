﻿#nullable enable

namespace PrimeFuncPack.UnitTest
{
    partial class TestData
    {
        public static readonly StructType SomeTextStructType
            =
            new StructType
            {
                Text = SomeString
            };

        public static readonly StructType LowerSomeTextStructType
            =
            new StructType
            {
                Text = LowerSomeString
            };

        public static readonly StructType NullTextStructType
        =
        new StructType();
    }
}
