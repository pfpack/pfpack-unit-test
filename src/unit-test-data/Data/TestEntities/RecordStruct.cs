using static System.FormattableString;

namespace PrimeFuncPack.UnitTest;

public readonly record struct RecordStruct
{
    public string? Text { get; init; }

    public override string? ToString()
        =>
        Invariant($"{nameof(RecordStruct)}: '{Text}'");
}