namespace PrimeFuncPack.UnitTest;

partial class TestData
{
    public static readonly RecordStruct SomeTextRecordStruct
        =
        new()
        {
            Text = SomeString
        };

    public static readonly RecordStruct UpperSomeTextRecordStruct
        =
        new()
        {
            Text = UpperSomeString
        };

    public static readonly RecordStruct AnotherTextRecordStruct
        =
        new()
        {
            Text = AnotherString
        };

    public static readonly RecordStruct UpperAnotherTextRecordStruct
        =
        new()
        {
            Text = UpperAnotherString
        };
}