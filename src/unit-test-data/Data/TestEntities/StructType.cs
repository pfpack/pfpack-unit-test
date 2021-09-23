using static System.FormattableString;

namespace PrimeFuncPack.UnitTest;

public struct StructType
{
    public string? Text { readonly get; set; }

    public override string? ToString()
        =>
        Invariant($"{nameof(StructType)}: '{Text}'");
}
