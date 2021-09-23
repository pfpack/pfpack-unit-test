using static System.FormattableString;

namespace PrimeFuncPack.UnitTest;

public sealed class RefType
{
    public int Id { get; set; }

    public override string? ToString()
        =>
        Invariant($"{nameof(RefType)}: {nameof(Id)} = {Id}");
}
