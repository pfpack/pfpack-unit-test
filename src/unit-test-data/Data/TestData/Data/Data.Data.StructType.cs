namespace PrimeFuncPack.UnitTest;

partial class TestData
{
    public static readonly StructType SomeTextStructType
        =
        new()
        {
            Text = SomeString
        };

    public static readonly StructType LowerSomeTextStructType
        =
        new()
        {
            Text = LowerSomeString
        };

    public static readonly StructType AnotherTextStructType
        =
        new()
        {
            Text = AnotherString
        };

    public static readonly StructType UpperAnotherTextStructType
        =
        new()
        {
            Text = UpperAnotherString
        };

    public static readonly StructType NullTextStructType
        =
        new()
        {
            Text = null
        };
}
